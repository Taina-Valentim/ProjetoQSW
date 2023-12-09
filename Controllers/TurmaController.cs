using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoQSW.Data;
using ProjetoQSW.Models;
using ProjetoQSW.ViewModels;
using System.Linq;

namespace ProjetoQSW.Controllers
{
    
    
    public class TurmaController : Controller
    {
        public EscolinhaBancoSimulado db = new EscolinhaBancoSimulado();
        public IActionResult Index(int idAluno, List<int> ids)
        {
            db.PopularBancoSimulado();
            var viewModel = new TurmaViewModel();
            viewModel.AlunoId = db.Alunos.FirstOrDefault(x => x.Id == idAluno).Id;
            viewModel.Aluno = db.Alunos.FirstOrDefault(x => x.Id == viewModel.AlunoId);
            foreach (int id in ids)
            {
                db.Turmas.FirstOrDefault(x => x.Id == id).AlunosInscritos.Add(viewModel.Aluno);
            }
            viewModel.Turmas = db.Turmas.Where(x => x.AlunosInscritos.Any(x => x.Id == viewModel.AlunoId)).ToList();
            return View(viewModel);
        }

        public IActionResult Inscrever(TurmaViewModel viewModel, string login)
        {
            db.PopularBancoSimulado();
            viewModel.AlunoId = db.Alunos.FirstOrDefault(x => x.Login == login).Id;
            viewModel.TotalCreditos = 0;
            viewModel.Aluno = db.Alunos.FirstOrDefault(x => x.Id == viewModel.AlunoId);
            viewModel.Turmas = db.Turmas.ToList();
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Inscrever(TurmaViewModel viewModel)
        {
            db.PopularBancoSimulado();
            viewModel.Aluno = db.Alunos?.FirstOrDefault(x => x.Id == viewModel.AlunoId);
            
            string[] materiasSelecionadas = Request.Form["selecionarMateria"];
            List<int> idsConvertidos = new List<int>();
            foreach (string materia in materiasSelecionadas)
            {
                if (int.TryParse(materia, out int inteiro))
                    idsConvertidos.Add(inteiro);
                else
                    Console.WriteLine($"A string '{materia}' não pôde ser convertida para um número inteiro.");
            }
            
            VerificaDisponibilidade(idsConvertidos);
            VerificaChoqueHorarios(viewModel, idsConvertidos);
            VerificaCreditos(viewModel, idsConvertidos);
            VerificaPreRequisito(viewModel, idsConvertidos);
            VerificaJaCursado(viewModel, idsConvertidos);

            if(ModelState.IsValid)
            {
                
                return RedirectToAction("Index", "Turma", new {idAluno = viewModel.AlunoId, ids = idsConvertidos});

            }
            else
            {
                viewModel.Turmas = db.Turmas.ToList();
            }
            return View(viewModel);
        }
        public void VerificaDisponibilidade(List<int> turmasSelecionadas)
        {
            db.PopularBancoSimulado();
            foreach (var turmaId in turmasSelecionadas)
            {
                var totalVagas = db.Turmas?.FirstOrDefault(x => x.Materia.Id == turmaId)?.Vagas;
                var numeroInscritos = db.Turmas?.FirstOrDefault(x => x.Materia.Id == turmaId)?.AlunosInscritos?.Count;
                if (numeroInscritos == null) numeroInscritos = 0;
                if(!(totalVagas > numeroInscritos))
                {
                    ModelState.AddModelError("", "Turma lotada!");
                }
            }
        }
        
        public void VerificaChoqueHorarios(TurmaViewModel viewModel, List<int> turmasSelecionadas)
        {
            db.PopularBancoSimulado();
            var turmasIncrito = viewModel.Turmas;
            var turmas = db.Turmas?.Where(x => turmasSelecionadas.Contains(x.Id));

            foreach (var turmaId in turmasSelecionadas)
            {
                if(turmasIncrito != null)
                {
                    var jaInscritoNaMesmaTurma = turmasIncrito.Any(x => x.Materia?.Id == turmaId) ;
                    if (jaInscritoNaMesmaTurma)
                    {
                        ModelState.AddModelError("", "Você já está inscrito em alguma dessas turmas, confira suas turmas e tente novamente");
                    }
                }

                var dia = db.Turmas?.FirstOrDefault(x => x.Materia.Id == turmaId)?.Dia;
                var horario = db.Turmas?.FirstOrDefault(x => x.Materia.Id == turmaId)?.Horario;

                if(turmas.Count(x => x.Dia == dia &&  x.Horario == horario) > 1)
                {
                    ModelState.AddModelError("", "Há conflito de horários nas matérias escolhidas, confira e tente novamente");
                }
            }
        }

        public void VerificaCreditos(TurmaViewModel viewModel, List<int> materiasSelecionadas)
        {
            db.PopularBancoSimulado();
            var creditos = 0;
            foreach (var materiaId in materiasSelecionadas)
            {
                creditos += db.Materias.FirstOrDefault(x => x.Id == materiaId).Creditos;
            }
            if(creditos > 20)
            {
                ModelState.AddModelError("", "Limite de créditos ultrapassado!");
            }
        }

        public void VerificaPreRequisito(TurmaViewModel viewModel, List<int> materiasSelecionadas)
        {
            db.PopularBancoSimulado();
            foreach (var materiaId in materiasSelecionadas)
            {
                if(db.Materias.FirstOrDefault(x => x.Id == materiaId).PreRequisito != null)
                {
                    var materiasAprovado = db.Historicos.Where(x => x.Aluno.Id == viewModel.AlunoId && x.Estado.Nome.Equals("Aprovado"));
                    var preRequisito = db.Materias.FirstOrDefault(x => x.Id == materiaId)?.PreRequisito;
                    var preRequisitoCursado = materiasAprovado.Any(x => x.Materia.Id == preRequisito.Id);
                    if(!preRequisitoCursado)
                    {
                        ModelState.AddModelError("", "Você não cumpre o pré requisito para esta matéria");
                    }
                }
            }
        }

        public void VerificaJaCursado(TurmaViewModel viewModel, List<int> materiasSelecionadas)
        {
            db.PopularBancoSimulado();
            var materiasAprovado = db.Historicos.Where(x => x.Aluno.Id == viewModel.AlunoId && x.Estado.Nome.Equals("Aprovado"));
            foreach (var materiaId in materiasSelecionadas)
            {
                if(materiasAprovado.Any(x => x.Materia.Id == materiaId))
                {
                    ModelState.AddModelError("", "Você já foi aprovado em uma das matérias selecionadas, verifique seu histórico e tente novamente.");
                }
            }
        }

    }
}

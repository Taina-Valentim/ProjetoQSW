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
        private readonly EscolinhaContext _db;
        public TurmaController(EscolinhaContext db)
        {
            _db = db;
        }
        public IActionResult Index(string login)
        {
            var viewModel = new TurmaViewModel();
            if (_db.Turmas.Any(x => x.AlunosInscritos.Any(x => x.Login == login)))
            {
                viewModel.AlunoId = _db.Alunos.FirstOrDefault(x => x.Login == login).Id;
                viewModel.Aluno = _db.Alunos.FirstOrDefault(x => x.Login == login);
                viewModel.Turmas = _db.Turmas.Where(x => x.AlunosInscritos.Any(x => x.Login == login)).ToList();
                foreach (Turma turma in viewModel.Turmas)
                {
                    viewModel.TotalCreditos += turma.Materia.Creditos;
                }
            }

            else
            {
                viewModel.AlunoId = _db.Alunos.FirstOrDefault(x => x.Login == login).Id;
                viewModel.TotalCreditos = 0;
                return RedirectToAction("Inscrever", "Turma", viewModel);
            }

            return View(viewModel);
        }

        public IActionResult Inscrever(TurmaViewModel viewModel, string[] materiasSelecionadas)
        {
            viewModel.Aluno = _db.Alunos.FirstOrDefault(x => x.Id == viewModel.AlunoId);
            viewModel.Turmas = _db.Turmas.ToList();
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Inscrever(TurmaViewModel viewModel)
        {
            viewModel.Aluno = _db.Alunos?.FirstOrDefault(x => x.Id == viewModel.AlunoId);
            
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
                foreach (int id in idsConvertidos)
                {
                    _db.Turmas.FirstOrDefault(x => x.Id == id).AlunosInscritos.Add(viewModel.Aluno);
                }
                return RedirectToAction("Index", "Turma", new {login = viewModel.Aluno.Login});

            }
            else
            {
                viewModel.Turmas = _db.Turmas.ToList();
            }
            return View(viewModel);
        }
        public void VerificaDisponibilidade(List<int> turmasSelecionadas)
        {
            foreach(var turmaId in turmasSelecionadas)
            {
                var totalVagas = _db.Turmas?.FirstOrDefault(x => x.Materia.Id == turmaId)?.Vagas;
                var numeroInscritos = _db.Turmas?.FirstOrDefault(x => x.Materia.Id == turmaId)?.AlunosInscritos?.Count;
                if (numeroInscritos == null) numeroInscritos = 0;
                if(!(totalVagas > numeroInscritos))
                {
                    ModelState.AddModelError("", "Turma lotada!");
                }
            }
        }
        
        public void VerificaChoqueHorarios(TurmaViewModel viewModel, List<int> turmasSelecionadas)
        {
            var turmasIncrito = viewModel.Turmas;
            var turmas = _db.Turmas?.Where(x => turmasSelecionadas.Contains(x.Id));

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

                var dia = _db.Turmas?.FirstOrDefault(x => x.Materia.Id == turmaId)?.Dia;
                var horario = _db.Turmas?.FirstOrDefault(x => x.Materia.Id == turmaId)?.Horario;

                if(turmas.Count(x => x.Dia == dia &&  x.Horario == horario) > 1)
                {
                    ModelState.AddModelError("", "Há conflito de horários nas matérias escolhidas, confira e tente novamente");
                }
            }
        }

        public void VerificaCreditos(TurmaViewModel viewModel, List<int> materiasSelecionadas)
        {
            var creditos = 0;
            foreach (var materiaId in materiasSelecionadas)
            {
                creditos += _db.Materias.FirstOrDefault(x => x.Id == materiaId).Creditos;
            }
            if(creditos > 20)
            {
                ModelState.AddModelError("", "Limite de créditos ultrapassado!");
            }
        }

        public void VerificaPreRequisito(TurmaViewModel viewModel, List<int> materiasSelecionadas)
        {
            foreach (var materiaId in materiasSelecionadas)
            {
                if(_db.Materias.FirstOrDefault(x => x.Id == materiaId).PreRequisito != null)
                {
                    var materiasAprovado = _db.Historicos.Where(x => x.Aluno.Id == viewModel.AlunoId && x.Estado.Nome.Equals("Aprovado"));
                    var preRequisito = _db.Materias.FirstOrDefault(x => x.Id == materiaId)?.PreRequisito;
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
            var materiasAprovado = _db.Historicos.Where(x => x.Aluno.Id == viewModel.AlunoId && x.Estado.Nome.Equals("Aprovado"));
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

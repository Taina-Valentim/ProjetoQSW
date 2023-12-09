using ProjetoQSW.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoQSW.ViewModels
{
    public class TurmaViewModel
    {
        public int TotalCreditos { get; set; }
        public List<Turma>? Turmas { get; set; }
        public int AlunoId { get; set; }
        public Aluno? Aluno { get; set; }
    }
}

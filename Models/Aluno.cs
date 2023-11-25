using System.Diagnostics;

namespace ProjetoQSW.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Login { get; set; }
        public required string Senha { get; set; }
        public ICollection<Grade> Grades { get; set; }
    }
}

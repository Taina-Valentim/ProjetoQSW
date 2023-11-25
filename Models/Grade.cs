namespace ProjetoQSW.Models
{
    public class Grade
    {
        public int Id { get; set; }
        public required int TotalCreditos { get; set; }
        public required int IdMateriaGrade { get; set; }
        public required MateriaGrade MateriaGrade { get; set; }


        public required int IdAluno { get; set; }
        public required Aluno Aluno { get; set; }
    }
}

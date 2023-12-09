namespace ProjetoQSW.Models
{
    public class Turma
    {
        public int Id { get; set; }
        public string? Dia { get; set; }
        public string? Horario { get; set; }
        public int Vagas { get; set; }
        public int MateriaId { get; set; }
        public Materia? Materia { get; set; }
        public List<Aluno>? AlunosInscritos { get; set; }

    }
}

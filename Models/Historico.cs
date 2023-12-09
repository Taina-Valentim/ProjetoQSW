namespace ProjetoQSW.Models
{
    public class Historico
    {
        public int Id { get; set; }
        public int MateriaId { get; set; }
        public Materia? Materia { get; set; }
        public int EstadoId { get; set; }
        public Estado? Estado { get; set; }
        public int AlunoId { get; set; }
        public Aluno? Aluno { get; set; }
    }
}

namespace ProjetoQSW.Models
{
    public class Materia
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required int Creditos { get; set; }
        public required string Dia { get; set; }
        public required string Horario { get; set; }
        public required int IdProfessor { get; set; }
        public required Professor Professor { get; set; }
    }
}

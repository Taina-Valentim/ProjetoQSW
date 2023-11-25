namespace ProjetoQSW.Models
{
    public class MateriaGrade
    {
        public int Id { get; set; }
        public required int IdPeriodo { get; set; }
        public required Periodo Periodo { get; set; }

        public required int IdEstado { get; set; }
        public required Estado Estado { get; set; }

        public required int IdMateria { get; set; }
        public required int IdProfessor { get; set; }
        public required Materia Materia { get; set; }
    }
}

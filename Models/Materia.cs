using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoQSW.Models
{
    public class Materia
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public int Creditos { get; set; }

        public int PreRquisitoId { get; set; }
        public Materia? PreRequisito { get; set; }
        public int ProfessorId { get; set; }
        public Professor? Professor { get; set; }
    }
}

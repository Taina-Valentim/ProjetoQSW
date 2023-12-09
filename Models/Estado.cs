using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoQSW.Models
{
    public class Estado
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
    }
}

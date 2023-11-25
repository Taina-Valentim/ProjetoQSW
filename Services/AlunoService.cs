using ProjetoQSW.Models;

namespace ProjetoQSW.Services
{
    public class AlunoService
    {

        public IWebHostEnvironment WebHostEnvironment { get; }
        public AlunoService(IWebHostEnvironment webHostEnvironment) {
            WebHostEnvironment = webHostEnvironment;
        }
        
        public IEnumerable<Aluno> GetAlunos() { 
            return new List<Aluno>();
        }
    }
}

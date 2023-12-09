using Microsoft.AspNetCore.Mvc;
using ProjetoQSW.Data;
using ProjetoQSW.Models;

namespace ProjetoQSW.Controllers
{
    public class AlunoController : Controller
    {
        private readonly EscolinhaContext _db;
        public AlunoController(EscolinhaContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Alunos);
        }
    }
}

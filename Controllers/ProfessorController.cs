using Microsoft.AspNetCore.Mvc;
using ProjetoQSW.Data;
using ProjetoQSW.Models;

namespace ProjetoQSW.Controllers
{
    public class ProfessorController : Controller
    {
        private readonly EscolinhaContext _db;
        public ProfessorController(EscolinhaContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Professores);
        }
    }
}

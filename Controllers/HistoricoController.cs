using Microsoft.AspNetCore.Mvc;
using ProjetoQSW.Data;

namespace ProjetoQSW.Controllers
{
    public class HistoricoController : Controller
    {
        private readonly EscolinhaContext _db;
        public HistoricoController(EscolinhaContext db)
        {
            _db = db;
        }
        public IActionResult Index(string login)
        {
            var historicoAluno = _db.Historicos?.Where(x => x.Aluno.Login == login).ToList();
            return View(historicoAluno);
        }
    }
}

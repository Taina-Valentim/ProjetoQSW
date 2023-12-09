using Microsoft.AspNetCore.Mvc;
using ProjetoQSW.Data;
using ProjetoQSW.Models;

namespace ProjetoQSW.Controllers
{
    public class AlunoController : Controller
    {
        public EscolinhaBancoSimulado db = new EscolinhaBancoSimulado();
        public IActionResult Index()
        {
            db.PopularBancoSimulado();
            return View(db.Alunos);
        }
    }
}

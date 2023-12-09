using Microsoft.AspNetCore.Mvc;
using ProjetoQSW.Data;

namespace ProjetoQSW.Controllers
{
    public class HistoricoController : Controller
    {
        public EscolinhaBancoSimulado db = new EscolinhaBancoSimulado();
        public IActionResult Index(string login)
        {
            db.PopularBancoSimulado();
            var historicoAluno = db.Historicos?.Where(x => x.Aluno.Login == login).ToList();
            return View(historicoAluno);
        }
    }
}

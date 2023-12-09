using Microsoft.AspNetCore.Mvc;
using ProjetoQSW.Data;
using ProjetoQSW.Models;

namespace ProjetoQSW.Controllers
{
    public class EstadoController : Controller
    {
        private readonly EscolinhaContext _db;
        public EstadoController(EscolinhaContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Estados);
        }
    }
}

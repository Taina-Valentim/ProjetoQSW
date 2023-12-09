using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoQSW.Data;
using ProjetoQSW.Models;
using ProjetoQSW.ViewModels;

namespace ProjetoQSW.Controllers
{
    public class MateriaController : Controller
    {
        public EscolinhaBancoSimulado db = new EscolinhaBancoSimulado();
        public IActionResult Index()
        {
            db.PopularBancoSimulado();
            return View(db.Materias);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoQSW.Data;
using ProjetoQSW.Models;
using ProjetoQSW.ViewModels;

namespace ProjetoQSW.Controllers
{
    public class MateriaController : Controller
    {
        private readonly EscolinhaContext _db;
        public MateriaController(EscolinhaContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Materias);
        }
    }
}

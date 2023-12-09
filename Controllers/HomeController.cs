using Microsoft.AspNetCore.Mvc;
using ProjetoQSW.Data;
using ProjetoQSW.Models;
using ProjetoQSW.ViewModels;
using System.Diagnostics;

namespace ProjetoQSW.Controllers
{
    public class HomeController : Controller
    {
        private readonly EscolinhaContext _db;
        public HomeController(EscolinhaContext db)
        {
            _db = db;
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Login()
        {
            var viewModel = new LoginViewModel() { Login = "", Senha = "" };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel viewModel)
        {
            if (viewModel.Login == null)
            {
                ModelState.AddModelError("login", "O login � obrigat�rio");
            }
            if (viewModel.Senha == null)
            {
                ModelState.AddModelError("senha", "A senha � obrigat�ria");
            }
            else if (viewModel.Login.ToLower().Equals("teste"))
            {
                ModelState.AddModelError("", "O login 'teste' n�o � v�lido");
            }

            if (ModelState.IsValid)
            {
                var loginValido = _db.Alunos.Any(x => x.Login == viewModel.Login);
                var senhaValida = _db.Alunos.Any(x => x.Senha == viewModel.Senha);
                if (loginValido && senhaValida)
                {
                    return RedirectToAction("Index", "Turma", new { login = viewModel.Login });
                }
                if (!loginValido) { ModelState.AddModelError("login", "Verifique seu login e tente novamente"); }
                if (!senhaValida) { ModelState.AddModelError("senha", "Verifique sua senha e tente novamente"); }
            }
            return View();
        }

    }
}

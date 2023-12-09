using Microsoft.AspNetCore.Mvc;
using ProjetoQSW.Data;
using ProjetoQSW.Models;
using ProjetoQSW.ViewModels;
using System.Diagnostics;

namespace ProjetoQSW.Controllers
{
    public class HomeController : Controller
    {
        public EscolinhaBancoSimulado db = new EscolinhaBancoSimulado();


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Login()
        {
            db.PopularBancoSimulado();
            var viewModel = new LoginViewModel() { Login = "", Senha = "" };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel viewModel)
        {
            db.PopularBancoSimulado();
            if (viewModel.Login == null)
            {
                ModelState.AddModelError("login", "O login é obrigatório");
            }
            if (viewModel.Senha == null)
            {
                ModelState.AddModelError("senha", "A senha é obrigatória");
            }
            else if (viewModel.Login.ToLower().Equals("teste"))
            {
                ModelState.AddModelError("", "O login 'teste' não é válido");
            }

            if (ModelState.IsValid)
            {
                var loginValido = db.Alunos.Any(x => x.Login == viewModel.Login);
                var senhaValida = db.Alunos.Any(x => x.Senha == viewModel.Senha);
                if (loginValido && senhaValida)
                {
                    return RedirectToAction("Inscrever", "Turma", new { login = viewModel.Login });
                }
                if (!loginValido) { ModelState.AddModelError("login", "Verifique seu login e tente novamente"); }
                if (!senhaValida) { ModelState.AddModelError("senha", "Verifique sua senha e tente novamente"); }
            }
            return View();
        }

    }
}

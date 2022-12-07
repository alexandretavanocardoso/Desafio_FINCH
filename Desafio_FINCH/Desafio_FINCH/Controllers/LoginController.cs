using Desafio_FINCH.Services;
using Microsoft.AspNetCore.Mvc;

namespace Desafio_FINCH.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILoginServices _loginServices;

        public LoginController(ILoginServices loginServices) { _loginServices = loginServices; }

        public IActionResult Index() => View();

        public ActionResult Login(string email, string senha) {
            if (_loginServices.Login(email, senha))
                return RedirectToRoute(new { controller = "Home", action = "Index" });

            return RedirectToRoute(new { controller = "Login", action = "Index" });
        }
    }
}

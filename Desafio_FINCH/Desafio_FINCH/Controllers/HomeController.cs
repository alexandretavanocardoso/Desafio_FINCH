using Desafio_FINCH.Models;
using Desafio_FINCH.Services;
using Microsoft.AspNetCore.Mvc;

namespace Desafio_FINCH.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeServices _homeServices;

        public HomeController(IHomeServices homeServices) { _homeServices = homeServices; }

        public ActionResult<Bored> Index() => View(_homeServices.GetBored());
    }
}
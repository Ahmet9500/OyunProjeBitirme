using Microsoft.AspNetCore.Mvc;

namespace OyunProjee.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

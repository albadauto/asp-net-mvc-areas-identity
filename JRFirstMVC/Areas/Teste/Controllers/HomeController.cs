using Microsoft.AspNetCore.Mvc;

namespace JRFirstMVC.Areas.Teste.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

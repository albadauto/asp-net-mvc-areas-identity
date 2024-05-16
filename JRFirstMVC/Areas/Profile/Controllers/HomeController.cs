using Microsoft.AspNetCore.Mvc;

namespace JRFirstMVC.Areas.Profile.Controllers
{
    [Area("Profile")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

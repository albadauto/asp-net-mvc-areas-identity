using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JRFirstMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            HttpContext.Session.SetString("ID", "ADMIN");
            return View();
        }


        public IActionResult Profile()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("ID")))
                return RedirectToAction("Index", "Home", new { area = "" });

            HttpContext.Session.Remove("ID");
            return View();
        }
    }
}

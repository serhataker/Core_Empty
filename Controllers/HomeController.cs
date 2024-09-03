using Microsoft.AspNetCore.Mvc;

namespace Core_Empty.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        } public IActionResult Anasayfa()
        {
            return View(Anasayfa);
        }
    }
}

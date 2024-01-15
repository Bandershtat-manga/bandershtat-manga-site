using Microsoft.AspNetCore.Mvc;

namespace bandershtat_manga.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

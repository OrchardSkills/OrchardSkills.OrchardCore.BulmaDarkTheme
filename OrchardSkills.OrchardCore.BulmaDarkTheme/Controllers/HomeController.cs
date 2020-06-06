using Microsoft.AspNetCore.Mvc;

namespace OrchardCore.Themes.BulmaDarkTheme.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

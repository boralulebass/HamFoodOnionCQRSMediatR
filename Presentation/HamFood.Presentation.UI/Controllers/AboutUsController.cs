using Microsoft.AspNetCore.Mvc;

namespace HamFood.Presentation.UI.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

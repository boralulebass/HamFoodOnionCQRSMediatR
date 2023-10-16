using Microsoft.AspNetCore.Mvc;

namespace HamFood.Presentation.UI.Controllers
{
    public class AboutUsController : Controller
    {
        [Route("/aboutus")]
        public IActionResult Index()
        {
            return View();
        }
    }
}

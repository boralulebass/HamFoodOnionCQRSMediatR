using HamFood.Core.Application.Dtos.CategoryDtos;
using HamFood.Core.Application.Dtos.MenuDtos;
using HamFood.Presentation.UI.Services;
using Microsoft.AspNetCore.Mvc;

namespace HamFood.Presentation.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IApiService _apiService;

        public HomeController(IApiService apiService)
        {
            _apiService = apiService;
        }

        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }


        public PartialViewResult Banner()
        {
            return PartialView();
        }
        public PartialViewResult About()
        {
            return PartialView();
        }

        public PartialViewResult Stats()
        {
            return PartialView();
        }

    }
}

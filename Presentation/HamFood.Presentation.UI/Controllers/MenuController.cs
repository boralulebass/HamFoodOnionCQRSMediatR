using HamFood.Core.Application.Dtos.CategoryDtos;
using HamFood.Core.Application.Dtos.MenuDtos;
using HamFood.Presentation.UI.Services;
using Microsoft.AspNetCore.Mvc;

namespace HamFood.Presentation.UI.Controllers
{
    public class MenuController : Controller
    {
        private readonly IApiService _apiService;

        public MenuController(IApiService apiService)
        {
            _apiService = apiService;
        }

        [Route("/menu")]
        public async Task<IActionResult> Index()
        {
            var values = await _apiService.GetTableData<ResultCategoryDto>("https://localhost:7087/api/Category");
            return View(values);
        }
    }
}

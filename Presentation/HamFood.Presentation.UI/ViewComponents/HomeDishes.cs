using HamFood.Core.Application.Dtos.MenuDtos;
using HamFood.Presentation.UI.Services;
using Microsoft.AspNetCore.Mvc;

namespace HamFood.Presentation.UI.ViewComponents
{
    public class HomeDishes : ViewComponent
    {
        private readonly IApiService _apiService;

        public HomeDishes(IApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<IViewComponentResult> InvokeAsync() 
        {
            var values = await _apiService.GetTableData<ResultMenuDto>("https://localhost:7087/api/Menu");
            var filteredValues = values.Take(3).ToList();
            return View(filteredValues);
        }
    }
}

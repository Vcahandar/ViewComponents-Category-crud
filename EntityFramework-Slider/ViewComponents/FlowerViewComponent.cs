using EntityFramework_Slider.Models;
using EntityFramework_Slider.Services.Interfaces;
using EntityFramework_Slider.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EntityFramework_Slider.ViewComponents
{
    public class FlowerViewComponent : ViewComponent
    {
        private readonly IFlowerExpertsService _flowerService;
        public FlowerViewComponent(IFlowerExpertsService flowerService)
        {
            _flowerService = flowerService;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult(View(new FloExpertVM { Experts = await _flowerService.GetAll(), ExpertHeader = await _flowerService.GetInfoExpertHeader()}));
        }
    }
}

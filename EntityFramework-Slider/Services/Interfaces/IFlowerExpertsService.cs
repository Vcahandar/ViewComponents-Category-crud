using EntityFramework_Slider.Models;

namespace EntityFramework_Slider.Services.Interfaces
{
    public interface IFlowerExpertsService
    {
        Task<IEnumerable<FloExpert>> GetAll();
        Task<ExpertHeader> GetInfoExpertHeader();
    }
}

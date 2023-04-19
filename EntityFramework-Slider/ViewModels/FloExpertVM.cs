using EntityFramework_Slider.Models;

namespace EntityFramework_Slider.ViewModels
{
    public class FloExpertVM
    {
        public IEnumerable<FloExpert> Experts { get; set; }
        public ExpertHeader ExpertHeader { get; set; }
    }
}

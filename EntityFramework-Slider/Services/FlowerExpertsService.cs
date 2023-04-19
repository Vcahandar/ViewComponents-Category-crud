using EntityFramework_Slider.Data;
using EntityFramework_Slider.Models;
using EntityFramework_Slider.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework_Slider.Services
{
    public class FlowerExpertsService : IFlowerExpertsService
    {
        private readonly AppDbContext _context;
        public FlowerExpertsService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<FloExpert>> GetAll()
        {
            return await _context.FloExperts.ToListAsync();
        }

        public async Task<ExpertHeader> GetInfoExpertHeader()
        {
            return await _context.ExpertHeaders.FirstOrDefaultAsync();
        }
    }
}

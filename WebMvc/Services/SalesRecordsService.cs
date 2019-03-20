using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WebMvc.Models;

namespace WebMvc.Services
{
    public class SalesRecordsService
    {
        private readonly WebMvcContext _context;

        public SalesRecordsService(WebMvcContext webMvcContext)
        {
            _context = webMvcContext;
        }

        public async Task<List<SalesRecord>> FindByDateAsync(DateTime? min, DateTime? max)
        {
            var result = from obj in _context.SalesRecord select obj;
            if (min.HasValue)
            {
                result = result.Where(x => x.Date >= min.Value);
            }
            if (max.HasValue)
            {
                result = result.Where(x => x.Date <= max.Value);
            }

            return await result.Include(x => x.Seller)
                .Include(x => x.Seller.Department)
                .OrderByDescending(x => x.Date)
                .ToListAsync();
        }
    }
}

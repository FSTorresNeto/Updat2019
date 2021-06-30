using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class SallesrecordService
    {
        private readonly SalesWebMvcContext _context;

        public SallesrecordService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<SalesRecords>> FindDataAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRercod select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);

            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date >= maxDate.Value);
            }
            return  await result
                .Include(x => x.Seller)
                .Include(X => X.Seller.Department)
                .OrderByDescending(x => x.Date)
                .ToListAsync();
        }
    }
}

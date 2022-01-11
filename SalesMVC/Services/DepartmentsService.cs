using System.Collections.Generic;
using System.Linq;
using SalesMVC.Models;
using SalesMVC.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesMVC.Services
{
    public class DepartmentsService
    {

        private readonly SalesMVCContext _context;
        public DepartmentsService(SalesMVCContext context)
        {
            _context = context;
        }
        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}

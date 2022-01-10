using System.Collections.Generic;
using System.Linq;
using SalesMVC.Models;
using SalesMVC.Data;

namespace SalesMVC.Services
{
    public class DepartmentsService
    {

        private readonly SalesMVCContext _context;
        public DepartmentsService(SalesMVCContext context)
        {
            _context = context;
        }
        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}

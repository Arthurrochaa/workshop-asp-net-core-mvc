using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace WebMvc.Services
{
    public class DepartmentService
    {
        private readonly WebMvcContext _context;

        public DepartmentService(WebMvcContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}

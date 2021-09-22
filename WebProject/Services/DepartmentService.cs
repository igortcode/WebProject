using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProject.Data;
using WebProject.Models;

namespace WebProject.Services
{
    public class DepartmentService
    {
        private readonly Context _context;

        public DepartmentService(Context context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.departments.OrderBy(d => d.Name).ToList();
        }
    }
}

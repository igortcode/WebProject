using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProject.Data;
using WebProject.Models;

namespace WebProject.Services
{
    public class SellerService
    {
        private readonly Context _context;

        public SellerService(Context context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Sellers.ToList();
        }
    }
}

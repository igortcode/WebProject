using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProject.Models;

namespace WebProject.Data
{
    public class Context : DbContext
    {
        public DbSet<Department> departments { get; set;}
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<SalesRecord> SalesRecords { get; set; }

        public Context(DbContextOptions<Context> options) : base(options){}
    }
}

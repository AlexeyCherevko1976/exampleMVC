using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MobileStore.Models
{
    public class MobileContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Nomenclature> Nomenclatures { get; set; }

        public MobileContext(DbContextOptions<MobileContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }


    }
}

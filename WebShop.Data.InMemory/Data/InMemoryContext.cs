using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.Core.Entities;

namespace WebShop.Data.InMemory.Data
{
    public class InMemoryContext : DbContext
    {
        public InMemoryContext(DbContextOptions options)
        : base(options)
        {
        }

        public  DbSet<Product> Products { get; set; }

    }
}

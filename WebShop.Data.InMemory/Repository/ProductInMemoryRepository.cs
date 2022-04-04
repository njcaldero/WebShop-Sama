using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.Core.Entities;
using WebShop.Core.Interfaces;
using WebShop.Data.InMemory.Data;

namespace WebShop.Data.InMemory.Repository
{

    public class ProductInMemoryRepository : IProductRepository
    {
        private readonly InMemoryContext context;

        public ProductInMemoryRepository(InMemoryContext _context)
        {
            context = _context;
        }

        public async Task InsertProduct(Product product)
        {
            product.CreateDate = DateTime.Now;
            context.Products.Add(product);
            await context.SaveChangesAsync();

        }

        async Task<IEnumerable<Product>> IProductRepository.GetAll()
        {
            var products = await context.Products.ToListAsync();
            return products;

        }
    }

}

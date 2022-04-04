using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.Core.Entities;
using WebShop.Core.Interfaces;
using WebShop.Data.Data;

namespace WebShop.Data.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly WebShopContext context;

        public ProductRepository(WebShopContext _context)
        {
            context = _context;
        }

        async Task IProductRepository.InsertProduct(Product product)
        {
            product.CreateDate = DateTime.Now;
            context.Products.Add(product);
            await context.SaveChangesAsync();
        }


        public async Task<IEnumerable<Product>> GetAll()
        {
            var products = await context.Products.ToListAsync();
            return products;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.Core.Entities;

namespace WebShop.Core.Interfaces
{
    public interface IProductRepository 
    {
        Task InsertProduct(Product product);
        Task<IEnumerable<Product>> GetAll();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.Core.Entities;

namespace WebShop.Core.Interfaces
{
    public interface IProductService
    {
        Task InsertProduct(Product post);

        Task<IEnumerable<Product>> GetAll();
    }
}

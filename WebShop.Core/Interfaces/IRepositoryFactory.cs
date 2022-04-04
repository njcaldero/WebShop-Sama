using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.Core.Enumerations;

namespace WebShop.Core.Interfaces
{
    public interface IRepositoryFactory
    {
        public IProductRepository GetRepository(Repository repository);
    }
}

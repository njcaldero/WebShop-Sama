using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.Core.Interfaces;
using WebShop.Data.InMemory.Repository;
using WebShop.Data.Repository;

namespace WebShop.Data.Manager.Factory
{
    public class RepositoryFactory : IRepositoryFactory
    {
        private readonly IServiceProvider serviceProvider;

        public RepositoryFactory(IServiceProvider _serviceProvider)
        {
            serviceProvider = _serviceProvider;
        }

        public IProductRepository GetRepository(WebShop.Core.Enumerations.Repository repository)
        {
            switch (repository)
            {
                case Core.Enumerations.Repository.SqlServer:
                    return (IProductRepository)serviceProvider.GetService(typeof(ProductRepository));
                case Core.Enumerations.Repository.InMemory:
                    return (IProductRepository)serviceProvider.GetService(typeof(ProductInMemoryRepository));
                default:
                    throw new ArgumentOutOfRangeException("Invalid input.");
            }
        }

    }
}

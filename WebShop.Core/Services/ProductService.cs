using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.Core.Entities;
using WebShop.Core.Enumerations;
using WebShop.Core.Interfaces;

namespace WebShop.Core.Services
{

    public class ProductService : IProductService
    {
        private readonly IRepositoryFactory repositoryFactory;
        private readonly SwichDBService swichDBService;
        private readonly IProductRepository productRepository;
        public ProductService(IRepositoryFactory _repositoryFactory, SwichDBService _swichDBService)
        {
            repositoryFactory = _repositoryFactory;
            swichDBService = _swichDBService;

            productRepository = repositoryFactory.GetRepository(swichDBService.Repository);
        }

        public async Task InsertProduct(Product product)
        {
            await productRepository.InsertProduct(product);
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            var products = await productRepository.GetAll();
            return products;
        }
    }
}

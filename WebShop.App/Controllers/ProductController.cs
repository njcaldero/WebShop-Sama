using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebShop.App.Models;
using WebShop.Core.Entities;
using WebShop.Core.Interfaces;
using WebShop.Core.Services;

namespace WebShop.App.Controllers
{
    public class ProductController : Controller
    {
        //Inversion of control implemented with dependency injection
        private readonly IProductService productService;
        private readonly IMapper mapper;
        private readonly SwichDBService swichDBService;
        public ProductController(IProductService _productService, IMapper _mapper, SwichDBService _swichDBService)
        {
            productService = _productService;
            mapper = _mapper;
            swichDBService = _swichDBService; 
          
        }

        // GET: ProductController
        public ActionResult Index()
        {
         
            return View();
        }

        // GET: ProductController
        public async Task<ActionResult> List()
        {
            try
            {
                ValidateDB();
                var listProducts = await productService.GetAll();

                var list = mapper.Map<List<ProductModel>>(listProducts);

                return View(list);
            }
            catch (System.Exception)
            {
                return View();
            }

        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            ValidateDB();
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductModel productModel)
        {
            try
            {
                ValidateDB();
                if (ModelState.IsValid)
                {
                    var product = mapper.Map<Product>(productModel);

                    productService.InsertProduct(product);

                    //This message should go in a config file
                    ViewBag.Alert = "The product has been created successfully.";

                    // return RedirectToAction(nameof(List));
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        void ValidateDB()
        {
            @ViewBag.DB = swichDBService.Repository.ToString(); 
        }

    }
}

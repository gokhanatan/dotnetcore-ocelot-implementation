using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Product.API.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController:ControllerBase
    {
         private List<Models.Product> _products = new List<Models.Product>();

        public void InitializeCategories()
        {
            _products.Add(new Models.Product() { Id = 1, Name = "Apple Laptop", Quantity = 2 });
            _products.Add(new Models.Product() { Id = 2, Name = "IPhone 12" , Quantity = 20 });
            _products.Add(new Models.Product() { Id = 3, Name = "IPhone 11 Pro", Quantity = 15  });
            _products.Add(new Models.Product() { Id = 4, Name = "Apple Magic Mouse 2" , Quantity = 10 });
            _products.Add(new Models.Product() { Id = 5, Name = "Dell Monitor", Quantity = 12  });
        }
        public ProductsController()
        {
            InitializeCategories();
        }

        [Route("getall")]
        public IActionResult GetAll()
        {
            return Ok(_products);
        }

        public IActionResult Add(Models.Product product)
        {
            _products.Add(product);
            return Ok("Product added.");
        }

    }
}
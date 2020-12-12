using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Models = Category.API.Models;

namespace Category.API.Controllers
{

    [ApiController]
    [Route("api/categories")]
    public class CategoriesController : ControllerBase
    {
        private List<Models.Category> _categories = new List<Models.Category>();

        public void InitializeCategories()
        {
            _categories.Add(new Models.Category() { Id = 1, Name = "Laptop" });
            _categories.Add(new Models.Category() { Id = 2, Name = "Phone" });
            _categories.Add(new Models.Category() { Id = 3, Name = "Monitor" });
            _categories.Add(new Models.Category() { Id = 4, Name = "Mouse" });
        }
        public CategoriesController()
        {
            InitializeCategories();
        }

        [Route("getall")]
        public IActionResult GetAll()
        {
            return Ok(_categories);
        }

        [Route("add")]
        public IActionResult Add(Models.Category category)
        {
            _categories.Add(category);
            return Ok("Category added.");
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using SwaggerUIBug.Models;
using System.Collections.Generic;
using System.Linq;

namespace SwaggerUIBug.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase {
        private readonly IList<CategoryModel> Categories = new List<CategoryModel> {
            new CategoryModel{Id = 1, Name = "Category 1"},
            new CategoryModel{Id = 2, Name = "Category 2"},
            new CategoryModel{Id = 3, Name = "Category 3"},
            new CategoryModel{Id = 4, Name = "Category 4"},
            new CategoryModel{Id = 5, Name = "Category 5"},
            new CategoryModel{Id = 6, Name = "Category 6"}
        };

        [HttpGet]
        public IList<CategoryModel> Get() {
            return Categories;
        }

        [HttpGet("{id}")]
        public CategoryModel Get(int id) {
            var data = Categories.FirstOrDefault(x => x.Id == id);
            return data;
        }

        [HttpPost]
        public int Post(CategoryModel dto) {
            Categories.Add(dto);
            return 1;
        }

        [HttpPut("{id}")]
        public int Put(int id, CategoryModel dto) {
            var data = Categories.FirstOrDefault(x => x.Id == id);

            if (data != null) {
                data.Name = dto.Name;
            }

            return 1;
        }

        [HttpDelete("{id}")]
        public int Delete(int id) {
            var data = Categories.FirstOrDefault(x => x.Id == id);

            if (data != null) {
                Categories.Remove(data);
            }

            return 1;
        }
    }
}
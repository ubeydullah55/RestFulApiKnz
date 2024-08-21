using Microsoft.AspNetCore.Mvc;
using RestFulApi.Models;
using RestFulApi.Service;

namespace RestFulApi.Controllers
{
    [Route("api/categories")]       
    [ApiController]
    public class CategoriesController:ControllerBase
    {
        private readonly ICategoriesService _categoriesService;
        public CategoriesController(ICategoriesService categoriesService)
        {
            _categoriesService = categoriesService;
        }

        [HttpPost]
        public ActionResult Create(Categories categories)
        {
            var response=_categoriesService.Create(categories);
            return Ok(response);
        }
        [HttpGet("{id:int}")]
        public ActionResult GetPost(int id)
        {
            var response=_categoriesService.GetPost(id);
            return Ok(response);
        }
        [HttpGet] 
        public ActionResult GetAll()
        {
            var response = _categoriesService.GetAll();
            return Ok(response);
        }
        [HttpDelete("{id:int}")]
        public ActionResult DeletePost(int id)
        {
            var response=_categoriesService.DeleteProduct(id);
            return Ok();
        }
        [HttpPut("{id:int}")]
        public ActionResult UpdatePost(Categories categories,int id) 
        {
            var response = _categoriesService.UpdatePost(categories,id);
            return Ok(); 
        }
    }
}

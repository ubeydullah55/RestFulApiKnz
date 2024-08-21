using Microsoft.AspNetCore.Mvc;
using RestFulApi.Models;
using RestFulApi.Service;

namespace RestFulApi.Controllers
{
    [Route("api/products")]       
    [ApiController]
    public class ProductsController:ControllerBase
    {
        private readonly IProductsService _productsService;
        public ProductsController(IProductsService productsService)
        {
            _productsService = productsService;
        }

        [HttpPost]
        public ActionResult Create(Products products)
        {
            var response= _productsService.Create(products);
            return Ok(response);
        }
        [HttpGet("{id:int}")]
        public ActionResult GetPost(int id)
        {
            var response= _productsService.GetPost(id);
            return Ok(response);
        }
        [HttpGet] 
        public ActionResult GetAll()
        {
            var response = _productsService.GetAll();
            return Ok(response);
        }
        [HttpDelete("{id:int}")]
        public ActionResult DeletePost(int id)
        {
            var response= _productsService.DeleteProduct(id);
            return Ok();
        }
        [HttpPut("{id:int}")]
        public ActionResult UpdatePost(Products products,int id) 
        {
            var response = _productsService.UpdatePost(products,id);
            return Ok(); 
        }
    }
}

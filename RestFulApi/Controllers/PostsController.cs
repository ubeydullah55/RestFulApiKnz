using Microsoft.AspNetCore.Mvc;
using RestFulApi.Models;
using RestFulApi.Service;

namespace RestFulApi.Controllers
{
    [Route("api/posts")]       
    [ApiController]
    public class PostsController:ControllerBase
    {
        private readonly IPostService _postService;
        public PostsController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpPost]
        public ActionResult Create(Posts post)
        {
            var response=_postService.Create(post);
            return Ok(response);
        }
        [HttpGet("{id:int}")]
        public ActionResult GetPost(int id)
        {
            var response=_postService.GetPost(id);
            return Ok(response);
        }
        [HttpGet] 
        public ActionResult GetAll()
        {
            var response = _postService.GetAll();
            return Ok(response);
        }
        [HttpDelete("{id:int}")]
        public ActionResult DeletePost(int id)
        {
            var response=_postService.DeleteProduct(id);
            return Ok();
        }
        [HttpPut("{id:int}")]
        public ActionResult UpdatePost(Posts post,int id) 
        {
            var response = _postService.UpdatePost(post,id);
            return Ok(); 
        }
    }
}

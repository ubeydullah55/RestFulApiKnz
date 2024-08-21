using Microsoft.AspNetCore.Mvc;
using RestFulApi.Models;
using RestFulApi.Service;

namespace RestFulApi.Controllers
{
    [Route("api/siparisdetay")]       
    [ApiController]
    public class SiparisDetayController : ControllerBase
    {
        private readonly ISiparisDetayService _siparisDetayService;
        public SiparisDetayController(ISiparisDetayService siparisDetayService)
        {
            _siparisDetayService = siparisDetayService;
        }

        [HttpPost]
        public ActionResult Create(SiparisDetay siparisDetay)
        {
            var response= _siparisDetayService.Create(siparisDetay);
            return Ok(new { id = response.siparisid });
        }
        [HttpGet("{id:int}")]
        public ActionResult GetPost(int id)
        {
            var response= _siparisDetayService.GetPost(id);
            return Ok(response);
        }
        [HttpGet] 
        public ActionResult GetAll()
        {
            var response = _siparisDetayService.GetAll();
            return Ok(response);
        }
        [HttpDelete("{id:int}")]
        public ActionResult DeletePost(int id)
        {
            var response= _siparisDetayService.DeleteProduct(id);
            return Ok();
        }
        [HttpPut("{id:int}")]
        public ActionResult UpdatePost(SiparisDetay siparisDetay, int id) 
        {
            var response = _siparisDetayService.UpdatePost(siparisDetay, id);
            return Ok(); 
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using RestFulApi.Models;
using RestFulApi.Service;

namespace RestFulApi.Controllers
{
    [Route("api/siparis")]       
    [ApiController]
    public class SiparisController : ControllerBase
    {
        private readonly ISiparisService _siparisService;
        public SiparisController(ISiparisService siparisService)
        {
            _siparisService = siparisService;
        }

        [HttpPost]
        public ActionResult Create(Siparis siparis)
        {
            var response= _siparisService.Create(siparis);
            return Ok(new { id = response.siparisid });
        }
        [HttpGet("{id:int}")]
        public ActionResult GetPost(int id)
        {
            var response= _siparisService.GetPost(id);
            return Ok(response);
        }
        [HttpGet] 
        public ActionResult GetAll()
        {
            var response = _siparisService.GetAll();
            return Ok(response);
        }
        [HttpDelete("{id:int}")]
        public ActionResult DeletePost(int id)
        {
            var response= _siparisService.DeleteProduct(id);
            return Ok();
        }
        [HttpPut("{id:int}")]
        public ActionResult UpdatePost(Siparis siparis,int id) 
        {
            var response = _siparisService.UpdatePost(siparis,id);
            return Ok(); 
        }
    }
}

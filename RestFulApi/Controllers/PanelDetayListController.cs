using Microsoft.AspNetCore.Mvc;
using RestFulApi.Models;
using RestFulApi.Service;

namespace RestFulApi.Controllers
{
    [Route("api/paneldetaylist")]       
    [ApiController]
    public class PanelDetayListController : ControllerBase
    {
        private readonly IPanelDetayListService _paneldetaylistService;
        public PanelDetayListController(IPanelDetayListService paneldetaylistService)
        {
            _paneldetaylistService = paneldetaylistService;
        }

        [HttpGet("{id:int}")]
        public ActionResult GetByList(int id)
        {
            var response = _paneldetaylistService.GetByList(id);
            return Ok(response);
        }

    }
}

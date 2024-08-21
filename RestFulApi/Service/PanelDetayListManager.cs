using Microsoft.AspNetCore.Http.HttpResults;
using RestFulApi.Models;

namespace RestFulApi.Service
{
    public class PanelDetayListManager : IPanelDetayListService
    {
        private readonly IGenericRepository<PanelDetayList> _repository;
        public PanelDetayListManager(IGenericRepository<PanelDetayList> repository)
        {
            _repository = repository;
        }
   

        List<PanelDetayList> IPanelDetayListService.GetByList(int id)
        {          
            return _repository.GetByList(id);
        }
  
    }
}

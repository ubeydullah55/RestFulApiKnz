using Microsoft.AspNetCore.Http.HttpResults;
using RestFulApi.Models;

namespace RestFulApi.Service
{
    public class SiparisDetayManager : ISiparisDetayService
    {
        private readonly IGenericRepository<SiparisDetay> _repository;
        public SiparisDetayManager(IGenericRepository<SiparisDetay> repository)
        {
            _repository = repository;
        }
        public SiparisDetay Create(SiparisDetay siparisDetay)     
        {
            return _repository.Add(siparisDetay);
        }

        //public Posts DeletePost(int id)
        //{
        //    var deleteModel=_repository.GetById(id);
        //    return _repository.Delete(deleteModel);
            
        //} 

        public SiparisDetay DeleteProduct(int id) 
        {
            var deleteModel = _repository.GetById(id);
            return _repository.Delete(deleteModel);
        }

        public SiparisDetay GetPost(int id)
        {
            return _repository.GetById(id);
        }

        public SiparisDetay UpdatePost(SiparisDetay siparisDetay, int id)
        {
            return _repository.UpdateById(siparisDetay, id);
        }

        List<SiparisDetay> ISiparisDetayService.GetAll()
        {
            return _repository.GetAll();
        }
    }
}

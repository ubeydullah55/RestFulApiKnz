using Microsoft.AspNetCore.Http.HttpResults;
using RestFulApi.Models;

namespace RestFulApi.Service
{
    public class SiparisManager : ISiparisService
    {
        private readonly IGenericRepository<Siparis> _repository;
        public SiparisManager(IGenericRepository<Siparis> repository)
        {
            _repository = repository;
        }
        public Siparis Create(Siparis siparis)     
        {
            return _repository.Add(siparis);
        }

        //public Posts DeletePost(int id)
        //{
        //    var deleteModel=_repository.GetById(id);
        //    return _repository.Delete(deleteModel);
            
        //} 

        public Siparis DeleteProduct(int id) 
        {
            var deleteModel = _repository.GetById(id);
            return _repository.Delete(deleteModel);
        }

        public Siparis GetPost(int id)
        {
            return _repository.GetById(id);
        }

        public Siparis UpdatePost(Siparis siparis, int id)
        {
            return _repository.UpdateById(siparis, id);
        }

        List<Siparis> ISiparisService.GetAll()
        {
            return _repository.GetAll();
        }
    }
}

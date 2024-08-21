using Microsoft.AspNetCore.Http.HttpResults;
using RestFulApi.Models;

namespace RestFulApi.Service
{
    public class CategoriesManager : ICategoriesService
    {
        private readonly IGenericRepository<Categories> _repository;
        public CategoriesManager(IGenericRepository<Categories> repository)
        {
            _repository = repository;
        }
        public Categories Create(Categories categories)     
        {
            return _repository.Add(categories);
        }

        //public Posts DeletePost(int id)
        //{
        //    var deleteModel=_repository.GetById(id);
        //    return _repository.Delete(deleteModel);
            
        //} 

        public Categories DeleteProduct(int id) 
        {
            var deleteModel = _repository.GetById(id);
            return _repository.Delete(deleteModel);
        }   

        public Categories GetPost(int id)
        {
            return _repository.GetById(id);
        }

        public Categories UpdatePost(Categories categories, int id)
        {
            return _repository.UpdateById(categories, id);
        }

        List<Categories> ICategoriesService.GetAll()
        {
            return _repository.GetAll();
        }
    }
}

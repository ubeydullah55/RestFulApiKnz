using Microsoft.AspNetCore.Http.HttpResults;
using RestFulApi.Models;

namespace RestFulApi.Service
{
    public class ProductsManager : IProductsService
    {
        private readonly IGenericRepository<Products> _repository;
        public ProductsManager(IGenericRepository<Products> repository)
        {
            _repository = repository;
        }
        public Products Create(Products products)
        {
            return _repository.Add(products);
        }

        //public Posts DeletePost(int id)
        //{
        //    var deleteModel=_repository.GetById(id);
        //    return _repository.Delete(deleteModel);
            
        //}

        public Products DeleteProduct(int id)
        {
            var deleteModel = _repository.GetById(id);
            return _repository.Delete(deleteModel);
        }

        public Products GetPost(int id)
        {
            return _repository.GetById(id);
        }

        public Products UpdatePost(Products products, int id)
        {
            return _repository.UpdateById(products, id);
        }

        List<Products> IProductsService.GetAll()
        {
            return _repository.GetAll();
        }
    }
}

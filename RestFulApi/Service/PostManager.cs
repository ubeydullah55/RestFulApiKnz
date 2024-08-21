using Microsoft.AspNetCore.Http.HttpResults;
using RestFulApi.Models;

namespace RestFulApi.Service
{
    public class PostManager : IPostService
    {
        private readonly IGenericRepository<Posts> _repository;
        public PostManager(IGenericRepository<Posts> repository)
        {
            _repository = repository;
        }
        public Posts Create(Posts post)
        {
            return _repository.Add(post);
        }

        //public Posts DeletePost(int id)
        //{
        //    var deleteModel=_repository.GetById(id);
        //    return _repository.Delete(deleteModel);
            
        //}

        public Posts DeleteProduct(int id)
        {
            var deleteModel = _repository.GetById(id);
            return _repository.Delete(deleteModel);
        }

        public Posts GetPost(int id)
        {
            return _repository.GetById(id);
        }

        public Posts UpdatePost(Posts post, int id)
        {
            return _repository.UpdateById(post, id);
        }

        List<Posts> IPostService.GetAll()
        {
            return _repository.GetAll();
        }
    }
}

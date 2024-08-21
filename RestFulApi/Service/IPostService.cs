using RestFulApi.Models;
using System.Runtime.InteropServices;

namespace RestFulApi.Service
{
    public interface IPostService
    {
        Posts Create(Posts post);
        Posts GetPost(int id);
        List<Posts> GetAll();
        Posts DeleteProduct(int id);
        Posts UpdatePost(Posts post,int id);
    }
}

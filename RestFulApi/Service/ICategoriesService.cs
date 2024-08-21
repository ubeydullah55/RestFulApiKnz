using RestFulApi.Models;
using System.Runtime.InteropServices;

namespace RestFulApi.Service
{
    public interface ICategoriesService
    {
        Categories Create(Categories categories);
        Categories GetPost(int id);
        List<Categories> GetAll();
        Categories DeleteProduct(int id);
        Categories UpdatePost(Categories categories, int id);
    }
}

using RestFulApi.Models;
using System.Runtime.InteropServices;

namespace RestFulApi.Service
{
    public interface IProductsService
    {
        Products Create(Products products);
        Products GetPost(int id);
        List<Products> GetAll();
        Products DeleteProduct(int id);
        Products UpdatePost(Products products, int id);
    }
}

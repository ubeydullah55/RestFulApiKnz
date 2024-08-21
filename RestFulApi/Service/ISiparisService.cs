using RestFulApi.Models;
using System.Runtime.InteropServices;

namespace RestFulApi.Service
{
    public interface ISiparisService
    {
        Siparis Create(Siparis siparis);
        Siparis GetPost(int id);
        List<Siparis> GetAll();
        Siparis DeleteProduct(int id);
        Siparis UpdatePost(Siparis siparis, int id);
    }
}

using RestFulApi.Models;
using System.Runtime.InteropServices;

namespace RestFulApi.Service
{
    public interface ISiparisDetayService
    {
        SiparisDetay Create(SiparisDetay siparisDetay);
        SiparisDetay GetPost(int id);
        List<SiparisDetay> GetAll();
        SiparisDetay DeleteProduct(int id);
        SiparisDetay UpdatePost(SiparisDetay siparisDetay, int id);
    }
}

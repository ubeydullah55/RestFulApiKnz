using RestFulApi.Models;
using System.Runtime.InteropServices;

namespace RestFulApi.Service
{
    public interface IPanelDetayListService
    {
        List<PanelDetayList> GetByList(int id);
    }
}

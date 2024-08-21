using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestFulApi.Models
{
    public class SiparisDetay
    {
        [Key]
        public int id { get; set; }
        public int siparisid { get; set; }
        public int productid { get; set; }
        public int count { get; set; }

    }
}

using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestFulApi.Models
{
    public class Siparis
    {
        [Key]
        public int siparisid { get; set; }
        [MaxLength(99)]
        public string name { get; set; }
        [MaxLength(99)]
        public string mail { get; set; }
        [MaxLength(10)]
        public string tel { get; set; }
        public int totalprice { get; set; }
        public DateTime? tarih { get; set; }

    }
}

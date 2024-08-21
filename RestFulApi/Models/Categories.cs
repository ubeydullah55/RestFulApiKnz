using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestFulApi.Models
{
    public class Categories
    {
        [Key]
        public int id { get; set; }
        [Required]
        [MaxLength(99)]
        public string name { get; set; }
        
    }
}

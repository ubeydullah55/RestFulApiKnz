using Microsoft.EntityFrameworkCore;
using RestFulApi.Models;

namespace RestFulApi.Data
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> opt) : base(opt) 
        {
        }
        public DbSet<Posts> Posts { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Siparis> Siparis { get; set; }
        public DbSet<SiparisDetay> SiparisDetay { get; set; }
        public DbSet<PanelDetayList> PanelDetayList { get; set; }
    }
}

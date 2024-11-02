using Authentication_BackEnd.Entities;
using Microsoft.EntityFrameworkCore;

namespace Authentication_BackEnd.DBContext
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        public DbSet<User> users { get; set; }
    }
}

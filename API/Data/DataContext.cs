using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data//namespace also realtes to the path of our file in this case API->Data
{
    public class DataContext : DbContext
    {
        public DataContext( DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> Users{ get; set; }
    }
}
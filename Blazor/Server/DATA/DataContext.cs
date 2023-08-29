using Blazor.Shared;
using Microsoft.EntityFrameworkCore;

namespace Blazor.Server.DATA
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
}
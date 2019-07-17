using bh.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace bh.Shared{
    public class ApplicationDbContext:DbContext{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
    }
}
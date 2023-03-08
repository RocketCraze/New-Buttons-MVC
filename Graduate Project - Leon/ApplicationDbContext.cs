
using Microsoft.EntityFrameworkCore;

using Graduate_Project___Leon.Models;

namespace Graduate_Project___Leon
{

    public class ApplicationDbContext : DbContext
    {
       

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Profile> Profile { get; set; }
    }

}
using JRFirstMVC.Areas.Admin.Models;
using JRFirstMVC.Areas.Profile.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JRFirstMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<UserVM> User { get; set; }
        public DbSet<AdminVM> Admin { get; set; }
    }
}

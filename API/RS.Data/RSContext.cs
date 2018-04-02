using Microsoft.EntityFrameworkCore;
using RS.Entity.Models;

namespace RS.Data
{
    public class RSContext : DbContext
    {
        public RSContext(DbContextOptions<RSContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Skills> Skills { get; set; }
        public virtual DbSet<Users> Users { get; set; }

    }
}

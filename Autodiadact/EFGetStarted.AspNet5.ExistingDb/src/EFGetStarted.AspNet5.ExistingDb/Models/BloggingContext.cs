using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace EFGetStarted.AspNet5.ExistingDb.Models
{
    public partial class BloggingContext : DbContext
    {
     

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BLOG>(entity =>
            {
                entity.Property(e => e.Url).IsRequired();
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.HasOne(d => d.Blog).WithMany(p => p.Post).HasForeignKey(d => d.BlogId);
            });
        }

        public virtual DbSet<BLOG> BLOG { get; set; }
        public virtual DbSet<Post> Post { get; set; }
    }
}
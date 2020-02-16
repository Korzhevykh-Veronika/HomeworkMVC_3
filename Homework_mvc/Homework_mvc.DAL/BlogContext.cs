using Homework_mvc.Entities;
using System.Data.Entity;

namespace Homework_mvc.Infrastructure.Data
{
    public class BlogContext : DbContext
    {
        public BlogContext() : base("DefaultConnection")
        {
            
        }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>().HasMany(a => a.Tags)
                .WithMany(t => t.Articles)
                .Map(t => t.MapLeftKey("ArticleId")
                .MapRightKey("TagId")
                .ToTable("ArticleTag"));
        }
    }
}

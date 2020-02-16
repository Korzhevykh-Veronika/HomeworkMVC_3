using System.Data.Entity;

namespace Homework_mvc.Models
{
    public class BlogContext : DbContext
    {
        public BlogContext() : base("DefaultConnection")
        {
           // Database.CreateIfNotExists();
        }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Profile> Profiles { get; set; }
    }
}
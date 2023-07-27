// Data/ApplicationDbContext.cs

using System.Data.Entity;
using blog.Models;

namespace blog.Data
{
    public class ApplicationDbContext : DbContext
    {
        // 기본 생성자 추가
        public ApplicationDbContext() : base("name=_db_Blog")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
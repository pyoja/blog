// Data/ApplicationDbContext.cs

using System.Data.Entity;
using blog.Models;

namespace blog.Data
{
    public class AppDbContext : DbContext
    {
        // 기본 생성자 추가
        public AppDbContext() : base("name=_db_Blog")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
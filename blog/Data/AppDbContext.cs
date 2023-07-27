using blog.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;


namespace blog.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        // 기본 생성자 추가
        public AppDbContext() : base("name=_db_Blog")
        {
        }

        public DbSet<Post> Posts { get; set; }

        // 필요한 경우 추가 구성 코드
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // 추가 구성 코드 작성
        }
    }
}

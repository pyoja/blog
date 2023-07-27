namespace blog.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

<<<<<<< HEAD
    internal sealed class Configuration : DbMigrationsConfiguration<blog.Data.ApplicationDbContext>
=======
    internal sealed class Configuration : DbMigrationsConfiguration<blog.Data.AppDbContext>
>>>>>>> adeadff366e31d24dcdfb3092236b73f076c2a7c
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

<<<<<<< HEAD
        protected override void Seed(blog.Data.ApplicationDbContext context)
=======
        protected override void Seed(blog.Data.AppDbContext context)
>>>>>>> adeadff366e31d24dcdfb3092236b73f076c2a7c
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}

namespace blog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        No = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Content = c.String(),
                        ImgUrl = c.String(),
                        Like = c.Int(nullable: false),
                        Comment = c.String(),
                        RegDate = c.DateTime(nullable: false),
                        DelState = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.No);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        No = c.Int(nullable: false, identity: true),
                        Id = c.String(),
                        Password = c.String(),
                        Reg_date = c.DateTime(nullable: false),
                        Del_state = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.No);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Posts");
        }
    }
}

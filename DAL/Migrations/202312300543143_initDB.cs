namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BuyerComments",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        BuyerReview = c.String(nullable: false),
                        Time = c.DateTime(nullable: false),
                        ReviewedBy = c.String(maxLength: 128),
                        PId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Products", t => t.PId, cascadeDelete: true)
                .ForeignKey("dbo.Sellers", t => t.ReviewedBy)
                .Index(t => t.ReviewedBy)
                .Index(t => t.PId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Details = c.String(nullable: false),
                        Prize = c.String(nullable: false),
                        PostedBy = c.String(maxLength: 128),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Sellers", t => t.PostedBy)
                .Index(t => t.PostedBy);
            
            CreateTable(
                "dbo.Sellers",
                c => new
                    {
                        Sname = c.String(nullable: false, maxLength: 128),
                        Password = c.String(nullable: false, maxLength: 20),
                        Name = c.String(nullable: false, maxLength: 20),
                        Type = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Sname);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BuyerComments", "ReviewedBy", "dbo.Sellers");
            DropForeignKey("dbo.BuyerComments", "PId", "dbo.Products");
            DropForeignKey("dbo.Products", "PostedBy", "dbo.Sellers");
            DropIndex("dbo.Products", new[] { "PostedBy" });
            DropIndex("dbo.BuyerComments", new[] { "PId" });
            DropIndex("dbo.BuyerComments", new[] { "ReviewedBy" });
            DropTable("dbo.Sellers");
            DropTable("dbo.Products");
            DropTable("dbo.BuyerComments");
        }
    }
}

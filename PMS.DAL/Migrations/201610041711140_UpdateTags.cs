using System.Data.Entity.Migrations;

namespace PMS.DAL.Migrations
{
    public partial class UpdateTags : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Tags", "Product_Id", "dbo.Products");
            DropIndex("dbo.Tags", new[] {"Product_Id"});
            CreateTable(
                "dbo.ProductTags",
                c => new
                {
                    Product_Id = c.Int(false),
                    Tag_Id = c.Int(false)
                })
                .PrimaryKey(t => new {t.Product_Id, t.Tag_Id})
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .ForeignKey("dbo.Tags", t => t.Tag_Id)
                .Index(t => t.Product_Id)
                .Index(t => t.Tag_Id);

            DropColumn("dbo.Tags", "Product_Id");
        }

        public override void Down()
        {
            AddColumn("dbo.Tags", "Product_Id", c => c.Int());
            DropForeignKey("dbo.ProductTags", "Tag_Id", "dbo.Tags");
            DropForeignKey("dbo.ProductTags", "Product_Id", "dbo.Products");
            DropIndex("dbo.ProductTags", new[] {"Tag_Id"});
            DropIndex("dbo.ProductTags", new[] {"Product_Id"});
            DropTable("dbo.ProductTags");
            CreateIndex("dbo.Tags", "Product_Id");
            AddForeignKey("dbo.Tags", "Product_Id", "dbo.Products", "Id");
        }
    }
}
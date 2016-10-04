using System.Data.Entity.Migrations;

namespace PMS.DAL.Migrations
{
    public partial class Updates : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ConditionProducts", "Condition_Id", "dbo.Conditions");
            DropForeignKey("dbo.ConditionProducts", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.PawnProducts", "Pawn_Id", "dbo.Pawns");
            DropForeignKey("dbo.PawnProducts", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.ProductPurchases", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.ProductPurchases", "Purchase_Id", "dbo.Purchases");
            DropForeignKey("dbo.NotePawns", "Note_Id", "dbo.Notes");
            DropForeignKey("dbo.NotePawns", "Pawn_Id", "dbo.Pawns");
            DropForeignKey("dbo.LocationPawns", "Location_Id", "dbo.Locations");
            DropForeignKey("dbo.LocationPawns", "Pawn_Id", "dbo.Pawns");
            DropForeignKey("dbo.NotePurchases", "Note_Id", "dbo.Notes");
            DropForeignKey("dbo.NotePurchases", "Purchase_Id", "dbo.Purchases");
            DropForeignKey("dbo.LocationPurchases", "Location_Id", "dbo.Locations");
            DropForeignKey("dbo.LocationPurchases", "Purchase_Id", "dbo.Purchases");
            AddForeignKey("dbo.ConditionProducts", "Condition_Id", "dbo.Conditions", "Id");
            AddForeignKey("dbo.ConditionProducts", "Product_Id", "dbo.Products", "Id");
            AddForeignKey("dbo.PawnProducts", "Pawn_Id", "dbo.Pawns", "Id");
            AddForeignKey("dbo.PawnProducts", "Product_Id", "dbo.Products", "Id");
            AddForeignKey("dbo.ProductPurchases", "Product_Id", "dbo.Products", "Id");
            AddForeignKey("dbo.ProductPurchases", "Purchase_Id", "dbo.Purchases", "Id");
            AddForeignKey("dbo.NotePawns", "Note_Id", "dbo.Notes", "Id");
            AddForeignKey("dbo.NotePawns", "Pawn_Id", "dbo.Pawns", "Id");
            AddForeignKey("dbo.LocationPawns", "Location_Id", "dbo.Locations", "Id");
            AddForeignKey("dbo.LocationPawns", "Pawn_Id", "dbo.Pawns", "Id");
            AddForeignKey("dbo.NotePurchases", "Note_Id", "dbo.Notes", "Id");
            AddForeignKey("dbo.NotePurchases", "Purchase_Id", "dbo.Purchases", "Id");
            AddForeignKey("dbo.LocationPurchases", "Location_Id", "dbo.Locations", "Id");
            AddForeignKey("dbo.LocationPurchases", "Purchase_Id", "dbo.Purchases", "Id");
        }

        public override void Down()
        {
            DropForeignKey("dbo.LocationPurchases", "Purchase_Id", "dbo.Purchases");
            DropForeignKey("dbo.LocationPurchases", "Location_Id", "dbo.Locations");
            DropForeignKey("dbo.NotePurchases", "Purchase_Id", "dbo.Purchases");
            DropForeignKey("dbo.NotePurchases", "Note_Id", "dbo.Notes");
            DropForeignKey("dbo.LocationPawns", "Pawn_Id", "dbo.Pawns");
            DropForeignKey("dbo.LocationPawns", "Location_Id", "dbo.Locations");
            DropForeignKey("dbo.NotePawns", "Pawn_Id", "dbo.Pawns");
            DropForeignKey("dbo.NotePawns", "Note_Id", "dbo.Notes");
            DropForeignKey("dbo.ProductPurchases", "Purchase_Id", "dbo.Purchases");
            DropForeignKey("dbo.ProductPurchases", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.PawnProducts", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.PawnProducts", "Pawn_Id", "dbo.Pawns");
            DropForeignKey("dbo.ConditionProducts", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.ConditionProducts", "Condition_Id", "dbo.Conditions");
            AddForeignKey("dbo.LocationPurchases", "Purchase_Id", "dbo.Purchases", "Id", true);
            AddForeignKey("dbo.LocationPurchases", "Location_Id", "dbo.Locations", "Id", true);
            AddForeignKey("dbo.NotePurchases", "Purchase_Id", "dbo.Purchases", "Id", true);
            AddForeignKey("dbo.NotePurchases", "Note_Id", "dbo.Notes", "Id", true);
            AddForeignKey("dbo.LocationPawns", "Pawn_Id", "dbo.Pawns", "Id", true);
            AddForeignKey("dbo.LocationPawns", "Location_Id", "dbo.Locations", "Id", true);
            AddForeignKey("dbo.NotePawns", "Pawn_Id", "dbo.Pawns", "Id", true);
            AddForeignKey("dbo.NotePawns", "Note_Id", "dbo.Notes", "Id", true);
            AddForeignKey("dbo.ProductPurchases", "Purchase_Id", "dbo.Purchases", "Id", true);
            AddForeignKey("dbo.ProductPurchases", "Product_Id", "dbo.Products", "Id", true);
            AddForeignKey("dbo.PawnProducts", "Product_Id", "dbo.Products", "Id", true);
            AddForeignKey("dbo.PawnProducts", "Pawn_Id", "dbo.Pawns", "Id", true);
            AddForeignKey("dbo.ConditionProducts", "Product_Id", "dbo.Products", "Id", true);
            AddForeignKey("dbo.ConditionProducts", "Condition_Id", "dbo.Conditions", "Id", true);
        }
    }
}
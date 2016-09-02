namespace PMS.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V00 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Street = c.String(),
                        PostalCode = c.String(nullable: false),
                        City_Id = c.Int(nullable: false),
                        Country_Id = c.Int(nullable: false),
                        Province_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.City_Id)
                .ForeignKey("dbo.Countries", t => t.Country_Id)
                .ForeignKey("dbo.Provinces", t => t.Province_Id)
                .Index(t => t.City_Id)
                .Index(t => t.Country_Id)
                .Index(t => t.Province_Id);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 80),
                        Province_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Provinces", t => t.Province_Id)
                .Index(t => t.Province_Id);
            
            CreateTable(
                "dbo.Provinces",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 80),
                        Abbreviation = c.String(),
                        Country_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.Country_Id)
                .Index(t => t.Name, unique: true)
                .Index(t => t.Country_Id);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        IdentificationNumber = c.String(nullable: false, maxLength: 50),
                        OtherIdentificationNumber = c.String(maxLength: 50),
                        Address_Id = c.Int(nullable: false),
                        IdentificationType_Id = c.Int(nullable: false),
                        OtherIdentificationType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Addresses", t => t.Address_Id)
                .ForeignKey("dbo.IdentificationTypes", t => t.IdentificationType_Id)
                .ForeignKey("dbo.IdentificationTypes", t => t.OtherIdentificationType_Id)
                .Index(t => t.Address_Id)
                .Index(t => t.IdentificationType_Id)
                .Index(t => t.OtherIdentificationType_Id);
            
            CreateTable(
                "dbo.IdentificationTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true);
            
            CreateTable(
                "dbo.Colours",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Code = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true);
            
            CreateTable(
                "dbo.Conditions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 80),
                        Description = c.String(nullable: false, maxLength: 255),
                        Year = c.Int(nullable: false),
                        Colour_Id = c.Int(nullable: false),
                        ProductType_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Colours", t => t.Colour_Id)
                .ForeignKey("dbo.ProductTypes", t => t.ProductType_Id)
                .Index(t => t.Name, unique: true)
                .Index(t => t.Colour_Id)
                .Index(t => t.ProductType_Id);
            
            CreateTable(
                "dbo.Pawns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PawnValue = c.Double(nullable: false),
                        EstimatedValueLow = c.Double(),
                        EstimatedValueHigh = c.Double(),
                        ExpiryDate = c.DateTime(nullable: false),
                        ExtendedToDate = c.DateTime(),
                        PickupPrice = c.Double(nullable: false),
                        ClosedDate = c.DateTime(),
                        Client_Id = c.Int(nullable: false),
                        Rate_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.Client_Id)
                .ForeignKey("dbo.Rates", t => t.Rate_Id)
                .Index(t => t.Client_Id)
                .Index(t => t.Rate_Id);
            
            CreateTable(
                "dbo.Notes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Value = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Purchases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PurchaseCost = c.Double(nullable: false),
                        EstimatedValueLow = c.Double(),
                        EstimatedValueHigh = c.Double(),
                        SaleableDate = c.DateTime(nullable: false),
                        Client_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.Client_Id)
                .Index(t => t.Client_Id);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Value = c.Double(nullable: false),
                        Date = c.DateTime(nullable: false),
                        PaymentType_Id = c.Int(nullable: false),
                        Purchase_Id = c.Int(),
                        Pawn_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PaymentTypes", t => t.PaymentType_Id)
                .ForeignKey("dbo.Purchases", t => t.Purchase_Id)
                .ForeignKey("dbo.Pawns", t => t.Pawn_Id)
                .Index(t => t.PaymentType_Id)
                .Index(t => t.Purchase_Id)
                .Index(t => t.Pawn_Id);
            
            CreateTable(
                "dbo.PaymentTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 80),
                        Description = c.String(nullable: false, maxLength: 255),
                        Facility_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Facilities", t => t.Facility_Id)
                .Index(t => t.Name, unique: true)
                .Index(t => t.Facility_Id);
            
            CreateTable(
                "dbo.Facilities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 80),
                        Address_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Addresses", t => t.Address_Id)
                .Index(t => t.Name, unique: true)
                .Index(t => t.Address_Id);
            
            CreateTable(
                "dbo.Rates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 80),
                        Value = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true);
            
            CreateTable(
                "dbo.ProductTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 80),
                        Product_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .Index(t => t.Name, unique: true)
                .Index(t => t.Product_Id);
            
            CreateTable(
                "dbo.Settings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 80),
                        Value = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 50),
                        Pin = c.Int(nullable: false),
                        Password = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserSettings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 80),
                        Value = c.String(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.Name, unique: true)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.PawnProducts",
                c => new
                    {
                        Pawn_Id = c.Int(nullable: false),
                        Product_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Pawn_Id, t.Product_Id })
                .ForeignKey("dbo.Pawns", t => t.Pawn_Id, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Product_Id, cascadeDelete: true)
                .Index(t => t.Pawn_Id)
                .Index(t => t.Product_Id);
            
            CreateTable(
                "dbo.NotePawns",
                c => new
                    {
                        Note_Id = c.Int(nullable: false),
                        Pawn_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Note_Id, t.Pawn_Id })
                .ForeignKey("dbo.Notes", t => t.Note_Id, cascadeDelete: true)
                .ForeignKey("dbo.Pawns", t => t.Pawn_Id, cascadeDelete: true)
                .Index(t => t.Note_Id)
                .Index(t => t.Pawn_Id);
            
            CreateTable(
                "dbo.LocationPawns",
                c => new
                    {
                        Location_Id = c.Int(nullable: false),
                        Pawn_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Location_Id, t.Pawn_Id })
                .ForeignKey("dbo.Locations", t => t.Location_Id, cascadeDelete: true)
                .ForeignKey("dbo.Pawns", t => t.Pawn_Id, cascadeDelete: true)
                .Index(t => t.Location_Id)
                .Index(t => t.Pawn_Id);
            
            CreateTable(
                "dbo.LocationPurchases",
                c => new
                    {
                        Location_Id = c.Int(nullable: false),
                        Purchase_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Location_Id, t.Purchase_Id })
                .ForeignKey("dbo.Locations", t => t.Location_Id, cascadeDelete: true)
                .ForeignKey("dbo.Purchases", t => t.Purchase_Id, cascadeDelete: true)
                .Index(t => t.Location_Id)
                .Index(t => t.Purchase_Id);
            
            CreateTable(
                "dbo.NotePurchases",
                c => new
                    {
                        Note_Id = c.Int(nullable: false),
                        Purchase_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Note_Id, t.Purchase_Id })
                .ForeignKey("dbo.Notes", t => t.Note_Id, cascadeDelete: true)
                .ForeignKey("dbo.Purchases", t => t.Purchase_Id, cascadeDelete: true)
                .Index(t => t.Note_Id)
                .Index(t => t.Purchase_Id);
            
            CreateTable(
                "dbo.ProductPurchases",
                c => new
                    {
                        Product_Id = c.Int(nullable: false),
                        Purchase_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Product_Id, t.Purchase_Id })
                .ForeignKey("dbo.Products", t => t.Product_Id, cascadeDelete: true)
                .ForeignKey("dbo.Purchases", t => t.Purchase_Id, cascadeDelete: true)
                .Index(t => t.Product_Id)
                .Index(t => t.Purchase_Id);
            
            CreateTable(
                "dbo.ConditionProducts",
                c => new
                    {
                        Condition_Id = c.Int(nullable: false),
                        Product_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Condition_Id, t.Product_Id })
                .ForeignKey("dbo.Conditions", t => t.Condition_Id, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Product_Id, cascadeDelete: true)
                .Index(t => t.Condition_Id)
                .Index(t => t.Product_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserSettings", "User_Id", "dbo.Users");
            DropForeignKey("dbo.ConditionProducts", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.ConditionProducts", "Condition_Id", "dbo.Conditions");
            DropForeignKey("dbo.Tags", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.ProductPurchases", "Purchase_Id", "dbo.Purchases");
            DropForeignKey("dbo.ProductPurchases", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.Products", "ProductType_Id", "dbo.ProductTypes");
            DropForeignKey("dbo.Pawns", "Rate_Id", "dbo.Rates");
            DropForeignKey("dbo.Payments", "Pawn_Id", "dbo.Pawns");
            DropForeignKey("dbo.NotePurchases", "Purchase_Id", "dbo.Purchases");
            DropForeignKey("dbo.NotePurchases", "Note_Id", "dbo.Notes");
            DropForeignKey("dbo.LocationPurchases", "Purchase_Id", "dbo.Purchases");
            DropForeignKey("dbo.LocationPurchases", "Location_Id", "dbo.Locations");
            DropForeignKey("dbo.LocationPawns", "Pawn_Id", "dbo.Pawns");
            DropForeignKey("dbo.LocationPawns", "Location_Id", "dbo.Locations");
            DropForeignKey("dbo.Locations", "Facility_Id", "dbo.Facilities");
            DropForeignKey("dbo.Facilities", "Address_Id", "dbo.Addresses");
            DropForeignKey("dbo.Payments", "Purchase_Id", "dbo.Purchases");
            DropForeignKey("dbo.Payments", "PaymentType_Id", "dbo.PaymentTypes");
            DropForeignKey("dbo.Purchases", "Client_Id", "dbo.Clients");
            DropForeignKey("dbo.NotePawns", "Pawn_Id", "dbo.Pawns");
            DropForeignKey("dbo.NotePawns", "Note_Id", "dbo.Notes");
            DropForeignKey("dbo.PawnProducts", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.PawnProducts", "Pawn_Id", "dbo.Pawns");
            DropForeignKey("dbo.Pawns", "Client_Id", "dbo.Clients");
            DropForeignKey("dbo.Products", "Colour_Id", "dbo.Colours");
            DropForeignKey("dbo.Clients", "OtherIdentificationType_Id", "dbo.IdentificationTypes");
            DropForeignKey("dbo.Clients", "IdentificationType_Id", "dbo.IdentificationTypes");
            DropForeignKey("dbo.Clients", "Address_Id", "dbo.Addresses");
            DropForeignKey("dbo.Addresses", "Province_Id", "dbo.Provinces");
            DropForeignKey("dbo.Addresses", "Country_Id", "dbo.Countries");
            DropForeignKey("dbo.Addresses", "City_Id", "dbo.Cities");
            DropForeignKey("dbo.Provinces", "Country_Id", "dbo.Countries");
            DropForeignKey("dbo.Cities", "Province_Id", "dbo.Provinces");
            DropIndex("dbo.ConditionProducts", new[] { "Product_Id" });
            DropIndex("dbo.ConditionProducts", new[] { "Condition_Id" });
            DropIndex("dbo.ProductPurchases", new[] { "Purchase_Id" });
            DropIndex("dbo.ProductPurchases", new[] { "Product_Id" });
            DropIndex("dbo.NotePurchases", new[] { "Purchase_Id" });
            DropIndex("dbo.NotePurchases", new[] { "Note_Id" });
            DropIndex("dbo.LocationPurchases", new[] { "Purchase_Id" });
            DropIndex("dbo.LocationPurchases", new[] { "Location_Id" });
            DropIndex("dbo.LocationPawns", new[] { "Pawn_Id" });
            DropIndex("dbo.LocationPawns", new[] { "Location_Id" });
            DropIndex("dbo.NotePawns", new[] { "Pawn_Id" });
            DropIndex("dbo.NotePawns", new[] { "Note_Id" });
            DropIndex("dbo.PawnProducts", new[] { "Product_Id" });
            DropIndex("dbo.PawnProducts", new[] { "Pawn_Id" });
            DropIndex("dbo.UserSettings", new[] { "User_Id" });
            DropIndex("dbo.UserSettings", new[] { "Name" });
            DropIndex("dbo.Settings", new[] { "Name" });
            DropIndex("dbo.Tags", new[] { "Product_Id" });
            DropIndex("dbo.Tags", new[] { "Name" });
            DropIndex("dbo.ProductTypes", new[] { "Name" });
            DropIndex("dbo.Rates", new[] { "Name" });
            DropIndex("dbo.Facilities", new[] { "Address_Id" });
            DropIndex("dbo.Facilities", new[] { "Name" });
            DropIndex("dbo.Locations", new[] { "Facility_Id" });
            DropIndex("dbo.Locations", new[] { "Name" });
            DropIndex("dbo.PaymentTypes", new[] { "Name" });
            DropIndex("dbo.Payments", new[] { "Pawn_Id" });
            DropIndex("dbo.Payments", new[] { "Purchase_Id" });
            DropIndex("dbo.Payments", new[] { "PaymentType_Id" });
            DropIndex("dbo.Purchases", new[] { "Client_Id" });
            DropIndex("dbo.Pawns", new[] { "Rate_Id" });
            DropIndex("dbo.Pawns", new[] { "Client_Id" });
            DropIndex("dbo.Products", new[] { "ProductType_Id" });
            DropIndex("dbo.Products", new[] { "Colour_Id" });
            DropIndex("dbo.Products", new[] { "Name" });
            DropIndex("dbo.Conditions", new[] { "Name" });
            DropIndex("dbo.Colours", new[] { "Name" });
            DropIndex("dbo.IdentificationTypes", new[] { "Name" });
            DropIndex("dbo.Clients", new[] { "OtherIdentificationType_Id" });
            DropIndex("dbo.Clients", new[] { "IdentificationType_Id" });
            DropIndex("dbo.Clients", new[] { "Address_Id" });
            DropIndex("dbo.Countries", new[] { "Name" });
            DropIndex("dbo.Provinces", new[] { "Country_Id" });
            DropIndex("dbo.Provinces", new[] { "Name" });
            DropIndex("dbo.Cities", new[] { "Province_Id" });
            DropIndex("dbo.Addresses", new[] { "Province_Id" });
            DropIndex("dbo.Addresses", new[] { "Country_Id" });
            DropIndex("dbo.Addresses", new[] { "City_Id" });
            DropTable("dbo.ConditionProducts");
            DropTable("dbo.ProductPurchases");
            DropTable("dbo.NotePurchases");
            DropTable("dbo.LocationPurchases");
            DropTable("dbo.LocationPawns");
            DropTable("dbo.NotePawns");
            DropTable("dbo.PawnProducts");
            DropTable("dbo.UserSettings");
            DropTable("dbo.Users");
            DropTable("dbo.Settings");
            DropTable("dbo.Tags");
            DropTable("dbo.ProductTypes");
            DropTable("dbo.Rates");
            DropTable("dbo.Facilities");
            DropTable("dbo.Locations");
            DropTable("dbo.PaymentTypes");
            DropTable("dbo.Payments");
            DropTable("dbo.Purchases");
            DropTable("dbo.Notes");
            DropTable("dbo.Pawns");
            DropTable("dbo.Products");
            DropTable("dbo.Conditions");
            DropTable("dbo.Colours");
            DropTable("dbo.IdentificationTypes");
            DropTable("dbo.Clients");
            DropTable("dbo.Countries");
            DropTable("dbo.Provinces");
            DropTable("dbo.Cities");
            DropTable("dbo.Addresses");
        }
    }
}

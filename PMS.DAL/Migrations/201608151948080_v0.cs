namespace PMS.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V0 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Street = c.String(),
                        PostalCode = c.String(),
                        City_Id = c.Int(),
                        Country_Id = c.Int(),
                        Province_Id = c.Int(),
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
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Provinces",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        LicenseNumber = c.String(),
                        OtherIdentificationNumber = c.String(),
                        Address_Id = c.Int(),
                        IdentificationType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Addresses", t => t.Address_Id)
                .ForeignKey("dbo.IdentificationTypes", t => t.IdentificationType_Id)
                .Index(t => t.Address_Id)
                .Index(t => t.IdentificationType_Id);
            
            CreateTable(
                "dbo.IdentificationTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Colours",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Conditions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Facilities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Addresses", t => t.Address_Id)
                .Index(t => t.Address_Id);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Facility_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Facilities", t => t.Facility_Id)
                .Index(t => t.Facility_Id);
            
            CreateTable(
                "dbo.Notes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Value = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
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
                        Client_Id = c.Int(),
                        Rate_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.Client_Id)
                .ForeignKey("dbo.Rates", t => t.Rate_Id)
                .Index(t => t.Client_Id)
                .Index(t => t.Rate_Id);
            
            CreateTable(
                "dbo.Rates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Value = c.Double(nullable: false),
                        Date = c.DateTime(nullable: false),
                        PaymentType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PaymentTypes", t => t.PaymentType_Id)
                .Index(t => t.PaymentType_Id);
            
            CreateTable(
                "dbo.PaymentTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Year = c.Int(nullable: false),
                        Colour_Id = c.Int(),
                        Condition_Id = c.Int(),
                        ProductType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Colours", t => t.Colour_Id)
                .ForeignKey("dbo.Conditions", t => t.Condition_Id)
                .ForeignKey("dbo.ProductTypes", t => t.ProductType_Id)
                .Index(t => t.Colour_Id)
                .Index(t => t.Condition_Id)
                .Index(t => t.ProductType_Id);
            
            CreateTable(
                "dbo.ProductTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
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
                        Client_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.Client_Id)
                .Index(t => t.Client_Id);
            
            CreateTable(
                "dbo.Settings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Value = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Pin = c.Int(nullable: false),
                        Password = c.String(),
                        UserSettings_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserSettings", t => t.UserSettings_Id)
                .Index(t => t.UserSettings_Id);
            
            CreateTable(
                "dbo.UserSettings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Value = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "UserSettings_Id", "dbo.UserSettings");
            DropForeignKey("dbo.Purchases", "Client_Id", "dbo.Clients");
            DropForeignKey("dbo.Products", "ProductType_Id", "dbo.ProductTypes");
            DropForeignKey("dbo.Products", "Condition_Id", "dbo.Conditions");
            DropForeignKey("dbo.Products", "Colour_Id", "dbo.Colours");
            DropForeignKey("dbo.Payments", "PaymentType_Id", "dbo.PaymentTypes");
            DropForeignKey("dbo.Pawns", "Rate_Id", "dbo.Rates");
            DropForeignKey("dbo.Pawns", "Client_Id", "dbo.Clients");
            DropForeignKey("dbo.Locations", "Facility_Id", "dbo.Facilities");
            DropForeignKey("dbo.Facilities", "Address_Id", "dbo.Addresses");
            DropForeignKey("dbo.Clients", "IdentificationType_Id", "dbo.IdentificationTypes");
            DropForeignKey("dbo.Clients", "Address_Id", "dbo.Addresses");
            DropForeignKey("dbo.Addresses", "Province_Id", "dbo.Provinces");
            DropForeignKey("dbo.Addresses", "Country_Id", "dbo.Countries");
            DropForeignKey("dbo.Addresses", "City_Id", "dbo.Cities");
            DropIndex("dbo.Users", new[] { "UserSettings_Id" });
            DropIndex("dbo.Purchases", new[] { "Client_Id" });
            DropIndex("dbo.Products", new[] { "ProductType_Id" });
            DropIndex("dbo.Products", new[] { "Condition_Id" });
            DropIndex("dbo.Products", new[] { "Colour_Id" });
            DropIndex("dbo.Payments", new[] { "PaymentType_Id" });
            DropIndex("dbo.Pawns", new[] { "Rate_Id" });
            DropIndex("dbo.Pawns", new[] { "Client_Id" });
            DropIndex("dbo.Locations", new[] { "Facility_Id" });
            DropIndex("dbo.Facilities", new[] { "Address_Id" });
            DropIndex("dbo.Clients", new[] { "IdentificationType_Id" });
            DropIndex("dbo.Clients", new[] { "Address_Id" });
            DropIndex("dbo.Addresses", new[] { "Province_Id" });
            DropIndex("dbo.Addresses", new[] { "Country_Id" });
            DropIndex("dbo.Addresses", new[] { "City_Id" });
            DropTable("dbo.UserSettings");
            DropTable("dbo.Users");
            DropTable("dbo.Tags");
            DropTable("dbo.Settings");
            DropTable("dbo.Purchases");
            DropTable("dbo.ProductTypes");
            DropTable("dbo.Products");
            DropTable("dbo.PaymentTypes");
            DropTable("dbo.Payments");
            DropTable("dbo.Rates");
            DropTable("dbo.Pawns");
            DropTable("dbo.Notes");
            DropTable("dbo.Locations");
            DropTable("dbo.Facilities");
            DropTable("dbo.Conditions");
            DropTable("dbo.Colours");
            DropTable("dbo.IdentificationTypes");
            DropTable("dbo.Clients");
            DropTable("dbo.Provinces");
            DropTable("dbo.Countries");
            DropTable("dbo.Cities");
            DropTable("dbo.Addresses");
        }
    }
}

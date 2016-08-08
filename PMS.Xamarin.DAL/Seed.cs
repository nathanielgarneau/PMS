using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Xam.DAL.Model;
using SQLite;

namespace PMS.Xam.DAL
{
    internal static class Seed
    {
        internal static void InitialSeed(SQLiteConnection context)
        {
            context.CreateTable<Address>();
            context.CreateTable<City>();
            context.CreateTable<Client>();
            context.CreateTable<Colour>();
            context.CreateTable<Condition>();
            context.CreateTable<Country>();
            context.CreateTable<Facility>();
            context.CreateTable<IdentificationType>();
            context.CreateTable<Location>();
            context.CreateTable<Note>();
            context.CreateTable<Pawn>();
            context.CreateTable<Payment>();
            context.CreateTable<PaymentType>();
            context.CreateTable<Product>();
            context.CreateTable<ProductType>();
            context.CreateTable<Province>();
            context.CreateTable<Purchase>();
            context.CreateTable<Rate>();
            context.CreateTable<Setting>();
            context.CreateTable<Tag>();
            context.CreateTable<User>();
            context.CreateTable<UserSettings>();


            SeedAddress(context);
            SeedCity(context);
            SeedClient(context);
            SeedColour(context);
            SeedCondition(context);
            SeedCountry(context);
            SeedFacility(context);
            SeedIdentificationType(context);
            SeedLocation(context);
            SeedNote(context);
            SeedPawn(context);
            SeedPayment(context);
            SeedPaymentType(context);
            SeedProduct(context);
            SeedProductType(context);
            SeedProvince(context);
            SeedPurchase(context);
            SeedRate(context);
            SeedSetting(context);
            SeedTag(context);
            SeedUser(context);
            SeedUserSettings(context);
        }

        private static void SeedAddress(SQLiteConnection context){}
         private static void SeedCity(SQLiteConnection context){}
        private static void SeedClient(SQLiteConnection context){}
         private static void SeedColour(SQLiteConnection context){}
         private static void SeedCondition(SQLiteConnection context){}
         private static void SeedCountry(SQLiteConnection context){}
         private static void SeedFacility(SQLiteConnection context){}
         private static void SeedIdentificationType(SQLiteConnection context){}
         private static void SeedLocation(SQLiteConnection context){}
         private static void SeedNote(SQLiteConnection context){}
        private static void SeedPawn(SQLiteConnection context){}
         private static void SeedPayment(SQLiteConnection context){}
         private static void SeedPaymentType(SQLiteConnection context){}
         private static void SeedProduct(SQLiteConnection context){}
         private static void SeedProductType(SQLiteConnection context){}
         private static void SeedProvince(SQLiteConnection context){}
        private static void  SeedPurchase(SQLiteConnection context){}
        private static void SeedRate(SQLiteConnection context){}
        
        private static void SeedSetting(SQLiteConnection context){}
        
        private static void SeedTag(SQLiteConnection context){}
        
        private static void SeedUser(SQLiteConnection context){}
        
        private static void SeedUserSettings(SQLiteConnection context){}
        
    }
}

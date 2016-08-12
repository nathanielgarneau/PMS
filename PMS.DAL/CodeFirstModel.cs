using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.DAL
{
    public class CodeFirstModel : System.Data.Entity.DbContext
    {
        public CodeFirstModel()
            : base("name=CodeFirstModel")
        {
            Database.SetInitializer<CodeFirstModel>(null);
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<MicroQCCodeFirstModel, Migrations.Configuration>());
            //Configuration.LazyLoadingEnabled = false;
        }

        private DbSet<Xam.DAL.Model.Address> Address { get; set; }
        private DbSet<Xam.DAL.Model.City> City { get; set; }
         private DbSet<Xam.DAL.Model.Client> Client { get; set; }
         private DbSet<Xam.DAL.Model.Colour> Colour { get; set; }
         private DbSet<Xam.DAL.Model.Condition> Condition { get; set; }
         private DbSet<Xam.DAL.Model.Country> Country { get; set; }
         private DbSet<Xam.DAL.Model.Facility> Facility { get; set; }
         private DbSet<Xam.DAL.Model.IdentificationType> IdentificationType { get; set; }
         private DbSet<Xam.DAL.Model.Location> Location { get; set; }
         private DbSet<Xam.DAL.Model.Note> Note { get; set; }
         private DbSet<Xam.DAL.Model.Pawn> Pawn { get; set; }
         private DbSet<Xam.DAL.Model.Payment> Payment { get; set; }
         private DbSet<Xam.DAL.Model.PaymentType> PaymentType { get; set; }
         private DbSet<Xam.DAL.Model.Product> Product { get; set; }
         private DbSet<Xam.DAL.Model.ProductType> ProductType { get; set; }
         private DbSet<Xam.DAL.Model.Province> Province { get; set; }
         private DbSet<Xam.DAL.Model.Purchase> Purchase { get; set; }
         private DbSet<Xam.DAL.Model.Rate> Rate { get; set; }
         private DbSet<Xam.DAL.Model.Setting> Setting { get; set; }
         private DbSet<Xam.DAL.Model.Tag> Tag { get; set; }
         private DbSet<Xam.DAL.Model.User> User { get; set; }
         private DbSet<Xam.DAL.Model.UserSettings> UserSettings { get; set; }



    }
}

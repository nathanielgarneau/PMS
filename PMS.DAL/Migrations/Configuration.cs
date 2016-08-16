using System.Collections.Generic;
using PMS.DAL.Interfaces;
using PMS.Xam.DAL.Model;

namespace PMS.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PMS.DAL.CodeFirstModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        private void ProcessSeeds(List<ISeed> seeds,PMS.DAL.CodeFirstModel context )
        {
             foreach (var seed in ReferenceTypedSeeds)
            {
                try
                {
                    seed.Seed(context);
                }
                catch (NotImplementedException exception)
                {
                    //Log this seed method not implemented.
                }
            }
        }

        protected override void Seed(PMS.DAL.CodeFirstModel context)
        {
            //  This method will be called after migrating to the latest version.
            ProcessSeeds(ReferenceTypedSeeds, context);
            ProcessSeeds(TransactionalSeeds, context);
        }

        private readonly List<ISeed> ReferenceTypedSeeds = new List<ISeed>()
        {
         //This order is important as some types have dependancies.  
            new Colour() as ISeed,
            new Condition() as ISeed,
            new Note() as ISeed,
            new IdentificationType() as ISeed,
            new PaymentType() as ISeed,
            new ProductType() as ISeed,
            new Country() as ISeed,
            new Rate() as ISeed,
            new Setting() as ISeed,
            new Tag() as ISeed,
            new User() as ISeed,
            
            new UserSetting() as ISeed,//Requires User
            new Province() as ISeed,//Requires Country
            new City() as ISeed, //Requires Province
            new Address() as ISeed, //Requires Country, Province,City
            new Facility() as ISeed,//Requires Address
            new Client() as ISeed,//Requires Address and IdentificationType
            new Location() as ISeed//Requires Facility
          
        }; 

   
       

        private readonly List<ISeed> TransactionalSeeds = new List<ISeed>()
        {
            new Payment() as ISeed,
            new Pawn() as ISeed,
            new Product() as ISeed,
            new Purchase() as ISeed
        };
     
    
    }
}

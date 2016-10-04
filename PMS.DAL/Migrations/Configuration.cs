using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using PMS.DAL.Interfaces;
using PMS.DAL.Seeds;

namespace PMS.DAL.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirstModel>
    {
        private readonly List<ISeed> ReferenceTypedSeeds = new List<ISeed>
        {
            //This order is important as some types have dependancies.  
            new Colour(),
            new Condition(),
            new Note(),
            new IdentificationType(),
            new PaymentType(),
            new ProductType(),
            new Country(),
            new Rate(),
            new Setting(),
            new Tag(),
            new User(),
            new UserSetting(), //Requires User
            new Province(), //Requires Country
            new City(), //Requires Province
            new Address(), //Requires Country, Province,City
            new Facility(), //Requires Address
            new Client(), //Requires Address and IdentificationType
            new Location() //Requires Facility
        };


        private readonly List<ISeed> TransactionalSeeds = new List<ISeed>
        {
            new Payment(),
            new Pawn(),
            new Product(),
            new Purchase()
        };

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        private void ProcessSeeds(List<ISeed> seeds, CodeFirstModel context)
        {
            foreach (var seed in ReferenceTypedSeeds)
            {
                try
                {
                    seed?.Seed(context);
                    context.SaveChanges();
                }
                catch (NotImplementedException exception)
                {
                    //Log this seed method not implemented.
                }
            }
        }

        protected override void Seed(CodeFirstModel context)
        {
            //  This method will be called after migrating to the latest version.
            ProcessSeeds(ReferenceTypedSeeds, context);
            //ProcessSeeds(TransactionalSeeds, context);
        }
    }
}
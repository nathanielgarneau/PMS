using System.Collections.Generic;
using System.Data.Entity.Migrations;
using PMS.DAL.Interfaces;

namespace PMS.DAL.Seeds
{
    public class ProductType : ISeed
    {
        private readonly List<string> ProductTypes = new List<string>
        {
            "Phones",
            "Tires",
            "Laptops",
            "Desktop Computers",
            "Tablets",
            "Cars",
            "Trucks",
            "SUVs",
            "Saws",
            "Drills",
            "Welders",
            "Generators",
            "Jewelry",
            "Electronics",
            "Home Theater",
            "Instruments"
        };

        public void Seed(CodeFirstModel context)
        {
            context.ProductType.AddOrUpdate(x => x.Name,
                GetPaymentTypes()
                );
        }

        private Xam.DAL.Model.ProductType[] GetPaymentTypes()
        {
            var productTypes = new List<Xam.DAL.Model.ProductType>();
            foreach (var name in ProductTypes)
            {
                var productType = new Xam.DAL.Model.ProductType
                {
                    Name = name
                };
                productTypes.Add(productType);
            }

            return productTypes.ToArray();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using PMS.DAL.Interfaces;
using PMS.Xam.Model.Interfaces;

namespace  PMS.DAL.Seeds
{
    public class ProductType :ISeed{
        public void Seed(CodeFirstModel context)
        {
            context.ProductType.AddOrUpdate(x => x.Name,
                GetPaymentTypes()
                );   
        }

        private Xam.DAL.Model.ProductType[] GetPaymentTypes()
        {
            var productTypes = new List<PMS.Xam.DAL.Model.ProductType>();
            foreach (var name in ProductTypes)
            {
                var productType = new PMS.Xam.DAL.Model.ProductType()
                {
                    Name = name
                };
                productTypes.Add(productType);
            }

            return productTypes.ToArray();
        }


        private readonly List<string> ProductTypes = new List<string>()
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
    }
}
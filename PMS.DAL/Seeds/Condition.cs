using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using PMS.DAL.Interfaces;
using PMS.Xam.Model.Interfaces;

namespace  PMS.DAL.Seeds
{
    public class Condition:ISeed
    {  public void Seed(CodeFirstModel context)
        {
               context.Condition.AddOrUpdate(x => x.Name,
                GetConditions()
                );  
        }
           private PMS.Xam.DAL.Model.Condition[] GetConditions( )
        {
            var conditions = new List<PMS.Xam.DAL.Model.Condition>();
            foreach (var name in Conditions)
            {
                var condition = new PMS.Xam.DAL.Model.Condition()
                {
                    Name = name
                };
                conditions.Add(condition);
            }
             foreach (var name in VisualConditions)
            {
                var condition = new PMS.Xam.DAL.Model.Condition()
                {
                    Name = name
                };
                conditions.Add(condition);
            }
            return conditions.ToArray();
        }

        private readonly List<string> Conditions = new List<string>()
        {
            "New",
            "Manufacturer refurbished",
            "Seller refurbished",
            "Used",
            "For parts or not working",
            "New with tags",
            "New without tags",
            "New with defects",
            "Pre-owned",
            "New with box",
            "New without box",
            "Brand New",
            "Like New",
            "Very Good",
            "Good",
            "Acceptable",
            "Remanufactured",
            "Rebuilt",
            "Retread",
            "Damaged",
            "Certified pre-owned"
        };

        private readonly List<string> VisualConditions = new List<string>()
        {
            "Dented",
            "Scratched",
            "Marked",
            "Painted"
        };

    }
}
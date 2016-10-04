using System.Collections.Generic;
using System.Data.Entity.Migrations;
using PMS.DAL.Interfaces;

namespace PMS.DAL.Seeds
{
    public class Country : ISeed
    {
        public void Seed(CodeFirstModel context)
        {
            context.Country.AddOrUpdate(
                x => x.Name,
                GetCountries()
                );
        }

        private Xam.DAL.Model.Country[] GetCountries()
        {
            var cities = new List<Xam.DAL.Model.Country>();
            var city = new Xam.DAL.Model.Country
            {
                Name = "Canada"
            };
            cities.Add(city);
            return cities.ToArray();
        }
    }
}
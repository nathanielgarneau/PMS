using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using PMS.DAL.Interfaces;

namespace PMS.DAL.Seeds
{
    public class Province : ISeed
    {
        private readonly Dictionary<string, object> CanadianProvinces = new Dictionary<string, object>
        {
            {"Alberta", new[] {"Canada", "AB"}},
            {"British Columbia", new[] {"Canada", "BC"}},
            {"Manitoba", new[] {"Canada", "MB"}},
            {"New Brunswick", new[] {"Canada", "NB"}},
            {"Newfoundland and Labrador", new[] {"Canada", "NL"}},
            {"Nova Scotia", new[] {"Canada", "NS"}},
            {"Ontario", new[] {"Canada", "ON"}},
            {"Prince Edward Island", new[] {"Canada", "PE"}},
            {"Quebec", new[] {"Canada", "QC"}},
            {"Saskatchewan", new[] {"Canada", "SK"}},
            {"Northwest Territories", new[] {"Canada", "NT"}},
            {"Nunavut", new[] {"Canada", "NU"}},
            {"Yukon", new[] {"Canada", "YT"}}
        };

        public void Seed(CodeFirstModel context)
        {
            context.Province.AddOrUpdate(
                x => x.Name,
                GetProvinces(context)
                );
        }

        private Xam.DAL.Model.Province[] GetProvinces(CodeFirstModel context)
        {
            var cities = new List<Xam.DAL.Model.Province>();
            foreach (var kvp in CanadianProvinces)
            {
                var countryName = ((object[]) kvp.Value)[0].ToString();
                var abbreviation = ((object[]) kvp.Value)[1].ToString();
                var city = new Xam.DAL.Model.Province
                {
                    Name = kvp.Key,
                    Country = context.Country.First(x => x.Name == countryName),
                    Abbreviation = abbreviation
                };
                cities.Add(city);
            }

            return cities.ToArray();
        }
    }
}
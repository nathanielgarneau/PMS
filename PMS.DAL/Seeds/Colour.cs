using System.Collections.Generic;
using System.Data.Entity.Migrations;
using PMS.DAL.Interfaces;

namespace PMS.DAL.Seeds
{
    public class Colour : ISeed
    {
        private readonly Dictionary<string, string> Colours = new Dictionary<string, string>
        {
            {"White", "#FFFFFF"},
            {"Silver", "#C0C0C0"},
            {"Gray", "#808080"},
            {"Black", "#000000"},
            {"Red", "#FF0000"},
            {"Maroon", "#800000"},
            {"Yellow", "#FFFF00"},
            {"Olive", "#808000"},
            {"Lime", "#00FF00"},
            {"Green", "#008000"},
            {"Aqua", "#00FFFF"},
            {"Teal", "#008080"},
            {"Blue", "#0000FF"},
            {"Navy", "#000080"},
            {"Fuchsia", "#FF00FF"},
            {"Purple", "#800080"}
        };

        public void Seed(CodeFirstModel context)
        {
            context.Colour.AddOrUpdate(x => x.Name,
                GetColours()
                );
        }

        private Xam.DAL.Model.Colour[] GetColours()
        {
            var cities = new List<Xam.DAL.Model.Colour>();
            foreach (var kvp in Colours)
            {
                var city = new Xam.DAL.Model.Colour
                {
                    Name = kvp.Key,
                    Code = kvp.Value
                };
                cities.Add(city);
            }

            return cities.ToArray();
        }
    }
}
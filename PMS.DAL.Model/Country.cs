using PMS.DAL.Model.Interfaces;

namespace PMS.DAL.Model
{
    public class Country:IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
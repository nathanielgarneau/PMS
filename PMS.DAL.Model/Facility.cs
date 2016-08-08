using PMS.DAL.Model.Interfaces;

namespace PMS.DAL.Model
{
    public class Facility:IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
    }
}
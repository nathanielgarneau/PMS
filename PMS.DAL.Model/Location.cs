using PMS.DAL.Model.Interfaces;

namespace PMS.DAL.Model
{
    public class Location:IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Facility Facility { get; set; }
    }
}
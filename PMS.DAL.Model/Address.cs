using PMS.DAL.Model.Interfaces;

namespace PMS.DAL.Model
{
    public class Address:IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public City City { get; set; }
        public Province Province { get; set; }
        public string PostalCode { get; set; }
        public Country Country { get; set; }
    }
}
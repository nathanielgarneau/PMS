using PMS.DAL.Model.Interfaces;

namespace PMS.DAL.Model
{
    public class Rate:IEntity<int>
    {
        public int Id { get; set; }
        public string Name;
        public double Value;

    }
}
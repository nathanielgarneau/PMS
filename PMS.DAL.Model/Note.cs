using PMS.DAL.Model.Interfaces;

namespace PMS.DAL.Model
{
    public class Note:IEntity<int>
    {
        public int Id { get; set; }
        public string Value { get; set; }
    }
}
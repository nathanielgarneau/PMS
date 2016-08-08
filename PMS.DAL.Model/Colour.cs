using PMS.DAL.Model.Interfaces;

namespace PMS.DAL.Model
{
    public class Colour:IEntity<int>
    {
         public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
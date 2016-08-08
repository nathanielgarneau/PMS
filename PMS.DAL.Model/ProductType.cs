using PMS.DAL.Model.Interfaces;

namespace PMS.DAL.Model
{
    public class ProductType:IEntity<int>
    {
         public int Id { get; set; }
        public string Name { get; set; }
    }
}
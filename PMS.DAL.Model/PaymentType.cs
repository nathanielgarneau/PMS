using PMS.DAL.Model.Interfaces;

namespace PMS.DAL.Model
{
    public class PaymentType:IEntity<int>
    {
        public int Id { get; set; }
        public int Name { get; set; }
    }
}
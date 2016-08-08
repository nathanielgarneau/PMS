using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.ViewModel
{
    public class PaymentTypeViewModel:IEntity<int>
    {
        public int Id { get; set; }
        public int Name { get; set; }
    }
}
using PMS.Xamarin.Model.Interfaces;

namespace PMS.ViewModel
{
    public class PaymentTypeViewModel:IEntity<int>
    {
        public int Id { get; set; }
        public int Name { get; set; }
    }
}
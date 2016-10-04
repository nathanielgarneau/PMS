using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.ViewModel
{
    public class PaymentTypeViewModel : IEntity<int>
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
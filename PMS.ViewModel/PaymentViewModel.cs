using System;
using PMS.Xamarin.Model.Interfaces;

namespace PMS.ViewModel
{
    public class PaymentViewModel:IEntity<int>
    {
        public int Id { get; set; }
        public double Value { get; set; }
        public DateTime Date { get; set; }
        public PaymentTypeViewModel PaymentType { get; set; }
    }
}
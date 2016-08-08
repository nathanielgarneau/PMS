using System;
using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.ViewModel
{
    public class PaymentViewModel:IEntity<int>
    {
        public int Id { get; set; }
        public double Value { get; set; }
        public DateTime Date { get; set; }
        public PaymentTypeViewModel PaymentType { get; set; }
    }
}
using System;
using PMS.DAL.Model.Interfaces;

namespace PMS.DAL.Model
{
    public class Payment:IEntity<int>
    {
        public int Id { get; set; }
        public double Value { get; set; }
        public DateTime Date { get; set; }
        public PaymentType PaymentType { get; set; }
    }
}
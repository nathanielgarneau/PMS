using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using PMS.DAL.Interfaces;
using PMS.Xam.Model.Interfaces;

namespace  PMS.DAL.Seeds
{
    public class PaymentType :ISeed{  public void Seed(CodeFirstModel context)
        {
       
               context.PaymentType.AddOrUpdate(x => x.Name,
                GetPaymentTypes()
                );  
        }

        private Xam.DAL.Model.PaymentType[] GetPaymentTypes()
        {
            var paymentTypes = new List<PMS.Xam.DAL.Model.PaymentType>();
            foreach (var name in PaymentTypes)
            {
                var paymentType = new PMS.Xam.DAL.Model.PaymentType()
                {
                    Name = name
                };
                paymentTypes.Add(paymentType);
            }

            return paymentTypes.ToArray();
        }


        private readonly List<string> PaymentTypes = new List<string>()
        {
            "Debit",
            "Credit",
            "E-transfer",
            "Paypal"
        };
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.SqlClient;
using DatabaseHelper;

namespace swen_assignment_3.Classes
{
    class PaymentDBMananger
    {
        //Create Booking
        public static bool AddPayment(Payment p)
        {
            DatabaseInsertQuery newPayment = new DatabaseInsertQuery("payment");
            newPayment.AddData("PaymentType", p.PaymentType);
            newPayment.AddData("CreditCardNumber", Convert.ToString(p.CreditCardNumber));
            newPayment.AddData("CardHolderName", p.CardHolderName);
            newPayment.AddData("ExpiryDate", Convert.ToString(p.ExpiryDate));
            newPayment.AddData("Amount", Convert.ToString(p.Amount));
            newPayment.AddData("Price", Convert.ToString(p.Price));

            if (newPayment.RunQuery())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
       

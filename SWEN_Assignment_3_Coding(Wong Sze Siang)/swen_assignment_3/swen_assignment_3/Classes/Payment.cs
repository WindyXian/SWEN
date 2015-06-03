using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swen_assignment_3.Classes
{
    class Payment
    {
        public int PaymentID { get; set; }
        public string PaymentType { get; set; }
        public int CreditCardNumber { get; set; }
        public string CardHolderName { get; set; }
        public string ExpiryDate { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }

        public Payment() { }

        public Payment(int PaymentID, string PaymentType, int CreditCardNumber, string CardHolderName, string ExpiryDate, int Amount, int Price)
        {
            this.PaymentID = PaymentID;
            this.PaymentType = PaymentType;
            this.CreditCardNumber = CreditCardNumber;
            this.CardHolderName = CardHolderName;
            this.ExpiryDate = ExpiryDate;
            this.Amount = Amount;
            this.Price = Price;
        }
    }
}

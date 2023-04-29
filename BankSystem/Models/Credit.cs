using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Models
{
    internal class Credit
    {
        //  ID
        public Guid ID { get; init; }

        //  Amount
        public double Amount { get; set; }

        //  Percentage
        private byte _percentage;
        public byte Percentage
        {
            get { return _percentage; }
            set
            {
                //  Percentage should be more than 0 and less than 100
                if (value > 0 && value < 100)
                {
                    _percentage = value;
                }

                //  If the condition is not met
                else
                {
                    throw new Exception("Percentage should be more than 0 and less than 100!");
                }
            }
        }

        //  Months
        private short _months;

        //  Months
        public short Months
        {
            get { return _months; }
            set 
            {
                //  Months should be positive number
                if (value > 0)
                {
                    _months = value; 
                }

                //  If the condition is not met
                else
                {
                    throw new Exception("Months should be positive number");
                }
            }
        }

        //  Payment
        private int _payment;

        public int Payment
        {
            get { return _payment; }
            set 
            {
                //  Payment should be positive number
                if (value > 0)
                {
                    _payment = value;
                }

                //  If the contion is not met
                else
                {
                    throw new Exception("Payment should be positive number");
                }
            }
        }

        //  CalculatePercent
        public int CalculatePercent()
        {
            return ((int)((Months * Payment )- Amount));
        }

        //  Pay
        public void Pay(double AmountforPay)
        {
            if (Amount != 0)
            {
                Amount -= AmountforPay;
            }
        }


    }
}

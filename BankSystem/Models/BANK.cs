using BankSystem.Models.Workers;
using MyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Models
{
    internal class BANK
    {
        //  Name
        private string _name;
        public string Name
        {
            get { return _name; }
            set 
            {
                //  Check other symbol in name
                if (MyString.CheckOnlyLettersInString(value))
                {
                    _name = value;  
                }

                //  If the contion is not met
                else
                {
                    throw new Exception("Name should be only contain letters");
                }
            }
        }


        //  Budget
        private double _budget;
        public double Budget
        {
            get { return _budget; }
            set 
            {
                //  Budget should be positive number
                if (value > 0)
                {
                    _budget = value;
                }

                //  IF the condition is not met
                else
                {
                    throw new Exception("Budget should be positive number!");
                }
            }
        }

        //  Profit
        private int _profit;
        public int Profit
        {
            get { return _profit; }
            set 
            {
                //  Profit should be positive number
                if (value > 0)
                {
                    _profit = value;
                }

                //  If the condition is not met
                else
                {
                    throw new Exception("Profit should be positive number!");
                }
            }
        }

        //  Calculate profit
        public double CalculateProfit(int year)
        {
            return _budget * 0.14 * year;
        }

        //  CEO
        public CEO Ceo { get; set; }

        //  Workers
        public Worker[] Workers { get; set; }

        //  Clients
        public Client[] Clients { get; set; }

        //  Show credit Client
        public void ShowCreditsOfClient(Client client)
        {
            foreach (var credit in client.Credits)
            {
                Console.WriteLine(credit.ToString());
            }
        }

    }
}

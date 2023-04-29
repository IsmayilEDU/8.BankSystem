using BankSystem.Models.Workers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Models
{
    internal class Client : Person
    {

        //  Constructor with parametres
        public Client(Guid id,string name, string surname, byte age, double salary, string liveAdress, string workAdress)
            : base(id, name, surname, age, salary)
        {
            LiveAdress = liveAdress;
            WorkAdress = workAdress;
        }

        //  Live adress of client
        public string LiveAdress { get; set; }

        //  Work adress of client
        public string WorkAdress { get; set; }

        //  Credits
        public List<Credit> Credits { get; set; }

        //  Add credit
        public void AddCredit(Credit credit)
        {
            Credits.Add(credit);
        }

        //  Search credit by ID
        private int IndexCreditByID(string creditID)
        {

            for (int i = 0; i < Credits.Count; i++)
            {
                if (Credits[i].ID.ToString() == creditID)
                {
                    return i;
                }
            }

            return -1;
        }

        //  Remove credit by ID
        public void RemoveCreditByID(string creditID)
        {
            int indexRemoveCredit = IndexCreditByID(creditID);

            //  if the searched post is not in the Posts
            if (indexRemoveCredit == -1)
            {
                throw new Exception("The requested credit was not found in the Credits");
            }

            //  If the condition is not met
            else
            {
                Credits.RemoveAt(indexRemoveCredit);
            }
        }

        //  Pay credit
        public void PayCredit(string creditID, double AmountPay)
        {
            int indexRemoveCredit = IndexCreditByID(creditID);

            //  if the searched post is not in the Posts
            if (indexRemoveCredit == -1)
            {
                throw new Exception("The requested credit was not found in the Credits");
            }

            //  If the condition is not met
            else
            {
                Credits[indexRemoveCredit].Pay(AmountPay);
            }
        }

    }
}

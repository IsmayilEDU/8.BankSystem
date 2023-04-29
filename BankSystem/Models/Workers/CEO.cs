using BankSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Models.Workers
{
    internal class CEO : Person, IOrganize, IControl
    {
        //  Constructor with parametres
        public CEO(Guid id, string name, string surname, byte age, double salary)
            :base(id,name,surname, age, salary) { }

        //  Implement IOrganize
        public void Control()
        {
            Console.WriteLine("COntrol");
        }

        //  Implement IControl
        public void Organize()
        {
            Console.WriteLine("Organize");
        }
    }
}

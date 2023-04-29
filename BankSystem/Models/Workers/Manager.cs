using BankSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Models.Workers
{
    internal class Manager : Person, IOrganize
    {
        //  Calculate salaries
        public double CalculateSalaries(List<Worker> workers)
        {
            double totalSalaries = 0;
            foreach (Worker worker in workers)
            {
                totalSalaries += worker.Salary;
            }
            return totalSalaries;
        }

        //  Organize
        public void Organize()
        {
            Console.WriteLine("Organize");
        }

        //  Constructor with parametres
        public Manager(Guid id, string name, string surname, byte age, double salary)
        :base(id, name,surname, age, salary){ }
    }
}

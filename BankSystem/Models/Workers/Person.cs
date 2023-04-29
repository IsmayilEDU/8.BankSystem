using MyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Models.Workers
{
    internal abstract class Person
    {
        //  ID
        public Guid ID { get; init; }

        //  Name
        private string __name;
        public string Name 
        { 
            get { return __name; }
            set
            {
                //  Check other symbol in name
                if (MyString.CheckOnlyLettersInString(value))
                {
                    __name= value;
                }

                //  If the condition is not met
                else
                {
                    throw new Exception("Name contain only letters!");
                }
            }
        }

        //  Surname
        private string __surname;
        public string Surname 
        {
            get { return __surname; }
            set
            {
                //  Check other symbol in Surname
                if (MyString.CheckOnlyLettersInString(value))
                {
                    __surname = value;
                }

                //  If the condition is not met
                else
                {
                    throw new Exception("Surname contain only letters!");
                }
            }
        }

        //  Age
        private byte __age;
        public byte Age 
        {
            get{  return __age; }
            set
            {
                //  Age should be MIN 18
                if (value >= 18)
                {
                    __age = value;
                }

                //  If the condition is not met
                else
                {
                    throw new Exception("Age should be MIN 18!");
                }
            }
        }

        //  Salary
        private double __salary;
        public double Salary 
        { 
            get { return __salary; }
            set
            {
                //  Salary should be positive number
                if (value > 0)
                {
                    __salary = value;
                }

                //  If the condition is not met
                else
                {
                    throw new Exception("Salary should be positive number");
                }
            }
        }

        //  Constructor with parametres
        protected Person(Guid iD, string name,string surname, byte age, double salary)
        {
            ID = iD;
            Name = name;
            Surname = surname;
            Age = age;
            Salary = salary;
        }

        //  ToString 
        public override string ToString()
        {
            return $"ID: {ID}\nName: {Name}\nSurname: {Surname}\nAge: {Age}\nSalary: {Salary}\n";
        }
    }
}

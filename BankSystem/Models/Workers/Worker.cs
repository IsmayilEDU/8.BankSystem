using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Models.Workers
{
    internal class Worker : Person
    {
        //  Time of start to work
        private DateOnly _startTime;
        public DateOnly StartTime 
        {
            get { return _startTime; }
            set
            {
                //  Check startTime less than endTime
                if (_startTime < _endTime)
                {
                    _startTime = value;
                }

                //  If the condition is not met
                else
                {
                    //throw new Exception("Start time should be less than end time!");
                }
            }
        }

        //  Time of end to work
        private DateOnly _endTime;
        public DateOnly EndTime 
        { 
            get { return _endTime; }
            set
            {
                //  Check startTime less than endTime
                if (_startTime < value)
                {
                    _endTime = value;
                }

                //  If the condition is not met
                else
                {
                    throw new Exception("Start time should be less than end time!");
                }
            }
        }

        //  Operations
        public List<Operation> Operations { get; set; }

        //  Add operation to list (operations)
        public void AddOperation(Operation operation)
        {
            Operations.Add(operation);
        }

        //  Constructor with parametres
        public Worker(Guid iD, string name, string surname, byte age, double salary, DateOnly startTime, DateOnly endTime, List<Operation> operations)
            :base(iD,name, surname, age, salary) 
        {
            StartTime = startTime;
            EndTime = endTime;
            Operations = operations;
        }

        //  ToString
        public override string ToString()
        {
            string info = base.ToString() + $"Start time: {StartTime}\nEnd time: {EndTime}\n";
            string operations = "\n";
            foreach (var operation in Operations)
            {
                operations+= operation.ToString();
            }
            info += operations ;
            return info;
        }

    }
}

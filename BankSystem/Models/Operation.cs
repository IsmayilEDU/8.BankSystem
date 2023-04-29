using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Models
{
    internal class Operation
    {
        //  Constructor with parametres
        public Operation(Guid iD, string nameProcess, DateTime creationTime)
        {
            ID = iD;
            NameProcess = nameProcess;
            CreationTime = creationTime;
        }

        //  ID
        public Guid ID { get; init; }

        //  Name of Process
        public string NameProcess { get; init; }

        //  Creation Time
        public DateTime CreationTime { get; init; }

        //  ToString
        public override string ToString()
        {
            return $"Operation info:\nID: {ID}\nName of process: {NameProcess}\nCreation time: {CreationTime}\n\n";
        }
    }
}

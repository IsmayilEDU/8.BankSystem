using BankSystem.Models;
using BankSystem.Models.Workers;
using MyLibrary;
namespace BankSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operation op1 = new Operation(Guid.NewGuid(), "kredit1", DateTime.Now);
            Operation op2 = new Operation(Guid.NewGuid(), "kredit2", DateTime.Now);
            Operation op3 = new Operation(Guid.NewGuid(), "kredit3", DateTime.Now);

            List<Operation> operations = new List<Operation>()
            { op1, op2, op3 };

            Worker w1 = new Worker(Guid.NewGuid(),"Ismayil", "Kerimzade", 19, 2000, new DateOnly(2018,5,16),new DateOnly(2022,5,16),operations);
            Console.WriteLine(w1.ToString());
        }
    }
}
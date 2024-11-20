using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 library = new Class1();
            library.PrintMessage("Hello My NIGGERS!");
            library.AddAndPrint(89, 52);
            Console.WriteLine($"Сумма 78 + 23 = {library.AddIntegers(78, 23)}");
            Console.WriteLine($"Среднее 100 и 50: {library.CalculateAverage(100, 50)}");
            Console.WriteLine(library.GetGreeting("Maksimen"));
        }
    }
}

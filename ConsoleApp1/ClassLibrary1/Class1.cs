using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        // Методы с типом void
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void AddAndPrint(int a, int b)
        {
            Console.WriteLine($"Сумма {a} + {b} = {a + b}");
        }

        // Методы с возвращаемыми значениями
        public int AddIntegers(int a, int b)
        {
            return a + b;
        }

        public double CalculateAverage(double a, double b)
        {
            return (a + b) / 2;
        }

        public string GetGreeting(string name)
        {
            return $"Привет, {name}!";
        }
    }
}


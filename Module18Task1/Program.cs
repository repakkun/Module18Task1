using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine("Введите два числа");
            calculator.Addition(Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()));
            Console.ReadKey();
        }
        public interface ICalculator
        {
            void Addition(int a, int b);
        }
        public class Calculator : ICalculator
        {           
            public void Addition(int a, int b)
            {
                Console.WriteLine($"Сумма равна {a + b}");
            }            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            CalCulator sq = new CalCulator();
            Console.WriteLine(sq.Square(8).ToString());
            Console.WriteLine(sq.Add(8.3, 9.24).ToString());
            Console.WriteLine(sq.Multiply(5, 8).ToString());
            Console.WriteLine(sq.Subtract(22, 42).ToString());
            Console.ReadLine(); 
        }
    }
}

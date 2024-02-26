using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1EX6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digíte um número.");
            int x;
            x= int.Parse(Console.ReadLine());

            if (x == (x/4)*4)
            {
                Console.WriteLine("O número é divisível por 4.");
            }
            else Console.WriteLine("O número não é divisível por 4.");
        }
    }
}

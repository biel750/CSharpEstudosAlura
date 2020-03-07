using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcula Pouança");

            double valorInvestido = 1000;
            int i = 1;

            while (i <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após " + i + " mês, você terá R$" + valorInvestido);
                i++;
            }





            












            Console.ReadLine();
        }
    }
}

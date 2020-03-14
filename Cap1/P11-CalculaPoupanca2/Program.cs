using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 11");

            double valorInvestido = 1000;

            for (int i = 1; i <= 12; i++)
            {
                valorInvestido *= 1.0036;
                Console.WriteLine("Após " + i + " mês, você terá R$" + valorInvestido);






            }

            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_12CalculaInvestimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Executando o projeto 12");

            double fatorRendimento = 1.0036;
            double valorInvestido = 1000;


            for (int i = 1; i <= 5; i++)
            {
                for (int k = 1; k <= 12; k++)
                {
                    valorInvestido *= fatorRendimento;
                    Console.WriteLine("k" +k);
                }
                fatorRendimento += 0.0010;
                Console.WriteLine("i" +i);
            }

            Console.WriteLine("Ao término do investimento você terá R$" + valorInvestido);



















            Console.Read();
        }
    }
}

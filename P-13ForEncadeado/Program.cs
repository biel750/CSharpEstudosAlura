using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_13ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 13");

            for (int i = 0; i < 10; i++)
            {
                
                for (int k = 0; k < 10; k++)
                {
                    Console.Write("*");
                    if (k >= i)
                    {
                        break;
                    }
                }
                Console.WriteLine();
            }


















            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exxecutando o projeto 7");

            int idadeJoao = 16;
            int qntPessoas = 2;

            if (idadeJoao > 18)
            {
                Console.WriteLine("Oi joao");

            }
            else
            {
                if (qntPessoas >= 2)
                {
                    Console.WriteLine("Joao pode entrar");
                }
                else
                {
                    Console.WriteLine("AAAAAAA");
                }


            }









            Console.Read();
        }
    }
}

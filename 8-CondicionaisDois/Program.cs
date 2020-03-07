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
            Console.WriteLine("Exxecutando o projeto 8");

            int idadeJoao = 16;
            int qntPessoas = 2;

            bool acompanhado = qntPessoas >= 2;

            if (idadeJoao > 18 || acompanhado)
            {
                Console.WriteLine("Oi joao vc pode entrar");

            }
            else
            {
                Console.WriteLine("joao nao pode entrar");

            }









            Console.Read();
        }
    }
}

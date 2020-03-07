using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario;
            salario = 1200.50;

            // O int é uma variavel de 32 bits
            int salarioInteiro;
            salarioInteiro = (int)salario;

            Console.WriteLine(salarioInteiro);

            // O short é uma variavel de 16 bits
            short idade;
            idade = 13;

            // O Long é uma variavel de 64 bits
            long idadeUniverso = 130000000000000;

            // A variavel float preciso do f no final
            float altura = 1.80f;



            Console.Read();
        }
    }
}

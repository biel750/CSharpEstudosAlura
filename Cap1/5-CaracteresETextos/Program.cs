using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5");

            char primeiraletra = 'a';
            Console.WriteLine(primeiraletra);

            primeiraletra = (char)65;
            Console.WriteLine(primeiraletra);

            primeiraletra = (char)(primeiraletra + 1);
            Console.WriteLine(primeiraletra);

            string titulo = "Gabriel Totino" + 2048;
            Console.WriteLine(titulo);

            /*Não é permitido ter um char vazio
            mas é permitido ter uma string vazia*/

            string[] lista = { "fiap, judo, marketing" };
            foreach(string nome in lista)
            {
                Console.WriteLine(nome);
            }




            Console.Read();
        }
    }
}

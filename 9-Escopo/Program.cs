using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exxecutando o projeto 9");

            int idadeJoao = 19;

            bool acompanhado = true;
            string mensagemAdicional = "";

            if (acompanhado)
            {
                mensagemAdicional = "Joao está acompanhado";

            }
            else
            {
                mensagemAdicional = "Joao não está acompanhado";
            }



            if (idadeJoao > 18 || acompanhado)
            {
                Console.WriteLine("Oi joao vc pode entrar");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("joao nao pode entrar");

            }









            Console.Read();



        }
    }
}

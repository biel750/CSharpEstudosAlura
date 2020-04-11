using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Metodo();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Não é possível divisão por zero");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("Aconteceu um erro !");
            }

            Console.ReadLine();
        }

        static void Metodo()
        {
            try
            {
                TestaDivisao(0);
            }
            catch (NullReferenceException excecao)
            {
                Console.WriteLine(excecao.Message);
                Console.WriteLine(excecao.StackTrace);
            }


        }

        static void TestaDivisao(int divisor)
        {
                int resultado = Dividir(10, divisor);
                Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
        }

        static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exceção com número = " + numero + " e divisor = " + divisor);
                throw;
            }            
            
        }



    }
}   

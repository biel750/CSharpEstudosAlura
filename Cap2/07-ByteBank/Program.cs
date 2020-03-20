using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);



            ContaCorrente conta = new ContaCorrente(86712540,878);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);



            
            Console.WriteLine(conta.Numero);
            Console.WriteLine(conta.Agencia);

            ContaCorrente contaDaGabriela = new ContaCorrente(86712540, 878);

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);




            Console.Read();
        }
    }
}

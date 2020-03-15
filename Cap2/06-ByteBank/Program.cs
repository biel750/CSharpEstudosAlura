using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();
            cliente.Nome = "Guilherme";
            cliente.CPF = "481.913.388-82";
            cliente.Profissao = "Desenvolvedor";


            conta.Saldo = -50;
            conta.Titular = cliente;

            Console.WriteLine(conta.Saldo);
            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine("CPF = " + conta.Titular.CPF);

            //
            Console.Read();
        
        
        }
    }
}

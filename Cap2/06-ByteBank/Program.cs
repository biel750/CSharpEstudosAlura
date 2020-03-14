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
            cliente.nome = "Guilherme";
            cliente.cpf = "481.913.388-82";
            cliente.profissao = "Desenvolvedor";


            conta.Saldo = 50;
            conta.Titular = cliente;

            Console.WriteLine(conta.Saldo);
            Console.WriteLine(conta.Titular.nome);


            Console.Read();
        }
    }
}

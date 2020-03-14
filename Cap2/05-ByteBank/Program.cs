using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente gabriela = new Cliente();

            //gabriela.nome = "Gabriela";
            //gabriela.profissao = "Desenvolvedora";
            //gabriela.cpf = "481.913.388-82";

            ContaCorrente conta = new ContaCorrente();

            //conta.titular = gabriela;
            conta.titular = new Cliente();
            conta.titular.nome = "Joaquim";
            conta.titular.cpf = "481.913.388-82";
            conta.titular.profissao = "Desenvolvedor";

            // caso eu tire a linha do conta.titular = new
            // o conta.titular será == null
            // caso eu tente iniciar o nome, caira na exceção de objeto null, pois conta.titular é null
            



            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 563427;

            

            //se eu mudar o nome pelo objeto conta reflete no objeto gabriela

            //Console.WriteLine(conta.titular.nome);



            Console.ReadLine();
        }
    }
}

using ByteBank.Funcionarios;
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
            Funcionario carlos = new Funcionario();

            carlos.Nome = "Carlos";
            carlos.CPF = "481.913.38-82";
            carlos.Salario = 2000;

            Diretor roberta = new Diretor();
            roberta.Nome = "Roberta";
            roberta.CPF = "123.321.654-99";
            roberta.Salario = 5000;

            

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());
             
            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());


            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
            gerenciador.Registrar(carlos);
            gerenciador.Registrar(roberta);

            Console.WriteLine("Total de bonificações: R$" + gerenciador.GetTotalBonificacao());
            


             
            Console.Read();
        }
    }
}

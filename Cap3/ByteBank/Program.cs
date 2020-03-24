using ByteBank.Funcionarios;
using ByteBank.Sistemas;
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
            //CalcularBonificacao();

            UsarSistema();

            Console.Read();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("111.111.111-11");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("481.913.388-82");
            camila.Nome = "Camila";
            camila.Senha = "abc";

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "abc");


        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Designer pedro = new Designer("481.913.388-82");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("111.111.111-11");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("033.950.828-06");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("481.913.388-82");
            camila.Nome = "Camila";

            Desenvolvedor gabriel = new Desenvolvedor("481.913.388-82");
            gabriel.Nome = "Gabriel";

            gerenciador.Registrar(pedro);
            gerenciador.Registrar(roberta);
            gerenciador.Registrar(igor);
            gerenciador.Registrar(camila);
            gerenciador.Registrar(gabriel);

            Console.WriteLine("Total de bonificações do mês R$ " + gerenciador.GetTotalBonificacao());












        }



    }
}

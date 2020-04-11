using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    // primeiro a classe depois a interface
    public class Diretor : FuncionarioAutenticavel
    {
        
        

        //toda vez que eu chamo um diretor da classe derivada
        //automaticamente chama o construtor da classe base
        //primeiro executa o construtor da classe base
        public Diretor(string cpf) : base(5000,cpf)
        {
            Console.WriteLine("Criando DIRETOR");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        //override é usado para sobreescrever o metodo 
        //(necessário usar virtual no metodo que vai ser sobreescrito)
        public override double GetBonificacao()
        {
            //base é usado para referenciar a classe base (Funcionario)
            return this.Salario * 0.5;
        }

    




    }
}

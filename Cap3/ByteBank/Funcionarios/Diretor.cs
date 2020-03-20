using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : Funcionario
    {
        

        //override é usado para sobreescrever o metodo 
        //(necessário usar virtual no metodo que vai ser sobreescrito)
        public override double GetBonificacao()
        {
            //base é usado para referenciar a classe base (Funcionario)
            return this.Salario + base.GetBonificacao();
        }






    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
       //as propriedades tambem podem ser sobreescritas
       //Os gets e sets podem ser diferentes nas classes derivadas
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        
        //virtual para indicar que o metodo vai ser sobreescrito
        public virtual double GetBonificacao()
        {
            return this.Salario * 0.1;
        }






    }
}

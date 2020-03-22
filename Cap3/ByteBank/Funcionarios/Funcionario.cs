using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        //static pra mostrar que é exclusivo da classe 
        public static int TotalDeFuncionarios { get; private set; }
       //as propriedades tambem podem ser sobreescritas
       //Os gets e sets podem ser diferentes nas classes derivadas
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }
        //protected pode ser usado na classe base e nas derivadas
        public Funcionario(double salario, string cpf)
        {
            CPF = cpf;
            Salario = salario;
            Console.WriteLine("Criando FUNCIONARIO");
            TotalDeFuncionarios++;
        }
        //abstract pra mostrar que o metodo obrigatoriamente 
        //vai ser sobreescrito (obrigatoriamente tem que ser sobreescrito)
        //nas classes derivadas
        public abstract void AumentarSalario();


        //virtual para indicar que o metodo vai ser sobreescrito
        public abstract double GetBonificacao();
      






    }
}

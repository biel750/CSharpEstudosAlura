using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistemas
{
    public abstract class Autenticavel : Funcionario
    {
        public string Senha { get; set; }

        //por mais que seja abstrata tem que preecher os parametros da classe base
        public Autenticavel(double salario, string cpf) : base(salario,cpf)
        {
            //construtor
        }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }




    }
}

using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistemas
{
    public interface Autenticavel
    {

        //em uma interface todos os membros são publicos
         bool Autenticar(string senha);
        




    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string cpf) : base(1000, cpf)
        {
            Console.WriteLine("Criando DESENVOLVEDOR");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        public override double GetBonificacao()
        {
            return Salario *= 0.1;
        }

    }
}

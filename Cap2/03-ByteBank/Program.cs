﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;

            Console.WriteLine("igualdade de tipo de referência: " + (contaDaGabriela == contaDaGabrielaCosta));

            int idade = 27, idade2 = 27;

            Console.WriteLine("Igualdade de tipo de valor: " + (idade == idade2));

            contaDaGabriela = contaDaGabrielaCosta;

            Console.WriteLine(contaDaGabriela == contaDaGabrielaCosta);

            contaDaGabriela.saldo = 300;
            Console.WriteLine(contaDaGabriela.saldo);
            Console.Write(contaDaGabrielaCosta.saldo);

             






            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
class Program
{
    static void Main(string[] args)
    {
        ContaCorrente contaDoBruno = new ContaCorrente();

        contaDoBruno.titular = "Bruno";

        Console.WriteLine("Antes do saque R$" + contaDoBruno.saldo);

        bool resultadoSaque = contaDoBruno.Sacar(50);

        Console.WriteLine("Depois do saque R$"+contaDoBruno.saldo);

        contaDoBruno.Depositar(500);
        Console.WriteLine("Após o deposito de 500 R$"+contaDoBruno.saldo);

        ContaCorrente contaDaGabriela = new ContaCorrente();
        contaDaGabriela.titular = "Gabriela";

        contaDoBruno.Transferir(200, contaDaGabriela);

        Console.WriteLine("Saldo da Gabriela R$"+contaDaGabriela.saldo);
        Console.WriteLine("Saldo do Bruno R$"+contaDoBruno.saldo);

        Console.Read();
    }
}
}

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
            Console.WriteLine(contaDoBruno.saldo);
            contaDoBruno.titular = "Bruno";
            contaDoBruno.Sacar(50);

            contaDoBruno.Depositar(500);
            Console.WriteLine(contaDoBruno.saldo);
            Console.ReadLine();

            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDoBruno.Transferir(200, contaDaGabriela);

            Console.WriteLine("Saldo Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("saldo Gabi :" + contaDaGabriela.saldo);
            Console.ReadLine();
        }
    }
}

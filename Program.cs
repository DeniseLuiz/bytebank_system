using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //tipo        nome              atribuição
            ContaCorrente ContaDaGabriela = new ContaCorrente();
            ContaDaGabriela.titular = "Gabriela";
            ContaDaGabriela.agencia = 863;
            ContaDaGabriela.conta = 863452;
            ContaDaGabriela.saldo = 100;
            Console.WriteLine(ContaDaGabriela.titular);
            Console.WriteLine(ContaDaGabriela.agencia); 
            Console.WriteLine(ContaDaGabriela.conta); 
            Console.WriteLine(ContaDaGabriela.saldo + 200);
            Console.ReadLine();
        }
    }
}

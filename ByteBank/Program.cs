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
            ContaCorrente conta = new ContaCorrente(7564, 98594);
            Console.WriteLine("taxa de operação " + ContaCorrente.TaxaDeoperacao);
            Console.ReadLine();
        }
    }
}
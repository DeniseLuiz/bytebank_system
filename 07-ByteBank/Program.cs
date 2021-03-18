using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(8712, 867);
            Console.WriteLine(conta.Agencia);

            conta.Agencia = -10;
            Console.WriteLine(conta.Agencia);
            Console.WriteLine(ContaCorrente.totalDeContasCriadas);
            Console.ReadLine();
        }
    }
}

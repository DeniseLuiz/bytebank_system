using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.Saldo = -10;
            Console.WriteLine(conta.Saldo);
            Console.ReadLine();

            Cliente cliente = new Cliente();
            cliente.Nome = "Guilherme";
            cliente.CPF = "123.345.456.56";
            cliente.Profissao = "Dev";

            conta.Titular = cliente;
            Console.WriteLine(conta.Titular.Nome);
            Console.ReadLine();
        }
    }
}

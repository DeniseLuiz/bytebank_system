using System;
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

            ContaCorrente ContaDaGabriela = new ContaCorrente();
            ContaDaGabriela.titular = "Gabriela";
            ContaDaGabriela.agencia = 863;
            ContaDaGabriela.conta = 863452;
            ContaDaGabriela.saldo = 100;
            
            
            ContaCorrente ContaDaGabrielaCosta = new ContaCorrente();
            ContaDaGabrielaCosta.titular = "Gabriela";
            ContaDaGabrielaCosta.agencia = 863;
            ContaDaGabrielaCosta.conta = 863452;
            ContaDaGabrielaCosta.saldo = 100;

            Console.WriteLine(ContaDaGabrielaCosta == ContaDaGabriela); // false pois compara a referencia de memória do computador e não de igualdade
            Console.WriteLine(ContaDaGabrielaCosta.titular == ContaDaGabriela.titular); // true pois compara o valor 

            Console.ReadLine();

        }
    }
}

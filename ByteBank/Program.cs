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
            //TestarInnerExcepion();
            CarregarContas();
            Console.WriteLine("Execução finalizada! Tecle enter para sair");
            Console.ReadLine();
        }

        private static void CarregarContas()
        {
            LeitorDeArquivos leitor = new LeitorDeArquivos("contas.txt");
            leitor.LerProximaLinha();
            leitor.LerProximaLinha();
            leitor.LerProximaLinha();

            leitor.Fechar();
        }

        private static void TestarInnerExcepion()
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(7564, 98594);
                Console.WriteLine("Saldo: " + conta.Saldo);
                //conta.Sacar(-500); //Entre na OperaçãoFinanceiraException
                ContaCorrente conta2 = new ContaCorrente(12345, 5553);
                Console.WriteLine("Saldo2: " + conta2.Saldo);
                conta.Transferir(5000, conta2);
                Console.WriteLine("Saldo2: " + conta2.Saldo);
                //ContaCorrente conta = new ContaCorrente(0, 0); //entra na ArgumentException
                Console.WriteLine("taxa de operação " + ContaCorrente.TaxaDeoperacao);
            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OperacaoFinanceiraException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.InnerException.Message);
            }
        }
    }
}
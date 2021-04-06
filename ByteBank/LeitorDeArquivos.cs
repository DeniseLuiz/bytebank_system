using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class LeitorDeArquivos
    {
        public string Arquivo { get; }
        public LeitorDeArquivos(string arquivo)
        {
            Arquivo = arquivo;
        }

        public string LerProximaLinha()
        {
            Console.WriteLine("Lendo linha...");
            return "Linha do aquivo";
        }

        public void Fechar()
        {
            Console.WriteLine("Fechando arquivo.");
        }
    }
}

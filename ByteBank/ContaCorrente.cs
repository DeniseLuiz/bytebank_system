using System;

namespace ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }

        public static double TaxaDeoperacao { get; private set; }
        public static int TotalDeContasCriadas { get; private set; }


        private int _agencia;
        public int Agencia { get; }
        public int Numero { get; }

        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }


        public ContaCorrente(int agencia, int numero)
        {
       
            if(agencia <= 0 )
            {
                throw new ArgumentException("A agência deve ser maior que 0.", nameof(agencia));
                //ArgumentException -> 1º parametro = mensagem, 2º parametro = ParamName.
            }

            if(numero <= 0)
            {
                throw new ArgumentException("O número da conta deve ser maior que 0.", nameof(numero));
            }

            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
            TaxaDeoperacao = 30 / TotalDeContasCriadas;
            
        }


        public void Sacar(double valor)
        {
            if(valor < 0)
            {
                throw new ArgumentException("Valor inválido para o saque.", nameof(valor));
            }

            if (_saldo < valor)
            {
                throw new SaldoInsuficienteException(Saldo, valor);
            }
            _saldo -= valor;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }


        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para transferência.", nameof(valor));
            }

            Sacar(valor);
            contaDestino.Depositar(valor);
        }
    }
}
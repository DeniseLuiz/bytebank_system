﻿namespace _07_ByteBank
{
    public class ContaCorrente
    {
        private double _saldo = 100;
        private int _agencia;

        public Cliente Titular { get; set; }

        public int TotalDeContasCriadas { get; set; }

        public static int totalDeContasCriadas { get; set; }
        public int Agencia {
            get 
            {
                return _agencia;
            }
            set 
            {
                if(value <= 0)
                {
                    return; 
                }
                _agencia = value;
            } 
        }

        public int Numero { get; set; }

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

                _saldo = value; // o value faz referência ao saldo da classe
            }
        }
       

        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;
            TotalDeContasCriadas++;
        }

        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }

    }


}



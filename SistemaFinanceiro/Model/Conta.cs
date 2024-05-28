using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Model
{
    public class Conta
    {

        private long _numero;
        private decimal _saldo;
        public Agencia agencia;
        public Cliente titular;

        public Conta(long numero)
        {
            _numero = numero;
        }

        public Conta(long numero, decimal saldo, Agencia ag, Cliente titular)
        {

            _numero = numero;
            _saldo = saldo;
            agencia = ag;
            this.titular = titular;
        }

        public long Numero
        {
            get => _numero;
            private set
            {
                _numero = value;
            }
        }

        public decimal Saldo { get => _saldo; }

        public void Deposito(decimal valor)
        {
            if (valor > 0)
            {
                _saldo += valor;
            }
        }

        public decimal Saque(decimal valor)
        {
            if(_saldo - valor >= 0)
            {
                _saldo -= valor;
                return _saldo;
            }else
            {
                throw new ArgumentException("Valor do saque ultrapassa o saldo");
            }
            
        }

    }
}

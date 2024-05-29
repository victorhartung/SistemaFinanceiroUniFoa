using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        private const decimal TaxaSaque = 0.10m;

        public Conta(long numero)
        {
            _numero = numero;
        }

        public Conta(long numero, decimal saldo, Agencia ag, Cliente titular)
        {

            if(saldo <= 10.00m)
            {
                throw new ArgumentException("O saldo deve ser superior a R$10,00");
            }else if(titular == null)
            {
                throw new ArgumentNullException(nameof(titular), "A conta deve possuir um titular");
            }

            _numero = numero;
            _saldo = saldo;
            agencia = ag ?? throw new ArgumentNullException(nameof(ag), "A conta deve ter uma agencia");
            this.titular = titular ?? throw new ArgumentNullException(nameof(titular), "A conta deve ter um cliente");
        }

        public long Numero
        {
            get => _numero;
            private set
            {
                _numero = value;
            }
        }

        public decimal Saldo { 
            
            get => _saldo;
            private set
            {   
                _saldo = value; 
            }
        }

        public void Deposito(decimal valor)
        {
            if (valor > 0)
            {
                _saldo += valor;
            }
        }

        public decimal Saque(decimal valor)
        {

            decimal valorTotal = valor + TaxaSaque;

            if(_saldo - valorTotal >= 0)
            {
                _saldo -= valorTotal;
                return _saldo;
            }else
            {
                throw new ArgumentException("Valor do saque ultrapassa o saldo");
            }
            
        }

        public void Transferir(decimal valor, Conta contaDestino)
        {
            if (valor <= 0)
            {
                throw new ArgumentException("O valor da transferência deve ser maior que 0");
            }
            else if (valor > Saldo) {

                throw new InvalidOperationException("Saldo insuficiente para realizar transferência");
            
            }

            this.Saldo -= valor;
            contaDestino.Saldo += valor;

            
        }

    }
}

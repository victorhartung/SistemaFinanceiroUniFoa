using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro
{
    public class Agencia
    {
        private int _numero;
        private string _nome, _telefone;
        public Banco Banco {  get; set; }

        public Agencia(int numero) 
        {

            _numero = numero;
        
        }

        public Agencia(int numero, string nome, string telefone, Banco banco)
        {
            _numero = numero;
            _nome = nome;
            _telefone = telefone;
            Banco = banco ?? throw new ArgumentNullException(nameof(banco), "A agencia deve pertencer a um banco");

           
        }

        public int Numero { get => _numero; }

        public string Nome { get => _nome; set => _nome = value; }

        public string Telefone
        {
            get => _telefone;
            set => _telefone = value;
        }
    }
}

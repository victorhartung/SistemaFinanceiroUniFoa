using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Model
{
    public class Cliente
    {

        private string _nome;
        private string _cpf;
        private int _anoNascimento;
        
        public Cliente() { }

        public Cliente(string nome, string cpf, int anoNascimento)
        {

            _nome = nome;
            _cpf = cpf;
            _anoNascimento = anoNascimento;
            
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Cpf 
        {  
            get { return _cpf; } 
            set { _cpf = value; } 
        }

        public int AnoNascimento { 
            
            get { return _anoNascimento; }
            set {
                
                if(CalcularIdade(value) < 18)
                {
                    throw new ArgumentException("O cliente deve ter mais de 18 anos.");
                }
                
                _anoNascimento = value; 
            } 
        
        }

        private int CalcularIdade(int anoNascimento)
        {
            int anoAtual = DateTime.Today.Year;

            return anoAtual - anoNascimento;
        }



    }
}

﻿using System;
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

        public Agencia(int numero) 
        {

            _numero = numero;
        
        }

        public Agencia(int numero, string nome, string telefone)
        {
            _numero = numero;
            _nome = nome;
            _telefone = telefone;
           
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

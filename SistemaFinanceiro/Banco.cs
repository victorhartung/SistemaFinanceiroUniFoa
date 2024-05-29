using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro
{
    public class Banco
    {
        public string Nome {  get; set; }
        public int Numero { get; set; }

        public Banco(string nome, int numero)
        {
            Nome = nome ?? throw new ArgumentNullException(nameof(nome), "O nome do banco não pode ser nulo.");
            Numero = numero;
        }

    }
}

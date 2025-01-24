using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revendedora
{
     class Venda
    {
        string nome;
        //string cpf;
        decimal valor;

        public string Nome { get => nome; set => nome = value; }
        //public string Cpf { get => cpf; set => cpf = value; }
        public decimal Valor { get => valor; set => valor = value; }
    }
}

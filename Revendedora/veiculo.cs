using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revendedora
{
    class Veiculo
    {

        string placa;
        string cor;
        string modelo;

        int marca;
        int ano;

        decimal valor;

        public string Placa { get => placa; set => placa = value; }
        public string Cor { get => cor; set => cor = value; }   
        public string Modelo { get => modelo; set => modelo = value; }
        public int Marca { get => marca; set => marca = value; }
        public int Ano { get => ano; set => ano = value; }
        public decimal Valor { get => valor; set => valor = value; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revendedora
{
    internal class user
    {

        string nome;
        string email;
        string senha;

        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }
    }
}

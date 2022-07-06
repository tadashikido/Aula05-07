using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastroClientes
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }

        public int Idade
        {
            get
            {
                return (DateTime.Today - DataNascimento).Days / 365;
            }
        }
    }
}

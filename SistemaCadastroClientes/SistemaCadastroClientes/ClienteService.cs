using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastroClientes
{
    public class ClienteService
    {
        public void ListarClientes()
        {
            for (var i = 0; i < BancoDados.QtdeClientes; i++)
            {
                Console.WriteLine("Nome: " + BancoDados.Clientes[i].Nome);
                Console.WriteLine("CPF: " + BancoDados.Clientes[i].Cpf);
                Console.WriteLine("Data Nascimento: " + BancoDados.Clientes[i].DataNascimento.ToShortDateString());
                Console.WriteLine("Endereço: " + BancoDados.Clientes[i].Endereco);
                Console.WriteLine();
            }
        }

        public void Relatorio()
        {
            var ordenado = BancoDados.Clientes.Where(x => x != null).OrderBy(x => x.Idade).ToArray();

            for (var i = 0; i < BancoDados.QtdeClientes; i++)
            {
                Console.WriteLine("Nome: " + ordenado[i].Nome);
                Console.WriteLine("Idade: " + ordenado[i].Idade);
                Console.WriteLine();
            }
        }

        public void ExcluirCliente()
        {
            Console.Write("Digite o CPF para buscar o cliente: ");
            var cpf = Console.ReadLine();

            for (var i = 0; i < BancoDados.QtdeClientes; i++)
            {
                if (BancoDados.Clientes[i].Cpf == cpf)
                {
                    var nome = BancoDados.Clientes[i].Nome;
                    for (var j = i + 1; j < BancoDados.QtdeClientes; j++)
                    {
                        BancoDados.Clientes[j - 1] = BancoDados.Clientes[j];
                    }
                    BancoDados.QtdeClientes--;

                    Console.WriteLine("Cliente " + nome + " excluído com sucesso!");
                    break;
                }
            }
        }

        public void CadastrarCliente()
        {
            Console.Write("Digite o nome do cliente: ");
            var nome = Console.ReadLine();

            Console.Write("Digite o cpf do cliente: ");
            var cpf = Console.ReadLine();

            Console.Write("Digite a data de nascimento do cliente: ");
            var dataNacimento = Console.ReadLine();

            Console.Write("Digite o endereço do cliente: ");
            var endereco = Console.ReadLine();

            var cliente = new Cliente()
            {
                Nome = nome,
                Cpf = cpf,
                DataNascimento = Convert.ToDateTime(dataNacimento),
                Endereco = endereco,
            };

            BancoDados.Clientes[BancoDados.QtdeClientes] = cliente;
            BancoDados.QtdeClientes++;

            Console.WriteLine("Cadastro do " + cliente.Nome + " realizado com sucesso!");
        }
    }
}

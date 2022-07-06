using Bogus;
using Bogus.Extensions.Brazil;
using System;
using System.Linq;

namespace SistemaCadastroClientes
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 0; i < 15; i++)
            {
                var faker = new Faker();
                BancoDados.Clientes[BancoDados.QtdeClientes++] = new Cliente
                {
                    Nome = faker.Person.FullName,
                    Cpf = faker.Person.Cpf(),
                    DataNascimento = faker.Person.DateOfBirth,
                    Endereco = $"{faker.Person.Address.Street}, {faker.Address.BuildingNumber()} - {faker.Address.City()}-{faker.Address.StateAbbr()}"
                };
            }

            while (true)
            {
                var sair = Menu();

                if (sair)
                {
                    break;
                }

                Console.WriteLine("Tecle enter para continuar ...");
                Console.ReadKey();

                Console.WriteLine();
                Console.WriteLine();
            }
        }


        public static bool Menu()
        {
            var clienteService = new ClienteService();

            Console.WriteLine("** Sistema de cadastro de cliente **");
            Console.WriteLine();
            Console.WriteLine("[1] - Listar Clientes");
            Console.WriteLine("[2] - Cadastrar Cliente");
            Console.WriteLine("[3] - Excluir Cliente");
            Console.WriteLine("[4] - Relatório");
            Console.WriteLine("[9] - Sair ");

            Console.WriteLine();
            Console.Write("Selecione uma opção: ");

            var opcao = Console.ReadLine();

            if (opcao == "1")
            {
                clienteService.ListarClientes();
            }
            else if (opcao == "2")
            {
                clienteService.CadastrarCliente();
            }
            else if (opcao == "3")
            {
                clienteService.ExcluirCliente();
            }
            else if (opcao == "4")
            {
                clienteService.Relatorio();
            }
            else if (opcao == "9")
            {
                return true;
            }

            return false;
        }
    }
}

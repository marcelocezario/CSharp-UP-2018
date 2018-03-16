using Controllers;
using Modelos;
using System;

namespace ConsoleView
{
    class Program
    {
        enum OpcoesMenuPrincipal
        {
            CadastrarCliente = 1,
            PesquisarCliente = 2,
            ListarClientes = 3,
            ListarEnderecos = 4,
            EditarCliente = 5,
            ExcluirCliente = 6,
            LimparTela = 9,
            Sair = 10
        }

        // opções do menu principal switch
        private static OpcoesMenuPrincipal Menu()
        {
            Console.WriteLine(" =======================================================  ");
            Console.WriteLine("|----------------------- CLIENTES ----------------------| ");
            Console.WriteLine("|       1 - Cadastrar Novo                              | ");
            Console.WriteLine("|       2 - Pesquisar Cliente                           | ");
            Console.WriteLine("|       3 - Listar Clientes Cadastrados                 | ");
            Console.WriteLine("|       4 - Listar Endereços Cadastrados                | ");
            Console.WriteLine("|       5 - Editar Cliente                              | ");
            Console.WriteLine("|       6 - Excluir Cliente                             | ");
            Console.WriteLine("|                                                       | ");
            Console.WriteLine("|       9 - Limpar Tela                                 | ");
            Console.WriteLine("|      10 - Sair                                        | ");
            Console.WriteLine(" =======================================================  ");
            Console.WriteLine("");
            Console.WriteLine("Escolha sua opcao e tecle enter: ");
            string opcao = Console.ReadLine();
            return (OpcoesMenuPrincipal) int.Parse(opcao);
        }

        // método main - view
        static void Main(string[] args)
        {
            OpcoesMenuPrincipal opcaoDigitada =
                OpcoesMenuPrincipal.Sair;

            do
            {
                opcaoDigitada = Menu();

                switch (opcaoDigitada)
                {
                    case OpcoesMenuPrincipal.CadastrarCliente:
                        CadastrarCliente();
                        break;
                    case OpcoesMenuPrincipal.PesquisarCliente:
                        PesquisarCliente();
                        break;
                    case OpcoesMenuPrincipal.ListarClientes:
                        ListarClientes();
                        break;
                    case OpcoesMenuPrincipal.ListarEnderecos:
                        ListarEnderecos();
                        break;
                    case OpcoesMenuPrincipal.EditarCliente:
                        EditarCliente();
                        break;
                    case OpcoesMenuPrincipal.ExcluirCliente:
                        ExcluirCliente();
                        break;
                    case OpcoesMenuPrincipal.LimparTela:
                        LimparTela();
                        break;
                    case OpcoesMenuPrincipal.Sair:
                        break;
                    default:
                        break;
                }
               
            } while (opcaoDigitada != OpcoesMenuPrincipal.Sair);
        }


        // método para cadastro do cliente
        private static Cliente CadastrarCliente()
        {
            Cliente cliente = new Cliente();

            Console.Write("Digite o nome: ");
            cliente.Nome = Console.ReadLine();

            Console.Write("Digite o cpf: ");
            cliente.Cpf = Console.ReadLine();

            cliente._Endereco = CadastrarEndereco();
            cliente.EnderecoID = cliente._Endereco.EnderecoID;
            
            ClienteController cc = new ClienteController();
            cc.SalvarCliente(cliente);

            return cliente;
        }
        
        // método para cadastro do endereço
        private static Endereco CadastrarEndereco()
        {
            Endereco endereco = new Endereco();

            Console.Write("Digite o nome da rua: ");
            endereco.Rua = Console.ReadLine();

            Console.Write("Digite o numero: ");
            endereco.Numero = int.Parse(Console.ReadLine());

            Console.Write("Digite o complemento: ");
            endereco.Complemento = Console.ReadLine();

            EnderecoController ec = new EnderecoController();
            ec.SalvarEndereco(endereco);
            
            return endereco;
        }

        // método para pesquisa do cliente
        private static void PesquisarCliente()
        {
            Console.WriteLine("Digite o nome do cliente: ");
            string nomeCliente = Console.ReadLine();

            ClienteController cc = new ClienteController();
            Cliente cliente = cc.PesquisarPorNome(nomeCliente);

            if (cliente != null)
                ExibirDadosCliente(cliente);
            else
                Console.WriteLine(" *******************************************************");
                Console.WriteLine(" * Erro: Cliente não encontrado!                       *");
                Console.WriteLine(" *******************************************************");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                LimparTela();
        }

        // método para listar todos os clientes
        private static void ListarClientes()
        {
            ClienteController cc = new ClienteController();

            LimparTela();
            Console.WriteLine("  ---------------- CLIENTES CADASTRADOS ---------------");
            if (cc.ListarClientes().Count == 0)
            {
                Console.WriteLine(" *******************************************************");
                Console.WriteLine(" * Erro: Não existem dados a serem listados!           *");
                Console.WriteLine(" *******************************************************");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                LimparTela();
            }
            else
            {
                foreach (var cliente in cc.ListarClientes())
                {
                    ExibirDadosCliente(cliente);
                }
            }
        }

        // método para listar todos os endereços
        private static void ListarEnderecos()
        {
            EnderecoController ec = new EnderecoController();

            LimparTela();
            Console.WriteLine("  ---------------- ENDEREÇOS CADASTRADOS --------------");
            if (ec.ListarEnderecos().Count == 0)
            {
                Console.WriteLine(" *******************************************************");
                Console.WriteLine(" * Erro: Não existem dados a serem listados!           *");
                Console.WriteLine(" *******************************************************");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                LimparTela();
            }
            else
            {
                foreach (var endereco in ec.ListarEnderecos())
                {
                    ExibirEndereco(endereco);
                }
            }

        }

        // método para editar cliente já cadastrado
        private static void EditarCliente()
        {
            ClienteController cc = new ClienteController();

            Cliente cliente;

            Console.WriteLine("Digite a Id do cadastro que deseja alterar: ");
            cliente = cc.PesquisarPorId(int.Parse(Console.ReadLine()));

            ExibirDadosCliente(cliente);


            Console.Write("Digite novo nome: ");
            cliente.Nome = Console.ReadLine();

            Console.Write("Digite novo cpf: ");
            cliente.Cpf = Console.ReadLine();

            // ... Endereco
            cliente._Endereco = CadastrarEndereco();
            cliente.EnderecoID = cliente._Endereco.EnderecoID;

        }

        // método para excluir um cliente cadastrado
        private static void ExcluirCliente()
        {
            Console.WriteLine("Digite o id do cliente que deseja excluir: ");
            int idCliente = int.Parse(Console.ReadLine());

            ClienteController cc = new ClienteController();
            cc.ExcluirCliente(idCliente);
        }

        // método para limpar a tela do console
        private static void LimparTela() => Console.Clear();

        // método para exibir todos os dados do cliente
        private static void ExibirDadosCliente(Cliente cliente)
        {
            Console.WriteLine();
            Console.WriteLine("--- DADOS CLIENTE --- ");
            Console.WriteLine("Id.....: " + cliente.PessoaID);
            Console.WriteLine("Nome...: " + cliente.Nome);
            Console.WriteLine("Cpf....: " + cliente.Cpf);

            ExibirEndereco(cliente._Endereco);
        }

        // método para exibir um endereço cadastrado
        private static void ExibirEndereco (Endereco endereco)
        {
            Console.WriteLine("- Endereco -");
            Console.WriteLine("Id End.: " + endereco.EnderecoID);
            Console.WriteLine("Rua....: " + endereco.Rua);
            Console.WriteLine("Num....: " + endereco.Numero);
            Console.WriteLine("Compl..: " + endereco.Complemento);
            Console.WriteLine("--------------------- ");
        }

    }
}

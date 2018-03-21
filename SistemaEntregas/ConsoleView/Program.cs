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
            EditarEndereco = 6,
            ExcluirCliente = 7,
            LimparTela = 9,
            Sair = 10
        }

        // opções do menu principal switch
        private static OpcoesMenuPrincipal Menu()
        {
            LimparTela();
            Console.WriteLine(" _______________________________________________________  ");
            Console.WriteLine("|----------------------- CLIENTES ----------------------| ");
            Console.WriteLine("|                                                       | ");
            Console.WriteLine("|       1 - Cadastrar Novo                              | ");
            Console.WriteLine("|       2 - Pesquisar Cliente                           | ");
            Console.WriteLine("|       3 - Listar Clientes Cadastrados                 | ");
            Console.WriteLine("|       4 - Listar Endereços Cadastrados                | ");
            Console.WriteLine("|       5 - Editar Cliente                              | ");
            Console.WriteLine("|       6 - Editar Endereco                             | ");
            Console.WriteLine("|       7 - Excluir Cliente                             | ");
            Console.WriteLine("|                                                       | ");
            Console.WriteLine("|       9 - Limpar Tela                                 | ");
            Console.WriteLine("|      10 - Sair                                        | ");
            Console.WriteLine("|_______________________________________________________| ");
            Console.WriteLine("");
            Console.WriteLine("Escolha sua opcao e tecle enter: ");
            string opcao = Console.ReadLine();
            return (OpcoesMenuPrincipal)int.Parse(opcao);
        }

        // método main - view
        static void Main(string[] args)
        {
            OpcoesMenuPrincipal opcaoDigitada =
                OpcoesMenuPrincipal.Sair;

            do
            {
                opcaoDigitada = Menu();

                LimparTela();
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
                    case OpcoesMenuPrincipal.EditarEndereco:
                        EditarEndereco();
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

                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();

            } while (opcaoDigitada != OpcoesMenuPrincipal.Sair);
        }


        // método para cadastro do cliente
        private static Cliente CadastrarCliente()
        {
            Console.WriteLine(" _______________________________________________________ ");
            Console.WriteLine("|------------------ CADASTRAR CLIENTE ------------------|");
            Console.WriteLine("|_______________________________________________________|");
            Console.WriteLine("");

            Cliente cliente = new Cliente();

            Console.Write("Digite o nome...........: ");
            cliente.Nome = Console.ReadLine();

            Console.Write("Digite o CPF............: ");
            cliente.Cpf = Console.ReadLine();

            cliente.EnderecoID = CadastrarEndereco().EnderecoID;

            ClienteController cc = new ClienteController();
            cc.SalvarCliente(cliente);

            Console.WriteLine("");
            Console.WriteLine("Cadastro efetuado com sucesso!");
            Console.WriteLine("");
            ExibirDadosCliente(cliente);

            return cliente;
        }

        // método para cadastro do endereço
        private static Endereco CadastrarEndereco()
        {
            Endereco endereco = new Endereco();

            Console.Write("Digite o nome da rua....: ");
            endereco.Rua = Console.ReadLine();

            Console.Write("Digite o numero.........: ");
            endereco.Numero = int.Parse(Console.ReadLine());

            Console.Write("Digite o complemento....: ");
            endereco.Complemento = Console.ReadLine();

            EnderecoController ec = new EnderecoController();
            ec.SalvarEndereco(endereco);

            return endereco;
        }

        // método para pesquisa do cliente
        private static void PesquisarCliente()
        {
            Console.WriteLine(" _______________________________________________________ ");
            Console.WriteLine("|------------------ PESQUISAR CLIENTE ------------------|");
            Console.WriteLine("|_______________________________________________________|");
            Console.WriteLine("");

            Console.WriteLine("Digite o nome do cliente: ");
            string nomeCliente = Console.ReadLine();

            ClienteController cc = new ClienteController();
            Cliente cliente = cc.PesquisarPorNome(nomeCliente);

            if (cliente != null)
                ExibirDadosCliente(cliente);
            else
            {
                Console.WriteLine(" *******************************************************");
                Console.WriteLine(" * Erro: Cliente não encontrado!                       *");
                Console.WriteLine(" *******************************************************");
            }
        }

        // método para listar todos os clientes
        private static void ListarClientes()
        {
            ClienteController cc = new ClienteController();

            Console.WriteLine(" _______________________________________________________ ");
            Console.WriteLine("|------------------- LISTAR CLIENTES -------------------|");
            Console.WriteLine("|_______________________________________________________|");
            Console.WriteLine("");

            if (cc.ListarClientes().Count == 0)
            {
                Console.WriteLine(" *******************************************************");
                Console.WriteLine(" * Erro: Não existem dados a serem listados!           *");
                Console.WriteLine(" *******************************************************");
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

            Console.WriteLine(" _______________________________________________________ ");
            Console.WriteLine("|------------------ LISTAR ENDEREÇOS -------------------|");
            Console.WriteLine("|_______________________________________________________|");
            Console.WriteLine("");

            if (ec.ListarEnderecos().Count == 0)
            {
                Console.WriteLine(" *******************************************************");
                Console.WriteLine(" * Erro: Não existem dados a serem listados!           *");
                Console.WriteLine(" *******************************************************");
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
            Console.WriteLine(" _______________________________________________________ ");
            Console.WriteLine("|------------------- EDITAR CLIENTE --------------------|");
            Console.WriteLine("|_______________________________________________________|");
            Console.WriteLine("");


            ClienteController cc = new ClienteController();

            Cliente cliente;

            Console.WriteLine("Digite a Id do cadastro que deseja alterar: ");
            cliente = cc.PesquisarPorId(int.Parse(Console.ReadLine()));


            if (cliente != null)
            {
                ExibirDadosCliente(cliente);

                Cliente novoCliente = cliente;

                Console.Write("Digite novo nome........: ");
                novoCliente.Nome = Console.ReadLine();

                Console.Write("Digite novo cpf.........: ");
                novoCliente.Cpf = Console.ReadLine();

                cliente = novoCliente;

                // ... Endereco
                EnderecoController ec = new EnderecoController();

                EditarEndereco(cliente.EnderecoID);
            }
            else
            {
                Console.WriteLine(" *******************************************************");
                Console.WriteLine(" * Erro: Cliente não encontrado!                       *");
                Console.WriteLine(" *******************************************************");
            }
        }

        // método para editar endereço já cadastrado
        private static void EditarEndereco()
        {
            Console.WriteLine(" _______________________________________________________ ");
            Console.WriteLine("|------------------- EDITAR ENDERECO -------------------|");
            Console.WriteLine("|_______________________________________________________|");
            Console.WriteLine("");

            Console.WriteLine("Digite a Id do endereço que deseja alterar: ");
            int idPesquisa = int.Parse(Console.ReadLine());
            EditarEndereco(idPesquisa);
        }

        // método para editar endereço utilizando o número de Id como parametro. Retorna novo endereço
        private static void EditarEndereco(int EnderecoID)
        {
            EnderecoController ec = new EnderecoController();
            Endereco endereco;
            endereco = ec.PesquisarPorId(EnderecoID);

            Console.Write("Digite o nome da rua....: ");
            endereco.Rua = Console.ReadLine();

            Console.Write("Digite o numero.........: ");
            endereco.Numero = int.Parse(Console.ReadLine());

            Console.Write("Digite o complemento....: ");
            endereco.Complemento = Console.ReadLine();
        }

        // método para excluir um cliente cadastrado
        private static void ExcluirCliente()
        {
            Console.WriteLine(" _______________________________________________________ ");
            Console.WriteLine("|------------------- EXCLUIR CLIENTE -------------------|");
            Console.WriteLine("|_______________________________________________________|");
            Console.WriteLine("");


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
            EnderecoController ec = new EnderecoController();

            Console.WriteLine();
            Console.WriteLine("--- DADOS CLIENTE --- ");
            Console.WriteLine("Id...........: " + cliente.PessoaID);
            Console.WriteLine("Nome.........: " + cliente.Nome);
            Console.WriteLine("Cpf..........: " + cliente.Cpf);

            ExibirEndereco(ec.PesquisarPorId(cliente.EnderecoID));
        }

        // método para exibir um endereço cadastrado
        private static void ExibirEndereco(Endereco endereco)
        {
            Console.WriteLine("- Endereco -");
            Console.WriteLine("Id endereço..: " + endereco.EnderecoID);
            Console.WriteLine("Rua..........: " + endereco.Rua);
            Console.WriteLine("Número.......: " + endereco.Numero);
            Console.WriteLine("Complemento..: " + endereco.Complemento);
            Console.WriteLine("--------------------- ");
        }

    }
}

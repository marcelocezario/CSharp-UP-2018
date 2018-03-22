using System;

namespace ProducaoAlimentos
{
    class Program
    {
        enum OpcoesMenuPrincipal
        {
            RegistrarEntradasInsumos = 1,
            RegistrarProducao = 2,
            RegistrarVenda = 3,
            Cadastros = 4,
            Consultas = 5,

            Sair = 9
        }
        static void Main(string[] args)
        {
            OpcoesMenuPrincipal opcaoDigitada = OpcoesMenuPrincipal.Sair;
        }

        private static OpcoesMenuPrincipal Menu()
        {
            Console.WriteLine(" ___________________________________________________________________ ");
            Console.WriteLine("|                                                                   |");
            Console.WriteLine("|                       PRODUCAO DE ALIMENTOS                       |");
            Console.WriteLine("|___________________________________________________________________|");
            Console.WriteLine("|                                                                   |");
            Console.WriteLine("|         1 - Registro de entrada de Insumos                        |");
            Console.WriteLine("|         2 - Registro de produção                                  |");
            Console.WriteLine("|         3 - Registro de vendas                                    |");
            Console.WriteLine("|         4 - Cadastros                                             |");
            Console.WriteLine("|         5 - Consultas                                             |");
            Console.WriteLine("|                                                                   |");
            Console.WriteLine("|         9 - Encerrar execução                                     |");
            Console.WriteLine("|___________________________________________________________________|");
            Console.WriteLine("");
            Console.WriteLine("Escolha sua opcao e tecle enter: ");
            string opcao = Console.ReadLine();
            return (OpcoesMenuPrincipal)int.Parse(opcao);
        }
    }
}

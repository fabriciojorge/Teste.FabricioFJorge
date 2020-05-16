using System;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var menu = new Menu();
                bool encerrarMenu = false;

                while (!encerrarMenu)
                {
                    menu.CarregaOpcoesMenu();
                    var key = Console.ReadKey(false).KeyChar;
                    Console.Clear();

                    if (OpcaoValida(key))
                    {
                        Console.WriteLine($"Você selecionou a opção {key}. \n");

                        if (key.Equals('9'))
                            encerrarMenu = true;
                        else
                            menu.ProcessarOpcao(key);
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida!");
                    }

                    Console.WriteLine();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Houve um erro ao executar o programa. Encerrando a aplicação.");
            }
        }

        private static bool OpcaoValida(char opcao)
        {
            char[] opcoes = { '1', '2', '3', '4', '9' };
            return opcoes.Contains(opcao);
        }
    }
}

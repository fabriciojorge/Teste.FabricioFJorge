using Service;
using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    public class Menu
    {
        /// <summary>
        /// Carrega o menu da aplicação em console
        /// </summary>
        public void CarregaOpcoesMenu()
        {
            Console.WriteLine("Escolha uma funcionalidade selecionando entre os números abaixo. \n");

            Console.WriteLine("1 - Função Números");
            Console.WriteLine("2 - Função Soma de Quadrados");
            Console.WriteLine("3 - Função Fibonacci");
            Console.WriteLine("4 - Função Números Triângulo");
            Console.WriteLine("9 - Encerrar aplicação");

            Console.WriteLine();
        }

        /// <summary>
        /// Executa um dos métodos a partir da seleção do usuário
        /// </summary>
        /// <param name="opcao"></param>
        public void ProcessarOpcao(char opcao)
        {
            if (opcao == '1')
            {
                ListarNumeros();
            }
            else if (opcao == '2')
            {
                SomaQuadrados();
            }
            else if (opcao == '3')
            {
                Fibonacci();
            }
            else if (opcao == '4')
            {
                NumerosTriangulo();
            }

        }

        private void EncerrarFuncao()
        {
            Console.ReadKey(false);
            Console.Clear();
        }

        private void ListarNumeros()
        {
            string nome, sobrenome;

            Console.WriteLine("Função Números");
            Console.WriteLine("\nDigite o nome");
            nome = Console.ReadLine();
            Console.WriteLine("\nDigite o sobrenome");
            sobrenome = Console.ReadLine();
            Console.WriteLine();

            var servico = new ListagemNumerosService();
            var resultado = servico.ImprimeNumeros(nome, sobrenome);

            foreach (var item in resultado)
            {
                Console.WriteLine(item);
            }

            EncerrarFuncao();
        }

        private void SomaQuadrados()
        {
            Console.WriteLine("Função Soma de Quadrados");
            Console.WriteLine("\nInsira um numero por vez. (Para ver a soma dos quadrados pressione ENTER.)");
            var numeros = new List<int>();
            bool encerrarLoop = false;
            while (!encerrarLoop)
            {
                var tecla = Console.ReadLine().Trim();

                if (string.IsNullOrWhiteSpace(tecla))
                {
                    encerrarLoop = true;
                }
                else if (int.TryParse(tecla, out int num))
                {
                    numeros.Add(num);
                }
            }

            var servico = new QuadradosService();
            var resultado = servico.SomaDeQuadrados(numeros);

            Console.WriteLine($"A soma de todos os quadrados da lista é {resultado}.");

            EncerrarFuncao();
        }

        private void Fibonacci()
        {
            Console.WriteLine("Função Fibonacci");
            Console.ReadKey(false);
            Console.WriteLine();

            var servico = new FibonacciService();
            var resultado = servico.ExecutaSequencia();

            Console.WriteLine($"O primeiro número da sequência com 5 dígitos é {resultado}.");

            EncerrarFuncao();
        }

        private void NumerosTriangulo()
        {
            Console.WriteLine("Função Números Triângulo");
            Console.WriteLine("\nDigite uma palavra. (Somente letras e sem espaços)");
            string palavra = Console.ReadLine();
            Console.WriteLine();

            var servico = new PalavraTrianguloService();
            var resultado = servico.PalavraTriangulo(palavra);

            Console.WriteLine($"O valor da palavra {resultado.Palavra} é {resultado.Valor}.");

            EncerrarFuncao();
        }
    }
}

using Domain;
using System;

namespace Service
{
    public class PalavraTrianguloService
    {
        /// <summary>
        /// Verifica se a palavra é uma palavra triângulo e retorna o ser valor
        /// </summary>
        /// <param name="palavra">Palavra a ser verificada</param>
        /// <returns></returns>
        public PalavraTriangulo PalavraTriangulo(string palavra)
        {
            char[] sequencia = palavra.ToUpper().ToCharArray();
            var numeroTriangulo = new NumeroTriangulo
            {
                Numero = 1
            };
            int valorPalavra = 0;

            //Converte a letra em número e faz a soma do valor da palavra
            foreach (var item in sequencia)
            {
                valorPalavra += Convert.ToByte(item) - 64;
            }

            //Aplica a fórmula do número triângulo
            while (numeroTriangulo.Resultado < valorPalavra)
            {
                numeroTriangulo.Resultado = (numeroTriangulo.Numero * (numeroTriangulo.Numero + 1)) / 2;
                numeroTriangulo.Numero++;
            }

            return new PalavraTriangulo()
            {
                Palavra = palavra,
                Valor = valorPalavra == numeroTriangulo.Resultado ? valorPalavra : -1
            };
        }
    }
}

using System.Collections.Generic;

namespace Service
{
    public class QuadradosService
    {
        /// <summary>
        /// Gera a soma de todos os quadrados de uma lista
        /// </summary>
        /// <param name="numeros">Listagem de números inteiros a serem somados</param>
        /// <returns></returns>
        public int SomaDeQuadrados(IList<int> numeros)
        {
            int totalDosQuadrados = 0;

            foreach (var num in numeros)
            {
                totalDosQuadrados += num * num;
            }

            return totalDosQuadrados;
        }
    }
}

namespace Service
{
    public class FibonacciService
    {
        /// <summary>
        /// Executa a sequência de Fibonacci com um valor pré-definido
        /// </summary>
        /// <returns></returns>
        public int ExecutaSequencia()
        {
            return ExecutaSequencia(10000);
        }

        /// <summary>
        /// Executa a sequência de Fibonacci
        /// </summary>
        /// <param name="numReferencia">Número de referência para achar o primeiro elemento maior ou igual da sequência</param>
        /// <returns></returns>
        public int ExecutaSequencia(int numReferencia)
        {
            int elemento = 0;
            int el1 = 0;
            int el2 = 1;

            while (elemento < numReferencia)
            {
                elemento = el1 + el2;
                el2 = el1;
                el1 = elemento;
            }

            return elemento;
        }
    }
}

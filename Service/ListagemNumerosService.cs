using Domain;
using System.Collections.Generic;

namespace Service
{
    public class ListagemNumerosService
    {
        private readonly SequenciaNumerica sequencia = new SequenciaNumerica();

        /// <summary>
        /// Construtor padrão. Gera uma sequência numérica de 1 a 100
        /// </summary>
        public ListagemNumerosService()
        {
            sequencia.InicioSequencia = 1;
            sequencia.FimSequencia = 100;
        }

        /// <summary>
        /// Construtor que permite gerar uma sequência numérica personalizada.
        /// </summary>
        /// <param name="inicioSequencia"></param>
        /// <param name="fimSequencia"></param>
        public ListagemNumerosService(int inicioSequencia, int fimSequencia)
        {
            sequencia.InicioSequencia = inicioSequencia;
            sequencia.FimSequencia = fimSequencia;
        }

        /// <summary>
        /// Imprime uma sequência de números
        /// </summary>
        /// <param name="nome">Nome para referência</param>
        /// <param name="sobreNome">Sobrenome para referência</param>
        /// <returns></returns>
        public IList<string> ImprimeNumeros(string nome, string sobreNome)
        {
            var listagem = new List<string>();
            string valor;

            while (sequencia.InicioSequencia <= sequencia.FimSequencia)
            {
                if (sequencia.InicioSequencia % 3 == 0 && sequencia.InicioSequencia % 5 == 0)
                    valor = $"{sequencia.InicioSequencia} {nome} {sobreNome}";
                else if (sequencia.InicioSequencia % 5 == 0)
                    valor = $"{sequencia.InicioSequencia} {sobreNome}";
                else if (sequencia.InicioSequencia % 3 == 0)
                    valor = $"{sequencia.InicioSequencia} {nome}";
                else
                    valor = sequencia.InicioSequencia.ToString();

                listagem.Add(valor);

                sequencia.InicioSequencia++;
            }

            return listagem;
        }
    }
}

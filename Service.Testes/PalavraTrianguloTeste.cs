using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Service.Testes
{
    [TestClass]
    public class PalavraTrianguloTeste
    {
        public PalavraTrianguloService servico;
        private int resultado;
        const int resultadoPalavraInvalida = -1;

        [TestMethod]
        public void RetornaPalavraTrianguloValida()
        {
            servico = new PalavraTrianguloService();
            resultado = servico.PalavraTriangulo("sky").Valor;

            Assert.AreNotEqual(resultado, resultadoPalavraInvalida);
        }

        [TestMethod]
        public void RetornaPalavraTrianguloInvalida()
        {
            servico = new PalavraTrianguloService();
            resultado = servico.PalavraTriangulo("asdf").Valor;

            Assert.AreEqual(resultado, resultadoPalavraInvalida);
        }
    }
}

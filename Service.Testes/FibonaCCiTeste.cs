using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Service.Testes
{
    [TestClass]
    public class FibonacciTeste
    {
        public FibonacciService servico;
        int valorReferencia;
        int elemento;

        [TestMethod]
        public void ValidaElementoMaiorQue10000()
        {
            valorReferencia = 10000;
            servico = new FibonacciService();

            elemento = servico.ExecutaSequencia(valorReferencia);

            Assert.IsTrue(elemento > valorReferencia);
        }

        [TestMethod]
        public void ValidaElementoMaiorQue100()
        {
            valorReferencia = 100;
            servico = new FibonacciService();

            elemento = servico.ExecutaSequencia(valorReferencia);

            Assert.IsTrue(elemento > valorReferencia);
        }

        [TestMethod]
        public void ValidaElementoMaiorQue50000()
        {
            valorReferencia = 50000;
            servico = new FibonacciService();

            elemento = servico.ExecutaSequencia(valorReferencia);

            Assert.IsTrue(elemento > valorReferencia);
        }

        [TestMethod]
        public void NaoValidaElementoElemento1000()
        {
            valorReferencia = 1000;
            servico = new FibonacciService();

            elemento = servico.ExecutaSequencia(valorReferencia);

            Assert.AreNotEqual(valorReferencia, elemento);
        }
    }
}

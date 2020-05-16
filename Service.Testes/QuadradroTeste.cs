using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Service.Testes
{
    [TestClass]
    public class QuadradroTeste
    {
        public QuadradosService servico;
        private int resultado;
        private IList<int> listaNumero;

        [TestMethod]
        public void SomaUmaListaDeQuadrados()
        {
            servico = new QuadradosService();
            listaNumero = new List<int>() { 1, 2, 3, 4, 5 };

            resultado = servico.SomaDeQuadrados(listaNumero);

            Assert.AreEqual(55, resultado);
        }

        [TestMethod]
        public void NaoDeveValidarDuasListasDiferentes()
        {
            servico = new QuadradosService();
            listaNumero = new List<int>() { 1, 2, 3, 4, 5 };
            var listaNumero2 = new List<int> { 1, 3, 5, 7, 9 };

            resultado = servico.SomaDeQuadrados(listaNumero);
            var resultado2 = servico.SomaDeQuadrados(listaNumero2);

            Assert.AreNotEqual(resultado2, resultado);
        }
    }
}

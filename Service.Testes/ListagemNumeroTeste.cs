using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Service.Testes
{
    [TestClass]
    public class ListagemNumeroTeste
    {
        public ListagemNumerosService servico;
        private readonly string nomePadrao = "ABC";
        private readonly string sobrenomePadrao = "DEF";

        [TestMethod]
        public void ValidaTamanhoListaPadrao()
        {
            servico = new ListagemNumerosService();

            var lista = servico.ImprimeNumeros(nomePadrao, sobrenomePadrao);

            Assert.AreEqual(100, lista.Count);
        }

        [TestMethod]
        public void ValidaTamanhoLista300Elementos()
        {
            servico = new ListagemNumerosService(1, 300);

            var lista = servico.ImprimeNumeros(nomePadrao, sobrenomePadrao);

            Assert.AreEqual(300, lista.Count);
        }

        [TestMethod]
        public void ValidaElementoListaMultiploDe3()
        {
            servico = new ListagemNumerosService();
            var lista = servico.ImprimeNumeros(nomePadrao, sobrenomePadrao);

            var elemento = lista.Where(l => l.Contains(nomePadrao)).FirstOrDefault();

            Assert.IsTrue(elemento.EndsWith(nomePadrao));
        }

        [TestMethod]
        public void ValidaElementoListaMultiploDe5()
        {
            servico = new ListagemNumerosService();
            var lista = servico.ImprimeNumeros(nomePadrao, sobrenomePadrao);

            var elemento = lista.Where(l => l.Contains(sobrenomePadrao)).FirstOrDefault();

            Assert.IsTrue(elemento.EndsWith(sobrenomePadrao));
        }

        [TestMethod]
        public void ValidaElementoListaMultiploDe3e5()
        {
            servico = new ListagemNumerosService();
            string nomeCompleto = $"{nomePadrao} {sobrenomePadrao}";
            var lista = servico.ImprimeNumeros(nomePadrao, sobrenomePadrao);

            var elemento = lista.Where(l => l.Contains(nomeCompleto)).FirstOrDefault();

            Assert.IsTrue(elemento.EndsWith(nomeCompleto));
        }

        [TestMethod]
        public void ValidaElementoListaNaoMultiploDe3ou5()
        {
            servico = new ListagemNumerosService();
            var lista = servico.ImprimeNumeros(nomePadrao, sobrenomePadrao);

            var elemento = lista.Where(l => !l.Contains(nomePadrao) || !l.Contains(sobrenomePadrao)).FirstOrDefault();

            Assert.IsFalse(elemento.EndsWith(nomePadrao) || elemento.EndsWith(sobrenomePadrao));
        }
    }
}

using AcademiaTestePadra.Abstracoes;
using AcademiaTestePadra.Models;
using NUnit.Framework;

namespace AcademiaTestePadra.Tests
{
    class adicionarItemCarrinho : SuperClass
    {
        private HomePage_Model home;
        public adicionarItemCarrinho() : base()
        {
            home = new HomePage_Model(this.driver);
        }

        [Test]
        public void AdicionaItemCarrinho()
        {
            home.buscarUmItem("Blouse");
            home.selecionaItem();
            home.adicionaItemCarrinho();
            home.validaItemNoCarrinho();
        }
    }
}

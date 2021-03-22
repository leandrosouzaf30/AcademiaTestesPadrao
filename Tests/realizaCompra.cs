

using AcademiaTestePadra.Abstracoes;
using AcademiaTestePadra.Models;
using NUnit.Framework;

namespace AcademiaTestePadra.Tests
{
    class realizaCompra : SuperClass

    {
        private HomePage_Model home;
        public realizaCompra() : base()
        {
            home = new HomePage_Model(this.driver);
        }

        [Test]
        public void AdicionaItemCarrinho()
        {
            home.buscarUmItem("Blouse");
            home.selecionaItem();
            home.adicionaItemCarrinho();
            home.processarCompra();
            home.verificaEmEstoque();
        }

        [Test]
        public void finalizarCompra()
        {
            home.finalizarCompra();
            home.efetuaLogin("leandro@leandro.com", "1@34567");
            home.checkout();
            home.termosServicos();
            home.checkout();
            home.formaPagamentoBankWire();
            home.confirmaCompra();
        }
    }
}

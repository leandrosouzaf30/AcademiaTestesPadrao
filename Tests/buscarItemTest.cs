using AcademiaTestePadra.Abstracoes;
using AcademiaTestePadra.Models;
using NUnit.Framework;


namespace AcademiaTestePadra.Tests
{
    class buscarItemTest : SuperClass
    {
        private HomePage_Model home;
        public buscarItemTest() : base()
        {
            home = new HomePage_Model(this.driver);
        }


        [Test]
        public void buscarItem()
        {
            home.buscarUmItem("Blouse");
            home.selecionaItem();
        }
    }
}
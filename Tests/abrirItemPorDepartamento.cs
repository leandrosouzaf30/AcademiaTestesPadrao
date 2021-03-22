using AcademiaTestePadra.Abstracoes;
using AcademiaTestePadra.Models;
using NUnit.Framework;

namespace AcademiaTestePadra.Tests
{
    class abrirItemPorDepartamento : SuperClass
    {
        
        private HomePage_Model home;
        public abrirItemPorDepartamento() : base()
        {
            home = new HomePage_Model(this.driver);
        }


        [Test]
        public void navegaDepartamento()
        {
            home.navegaPorDepartamento();
            home.itensCategoriasEmLista();

        }

        [Test]
        public void selecionaItemDaLista()
        {
            home.itensCategoriasEmLista();
            home.selecionaItem();
        }

    }
}


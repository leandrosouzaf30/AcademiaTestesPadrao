using AcademiaTestePadra.Abstracoes;
using AcademiaTestePadra.Models;
using NUnit.Framework;

namespace AcademiaTestePadra.Tests
{
    class criaUsuario : SuperClass
    {
        private HomePage_Model home;
        public criaUsuario() : base()
        {
            home = new HomePage_Model(this.driver);
        }

        [Test]
        public void CriarUsuario()
        {
            home.clicaLinkSignIn();
            home.adicionaEmailCriarConta("leandro@leandro.com");
            home.criaConta();
            home.informacoesPessoais("Leandro", "Souza", "1@34567");
            home.InformacoesEndereco(
                "Desafio Academy", 
                "Rua 10, 222, APT 403",
                "Domingos olimpio",
                "Teste", 
                "09122", 
                "Participando da Academia Avanade",
                "3030-3030",
                "99101010",
                "leandro2@leandro2.com"
                );
        }
    }
}

using AcademiaTestePadra.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace AcademiaTestePadra.Models
{
    public class HomePage_Model
    {
        private IWebDriver driver;
        private HomePage_Page home;
        public HomePage_Model(IWebDriver superDriver)
        {
            driver = superDriver;
            home = new HomePage_Page(driver);
        }

        public void buscarUmItem(String sItem)
        {
            home.txtSearchItem().SendKeys(sItem);
            home.btnSearchItem().Click();

        }
        public void navegaPorDepartamento()
        {
            home.linkCategory().Click();
        }

        public void itensCategoriasEmLista()
        {
            home.linkTypeList().Click();
        }

        public void selecionaItem()
        {
            home.linkItem().Click();
        }

        public void adicionaItemCarrinho()
        {
            home.btnAddToCart().Click();
        }

        public void validaItemNoCarrinho()
        {
            Assert.IsTrue(home.spanItemCarrinho().Text.Contains(""));
        }

        public void processarCompra()
        {
            home.linkProceedToCheckout().Click();
        }

        public void finalizarCompra()
        {
            home.linkProceedToCheckoutSummary().Click();
        }

        public void verificaEmEstoque()
        {
            Assert.IsTrue(home.spanInStock().Text.Contains("In stock"));
        }

        public void clicaLinkSignIn()
        {
            home.linkSignIn().Click();
        }

        public void checkout()
        {
            home.btnProceed().Click();
        }

        public void termosServicos()
        {
            home.checkTermsService().Click();
        }

        public void formaPagamentoBankWire()
        {
            home.linkBankWire().Click();
        }

        public void confirmaCompra()
        {
            home.btnconfirmOrder().Click();
        }
        public void adicionaEmailCriarConta(String email)
        {
            home.txtEmailCreate().SendKeys(email);
        }

        public void criaConta()
        {
            home.btnCreateAccount().Click();
        }

        public void informacoesPessoais(String firstName, String lastName, String pass)
        {
            home.radioGender().Click();
            home.txtFirstName().SendKeys(firstName);
            home.txtLastName().SendKeys(lastName);
            home.txtPassword().SendKeys(pass);
            home.selectDays().Click();
            home.selectDays().Click();
            home.selectMonths().Click();
            home.selectYears().Click();

        }

        public void efetuaLogin(String email, String passwd)
        {
            home.txtEmail().SendKeys(email);
            home.txtPasswd().SendKeys(passwd);
            home.btnSubmitLogin().Click();

        }

        public void InformacoesEndereco(
            String company, 
            String address1, 
            String address2, 
            String city, 
            String postalCode, 
            String additionalInfo, 
            String phone,
            String mobilePhone,
            String alternativeEmail
            )
        {
            home.txtCompany().SendKeys(company);
            home.txtAddress1().SendKeys(address1);
            home.txtAddress2().SendKeys(address2);
            home.txtCity().SendKeys(city);
            home.txtAddress1().SendKeys(address1);
            home.selectState().Click();
            home.txtPostalCode().SendKeys(postalCode);
            home.selectCountry().Click();
            home.txtAdditionalInfo().SendKeys(additionalInfo);
            home.txtHomePhone().SendKeys(phone);
            home.txtMobilePhone().SendKeys(mobilePhone);
            home.txtReferenceAlternativeEmail().Clear();
            home.txtReferenceAlternativeEmail().SendKeys(alternativeEmail);
            home.btnsubmitAccount().Click();
        }

    }
}

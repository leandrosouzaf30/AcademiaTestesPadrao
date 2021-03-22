using OpenQA.Selenium;

namespace AcademiaTestePadra.Pages
{
    public class HomePage_Page
    {
        private IWebDriver driver;
        public HomePage_Page(IWebDriver superDriver)
        {
            driver = superDriver;
        }

        public IWebElement txtSearchItem()
        {
            return driver.FindElement(By.Id("search_query_top"));
        }

        public IWebElement btnSearchItem()
        {
            return driver.FindElement(By.Name("submit_search"));
        }

        public IWebElement linkCategory()
        {
            return driver.FindElement(By.XPath("//a[text()='Women']"));
        }

        public IWebElement linkTypeList()
        {
            return driver.FindElement(By.ClassName("icon-th-list"));
        }

        public IWebElement linkItem()
        {
            //Precisa melhorar esse XPath
            return driver.FindElement(By.XPath("//*/ul/li/div/div[1]/div/a[1]"));
        }

        public IWebElement btnAddToCart()
        {
            return driver.FindElement(By.XPath("//button[contains(., 'Add to cart')]"));
        }

        public IWebElement spanContinueShopping()
        {
            return driver.FindElement(By.XPath("//span[contains(., 'Continue shopping')]/span"));
        }
        public IWebElement linkProceedToCheckout()
        {
   
            return driver.FindElement(By.XPath("//a[contains(., 'Proceed to checkout')]"));
        }

        public IWebElement linkProceedToCheckoutSummary()
        {

            return driver.FindElement(By.XPath("//p/a[contains(., 'Proceed to checkout')]"));
        }

        public IWebElement btnProceed()
        {

            return driver.FindElement(By.XPath("//button[contains(., 'Proceed to checkout')]"));
        }
        public IWebElement checkTermsService()
        {

            return driver.FindElement(By.Id("uniform-cgv"));
        }

        public IWebElement spanInStock()
        {

            return driver.FindElement(By.XPath("//span[contains(., 'In stock')]"));
        }

        public IWebElement txtEmail()
        {
            return driver.FindElement(By.Id("email"));
        }

        public IWebElement txtPasswd()
        {
            return driver.FindElement(By.Id("passwd"));
        }


        public IWebElement btnSubmitLogin()
        {
            return driver.FindElement(By.Id("SubmitLogin"));
        }

        public IWebElement linkSignIn()
        {
            return driver.FindElement(By.ClassName("login"));
        }

        public IWebElement txtEmailCreate()
        {
            return driver.FindElement(By.Id("email_create"));
        }

        public IWebElement btnCreateAccount()
        {
            return driver.FindElement(By.Id("SubmitCreate"));
        }
        public IWebElement radioGender()
        {
            return driver.FindElement(By.Id("id_gender1"));
        }

        public IWebElement txtFirstName()
        {
            return driver.FindElement(By.Id("customer_firstname"));
        }

        public IWebElement txtLastName()
        {
            return driver.FindElement(By.Id("customer_lastname"));
        }

        public IWebElement txtPassword()
        {
            return driver.FindElement(By.Id("passwd"));
        }

        public IWebElement selectDays()
        {
            return driver.FindElement(By.Id("days")).FindElement(By.XPath(".//option[contains(text(),'30')]"));
        }

        public IWebElement selectMonths()
        {
            return driver.FindElement(By.Id("months")).FindElement(By.XPath(".//option[contains(text(),'October')]"));
        }

        public IWebElement selectYears()
        {
            return driver.FindElement(By.Id("years")).FindElement(By.XPath(".//option[contains(text(),'1990')]"));
        }

        public IWebElement txtCompany()
        {
            return driver.FindElement(By.Id("company"));
        }
        
        public IWebElement txtAddress1()
        {
            return driver.FindElement(By.Id("address1"));
        }

        public IWebElement txtAddress2()
        {
            return driver.FindElement(By.Id("address2"));
        }

        public IWebElement txtCity()
        {
            return driver.FindElement(By.Id("city"));
        }

        public IWebElement selectState()
        {
            return driver.FindElement(By.Id("id_state")).FindElement(By.XPath(".//option[contains(text(),'Arizona')]"));

        }

        public IWebElement txtPostalCode()
        {
            return driver.FindElement(By.Id("postcode"));
        }


        public IWebElement selectCountry()
        {
            return driver.FindElement(By.Id("id_country")).FindElement(By.XPath(".//option[contains(text(),'United States')]"));
        }

        public IWebElement txtAdditionalInfo()
        {
            return driver.FindElement(By.Id("other"));
        }

        public IWebElement txtHomePhone()
        {
            return driver.FindElement(By.Id("phone"));
        }

        public IWebElement txtMobilePhone()
        {
            return driver.FindElement(By.Id("phone_mobile"));
        }

        public IWebElement txtReferenceAlternativeEmail()
        {
            return driver.FindElement(By.Id("alias"));
        }

        public IWebElement btnsubmitAccount()
        {
            return driver.FindElement(By.Id("submitAccount"));
        }

        //Pagamento
        public IWebElement linkBankWire()
        {
            return driver.FindElement(By.XPath("//a[contains(., 'Pay by bank wire')]"));
        }

        //Confirmar compra
        public IWebElement btnconfirmOrder()
        {

            return driver.FindElement(By.XPath("//button[contains(., 'I confirm my order')]"));
        }

    }
}
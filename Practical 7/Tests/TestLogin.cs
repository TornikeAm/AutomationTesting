using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using PageObjects;
using Xunit;
using SeleniumExtras.WaitHelpers;


namespace Tests{
    public class Testing{
        protected IWebDriver driver = new ChromeDriver();
        [Fact]
        public void GmailLogin(){
            driver.Navigate().GoToUrl("https://login.yahoo.com/");
            LoginPage login = new LoginPage(driver);
            login.TypeUsername();
            login.clickFirstNext();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            login.TypePassword();
            login.Login();
            driver.Close();
        }
        
        [Fact]
        public void InvalidLogin(){
            driver.Navigate().GoToUrl("https://login.yahoo.com/");
            LoginPage login = new LoginPage(driver);
            login.TypeInvalidUsername();
            login.clickFirstNext();
            // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(4);
            Thread.Sleep(500);


            string error =driver.FindElement(By.XPath(login.ErrorMSG)).Text;
            Assert.Equal("Sorry, we don't recognize this email.",error);
            
        }
    }
}
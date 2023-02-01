using OpenQA.Selenium;

namespace PageObjects{
    public class LoginPage{
        IWebDriver driver;
        By Username = By.XPath("//*[@id='login-username']");
        By NextButton = By.XPath("//*[@id='login-signin']");
        By Password = By.XPath("//*[@id='login-passwd']");
        By AfterPassButton = By.XPath("//*[@id='login-signin']");

        public String ErrorMSG = "//*[@id='username-error']";
        
        public LoginPage(IWebDriver driver){
        this.driver = driver;
        }
        
        public void TypeUsername(){
            driver.FindElement(Username).SendKeys("test.a98");
        }
        public void TypeInvalidUsername(){
            driver.FindElement(Username).SendKeys("invalidUsernameSendedCMNN");
        }

        public void clickFirstNext(){
            driver.FindElement(NextButton).Click();
        }
        
        public void TypePassword(){
            driver.FindElement(Password).SendKeys("Won'tTellyouAPassword");
        }

        public void Login(){
            driver.FindElement(AfterPassButton).Click();
        }

    }

}
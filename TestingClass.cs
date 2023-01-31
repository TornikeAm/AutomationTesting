using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Xunit;


public class TestingClass{
    [Fact]
    public void test(){
        ChromeDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://www.bbc.com/sport");

        IWebElement GoToSearch =driver.FindElement(By.CssSelector("a.ssrcss-13qfcv5-NavigationLink-SearchLink.e1gviwgp16"));
        GoToSearch.Click();
        
        //  Input to Search
        driver.FindElement(By.Id("search-input")).SendKeys("Manchester United");    
        // Click on search button
        driver.FindElement(By.CssSelector("button.ssrcss-1pgdoq4-Button.etotop31")).Click();
        // Get The post and its heading 
        IWebElement heading = driver.FindElement(By.CssSelector("a.ssrcss-rl2iw9-PromoLink.e1f5wbog1"));
        String HText = driver.FindElement(By.CssSelector("a.ssrcss-rl2iw9-PromoLink.e1f5wbog1")).Text;
        heading.Click();
        // Get inner heading of the post and omapre it to outer heading
        String innerHeading = driver.FindElement(By.ClassName("br-masthead__title")).Text;
        Assert.Equal(HText,innerHeading);
        // Go back to previous Page
        driver.Navigate().Back();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
        // Go to Home Page and compare homepage url to excepted url
        IWebElement HomePage = driver.FindElement(By.CssSelector("a.ssrcss-1qc9pyg-NavigationLink.e1gviwgp17"));       
        HomePage.Click();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
        string current_url = driver.Url;
        Assert.Equal("https://www.bbc.com/",current_url);
        driver.Close();

    
    }
    [Fact]
    public void TestWithXpath(){
        ChromeDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://www.bbc.com/sport");

        //  Get and Open The MOre Section
        IWebElement more = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/header/div/nav/div/div[1]/div/div/div[3]/a"));
        more.Click();
        //  Get and Go to swimming Categoiry
        IWebElement Swimming = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/header/div/nav/div/div[2]/div/div/div[1]/ul/li[23]/a"));
        Swimming.Click();
        // Check if we are on right URL
        Assert.Equal("https://www.bbc.com/sport/swimming",driver.Url);
        // Get some Post and click on it
        IWebElement Post = driver.FindElement(By.XPath("/html/body/div[8]/div[3]/div/div[2]/div[1]/div/div[1]/div[1]/div/div/div[3]/div/div[2]/div/a"));
        Post.Click();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        // Close The Ajax Window
        IWebElement Close = driver.FindElement(By.XPath("/html/body/div[10]/div/div/div/div/div[1]/button"));
        Close.Click();
        // Get the Post category and compare it to excepted category
        String Category = driver.FindElement(By.XPath("/html/body/div[8]/div[4]/div/div/div[1]/article/header/p/span[2]/a")).Text;
        Assert.Equal("Swimming",Category);
        driver.Close();

    }
}   
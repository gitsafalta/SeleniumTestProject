using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SelenumTestPilot;
public class LoginTests
{
    [SetUp]
    public void Setup()
    {
    }

    public void Test1()
    {
        //Sudo code for setting up Selenium
        //1. Create a new instance of Selenium Web Driver
        //2. Navigate to the URL
        //2a.Maximum the browser window
        //3. Find the element / Find the login element
        //4. Type in the element
        //5. Click on the element
    }

    [Test]
    public void EAWebSiteTest()
    {
        //Sudo code for setting up Selenium
        //1. Create a new instance of Selenium Web Driver
        IWebDriver driver = new FirefoxDriver();
        //2. Navigate to the URL
        driver.Navigate().GoToUrl("http://eaapp.somee.com");
        //3. Find the login element
        IWebElement loginLink = driver.FindElement(By.LinkText("Login"));
        //4. Click the login link
        loginLink.Click();
        //5. Find the username text box
        IWebElement txtUserName = driver.FindElement(By.Name("UserName"));
        //6.Typing on the textUserName 
        txtUserName.SendKeys("admin");
        //7. Find the password text box
        IWebElement txtPassword = driver.FindElement(By.Name("Password"));
        //8. Typing on the textPassword
        txtPassword.SendKeys("password");
        //8. Identify the login button
        IWebElement loginButton = driver.FindElement(By.Id("loginIn"));
        //9. Click the login button
        loginButton.Submit();
    }

    [Test]
    public void LoginTest()
    {
        //Sudo code for setting up Selenium
        //1. Create a new instance of Selenium Web Driver
        IWebDriver driver = new FirefoxDriver();
        //2. Navigate to the URL
        driver.Navigate().GoToUrl("http://eaapp.somee.com");
        //3. Find and click the login element
        driver.FindElement(By.LinkText("Login")).Click();
        //5. Find and Type the username text box
        driver.FindElement(By.Name("UserName")).SendKeys("admin");
        //7. Find and Type the password text box
        driver.FindElement(By.Name("Password")).SendKeys("password");
        //8. Identify and submit the login button
        driver.FindElement(By.CssSelector(".btn")).Submit();   
    }
}

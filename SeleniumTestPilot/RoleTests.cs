
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SelenumTestPilot;
public class RoleTests
{
 
    [Test]
    public void AddRoleTest()
    {
      var targetname = "guest";
      
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
      
      //2. Navigate to the Role
      driver.Navigate().GoToUrl("http://eaapp.somee.com/role"); 
      //Find the table
      var table = driver.FindElement(By.CssSelector("table"));
      var rows = table.FindElements(By.XPath("..//tbody/tr"));
      foreach (var row in rows){
      var cells = row.FindElements(By.TagName("td"));
      if(cells is not null && cells.Count > 0 && cells[0].Text == targetname)
      {   
        // Since the row doesn't have a unique ID, use IJavaScriptExecutor to execute scripts and interact with elements within the row.
        
        // Locate the role dropdown inside the row
        IWebElement dropdownElement = row.FindElement(By.Name("RoleName")); // Adjust if needed
        SelectElement selectElement = new SelectElement(dropdownElement);
        ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].value = 'User';", selectElement);

        //click Assign button after selecting selecting role
        IWebElement assignButton = row.FindElement(By.CssSelector(".btn")); // Adjust if needed
        ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", assignButton);
            
        break;
      }
    }
  }
}
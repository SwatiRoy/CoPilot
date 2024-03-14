// To write method utility for login to Gmail\
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

public class Page
{
    private IWebDriver Driver;
    public Page(IWebDriver driver) 
    {
        Driver = driver;
    } 
    IWebElement txtUsername => Driver.FindElement(By.Name("UserName"));
    IWebElement txtPassword => Driver.FindElement(By.Name("Password"));
    IWebElement ClickOnSubmit => Driver.FindElement(By.Name("ClickOnSubmit"));
    

    public void EnterPassword(string password)
    {
        txtPassword.SendKeys(password);
    }

    public void EnterUserName(string userName)
    {
        txtPassword.SendKeys(userName);
    }


    // Assuming you have a WebDriver instance
    [Test]
    public string GetSelectedValueFromDropdown(string dropdownId)
    {
        var dropdown = new SelectElement(Driver.FindElement(By.Id(dropdownId)));
        return dropdown.SelectedOption.Text;
    }

    //create method to launch url
    public void LaunchBrowser(string url)
    {
        Driver.Navigate().GoToUrl(url);
    }
}
    

// Page to contain methods to write method for login page

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

[TestFixture]
public class LoginPage

{


    [Test]
    public void TestInvalidLogin()
    {
        IWebDriver _driver = new ChromeDriver();
        Page _page = new Page(_driver);
        _page.LaunchBrowser("https://www.google.com");
        _page.EnterPassword(""); // Code to test invalid login
    }

// [Test]
// public void TestEmptyCredentials()
// {
//     // Code to test login with empty credentials
// }

// [Test]
// public void TestLoginWithOnlyUsername()
// {
//     // Code to test login with only username
// }

// [Test]
// public void TestLoginWithOnlyPassword()
// {
//     // Code to test login with only password
// }

// [Test]
// public void TestLoginWithSpecialCharacters()
// {
//     // Code to test login with special characters in credentials
// }

// [Test]
// public void TestLoginWithSQLInjection()
// {
//     // Code to test login with SQL Injection queries
// }

// [Test]
// public void TestLoginWithLongStringCredentials()
// {
//     // Code to test login with long string in username and password
// }

// [Test]
// public void TestBrowserBackButtonAfterLogin()
// {
//     // Code to test behavior of browser back button after login
// }

// [Test]
// public void TestRememberMeFunctionality()
// {
//     // Code to test Remember Me functionality
// }

// [Test]
// public void TestPasswordVisibilityToggle()
// {
//     // Code to test password visibility toggle
// }

// [Test]
// public void TestPasswordResetFunctionality()
// {
//     // Code to test password reset functionality
// }
}
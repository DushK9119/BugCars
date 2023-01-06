using BugCars.Providers;
using OpenQA.Selenium;

namespace BugCars.WebElements
{
    public class BasePage
    {
        private WebDriverContext _webDriverContext;

        public BasePage(WebDriverContext webDriverContext) => _webDriverContext = webDriverContext;

        public IWebElement LogoLink => _webDriverContext.ChromeDriver.FindElement(By.LinkText("Buggy Rating"));

        public void ClickLogoLink() => LogoLink.Click();
    }
}
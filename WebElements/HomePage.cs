
using BugCars.Contexts;
using BugCars.Providers;
using OpenQA.Selenium;

namespace BugCars.WebElements
{
    public class HomePage : BasePage
    {
        private readonly WebDriverContext _webDriverContext;
        private readonly ConfigurationContext _configurationContext;
        private ConfigurationContext configurationContext;

        public HomePage(WebDriverContext webDriverContext,
            ConfigurationContext configurationContext) : base(webDriverContext)
        {
            _webDriverContext = webDriverContext;
            _configurationContext = configurationContext;
        }

 //       public HomePage(WebDriverContext webDriverContext, ConfigurationContext configurationContext) : base(webDriverContext)
   //     {
     //       this.configurationContext = configurationContext;
       // }

        public IWebElement HomeSection => _webDriverContext.ChromeDriver.FindElement(By.XPath("//my-home"));

        public void GoTo() => _webDriverContext.ChromeDriver.Navigate().GoToUrl(_configurationContext.Configuration.ApplicationBaseUrl);
        public bool IsHomeSectionDisplayed() => HomeSection.Displayed;
    }
}

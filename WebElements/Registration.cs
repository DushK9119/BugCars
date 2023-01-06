using BugCars.WebElements;
using BugCars.Contexts;
using BugCars.Providers;
using BugCars.Models;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using OpenQA.Selenium;
using BugCars.ModelsModels;

namespace BugCars.WebElements
{
    public class Registration : BasePage
    {
        private readonly WebDriverContext _webDriverContext;
        private readonly ConfigurationContext _configurationContext;

        public Registration(WebDriverContext webDriverContext,
            ConfigurationContext configurationContext) : base(webDriverContext)
        {
            _webDriverContext = webDriverContext;
            _configurationContext = configurationContext;
        }

        public IWebElement UsernameInput => _webDriverContext.ChromeDriver.FindElement(By.Id("username"));
        public IWebElement FirstNameInput => _webDriverContext.ChromeDriver.FindElement(By.Id("firstName"));
        public IWebElement LastNameInput => _webDriverContext.ChromeDriver.FindElement(By.Id("lastName"));
        public IWebElement PasswordInput => _webDriverContext.ChromeDriver.FindElement(By.Id("password"));
        public IWebElement ConfirmPasswordInput => _webDriverContext.ChromeDriver.FindElement(By.Id("confirmPassword"));
        public IWebElement RegisterButton => _webDriverContext.ChromeDriver.FindElement(By.XPath("//button[@type='submit'][text()='Register']"));
        public IWebElement RegistrationResult => _webDriverContext.ChromeDriver.FindElement(By.ClassName("result"));

        public void GoTo() => _webDriverContext.ChromeDriver.Navigate().GoToUrl($"{_configurationContext.Configuration.ApplicationBaseUrl}register");

        public void EnterRegistrationData(RegistrationModel data)
        {
            if (data.Username == "random")
                data.RandomizeUsername();

            UsernameInput.SendKeys(data.Username);
            FirstNameInput.SendKeys(data.FirstName);
            LastNameInput.SendKeys(data.LastName);
            PasswordInput.SendKeys(data.Password);
            ConfirmPasswordInput.SendKeys(data.ConfirmPassword);
        }

        public void ClickRegisterButton() => RegisterButton.Click();
    }
}

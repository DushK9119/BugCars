using BugCars.Contexts;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace BugCars.Providers
{
    public class WebDriverContext
        {
            private readonly ConfigurationContext _configurationContext;
            public IWebDriver ChromeDriver;

            public WebDriverContext(ConfigurationContext configurationContext)
            {
                _configurationContext = configurationContext;

                ChromeOptions options = new ChromeOptions();
                if (_configurationContext.Configuration.WebDriver.IsHeadless)
                    options.AddArgument("--headless");

                this.ChromeDriver = new ChromeDriver(options);

                this.ChromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(_configurationContext.Configuration.WebDriver.ImplicitWaitInSeconds);
            }
        }

    }
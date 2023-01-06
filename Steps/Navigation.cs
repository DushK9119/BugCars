using BuggyCarsRating.Tests.Contexts;
using BuggyCarsRating.Tests.Providers;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace BugCars.Steps
{
    [Binding]
    public sealed class NavigationSteps
    {
        private readonly WebDriverContext _webDriverContext;
        private readonly WebElementContext _webElementContext;

        public NavigationSteps(WebDriverContext webDriverContext,
            WebElementContext webElementContext)
        {
            _webDriverContext = webDriverContext;
            _webElementContext = webElementContext;
        }

        [Given(@"I navigate to (.*)")]
        public void GivenIAmIn(string url)
        {
            _webDriverContext.ChromeDriver.Navigate().GoToUrl(url);
        }

        [When(@"I click logo link")]
        public void WhenIClickLogoLink()
        {
            _webElementContext.Homepage.ClickLogoLink();
        }

        [Then(@"I should sent back to home page")]
        public void ThenIShouldBeSentBackToHomePage()
        {
            Assert.That(_webElementContext.Homepage.IsHomeSectionDisplayed(), Is.True);
        }
    }
}

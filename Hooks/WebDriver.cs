using BuggyCarsRating.Tests.Providers;
using TechTalk.SpecFlow;

namespace BuggyCarsRating.Tests.Hooks
{
    [Binding]
    public sealed class WebDriverHooks
    {
        private WebDriverContext _webDriverContext;

        public WebDriverHooks(WebDriverContext webDriverProvider) => _webDriverContext = webDriverProvider;

        [AfterScenario]
        public void AfterScenario()
        {
            _webDriverContext.ChromeDriver.Quit();
        }
    }
}

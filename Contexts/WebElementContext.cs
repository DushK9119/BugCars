using BugCars.WebElements;
using BugCars.Providers;

namespace BugCars.Contexts
{
    public class WebElementContext
    {
        private readonly WebDriverContext _webDriverContext;
        private readonly ConfigurationContext _configurationContext;

        public HomePage Homepage;
        public Registration Registration;
        public Login Login;
        public Navigation Navigation;
        

        public WebElementContext(WebDriverContext webDriverContext,
            ConfigurationContext configurationContext)
        {
            _webDriverContext = webDriverContext;
            _configurationContext = configurationContext;

            this.Homepage = new HomePage(_webDriverContext, _configurationContext);
            this.Registration = new Registration(_webDriverContext, _configurationContext);
            this.Login = new Login(_webDriverContext);
            this.Navigation = new Navigation(_webDriverContext);
            //this.OverallRatingPage = new OverallRatingPage(_webDriverContext, _configurationContext);
        }
    }
}
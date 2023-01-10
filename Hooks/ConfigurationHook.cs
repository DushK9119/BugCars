using BugCars.Contexts;
using BugCars.Models;
using Microsoft.Extensions.Configuration;
using TechTalk.SpecFlow;

namespace BugCars.Hooks
{
    public sealed class ConfigurationHook
    {
        private readonly ConfigurationContext _testConfigurationContext;

        public ConfigurationHook(ConfigurationContext testConfigurationContext)
        {
            _testConfigurationContext = testConfigurationContext;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            var config = new ConfigBuilder()
            .AddJsonFile("testsettings.json", optional: false)
            .Build();

            _testConfigurationContext.Configuration = config.Get<ConfigModel>();
        }
    }
}

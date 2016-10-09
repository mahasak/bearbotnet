using OpenQA.Selenium;
using System.Collections.ObjectModel;

namespace BearBot.Infrastructure.Bot.PageObject
{
    public class CommonPage
    {
        private readonly IWebDriver driver;

        public CommonPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public ReadOnlyCollection<IWebElement> GetTabs
        {
            get
            {
                return driver.FindElements(By.CssSelector("#hero-banner-tab-nav li"));
            }
        }

        public IWebElement GetActiveTab
        {
            get
            {
                var tabs = driver.FindElement(By.Id("hero-banner-tab-nav"));
                return tabs.FindElement(By.ClassName("active"));
            }
        }
    }
}

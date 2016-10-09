using BearBot.Infrastructure.Bot.PageObject;
using BearBot.Infrastructure.Bot.Selenium;
using NBehave.Narrator.Framework;
using NUnit.Framework;
using OpenQA.Selenium;

namespace BearBot.Infrastructure.Bot.ActionStep
{
    [ActionSteps]
    public class HomeStep
    {
        [Then("Home tab size should be $count")]
        public void TabSizeShouldBe(int count)
        {
            Assert.AreEqual(count, Home.GetTabs.Count);
        }

        private CommonPage _home;
        private CommonPage Home
        {
            get
            {
                if (_home == null)
                {
                    _home = new CommonPage((IWebDriver)FeatureContext.Current[ContextKeys.CHROME]);
                }
                return _home;
            }
        }
    }
}

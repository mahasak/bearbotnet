using BearBot.Infrastructure.Bot.Selenium;
using NBehave.Narrator.Framework;
using NUnit.Framework;
using OpenQA.Selenium;

namespace BearBot.Infrastructure.Bot.ActionStep
{
    [ActionSteps]
    public class GoToWebsite
    {
        [Given("Go to website $url")]
        public void GoToUrl(string url)
        {
            Chrome.Navigate().GoToUrl(url);
        }

        [Given("Go to website $url with $querystring")]
        public void GoToUrlWithQueryString(string url,string querystring)
        {
            Chrome.Navigate().GoToUrl(string.Format("{0}/?{1}",url, querystring));
        }

        [Then("Title should be $title")]
        public void TitleShouldBe(string title)
        {
            Assert.AreEqual(title, Chrome.Title);
        }

        [Then("Title should contain $title")]
        public void TitleShouldContain(string title)
        {
            Assert.IsTrue(Chrome.Title.Contains(title));
        }

        private IWebDriver Chrome
        {
            get { return (IWebDriver)FeatureContext.Current[ContextKeys.CHROME]; }
        }
    }
}

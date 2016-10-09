using NBehave.Narrator.Framework;
using NBehave.Narrator.Framework.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace BearBot.Infrastructure.Bot.Selenium
{
    [Hooks]
    public class SeleniumHooks
    {
        private IWebDriver driver;

        [BeforeFeature]
        public void SetupFeature()
        {
            try
            {
                driver = new ChromeDriver();
                FeatureContext.Current.Add(ContextKeys.CHROME, driver);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        [AfterFeature]
        public void TearDownFeature()
        {
            if (driver != null)
            {
                driver.Close();
            }
        }
    }

    public static class ContextKeys
    {
        public const string CHROME = "ChromeDriver";
    }
}

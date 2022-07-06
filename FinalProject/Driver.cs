using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;

namespace Framework
{
    public static class Driver
    {
        public static IWebDriver driver;

        public static void setDriver()
        {
            ChromeOptions options = new ChromeOptions();
            //options.AddArgument("--headless");
            options.AddArgument("--start-maximized");
            driver = new ChromeDriver(options);

            driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(10);
        }

        public static IWebDriver getDriver()
        {
            return driver;
        }

        public static void open(string url)
        {
            driver.Url = url;
        }

        public static void takeScreenshot()
        {
            string screenshotPath = $"{AppDomain.CurrentDomain.BaseDirectory}screenshots";
            Directory.CreateDirectory(screenshotPath);

            Screenshot screenshot = ((ITakesScreenshot)Driver.getDriver()).GetScreenshot();
            screenshot.SaveAsFile($"{screenshotPath}\\src-{Guid.NewGuid()}.png", ScreenshotImageFormat.Png);
        }

        public static void closeDriver()
        {
            driver.Quit();
        } 
    }
}

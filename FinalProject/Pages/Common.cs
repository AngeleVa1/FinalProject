using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using SeleniumExtras.WaitHelpers;

namespace Framework.Pages
{
    internal class Common
    {
        public static IWebElement getElement(string locator)
        {
            return Driver.getDriver().FindElement(By.XPath(locator));
        }

        public static void sendKeysToElement(string locator, string keys)
        {
            getElement(locator).SendKeys(keys);
        }

        public static void clickElement(string locator)
        {
            getElement(locator).Click();
        }

        public static string getElementText(string locator)
        {
            return getElement(locator).Text;
        }
        public static void waitForElementToBeVisible(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.getDriver(), TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locator)));
        }

        public static void waitForElementToBeClicable(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.getDriver(), TimeSpan.FromSeconds(25));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(locator)));
        }
    }
}

using Framework.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Pages.Pigu.Lt
{
    public class FirstPageSecondTest
    {
        public static void closeCookieByAccepting()
        {
            string acceptCookieButton = "//*[@class='button agree']";
            Common.waitForElementToBeVisible(acceptCookieButton);
            Common.clickElement(acceptCookieButton);
        }
        public static void navigateToLogInPage()
        {
            string logInButton = "(//*[@class='text'])[4]";
            Common.clickElement(logInButton);
        }

        public static void fillTheForm(string email, string password)
        {
            string eMailField = "(//*[@name='email'])[1]";
            Common.waitForElementToBeVisible(eMailField);
            Common.sendKeysToElement(eMailField, email);
            string passwordField = "(//*[@name='password'])[1]";
            Common.sendKeysToElement(passwordField, password);
        }

        public static void LogIn()
        {
            string logInButton = "//*[@name='login']";
            Common.clickElement(logInButton);
        }

        public static string verifyConnection()
        {
            string actualValue = "(//*[@class='text'])[4]";
            return Common.getElementText(actualValue);
        }
    }
}

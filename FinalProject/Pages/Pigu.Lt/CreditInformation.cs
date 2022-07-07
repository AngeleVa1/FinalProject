using Framework.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Pages.Pigu.Lt
{
    public class CreditInformation
    {
        public static void closeCookieByAccepting()
        {
            string acceptCookieButton = "//*[@class='button agree']";
            Common.waitForElementToBeVisible(acceptCookieButton);
            Common.clickElement(acceptCookieButton);
        }
        public static void informationButton()
        {
            string informationButton = "//*[@class='has-submenu guide-item']";
            Common.clickElement(informationButton);
        }

        public static void moreInformationAboutCredit()
        {
            string moreAboutCredit = "//*[@href='https://pigu.lt/lt/t/mokek_issimoketinai']";
            Common.clickElement(moreAboutCredit);       
        }

        public static string checkAboutCredit()
        {
            string actualResult = "(//*[@style='text-align:justify'])[4]";
            Common.waitForElementToBeVisible(actualResult);
            return Common.getElementText(actualResult); 
        }
    }
}

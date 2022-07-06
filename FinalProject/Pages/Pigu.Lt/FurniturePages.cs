using Framework.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Pages.Pigu.Lt
{
    public class FurniturePages
    {
        public static void closeCookieByAccepting()
        {
            string acceptCookieButton = "//*[@class='button agree']";
            Common.waitForElementToBeVisible(acceptCookieButton);
            Common.clickElement(acceptCookieButton);
        }
        public static void informationButton()
        {
            string informationButton = "//*[@id='fixedHeaderContainer']/div/div/div[2]/ul[2]/li/a";
            Common.clickElement(informationButton);
        }

        public static void moreInformationAboutCredit()
        {
            string moreAboutCredit = "//*[@id='iron_2']/div[1]/div/div/div[3]/a";
            Common.clickElement(moreAboutCredit);       
        }

        public static string checkAboutCredit()
        {
            string actualResult = "//*[@id='textPageContent']/div/h1";
            return Common.getElementText(actualResult); 
        }
    }
}

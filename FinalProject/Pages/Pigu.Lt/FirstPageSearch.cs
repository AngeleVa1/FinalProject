using Framework.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Pages.Pigu.Lt
{
    public class FirstPageSearch
    {
        public static void closeCookieByAccepting()
        {
            string acceptCookieButton = "//*[@class='button agree']";
            Common.clickElement(acceptCookieButton);
        }
        public static void searchItem(string item)
        {
            string searchButtonField = "//*[@id='searchInput']";
            Common.sendKeysToElement(searchButtonField, item);
        }
        public static void pressSearchButton()
        {
            string searchButton = "/html/body/div[1]/div[1]/div/div[1]/div/div/div[3]/div[2]/form/div/button";
            Common.clickElement(searchButton);
        }
        public static void sortByShop()
        {
            string shopCheckButton = "/html/body/div[1]/div[8]/div[1]/section[2]/div/div/div[1]/div[2]/ul/li[2]/ul/li[1]/a/label/div";
            Common.clickElement(shopCheckButton);
        }

        public static void searchForLegoGreatVehicles()
        {
            string legoGreatVehiclesItem = "(//*[@class='image-wrap'])[3]"; 
            Common.clickElement(legoGreatVehiclesItem);
        }

        public static string cheskIfTheRightLegoOpened()
        {
            string actualLego = "//*[@class='product-id']";
            return Common.getElementText(actualLego);
        }


    }
}

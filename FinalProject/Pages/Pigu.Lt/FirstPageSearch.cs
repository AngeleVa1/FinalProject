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
            string searchButton = "//*[@widget-attachpoint='searchBarSubmitButton']";
            Common.clickElement(searchButton);
        }
        public static void sortByShop()
        {
            string shopCheckButton = "(//*[@class='icheckbox icheck-item'])[2]";
            Common.clickElement(shopCheckButton);
        }

        public static void searchForLegoGreatVehicles()
        {
            string legoGreatVehiclesItem = "//*[@rel-widget-id='productBlock39047688']"; 
            Common.clickElement(legoGreatVehiclesItem);
        }

        public static string cheskIfTheRightLegoOpened()
        {
            string actualLego = "//*[@class='product-id']";
            return Common.getElementText(actualLego);
        }


    }
}

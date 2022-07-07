using Framework.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Pages.Pigu.Lt
{
    public class SpecialPricePage
    {
        public static void closeCookieByAccepting()
        {
            string acceptCookieButton = "//*[@class='button agree']";
            Common.clickElement(acceptCookieButton);
        }

        public static void choosePhilipsProposal()
        {
            string philipsItemButton = "(//*[@class='background-banner'])[4]";
            Common.clickElement(philipsItemButton);
        }

        public static void choosePhilipsEP2232()
        {
            string philipsCofeeMachine = "(//*[@class='product-image-container'])[3]";
            Common.clickElement(philipsCofeeMachine);
        }

        public static string CheckIfYouWillGetJacobsCofee()
        {
            string actualProposal = "//*[@id='productPage']/section[1]/div[1]/div[2]/div[3]/div[1]/div[3]/div/a/div/div/div[2]/span";
            return Common.getElementText(actualProposal);
        }
    }
}

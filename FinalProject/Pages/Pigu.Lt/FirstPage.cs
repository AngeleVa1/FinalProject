using Framework.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Pages.Pigu.Lt
{
    public class FirstPage
    {
        public static void searchForSportsItem()
        {
            string sportsItemButton = "//*[@id ='department-431']";
            Common.clickElement(sportsItemButton);
        }

        public static void swimmingPool()
        {
            string freeTimeButton = "//*[@id='categoriesGrid']/div[1]/a/div/img";
            Common.waitForElementToBeVisible(freeTimeButton);
            Common.clickElement(freeTimeButton);
            string swimmingPoolButton = "//*[@id='categoriesGrid']/div[1]/a/div/img"; 
            Common.clickElement(swimmingPoolButton);
        }
        public static void closeCookieByAccepting()
        {
            string acceptCookieButton = "//*[@class='button agree']";
            Common.waitForElementToBeVisible(acceptCookieButton);
            Common.clickElement(acceptCookieButton);
        }

        public static void chooseSwimingPool() { 
            
            string swimmingPool = "//*[@id='categoriesGrid']/div[1]/a/p";
            Common.clickElement(swimmingPool);
            string firstPool = "//*[@id='productBlock29456710']/div/div/div[3]/a/img[1]";
            Common.clickElement(firstPool);
        }

        public static void addToCart()
        {
            string addToCartButton = "//*[@id='productPage']/section[1]/div[1]/div[2]/div[3]/div[6]/div[2]/button";
            Common.clickElement(addToCartButton);
        }

        public static string VerifyIfWasAdded()
        {
            string actualMessage = "//*[@class='add-to-cart-modal-title']";
            return Common.getElementText(actualMessage);
        }

        public static void closeButton()
        {
            string closeButton = "//*[@id='close']";
            Common.clickElement(closeButton);
        }
    }
}

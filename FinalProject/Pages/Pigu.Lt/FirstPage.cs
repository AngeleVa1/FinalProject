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
        public static void closeCookieByAccepting()
        {
            string acceptCookieButton = "//*[@class='button agree']";
            Common.clickElement(acceptCookieButton);
        }
        public static void searchForSportsItem()
        {
            string sportsItemButton = "//*[@id ='department-431']";
            Common.waitForElementToBeClicable(sportsItemButton);
            Common.clickElement(sportsItemButton);
        }

        public static void swimmingPool()
        {
            string freeTimeButton = "//*[@id='categoriesGrid']/div[1]/a/div/img";
            Common.waitForElementToBeVisible(freeTimeButton);
            Common.clickElement(freeTimeButton);
            string swimmingPoolButton = "//*[@id='categoriesGrid']/div[1]/a/div/img"; 
            Common.waitForElementToBeVisible(swimmingPoolButton);
            Common.clickElement(swimmingPoolButton);
            string swimmingPool = "//*[@id='categoriesGrid']/div[1]/a/p";
            Common.waitForElementToBeVisible(swimmingPool);
            Common.clickElement(swimmingPool);
            string firstPool = "//*[@id='productBlock29456710']/div/div/div[3]/a/img[1]";
            Common.clickElement(firstPool);
        }
       

        public static void addToCart()
        {
            string addToCartButton = "//*[@class='btn btn-big-icon-inline btn-green']";
            Common.waitForElementToBeVisible(addToCartButton);
            Common.clickElement(addToCartButton);
        }

        public static string VerifyIfWasAdded()
        {
            string actualMessage = "(//*[@widget-id='cartWidget'])[2]";
            return Common.getElementText(actualMessage);
        }

        public static void closeButton()
        {
            string closeButton = "//*[@id='close']";
            Common.waitForElementToBeVisible(closeButton);
            Common.clickElement(closeButton);
        }
    }
}

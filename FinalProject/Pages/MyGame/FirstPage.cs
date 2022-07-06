using Framework.Pages;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Pages.MyGame
{
    public class FirstPage
    {
        public static void closeCookieByAccepting()
        {
            string acceptCookieButton = "//*[@class='mfn-gdpr-button']";
            Common.waitForElementToBeVisible(acceptCookieButton);
            Common.clickElement(acceptCookieButton);
        }
        public static void navigateToShopPage()
        {
            string shopPageButton = "//*[@id='menu-item-2425']";
            Common.clickElement(shopPageButton);
        }

        public static string verifyShopPage()
        {
            string actualPage = "(//*[@class='category-title'])[2]";
            return Common.getElementText(actualPage);
        }
        public static void sortBy()
        {
            string sortByGamintojasButton = "//*[@id='filter_1427_1']";
            Common.clickElement(sortByGamintojasButton);
            string ErePerezRadioButton = "//*[@id='filter_1427_1_84']";
            Common.clickElement(ErePerezRadioButton);
        }
        public static string getBrandNameAfterSorting()
        {
            string brandName = "//*[@class='active-filter-label']";
            return Common.getElementText(brandName);
        }

        public static void lipstickPagePop()
        {
            string lipstickButton = "(//*[@class='hover_box_wrapper'])[1]";
            Common.clickElement(lipstickButton);
            string lipstickCollorPop = "//*[@data-id='pop']";
            Common.clickElement(lipstickCollorPop);
            string addToBasketButton = "//*[@class='single_add_to_cart_button button alt']";
            Common.waitForElementToBeVisible(addToBasketButton);
            Common.clickElement(addToBasketButton); 
        }

        public static string verifyIfItemWasAdded()
        {
            string actualCheckMessage = "//*[@class='wc-forward']";
            return Common.getElementText(actualCheckMessage);
        }
        public static void lipstickPageCrush() 
        { 
            string lipstickCollorCrush = "//*[@data-id='crush']";
            Common.waitForElementToBeVisible(lipstickCollorCrush);
            Common.clickElement(lipstickCollorCrush);
            string addToBasketButton = "//*[@class='single_add_to_cart_button button alt']";
            Common.waitForElementToBeVisible(addToBasketButton);
            Common.clickElement(addToBasketButton);
        }
        public static void checkYourBag()
        {
            string checkYourBagButton = "(//*[@href='https://mygame.is/krepselis/'])[2]";
            Common.waitForElementToBeClicable(checkYourBagButton);
            Common.clickElement(checkYourBagButton);
        }

        public static string verifyShoppingBag()
        {
            string actualPrice= "//*[@class='cart-subtotal']";
            return Common.getElementText(actualPrice);
        }
        public static void updateTheShoppingBag()
        {
            string deleteButton = "//*[@id='Content']/div/div/div/div[2]/div/div/div/form/table/tbody/tr[2]/td[6]/a/span";
            Common.waitForElementToBeClicable(deleteButton);
            Common.clickElement(deleteButton);
           // string renewShoppingBag = "//*[@name='update_cart']";
           // Common.clickElement(renewShoppingBag);
        }

        public static string checkIfRightLipstickIsLeftInTheBag()
        {
            string actualMessage = "(//*[@href='https://mygame.is/produktas/ere-perez-lupu-blizgis-mango-lip-honey/?attribute_pa_atspalvis=pop'])[2]";
            Common.waitForElementToBeClicable(actualMessage);
            return Common.getElementText(actualMessage);
        }

        public static string CheckIfPriceChanged()
        {
            string actualPriceAfterUpdatingShoppingBag = "//*[@data-title='Suma']";
            Common.waitForElementToBeClicable(actualPriceAfterUpdatingShoppingBag);
            return Common.getElementText(actualPriceAfterUpdatingShoppingBag);
        }

        /*public static void restoreItem()
        {
            string restoreItemButton = "//*[@class='restore-item']";
            Common.waitForElementToBeClicable(restoreItemButton);
            Common.clickElement(restoreItemButton);
        }*/

 
        public static void removeAnotherLipstick()
        {
            string removeButton = "//*[@class='remove button the-icon']";
            Common.waitForElementToBeClicable(removeButton);
            Common.clickElement(removeButton);
        }

        public static string checkIfBagIsEmpty()
        {
            string actualMessageAfterDelete = "(//*[@class='alert_wrapper'])[2]";
            Common.waitForElementToBeVisible(actualMessageAfterDelete);
            return Common.getElementText(actualMessageAfterDelete);
        }

        public static void NavigateToTheShop()
        {
            string navigateToShop = "//*[@href='/parduotuve']";
            Common.clickElement(navigateToShop);
        }

        public static string verifyIfInTheShop()
        {
            string actualLocation = "(//*[@class='category-title'])[2]";
            return Common.getElementText(actualLocation);
        }
       
    }



}

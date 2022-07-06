using FinalProject.Pages.MyGame;
using Framework;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Test.MyGame
{
    public class First
    {
        [SetUp]
        public static void setup()
        {
            Driver.setDriver();
            Driver.open("https://mygame.is");

        }
        [Test]
        public static void addLipsticktoTheBag()
        {
            FirstPage.closeCookieByAccepting();
            FirstPage.navigateToShopPage();
            string expectedPage = "PARDUOTUVĖ";
            string actualPage = FirstPage.verifyShopPage();
            Assert.IsTrue(actualPage.Contains(expectedPage));

            FirstPage.sortBy();
            string expectedBrandName = "Ere Perez";
            string actualBrandName = FirstPage.getBrandNameAfterSorting();
            Assert.IsTrue(actualBrandName.Contains(expectedBrandName));
            FirstPage.lipstickPagePop();
            string expectedCheckMessage = "Peržiūrėti krepšelį";
            string actualCheckMessage = FirstPage.verifyIfItemWasAdded();
            Assert.IsTrue(actualCheckMessage.Contains(expectedCheckMessage));

            FirstPage.lipstickPageCrush();
            FirstPage.checkYourBag();
            string expectedPrice = "56,00€";
            string actualPrice = FirstPage.verifyShoppingBag();
            Assert.IsTrue(actualPrice.Contains(expectedPrice));

            FirstPage.updateTheShoppingBag();
            //string expectedMessage = "Lūpų blizgis „Mango Lip Honey“ – Pop";
            //string actualMessage = FirstPage.checkIfRightLipstickIsLeftInTheBag();
            //Assert.IsTrue(actualMessage.Contains(expectedMessage));
            //string expectedPriceAfterUpdate = "28,00€";
            //string actualPriceAfterUpdate = FirstPage.CheckIfPriceChanged();
            //Assert.IsTrue(actualPriceAfterUpdate.Contains(expectedPriceAfterUpdate));


           // FirstPage.removeAnotherLipstick();
           // string expectedMessageAfterDelete = "Krepšelis dar tuščias.";
           // string actualMessageAfterDelete = FirstPage.checkIfBagIsEmpty();
           // Assert.IsTrue(actualMessageAfterDelete.Contains(expectedMessageAfterDelete));
            FirstPage.NavigateToTheShop();
            string expectedLocation = "Parduotuvė";
            string actualLocation = FirstPage.verifyIfInTheShop();
            Assert.IsTrue(actualLocation.Contains(expectedLocation));  

        /*[Test]
        public static string fillUpForm(){

            string name = "Angelyte";
        string lastName = "Saulyte";
        string address = "Prudo g. 64";
        string city = "Vilnius";
        string state = "Vilniaus";
        string postCode = "2582";
        string phoneNumb = "861860712";
        string ePost = "angele.jasinskaite@gmail.com";
        FirstPage.fillName(name, lastName, address, city, state, postCode, phoneNumb, ePost);}
          //  FirstPage.agreeWithTerms();
            */



        }
    }
}

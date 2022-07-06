using FinalProject.Pages.Pigu.Lt;
using Framework;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Pigu.Lt
{
    public class First
    {
        [SetUp]
        public static void setup()
        {
            Driver.setDriver();
            Driver.open("https://pigu.lt/lt/");

        }
        [Test]
        public static void AddToFavorite()
        {
            FirstPage.searchForSportsItem();
            FirstPage.swimmingPool();
            FirstPage.closeCookieByAccepting();
            FirstPage.chooseSwimingPool();
            FirstPage.addToCart();

            string expectedMessage = "Prekė įtraukta į krepšelį";
            string actualMessage = FirstPage.VerifyIfWasAdded();

            Assert.IsTrue(actualMessage.Contains(expectedMessage));

            FirstPage.closeButton();
        }
    }
}

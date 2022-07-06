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
    public class Furniture
    {
        [SetUp]
        public static void setup()
        {
            Driver.setDriver();
            Driver.open("https://pigu.lt/lt/baldai-baldai-internetu-ir-interjeras");

        }
        [Test]
        public static void checkInformationAboutCredit()
        {
            FurniturePages.closeCookieByAccepting();
            FurniturePages.informationButton();
            FurniturePages.moreInformationAboutCredit();

            string expectedResult = "Prekes įsigykite išsimokėtinai ir už jas mokėkite dalimis!";
            string actualResult = FurniturePages.checkAboutCredit();

            Assert.IsTrue(actualResult.Equals(expectedResult));
        }
    }
}

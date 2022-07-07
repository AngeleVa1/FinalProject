using FinalProject.Pages.Pigu.Lt;
using Framework;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.BaseClasses;

namespace Test.Pigu.Lt
{
    public class Credit : BaseClass
    {
        [SetUp]
        public static void setup()
        {
            Driver.open("https://pigu.lt/lt/baldai-baldai-internetu-ir-interjeras");
        }

        [Test]
        public static void checkInformationAboutCredit()
        {
            CreditInformation.closeCookieByAccepting();
            CreditInformation.informationButton();
            CreditInformation.moreInformationAboutCredit();

            string expectedResult = "Kaip veikia pirkimas išsimokėtinai?";
            string actualResult = CreditInformation.checkAboutCredit();

            Assert.IsTrue(actualResult.Equals(expectedResult));
        }
    }
}

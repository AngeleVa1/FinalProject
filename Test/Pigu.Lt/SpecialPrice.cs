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
    public class SpecialPrice : BaseClass
    {
        [SetUp]
    public static void open()
    {
       
        Driver.open("https://pigu.lt/lt/super/akcijos");

    }
        [Test]
        public static void findPhilipsPage()
        {
            SpecialPricePage.closeCookieByAccepting();
            SpecialPricePage.choosePhilipsProposal();
            SpecialPricePage.choosePhilipsEP2232();

            string expectedProposal = "Jacobs Brazil pupelės DOVANŲ!";
            string actualProposal = SpecialPricePage.CheckIfYouWillGetJacobsCofee();

            Assert.IsTrue(actualProposal.Contains(expectedProposal));

        }
    }
}

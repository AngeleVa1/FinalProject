﻿using FinalProject.Pages.Pigu.Lt;
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
   
    public class First 
    {
        [SetUp]
        public static void setup()
        {
            Driver.setDriver();
            Driver.open("https://pigu.lt/");

        }
        [Test]
        public static void AddToFavorite()
        {
            FirstPage.closeCookieByAccepting();
            FirstPage.searchForSportsItem();
            FirstPage.swimmingPool();
            FirstPage.addToCart();

            string expectedMessage = "Prekė įtraukta į krepšelį";
            string actualMessage = FirstPage.VerifyIfWasAdded();

            Assert.IsTrue(actualMessage.Contains(expectedMessage));

            FirstPage.closeButton();
        }
        [Test]
        public static void LogInPage()
        {
            FirstPageSecondTest.closeCookieByAccepting();
            FirstPageSecondTest.navigateToLogInPage();
            string email = "angele.jasinskaite@gmail.com";
            string password = "Automation1/";
            FirstPageSecondTest.fillTheForm(email, password);
            FirstPageSecondTest.LogIn();

            string expectedValue = "Angele";
            string actualValue = FirstPageSecondTest.verifyConnection();

            Assert.IsTrue(actualValue.Contains(expectedValue));
        }

    }
}

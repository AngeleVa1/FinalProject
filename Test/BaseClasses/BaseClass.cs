using Framework;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System.IO;

namespace Test.BaseClasses
{
    public class BaseClass
    {
        [SetUp]
        public static void setup()
        {
            Driver.setDriver();
            Driver.open("https://pigu.lt");
        }
        
        [TearDown]
        public static void close()
        {
            if (TestContext.CurrentContext.Result.Outcome == ResultState.Failure)
            {
                Driver.takeScreenshot();
            }
            Driver.closeDriver();
        }
    }
}


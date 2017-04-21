using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateFramework;
using UltimateFramework.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    public class AutomationTestingPageOpens : TestBase
    {
        [TestMethod]
        public void RunTest()
        {
            Pages.AutomationTestingPractice.Goto();
            Assert.IsTrue(Pages.AutomationTestingPractice.IsAt());
        }

    }
}

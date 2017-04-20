using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Dynamic;
using OpenQA.Selenium.Support.PageObjects;

namespace UltimateFramework.Pages
{
    public class AutomationTestingPracticePage
    {
        public void Goto()
        {
            Browser.Goto("/automation-practice");
        }

        public bool IsAt()
        {
            return Browser.Title.Contains("Automation Testing Practice");

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Dynamic;
using OpenQA.Selenium.Support.PageObjects;

namespace UltimateFramework.Pages
{
    public static class Pages
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();

            PageFactory.InitElements(Browser.Driver, page);
            return page;
        }

        public static AutomationTestingPracticePage AutomationTestingPractice
        {
            get { return GetPage<AutomationTestingPracticePage>(); }
        }
    }
}

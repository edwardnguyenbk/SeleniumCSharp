﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTest
{
    public class TestScript : TestBase
    {
        [Test]
        public void Sample()
        {
            //TestPage.HomePage.WebDriver.Navigate().GoToUrl(URL);
            TestPage.HomePage.Edit.SendKeys("Hello");
            
           
        }
    }
}

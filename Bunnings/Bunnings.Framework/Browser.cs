﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunnings.Framework
{
    public enum BrowserType
    {
        InternetExplorer,
        Firefox,
        Chrome
    }
    public class Browser
    {
        private readonly IWebDriver _driver;

        public Browser(IWebDriver driver) => _driver = driver;

        public BrowserType Type { get; set; }

        public void GoToUrl(string url)
        {
            DriverContext.Driver.Url = url;
        }
        public void CloseBrowser()
        {
            DriverContext.Driver.Close();
        }
    }
}

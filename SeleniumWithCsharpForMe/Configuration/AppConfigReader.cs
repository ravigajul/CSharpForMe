﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumWithCsharpForMe.Interfaces;
using SeleniumWithCsharpForMe.Settings;

namespace SeleniumWithCsharpForMe.Configuration
{
    public class AppConfigReader : IConfig
    {
        public BrowserType GetBrowser()
        {
            string browser = ConfigurationManager.AppSettings.Get(AppConfigKeys.Browser);
            return (BrowserType) Enum.Parse(typeof(BrowserType), browser);
            
        }

        public string GetPassword()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Password);
        }

        public string GetUserName()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.UserName);
        }
    }
}

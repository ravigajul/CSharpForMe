using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumWithCsharpForMe.Configuration;

namespace SeleniumWithCsharpForMe.Interfaces
{
    public interface IConfig
    {
        BrowserType GetBrowser();
        string GetUserName();
        string GetPassword();
    }
}

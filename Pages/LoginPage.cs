using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCSharpNetCore.Pages
{
    public class LoginPage : DriverHelper
    {
        IWebElement lnkLogin => Driver.FindElement(By.LinkText("UserName"));
        public void ClickLogin() => lnkLogin.Click();

    }
}

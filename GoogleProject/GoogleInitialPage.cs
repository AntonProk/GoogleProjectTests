using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace GoogleProject
{
    class GoogleInitialPage
    {
        [FindsBy(How = How.Id, Using = "gb_70")]
        private IWebElement _login;
      
        [FindsBy(How = How.CssSelector, Using = ".gb_db.gbii")]
        private IWebElement _avatar;
        

        public void clickLoginBtn()
        {
            _login.Click();
        }
        public bool AvatarIsPresent
        {
            get { return _avatar.Displayed; }
        }

        public void clickAvatar()
        {
            _avatar.Click();
        }

    }
}

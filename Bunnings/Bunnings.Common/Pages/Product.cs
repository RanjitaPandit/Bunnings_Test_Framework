

using Bunnings.Framework;
using OpenQA.Selenium;
using System;

namespace Bunnings.Common.Pages
{
     public class Product
    {
        //define the elements
        private IWebElement SearchBar => DriverContext.Driver.FindElement(By.XPath("//*[@id='headerMainMenu']/div[2]/div/div[1]/div/div/input[1]"));
        private IWebElement Item => DriverContext.Driver.FindElement(By.XPath("/html/body/form/div[6]/div/div[2]/div[3]/div/div/section/div[2]/div/div[1]/div[1]/div/section/article[1]/a/div/div[1]"));
        private IWebElement Amount => DriverContext.Driver.FindElement(By.XPath("//*[@id='select2-select-size-container']"));
        private IWebElement Quantity => DriverContext.Driver.FindElement(By.XPath("//*[@id='body_1_ctl01_ucAddLineItemButtons_ucQuantityTextBox']"));
        private IWebElement AddItem => DriverContext.Driver.FindElement(By.XPath("/html/body/form/div[6]/div/div[2]/div[1]/section/div/div[2]/div[4]/div[2]/div[3]/button"));
        private IWebElement WishList => DriverContext.Driver.FindElement(By.XPath("//*[@id='RefreshHeader']/header/div[3]/div/div[2]/ul/li[2]/a"));
        private IWebElement ValidateTextString => DriverContext.Driver.FindElement(By.XPath("/html/body/form/div[4]/div/div[2]/div[1]/section[2]/p[1]/strong"));

        //methods
        public void EnterKeyword()
        {
            SearchBar.Click();
            SearchBar.SendKeys("Paint");
            SearchBar.SendKeys(Keys.Enter);
            // Enter Product Name in Search Bar
        }

        public void SelectProduct()
        {
            Item.Click();

        }

        public void ProductDetails()
        {
            Amount.Click();
            Quantity.Click();
        }

        public void AddItemToWishList()
        {
            AddItem.Click();
        }

        public void ValidateAddedItem()
        {
            WishList.Click();
            DriverContext.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


        }

        public void verify()
        {
           // DriverContext.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
           // Manage().timeouts().implicitlyWait(30, TimeUnit.SECONDS);
            bool AddItemSucess = DriverContext.Driver.FindElement(By.XPath("//*[@id='content - layout_inside - anchor']/div[1]/section[2]/p[1]/strong")).Enabled;

            if (AddItemSucess == true)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("fail");
            }
        }


    }
}

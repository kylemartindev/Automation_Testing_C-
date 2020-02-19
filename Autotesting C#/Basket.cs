using NUnit.Framework;
using OpenQA.Selenium;

using System;


namespace Autotesting_C_{

    class Basket {

        public static IWebDriver driver;

        public void checkbasket(IWebDriver driver) {

             driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
          driver.FindElement(By.XPath("//*[@id='header']/div[3]/div/div/div[3]/div/a")).Click();
          IJavaScriptExecutor js = (IJavaScriptExecutor) driver;
            js.ExecuteScript("window.scrollBy(0,250)", "");
          var totalproducts = driver.FindElement(By.XPath("//*[@id='total_product']")).Text;
          Assert.AreEqual(totalproducts, "$53.00");
         
           var totalprice = driver.FindElement(By.XPath("//*[@id='total_price']")).Text;
          Assert.AreEqual(totalprice,"$55.00");
          



        }

      






    }
}
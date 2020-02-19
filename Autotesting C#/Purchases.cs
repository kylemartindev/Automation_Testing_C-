

using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;


namespace Autotesting_C_{


    class Purchases {
         public static IWebDriver driver;

    public void purchaseblouse(IWebDriver driver) {
           
          driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
          driver.FindElement(By.LinkText("Home")).Click(); 
          //View Blouse  
          driver.FindElement(By.XPath("//*[@id='homefeatured']/li[2]/div/div[1]/div/a[1]/img")).Click(); 
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            driver.FindElement(By.XPath("//*[@id='add_to_cart']/button/span")).Click();
              WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
             wait.Until(d => d.FindElement(By.XPath("//*[@id='layer_cart']/div[1]/div[2]/div[4]/span/span")));
             driver.FindElement(By.XPath("//*[@id='layer_cart']/div[1]/div[2]/div[4]/span/span")).Click();
             driver.FindElement(By.XPath("//*[@id='columns']/div[1]/a[1]")).Click(); 
    }

    

      

        

    public void purchasedress(IWebDriver driver) {

             driver.FindElement(By.XPath("//*[@id='homefeatured']/li[3]/div/div[1]/div/a[1]/img")).Click();
             driver.FindElement(By.XPath("//*[@id='add_to_cart']/button/span")).Click();
            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
            wait2.Until(d => d.FindElement(By.XPath("//*[@id='layer_cart']/div[1]/div[2]/div[4]/span/span")));
            driver.FindElement(By.XPath("//*[@id='layer_cart']/div[1]/div[2]/div[4]/span/span")).Click();


    }




    }
}
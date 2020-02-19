using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;

namespace Autotesting_C_{

    class Checkout {

        public static IWebDriver driver;
        public void checkoutgoods(IWebDriver driver) {
            //proceed to checkout button
            driver.FindElement(By.XPath("//*[@id='center_column']/p[2]/a[1]/span")).Click();
            //confirm address
             driver.FindElement(By.XPath("//*[@id='center_column']/form/p/button/span")).Click();
             //Click on agree terms
              driver.FindElement(By.XPath("//*[@id='uniform-cgv']")).Click();
              driver.FindElement(By.XPath("//*[@id='form']/p/button/span")).Click();
              //click on bankwire
                 driver.FindElement(By.XPath("//*[@id='HOOK_PAYMENT']/div[1]/div/p/a")).Click();
                //confirm order
                driver.FindElement(By.XPath("//*[@id='cart_navigation']/button/span")).Click();
                var orderconfirmation = driver.FindElement(By.XPath("//*[@id='center_column']/h1"));
                Assert.IsTrue(orderconfirmation.Displayed);
                

                
            }

            public void saveorderreftoile(IWebDriver driver){
                var strLogText = driver.FindElement(By.XPath("//*[@id='center_column']/div")).Text;
                string test = strLogText.Remove(0, 222);
                 string test2 = test.Remove(10);
// Create a writer and open the file:
        StreamWriter log;

        if (!File.Exists("C:\\Users\\Max\\orderref.txt"))
        {
     log = new StreamWriter("C:\\Users\\Max\\orderref.txt");
        }
        else
        {
     log = File.AppendText("C:\\Users\\Max\\orderref.txt");
        }

    // Write to the file:
    log.WriteLine(DateTime.Now);
    log.WriteLine(test2);
    log.WriteLine();

  // Close the stream:
 log.Close();
  StreamWriter log1;

        if (!File.Exists("C:\\Users\\Max\\fullorderdetails.txt"))
        {
     log1 = new StreamWriter("C:\\Users\\Max\\fullorderdetails.txt");
        }
        else
        {
     log1 = File.AppendText("C:\\Users\\Max\\fullorderdetails.txt");
        }

    // Write to the file:
    log1.WriteLine(DateTime.Now);
    log1.WriteLine(strLogText);
    log1.WriteLine();

  // Close the stream:
 log1.Close();
          
    }
}
}

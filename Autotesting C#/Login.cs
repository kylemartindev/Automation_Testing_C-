using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
namespace Autotesting_C_{


class Login {

public IWebDriver driver;


public void signin(IWebDriver driver) {
  driver.FindElement(By.XPath("//*[@id='header']/div[2]/div/div/nav/div[1]/a")).Click();
  WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
  wait2.Until(d => d.FindElement(By.XPath("//*[@id='layer_cart']/div[1]/div[2]/div[4]/span/span")));
 driver.FindElement(By.Id("email")).SendKeys("kyle.martin3@gmail.com");
 driver.FindElement(By.Id("passwd")).SendKeys("testing1234");
driver.FindElement(By.XPath("//*[@id='SubmitLogin']")).Click();
}
        

  }

}



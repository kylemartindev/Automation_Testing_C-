using System;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Autotesting_C_{

 class Validation {

 public static IWebDriver driver;

public void checksigninvalidation(IWebDriver driver) {

 //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
driver.FindElement(By.XPath("//*[@id='header']/div[2]/div/div/nav/div[1]/a")).Click();
driver.FindElement(By.Id("email")).SendKeys("kylemgmail.com");
//  driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
var alert = driver.FindElement(By.XPath("//*[@id='center_column']/div[1]/ol/li")).GetAttribute("value");

Assert.Equals(alert,"Invalid Email Address");


}




 }



}



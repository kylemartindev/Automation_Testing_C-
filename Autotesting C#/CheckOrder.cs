using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

using System.IO;
using System.Linq;

namespace Autotesting_C_{
class Checkorder{
public static IWebDriver driver;

public void findorderonline(IWebDriver driver) {

driver.FindElement(By.XPath("//*[@id='header']/div[2]/div/div/nav/div[1]/a/span")).Click();
driver.FindElement(By.XPath("//*[@id='center_column']/div/div[1]/ul/li[1]/a/span")).Click();
var orderreference = driver.FindElement(By.XPath("//*[@id='order-list']/tbody/tr[1]/td[1]/a")).Text;

string fileName = "C:\\Users\\Max\\orderref.txt";
//var lastLine = File.ReadAllLines(fileName);
 string data = File.ReadAllText(fileName).Replace("\r\n\r\n", "\r\n");            
            //File.Delete("test.txt");
            File.WriteAllText("C:\\Users\\Max\\orderref2.txt", data);
 string newFile =  "C:\\Users\\Max\\orderref2.txt";          
foreach(var line in File.ReadLines(newFile).Reverse().Take(1)) {
Assert.AreEqual(line,orderreference);
File.Delete(newFile);

}








}


}


}
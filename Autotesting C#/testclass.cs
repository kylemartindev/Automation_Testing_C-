using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using System;
using System.IO;

namespace Autotesting_C_
{

    class testclass {

 public static IWebDriver driver;
  public static ExtentReports extent;
      public static ExtentTest test;
      
        [OneTimeSetUp]
		public void startBrowser()
        {

            string chromeDriverDirectory = "C:\\Users\\Max";
            //Setting up chrome driver for one instance only
            ChromeOptions options = new ChromeOptions();
             options.AddArgument("no-sandbox");
             driver = new ChromeDriver(chromeDriverDirectory, options, 
            TimeSpan.FromMinutes(2));
        
        //  ChromeDriver driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options, TimeSpan.FromMinutes(3));
        //  driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(30));
       //Setting up reports
        extent = new ExtentReports();
        var dir = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug","");
        DirectoryInfo di = Directory.CreateDirectory("C:\\Users\\Max\\Autotesting C#");
        var htmlReporter = new ExtentV3HtmlReporter(dir +"\\Reporting" + "\\AutoReport" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".html");
        extent.AddSystemInfo("User Name", "Kyle Martin");
        extent.AttachReporter(htmlReporter);

         driver.Url = "http://automationpractice.com";
        }
        [SetUp]
        //Getting test names from the method names
        public void getTestname() {
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name);

        }

       
        [Test]
        //login
        //Steps are in login.cs
        public void test1_login() {
        
        Login sign = new Login(); 
        
        sign.signin(driver);
        

        }

        [Test]
        //Viewing the products
        //All steps are in Purchases
        public void test2_purchase1() {
            Purchases shop = new Purchases(); 
    
            shop.purchaseblouse(driver);

        }

      
        [Test]
        //Purchasing product2 which is the dress in this instance
        //All steps are in purchase.cs file
        public void test3_purchase2() {
          Purchases shop = new Purchases();
            shop.purchasedress(driver);
            
        }
        
        [Test]
        //View and checking cart for the products
        //All steps are in Basket.cs file
        public void test4_viewcart() {
           Basket cart = new Basket();
           cart.checkbasket(driver);
            
           

            }

        [Test]
        //Running thrugh the checkout process
        //All steps are in Checkout.cs
        public void test5_checkout() {

         Checkout checkout = new Checkout();
         checkout.checkoutgoods(driver);
         checkout.saveorderreftoile(driver);



        }
        [Test]
        //Checking the order is on the account
        //All steps are in CheckOrder.cs
        public void test6_checkorder() {
        
        Checkorder checkingorder = new Checkorder();
        checkingorder.findorderonline(driver);

        }
        
        




        [TearDown]
        //After running all tests this checks for the status and records them to feedback
public void AfterTest()
{
try
{
var status = TestContext.CurrentContext.Result.Outcome.Status;
var stacktrace = "" + TestContext.CurrentContext.Result.StackTrace + "";
var errorMessage = TestContext.CurrentContext.Result.Message;
Status logstatus;
switch (status){
case TestStatus.Failed:
logstatus = Status.Fail;

test.Log(logstatus, "Test ended with " + logstatus + " – " + errorMessage);

break;
case TestStatus.Skipped:
logstatus = Status.Skip;
test.Log(logstatus, "Test ended with " + logstatus);
break;
default:
logstatus = Status.Pass;
test.Log(logstatus, "Test ended with " + logstatus);
break;
}
}
catch (Exception e)
{
throw (e);
}
}

        [OneTimeTearDown]
		public void closeBrowser()
        {
            //flushes out the information for reporting to the file
            extent.Flush();
            //quits the driver once tests are all completed
            driver.Quit();
        }

    }


 }



using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Text;
using NUnit.Framework;
using System;

public class EntryPoint
{
    

    public static void Main()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://buggy.justtestit.org");
        // First Test Case
        Register(driver);

        // Second Test Case
        Login(driver);

        //Third Test Case
        Additionalinfo(driver);

        //Fourth Test Case
        Cancelregister(driver);
    }

    public static void Register(IWebDriver driver)
    {

        driver.FindElement(By.CssSelector(".btn.btn-success-outline")).Click();
        string header = driver.FindElement(By.TagName("h2")).Text;
        Assert.AreEqual("Register with Buggy Cars Rating", header);
        driver.FindElement(By.CssSelector("input[name= 'username']")).SendKeys("Janice18");
        driver.FindElement(By.CssSelector("input[name= 'firstName']")).SendKeys("Test18");
        driver.FindElement(By.CssSelector("input[name= 'lastName']")).SendKeys("Purposes18");
        Thread.Sleep(5000);
        driver.FindElement(By.CssSelector("input[id= 'password']")).SendKeys("Testproduct18#");
        Thread.Sleep(2000);
        driver.FindElement(By.CssSelector("input[name= 'confirmPassword']")).SendKeys("Testproduct18#");
        Thread.Sleep(5000);
        driver.FindElement(By.CssSelector(".btn.btn-default")).Click();
        Thread.Sleep(5000);
        driver.Navigate().Back();
    }

    public static void Login(IWebDriver driver)
    {

        driver.FindElement(By.CssSelector("input[name= 'login']")).SendKeys("Janice15");

        Thread.Sleep(1000);
        driver.FindElement(By.CssSelector("input[name= 'password']")).SendKeys("Testproduct15#");


        driver.FindElement(By.CssSelector(".btn.btn-success")).Click();
        Thread.Sleep(2000);



     }
        public static void Additionalinfo(IWebDriver driver)
    {

        driver.FindElement(By.TagName("a.nav-link")).Click();
        Thread.Sleep(2000);
        driver.FindElement(By.CssSelector("input[name= 'age']")).SendKeys("25");
        driver.FindElement(By.CssSelector(".btn.btn-default")).Click();
        Thread.Sleep(2000);
        driver.Navigate().Back();
    }
    public static void Cancelregister(IWebDriver driver)
    {
        driver.FindElement(By.CssSelector(".btn.btn-success-outline")).Click();
        Thread.Sleep(2000);
        driver.FindElement(By.TagName("a")).Click();
        driver.Quit();
    }
}
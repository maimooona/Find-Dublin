using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit;
using NUnit.Framework;

namespace Dublin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IWebDriver driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://www.google.com/maps");
                driver.FindElement(By.Id("searchboxinput")).SendKeys("Dublin");
                driver.FindElement(By.Id("searchbox-searchbutton")).Click();
                Thread.Sleep(10000);
               
                Assert.IsTrue(driver.FindElement(By.XPath("//span[text()='Dublin']")).Displayed);
                
                Console.WriteLine("Dublin location has been found");

               
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
          
        }
    }
}

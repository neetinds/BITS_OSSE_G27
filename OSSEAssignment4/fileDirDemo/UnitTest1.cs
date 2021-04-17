using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SeleniumWindowHndling
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Frame()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://www.uitestpractice.com/Students/Switchto";
            driver.SwitchTo().Frame("iframe_a");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("name")).SendKeys("abc");
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("uitestpractice.com")).Click();
            Thread.Sleep(2000);
            driver.Quit();
        }

        [TestMethod]
        public void PromptAlert()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://www.uitestpractice.com/Students/Switchto";
            driver.FindElement(By.Id("alert")).Click();
            Thread.Sleep(2000);
            string s = driver.SwitchTo().Alert().Text;
            Console.WriteLine(s);
            driver.SwitchTo().Alert().SendKeys("");
            Thread.Sleep(2000);
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);
            driver.Quit();
        }

        [TestMethod]
        public void MultipleWindow()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://www.uitestpractice.com/Students/Switchto";
            Console.WriteLine("Before Click");
            Console.WriteLine("No of windows opened by Seelnium " + driver.WindowHandles.Count);
            foreach(var item in driver.WindowHandles)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Current window is -  " + driver.CurrentWindowHandle);

            driver.FindElement(By.LinkText("Opens in a new window")).Click();
            Console.WriteLine("After Click");
            Console.WriteLine("No of windows opened by Seelnium " + driver.WindowHandles.Count);
            foreach (var item in driver.WindowHandles)
            {
                Console.WriteLine(item);
            }

            driver.SwitchTo().Window(driver.WindowHandles[2]);
            Thread.Sleep(2000);
            Console.WriteLine(driver.FindElement(By.Id("draggable")).Text);
            Thread.Sleep(2000);
            Console.WriteLine("Current window is -  " + driver.CurrentWindowHandle);

            Thread.Sleep(2000);
            driver.Quit();
        }
    }
}

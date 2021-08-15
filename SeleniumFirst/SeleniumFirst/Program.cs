using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;

namespace SeleniumFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            //create the reference for the browser
            IWebDriver driver = new FirefoxDriver();

            //Navigate to google page 
            driver.Navigate().GoToUrl("https://www.google.com/");

            ///find the element
            IWebElement element = driver.FindElement(By.Name("q"));

            //perform ops
            element.SendKeys("executeautomation");

            ///driver.Close();

        }


    }

        
    }


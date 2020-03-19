using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
namespace WebBot
{
    class Program
    {
        
        IWebDriver WebDriverInstance = new ChromeDriver(@"C:\WebDriver\bin");
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"C:\WebDriver\bin");
            Program BaseInstance = new Program();
            BaseInstance.WebDriverInstance.Navigate().GoToUrl("https://www.google.com/search?q=chrome+api&rlz=1C1CHBD_ruRU856RU856&oq=chrome+api&aqs=chrome..69i57j0l7.2065j0j7&sourceid=chrome&ie=UTF-8");
        }
    }
}

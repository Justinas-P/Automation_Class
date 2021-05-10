using HomeWork_3.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3.Test
{
    public class CheckboxDemoTest
    {
        private static IWebDriver _driver;

        [OneTimeSetUp]
        public static void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize(); 
            _driver.Url = "https://www.seleniumeasy.com/test/basic-checkbox-demo.html";
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); 
            /*WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(x => _driver.FindElement(By.Id("at-cv-lightbox-close")).Displayed); 
            _driver.FindElement(By.Id("at-cv-lightbox-close")).Click(); 
            */
        }

        [OneTimeTearDown] 
        public static void TearDown()
        {
           // _driver.Close();
        }

        [TestCase("Success - Check box is checked", TestName = "SingleCheckBoxTest")]
        

        public static void TestOneCheckBox(string result)
        {
            CheckboxDemoPage page = new CheckboxDemoPage(_driver);
            page.CheckSingleCheckbox();
            page.VerifySingleCheckBoxDemoResult(result);
        }

        [TestCase("Uncheck All", TestName = "MultipleCheckBoxTest")]
        public static void TestMultipleCheckBox(string result)
        {
            CheckboxDemoPage page = new CheckboxDemoPage(_driver);
            page.CheckAllMultipleCheckBoxOptions();
            page.VerifyMultipleCheckBoxDemoButtonValue(result);
        }
    }
}

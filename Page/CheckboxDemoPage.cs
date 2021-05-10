using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3.Page
{
    public class CheckboxDemoPage
    {
        private static IWebDriver _driver;

        private IWebElement singleCheckBoxDemoSelect => _driver.FindElement(By.Id("isAgeSelected"));
        private IWebElement singleCheckBoxDemoResult => _driver.FindElement(By.Id("txtAge"));
        private IWebElement multipleCheckBox_1 => _driver.FindElement(By.CssSelector("#easycont > div > div.col-md-6.text-left > div:nth-child(5) > div.panel-body > div:nth-child(3) > label > input"));
        private IWebElement multipleCheckBox_2 => _driver.FindElement(By.CssSelector("#easycont > div > div.col-md-6.text-left > div:nth-child(5) > div.panel-body > div:nth-child(4) > label > input"));
        private IWebElement multipleCheckBox_3 => _driver.FindElement(By.CssSelector("#easycont > div > div.col-md-6.text-left > div:nth-child(5) > div.panel-body > div:nth-child(5) > label > input"));
        private IWebElement multipleCheckBox_4 => _driver.FindElement(By.CssSelector("#easycont > div > div.col-md-6.text-left > div:nth-child(5) > div.panel-body > div:nth-child(6) > label > input"));
        private IWebElement multipleCheckBoxDemoButton => _driver.FindElement(By.Id("check1"));

        public CheckboxDemoPage(IWebDriver webDriver) 
        {
            _driver = webDriver;
        }

        public void CheckSingleCheckbox()
        {
            singleCheckBoxDemoSelect.Click();
        }
        public void VerifySingleCheckBoxDemoResult(string expectedResult)
        {
            Assert.AreEqual(expectedResult, singleCheckBoxDemoResult.Text, "CheckBox is not selected");
        }
        public void CheckAllMultipleCheckBoxOptions()
        {
            multipleCheckBox_1.Click();
            multipleCheckBox_2.Click();
            multipleCheckBox_3.Click();
            multipleCheckBox_4.Click();
        }
        public void VerifyMultipleCheckBoxDemoButtonValue(string expectedResult)
        {
            Assert.AreEqual(expectedResult, multipleCheckBoxDemoButton.Text, "Not all checkboxes selected");
        }
    }
}

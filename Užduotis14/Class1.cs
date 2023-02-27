using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Užduotis14
{
    internal class Class1
    {  
        [Test ]
        public void TextBoxAllInputFields()
        {
            string expectedResult = "Arune";

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/text-box";

            IWebElement InPutFullName = driver.FindElement(By.XPath("//*[@id=\'userName\']"));
            InPutFullName.SendKeys(expectedResult);

            IWebElement buttonSubmit = driver.FindElement(By.XPath("//*[@id=\'userForm\']/div[5]"));
            buttonSubmit.Click();

            IWebElement spanMessage = driver.FindElement(By.XPath("//*[@id=\'output\']"));
            string actualResult = spanMessage.Text;

            driver.Quit();

            Assert.AreEqual(actualResult, expectedResult);


            


        }


    }    }       
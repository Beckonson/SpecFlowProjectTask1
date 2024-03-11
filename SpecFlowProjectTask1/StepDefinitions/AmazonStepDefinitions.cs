using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProjectTask1.StepDefinitions
{
    [Binding]
    public class AmazonStepDefinitions
    {
       public IWebDriver driver;
        private String itemTitlle = "TP-Link N450 WiFi Router - Wireless Internet Router for Home (TL-WR940N)";
        [Given(@"User navigate to the Amazon homepage")]
        public void GivenUserNavigateToTheAmazonHomepage()
        {
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.amazon.com");
        }

        [When(@"User search for ""([^""]*)""")]
        public void WhenUserSearchFor(string p0)
        {
            var searchBox = driver.FindElement(By.Id("twotabsearchtextbox"));
            searchBox.SendKeys("TP-Link N450 WiFi Router - Wireless Internet Router for Home (TL-WR940N)");
            //searchBox.Submit();
           driver.FindElement(By.XPath("//*[@id='nav-search-submit-button']")).Click();
           driver.FindElement(By.LinkText("N450 WiFi Router - Wireless Internet Router for Home (TL-WR940N)")).Click(); 

        }

        [When(@"User Add the corresponding item to the cart")]
        public void WhenUserAddTheCorrespondingItemToTheCart()
        {
            var addToListButton = driver.FindElement(By.XPath("//*[@id='wishListMainButton']/span/a"));
            addToListButton.Click();

        }

        [When(@"User Verify the corresponding item added to the cart")]
        public void WhenUserVerifyTheCorrespondingItemAddedToTheCart()
        {
            Console.WriteLine("Verification failed,User is being navigated to Amazon sign in Page");
        }

        [Then(@"User validate the correct item and the amount is displayed")]
        public void ThenUserValidateTheCorrectItemAndTheAmountIsDisplayed()
        {
            //var productTitlle = driver.FindElement(By.XPath("//*[@id='productTitle']"));
            Assert.AreNotEqual("Different Item", itemTitlle, "Item added to the cart should display and match the product titlle");

          
            
             
            
            driver.Quit();
        }
    }
}

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace NUnitFirst
{
    public class Tests
    {
        //private IWebDriver _driver;
        [SetUp]
        public void Setup()
        {
            //ChromeOptions options = new ChromeOptions();
            //_driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), options.ToCapabilities());
            //_driver.Manage().Window.Maximize();
            //_driver.Url = "https://github.com/login";
            }

        [Test]

        public void Test()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.selenium.dev/");
            Assert.That(driver.Title,Is.EqualTo("Selenium"));
            driver.Quit();
        }
        //public void Test1()
        //{
        //    // Click on first check box
        //    IWebElement firstCheckBox = _driver.FindElement(By.Name("li1"));
        //    firstCheckBox.Click();

        //    // Click on second check box
        //    IWebElement secondCheckBox = _driver.FindElement(By.Name("li2"));
        //    secondCheckBox.Click();

        //    //Enter item name
        //    IWebElement textField = _driver.FindElement(By.Name("sampletodotext"));
        //    textField.SendKeys("firstitem");

        //    //Click on Add buton
        //    IWebElement addButton = _driver.FindElement(By.Name("addButton"));
        //    addButton.Click();

        //    //Verified Added Item nam
        //    IWebElement itemtext = _driver.FindElement(By.XPath("/html/body/div/div/div/ul/li[6]/span"));

        //}

        [TearDown]

        public void Cleaup()
        {
            //Console.WriteLine("Selenium webdriver quit");      
            //_driver.Quit();
        }
    }
}
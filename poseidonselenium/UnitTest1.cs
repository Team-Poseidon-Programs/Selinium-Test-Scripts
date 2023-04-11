using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace poseidonselenium;

public class Tests
{
    public IWebDriver driver;

    [SetUp]
    public void Setup()
    {
        Console.WriteLine("started");
        driver = new ChromeDriver();
    }

    [Test]
    public void Test1()
    {
        driver.Navigate().GoToUrl("http://localhost:4200");

        //homepage

        //click services
        driver.FindElement(By.XPath("//a[@class='button']")).Click();
        Console.WriteLine("Navigating To Services Page ");

        //clickdoctor card in services
        driver.FindElement(By.XPath("//a[@class='service-card doc']")).Click();
        Console.WriteLine("Navigating To Doctor Home Page ");




        //Doctor

        //Login
        driver.FindElement(By.XPath("//a[@class='button']")).Click();
        driver.FindElement(By.Id("email")).SendKeys("srinu.orthopaedic@doctor.com");
        driver.FindElement(By.Id("password")).SendKeys("Doctor@123");
        driver.FindElement(By.Id("btn-login")).Click();
        Console.WriteLine("Doctor Login Check Completed");

        //Logout
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        driver.FindElement(By.XPath("//a[@class='button dd']")).Click();
        Console.WriteLine("Doctor Logout Check Completed returning to homepage");



        //click services
        driver.FindElement(By.XPath("//a[@class='button']")).Click();

        //clickdoctor card in services
        driver.FindElement(By.XPath("//a[@class='service-card nur']")).Click();

        //Nurse

        //Login
        driver.FindElement(By.XPath("//a[@class='button nn']")).Click();
        driver.FindElement(By.Id("email")).SendKeys("nurse@nurse.com");
        driver.FindElement(By.Id("password")).SendKeys("Nurse@123");
        driver.FindElement(By.Id("btn-login")).Click();
        Console.WriteLine("Nurse Login Check Completed");

        //Logout
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        driver.FindElement(By.XPath("//a[@class='button nn']")).Click();
        Console.WriteLine("Nurse Logout Check Completed returning to homepage");









        Assert.Pass();
    }
}

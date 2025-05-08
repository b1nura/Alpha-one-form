using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Alpha_One_Form
{
    public class AlphaForm
    {

        static string gmail = "binurayashi@gmail.com";
        public static void Main(string[] args)
        {
            var options = new ChromeOptions();
            options.AddArguments(@"C:\Users\binur\AppData\Local\Google\Chrome\User Data");
            options.AddExcludedArgument("enable-automation");
            options.AddAdditionalOption("useAutomationExtension", false);
            options.AddArgument("--disable-blink-features=AutomationControlled");

            ChromeDriver driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Navigate().GoToUrl("https://tinyurl.com/submit-hw/");

            IWebElement googleGmail = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/c-wiz/div/div[2]/div/div/div[1]/form/span/section/div/div/div[1]/div/div[1]/div/div[1]/input"));
            googleGmail.SendKeys(gmail + Keys.Enter);



        }
    }
}

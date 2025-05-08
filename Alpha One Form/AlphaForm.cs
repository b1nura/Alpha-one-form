using System.Xml.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Alpha_One_Form
{
    public class AlphaForm
    {

        static string gmail = "binuspotify13@gmail.com";
        static string Password = "Bathalaya1";
        public static void Main(string[] args)
        {
            int term = 2;
            
            
            
            
            
            
            var options = new ChromeOptions();
            options.AddArguments(@"C:\Users\binur\AppData\Local\Google\Chrome\User Data");
            options.AddExcludedArgument("enable-automation");
            options.AddAdditionalOption("useAutomationExtension", false);
            options.AddArgument("--disable-blink-features=AutomationControlled");
            

            ChromeDriver driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Navigate().GoToUrl("https://tinyurl.com/submit-hw/");

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            IWebElement txtGoogleGmail = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/c-wiz/div/div[2]/div/div/div[1]/form/span/section/div/div/div[1]/div/div[1]/div/div[1]/input"));
            txtGoogleGmail.SendKeys(gmail + Keys.Enter);

            IWebElement txtGooglePassword = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/c-wiz/div/div[2]/div/div/div/form/span/section[2]/div/div/div[1]/div[1]/div/div/div/div/div[1]/div/div[1]/input"));
            txtGooglePassword.SendKeys(Password + Keys.Enter);


            System.Threading.Thread.Sleep(1000); // 10 seconds (10000 ms)

            IWebElement btnClearForm = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/form/div[2]/div/div[3]/div[1]/div[2]/div/span/span"));
            js.ExecuteScript("arguments[0].scrollIntoView(true);", btnClearForm);
            btnClearForm.Click();

            System.Threading.Thread.Sleep(1000); // 10 seconds (10000 ms)

            IWebElement btnAClearForm = driver.FindElement(By.XPath("/html/body/div[3]/div/div[2]/div[3]/div[2]/span/span"));
            js.ExecuteScript("arguments[0].scrollIntoView(true);", btnAClearForm);
            btnAClearForm.Click();


            System.Threading.Thread.Sleep(1000);

            IWebElement txtAlphaEmail = driver.FindElement(By.XPath("/html/body/div/div[2]/form/div[2]/div/div[2]/div[1]/div/div[1]/div[2]/div[1]/div/div[1]/input"));
            js.ExecuteScript("arguments[0].scrollIntoView(true);", txtAlphaEmail);
            txtAlphaEmail.SendKeys("maladhikary@gmail.com");


            System.Threading.Thread.Sleep(1000);

            IWebElement txtAlphaFirstName = driver.FindElement(By.XPath("/html/body/div/div[2]/form/div[2]/div/div[2]/div[3]/div/div/div[2]/div/div[1]/div/div[1]/input"));
            js.ExecuteScript("arguments[0].scrollIntoView(true);", txtAlphaFirstName);
            txtAlphaFirstName.SendKeys("Binura");

            System.Threading.Thread.Sleep(1000);

            IWebElement txtAlphaLastName = driver.FindElement(By.XPath("/html/body/div/div[2]/form/div[2]/div/div[2]/div[4]/div/div/div[2]/div/div[1]/div/div[1]/input"));
            js.ExecuteScript("arguments[0].scrollIntoView(true);", txtAlphaLastName);
            txtAlphaLastName.SendKeys("Waniga Baduge");

            System.Threading.Thread.Sleep(1000);

            IWebElement txtTutorName = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/form/div[2]/div/div[2]/div[7]/div/div/div[2]/div/div[1]/div/div[1]/input"));
            js.ExecuteScript("arguments[0].scrollIntoView(true);", txtTutorName);
            txtTutorName.SendKeys("Amanda");

            System.Threading.Thread.Sleep(1000);

            IWebElement drpChooseCourse = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/form/div[2]/div/div[2]/div[6]/div/div/div[2]/div/div[1]/div[1]/div[1]"));
            drpChooseCourse.Click();

            System.Threading.Thread.Sleep(1000);

            js.ExecuteScript("arguments[0].scrollIntoView(true);", drpChooseCourse);
            IWebElement optChoseYear10 = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/form/div[2]/div/div[2]/div[6]/div/div/div[2]/div/div[2]/div[7]"));
            optChoseYear10.Click();


            System.Threading.Thread.Sleep(1000);

            IWebElement drpChooseCentre = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/form/div[2]/div/div[2]/div[5]/div/div/div[2]/div/div[1]/div[1]/div[1]"));
            drpChooseCentre.Click();

            System.Threading.Thread.Sleep(1000);

            js.ExecuteScript("arguments[0].scrollIntoView(true);", drpChooseCentre);
            IWebElement optChoseBellaVista = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/form/div[2]/div/div[2]/div[5]/div/div/div[2]/div/div[2]/div[3]"));
            optChoseBellaVista.Click();

            Thread.Sleep(1000);

            IWebElement btnSubmitForm = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/form/div[2]/div/div[3]/div[1]/div[1]/div/span"));

            btnSubmitForm.Click();

            Thread.Sleep(6000);

            IWebElement drpChooseTerm = driver.FindElement(By.XPath("/html/body/div/div[2]/form/div[2]/div/div[2]/div[3]/div/div/div[2]/div/div[1]/div[1]/div[1]"));

            drpChooseTerm.Click();


        }
    }
}

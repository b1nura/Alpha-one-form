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
            var options = new ChromeOptions();
            options.AddArguments(@"C:\Users\binur\AppData\Local\Google\Chrome\User Data");
            options.AddExcludedArgument("enable-automation");
            options.AddAdditionalOption("useAutomationExtension", false);
            options.AddArgument("--disable-blink-features=AutomationControlled");
            

            ChromeDriver driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Navigate().GoToUrl("https://tinyurl.com/submit-hw/");

            IWebElement txtGoogleGmail = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/c-wiz/div/div[2]/div/div/div[1]/form/span/section/div/div/div[1]/div/div[1]/div/div[1]/input"));
            txtGoogleGmail.SendKeys(gmail + Keys.Enter);

            IWebElement txtGooglePassword = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/c-wiz/div/div[2]/div/div/div/form/span/section[2]/div/div/div[1]/div[1]/div/div/div/div/div[1]/div/div[1]/input"));
            txtGooglePassword.SendKeys(Password + Keys.Enter);


            System.Threading.Thread.Sleep(10000); // 10 seconds (10000 ms)



            IWebElement txtAlphaEmail = driver.FindElement(By.XPath("/html/body/div/div[2]/form/div[2]/div/div[2]/div[1]/div/div[1]/div[2]/div[1]/div/div[1]/input"));
            txtAlphaEmail.Clear();
            txtAlphaEmail.SendKeys("maladhikary@gmail.com");


            IWebElement txtAlphaFirstName = driver.FindElement(By.XPath("/html/body/div/div[2]/form/div[2]/div/div[2]/div[3]/div/div/div[2]/div/div[1]/div/div[1]/input"));
            txtAlphaFirstName.Clear();
            txtAlphaFirstName.SendKeys("Binura");

            IWebElement txtAlphaLastName = driver.FindElement(By.XPath("/html/body/div/div[2]/form/div[2]/div/div[2]/div[4]/div/div/div[2]/div/div[1]/div/div[1]/input"));
            txtAlphaLastName.Clear();
            txtAlphaLastName.SendKeys("Waniga Baduge");

            if (driver.FindElements(By.XPath("/html/body/div[1]/div[2]/form/div[2]/div/div[2]/div[5]/div/div/div[2]/div/div[1]/div[1]/div[3]")).Count > 0)
            {
                if (driver.FindElements(By.XPath("/html/body/div[1]/div[2]/form/div[2]/div/div[2]/div[6]/div/div/div[2]/div/div[1]/div[1]/div[7]")).Count > 0)
                {
                    IWebElement txtTutorName = driver.FindElement(By.XPath("/html/body/div/div[2]/form/div[2]/div/div[2]/div[7]/div/div/div[2]/div"));
                    txtTutorName.Clear();
                    txtTutorName.SendKeys("Amanda");
                }
                else
                {
                    IWebElement drpChooseCourse = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/form/div[2]/div/div[2]/div[6]/div/div/div[2]/div/div[1]/div[1]/div[1]"));
                    drpChooseCourse.Click();

                    Thread.Sleep(1000);

                    IWebElement optChoseYear10 = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/form/div[2]/div/div[2]/div[6]/div/div/div[2]/div/div[2]/div[7]"));
                    optChoseYear10.Click();

                    IWebElement txtTutorName = driver.FindElement(By.XPath("/html/body/div/div[2]/form/div[2]/div/div[2]/div[7]/div/div/div[2]/div"));
                    txtTutorName.Clear();
                    txtTutorName.SendKeys("Amanda");
                }

            }
            else
            {
                IWebElement drpChooseCentre = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/form/div[2]/div/div[2]/div[5]/div/div/div[2]/div/div[1]/div[1]/div[1]"));
                drpChooseCentre.Click();

                Thread.Sleep(1000);

                IWebElement optChoseBellaVista = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/form/div[2]/div/div[2]/div[5]/div/div/div[2]/div/div[2]/div[3]"));
                optChoseBellaVista.Click();

                if (driver.FindElements(By.XPath("/html/body/div[1]/div[2]/form/div[2]/div/div[2]/div[6]/div/div/div[2]/div/div[1]/div[1]/div[7]")).Count > 0)
                {
                    IWebElement txtTutorName = driver.FindElement(By.XPath("/html/body/div/div[2]/form/div[2]/div/div[2]/div[7]/div/div/div[2]/div"));
                    txtTutorName.Clear();
                    txtTutorName.SendKeys("Amanda");
                }
                else
                {
                    IWebElement drpChooseCourse = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/form/div[2]/div/div[2]/div[6]/div/div/div[2]/div/div[1]/div[1]/div[1]"));
                    drpChooseCourse.Click();

                    Thread.Sleep(1000);

                    IWebElement optChoseYear10 = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/form/div[2]/div/div[2]/div[6]/div/div/div[2]/div/div[2]/div[7]"));
                    optChoseYear10.Click();

                    IWebElement txtTutorName = driver.FindElement(By.XPath("/html/body/div/div[2]/form/div[2]/div/div[2]/div[7]/div/div/div[2]/div"));
                    txtTutorName.Clear();
                    txtTutorName.SendKeys("Amanda");
                }
            }

        }
    }
}

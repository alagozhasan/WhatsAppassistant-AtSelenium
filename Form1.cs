using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading; 
namespace WhatsAppassistant_AtSelenium
{
    public partial class Form1 : Form
    {
        private IWebDriver driver;

        static bool devam;
        private string Texttbx;

        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_str_text_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl("https://web.whatsapp.com/");
        }

        private void btn_qr_Click(object sender, EventArgs e)
        {
            devam= true;
            btn_run.Enabled = true;

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

            driver.Quit();
            driver.Close();


        }

        private void btn_run_Click(object sender, EventArgs e)
        {

            //int i = 0;



            //WebElement sonmessage = (WebElement)driver.FindElement(By.ClassName("_8nE1Y"));
            //sonmessage.Click();
            //WebElement messagearea = (WebElement)driver.FindElement(By.ClassName("_3Uu1_"));
            //messagearea.Click();
            //messagearea.SendKeys(Text);
            //messagearea.SendKeys(OpenQA.Selenium.Keys.Enter);


            Texttbx = rtbx_metin.Text;

            while (true)
            {
                try
                {
                    
                    WebElement filter = (WebElement)driver.FindElement(By.CssSelector("#side > div._3gYev > div > button > div > span"));
                    filter.Click();
                    List<IWebElement> elements = driver.FindElements(By.ClassName("_8nE1Y")).ToList();
                    WebElement messagearea;
                    Text = rtbx_metin.Text;
                    foreach (IWebElement v in elements)
                    { 
                    Thread.Sleep(5000);
                    v.Click();
                    messagearea = (WebElement)driver.FindElement(By.ClassName("_3Uu1_"));
                    messagearea.Click();
                    messagearea.SendKeys(Texttbx);
                    messagearea.SendKeys(OpenQA.Selenium.Keys.Enter);
                    }

                }catch(Exception ex) { continue; }
                finally
                {
                    driver.Navigate().Refresh();
                    Thread.Sleep((10)*1000);

                }


            } 


        }

        private void help_btn_Click(object sender, EventArgs e)
        {
            string fileName = @"D:\C#_Projects\WhatsAppassistant-AtSelenium\Readme.txt"; 
            System.Diagnostics.Process.Start(fileName); 
        }
    }
    
}

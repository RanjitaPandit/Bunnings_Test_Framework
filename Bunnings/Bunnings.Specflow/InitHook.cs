using Bunnings.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Bunnings.Specflow
{
    [Binding]
    public class InitHook : Base
    {
        public InitHook() : base(BrowserType.Chrome)
        {

        }
        [BeforeScenario]
        public void BeforeScenario()
        {
            InitializeSettings();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //Console.WriteLine("ok~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            CloseBrowser();
        }
    }
}

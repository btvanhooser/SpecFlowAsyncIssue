using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowIssue
{
    [Binding]
    public class BasicSteps
    {
        [Given(@"some basic setup")]
        public void GivenSomeBasicSetup()
        {
            Console.WriteLine("the given");
        }

        [When(@"some basic synchronous action")]
        public void WhenSomeBasicSynchronousAction()
        {
            List<string> list = null;
            list.Where(x => x.Contains("whatever"));
        }

        [When(@"some basic async action")]
        public async Task WhenSomeBasicAsyncAction()
        {
            List<string> list = null;
            list.Where(x => x.Contains("whatever"));
        }

        [Then(@"some basic result")]
        public void ThenSomeBasicResult()
        {
            Console.WriteLine("the then");
        }
    }
}

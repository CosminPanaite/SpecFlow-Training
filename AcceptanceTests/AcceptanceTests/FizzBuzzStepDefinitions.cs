using FizzBuzzProblem.Library;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq.Expressions;
using TechTalk.SpecFlow;

namespace AcceptanceTests
{
    [Binding]
    public class FizzBuzzStepDefinitions
    {
        private List<string> results=new List<string>();
        private List<string> multipleOfNumber = new List<string>();
        

        [Given(@"a user has a range of (.*) numers")]
        public void GivenAUserHasARangeOfNumers(int p0)
        {
            var fizzBuzz = new FizzBuzz();
            results = fizzBuzz.GetValue(p0);

        }

        [When(@"the user tries to print the numbers multiple of (.*) in that range")]
        public void WhenTheUserTriesToPrintTheNumbersMultipleOfInThatRange(string p0)
        {
            
            switch (p0)
            {
                case "3":
                    multipleOfNumber = results.Where(x => x == "Fizz").ToList();
                    break;
                case "5":
                    multipleOfNumber = results.Where(x => x == "Buzz").ToList();

                    break;
                case "3 and 5":
                    multipleOfNumber = results.Where(x => x == "FizzBuzz").ToList();

                    break;
            }
            
        }

        [Then(@"the result is (.*)")]
        public void ThenTheResultItIsCorrect(int p0)
        {
            Assert.AreEqual(multipleOfNumber.Count, p0);
        }
    }
}

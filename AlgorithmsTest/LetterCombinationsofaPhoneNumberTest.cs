using Algorithms;
using Xunit;
using System.Collections.Generic;
namespace AlgorithmsTest
{
    public class LetterCombinationsofaPhoneNumberTest
    {
        [Theory]
        [MemberData("InlineData")]
        public void TestMethod(string digits, IList<string> output)
        {
            Assert.Equal(output, Solution017.LetterCombinations(digits));
        }
        public static IEnumerable<object[]> InlineData
        {
            get
            {
                var driverData = new List<object[]>();
                string digits = "23";
                IList<string> output = new List<string>{
                    "ad", "ae", "af", "bd", "be", "bf","cd", "ce", "cf"
                };
                driverData.Add(new object[] { digits,output });
                
                return driverData;
            }
        }    
    }
}


using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class GroupAnagramsTest
    {
        [Theory]
        [MemberData("InlineData")]
        public void TestMethod(string[] strs, IList<IList<string>> output)
        {
            Assert.Equal(output, Solution049.GroupAnagrams(strs));
        }

        public static IEnumerable<object[]> InlineData
        {
            get
            {
                var driverData = new List<object[]>();
                string[] strs = new []{"eat", "tea", "tan", "ate", "nat", "bat"};
                IList<IList<string>> output = new List<IList<string>>() {
                    new List<string> {"ate", "eat","tea"},
                    new List<string> {"nat","tan"},
                    new List<string> {"bat"}
                };
                driverData.Add(new object[] { strs, output });
                
                return driverData;
            }
        }  
    }
}


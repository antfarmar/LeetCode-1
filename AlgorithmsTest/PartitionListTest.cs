using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class PartitionListTest
    {
        [Theory]
        [InlineData()]
        public void TestMethod(ListNode head, int x, ListNode output)
        {
            Assert.Equal(output, Solution086.Partition(head, x));
        }
    }
}


using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class RemoveDuplicatesfromSortedListIITest
    {
        [Theory]
        [InlineData()]
        public void TestMethod(ListNode head, ListNode output)
        {
            Assert.Equal(output, Solution082.DeleteDuplicates(head));
        }
    }
}


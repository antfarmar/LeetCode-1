using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class RecoverBinarySearchTreeTest
    {
        [Theory]
        [InlineData()]
        public void TestMethod(TreeNode root)
        {
            Solution099.RecoverTree(root);
        }
    }
}


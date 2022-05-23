using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LeetCode.UnitTests
{
    [TestClass]
    public class LeetCodeTesting
    {
        [TestMethod]
        public void TestSmallestMissingPositive()
        {
            //Arrange
            int[] arr = { 1, 3, 2, -10, -20 };
            int arr_size = arr.Length;
            
            //Act
            int missing = SmallestMissingPositive.FindMissing(arr, arr_size);

            //Assert
            Assert.AreEqual(4, missing);
        }

        [TestMethod]
        public void TestLargestDistanceBetweenBlocks()
        {
            int[] arr = { 1, 5, 5, 2, 6 };
            int answer = FrogBlocks.LargestDistanceBetweenBlocks(arr);
            Assert.AreEqual(4, answer);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaximumLibrary;

namespace MaximumOfMinimumsTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void NextSmallerValueIndex_Test1()
        {
            int[] testArray = { 10, 20, 30, 50, 10, 70, 30 };
            int[] expectedResult = { 7, 4, 4, 4, 7, 6, 7 };

            CollectionAssert.AreEqual(expectedResult, Calculate.NextSmallerValueIndex(testArray.Length, testArray));
        }

        [TestMethod]
        public void NextSmallerValueIndex_Test2()
        {
            int[] testArray = { 50, 40, 30, 20, 10, 20, 30 };
            int[] expectedResult = { 1, 2, 3, 4, 7, 7, 7 };

            CollectionAssert.AreEqual(expectedResult, Calculate.NextSmallerValueIndex(testArray.Length, testArray));
        }

        [TestMethod]
        public void PreviousSmallerValueIndex_Test1()
        {
            int[] testArray = { 10, 20, 30, 50, 10, 70, 30 };
            int[] expectedResult = { -1, 0, 1, 2, -1, 4, 4 };

            CollectionAssert.AreEqual(expectedResult, Calculate.PreviousSmallerValueIndex(testArray.Length, testArray));
        }

        [TestMethod]
        public void PreviousSmallerValueIndex_Test2()
        {
            int[] testArray = { 50, 40, 30, 20, 10, 20, 30 };
            int[] expectedResult = { -1, -1, -1, -1, -1, 4, 5 };

            CollectionAssert.AreEqual(expectedResult, Calculate.PreviousSmallerValueIndex(testArray.Length, testArray));
        }

        [TestMethod]
        public void MaximumOfMinimumsPerWindowSize_Test1()
        {
            int[] testArray = { 10, 20, 30, 50, 10, 70, 30 };
            int[] expectedResult = { 0, 70, 30, 20, 10, 10, 10, 10 };

            CollectionAssert.AreEqual(expectedResult, Calculate.MaximumOfMinimumsPerWindowSize(testArray.Length, testArray));
        }

        int[] longTestArray = { 43, 40, 60, 4, 12, 84, 34, 60, 61, 75, 7, 74, 53, 16, 32, 64, 54, 40, 26,
                76, 45, 96, 96, 75, 60, 74, 54, 36, 0, 19, 52, 68, 12, 87, 5, 42, 24, 52, 96, 37, 47, 51,
                11, 41, 28, 49, 21, 1, 80, 80, 19, 65, 87, 5, 37, 47, 44, 85, 44, 38, 30, 97, 59, 42, 22,
                38, 61, 66, 11, 89, 39, 1, 43, 88, 28, 94, 84, 54, 46, 10, 53, 53, 56, 20, 0, 86, 81, 7,
                49, 57, 97, 38, 8, 57, 7, 49, 91, 69, 19, 89 };

        [TestMethod]
        public void MaximumOfMinimumsPerWindowSize_TestLong()
        {
            int windowSize = 3;
            int expectedResult = 75;

            Assert.AreEqual(expectedResult, Calculate.MaximumOfMinimumsPerWindowSize(longTestArray.Length, longTestArray)[windowSize]);
        }

        [TestMethod]
        public void CalculateMaxOfSegmentMins_Test()
        { 
            int[] testArray = { 1, 2, 3 };
            int segmentLength = 2;
            int expectedResult = 2;

            Assert.AreEqual(expectedResult, Calculate.CalculateMaxOfSegmentMins1(testArray, segmentLength));
            Assert.AreEqual(expectedResult, Calculate.CalculateMaxOfSegmentMins2(testArray, segmentLength));
        }
    }
}

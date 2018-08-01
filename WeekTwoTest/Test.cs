using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeekTwo;

namespace WeekTwoTest
{
    [TestClass]
    public class Test
    {
        Solution solution = new Solution();
        [TestMethod]
        public void ChallengeOneTestOne()
        {
            int[] actual = new int[5] { 3, 8, 9, 7, 6 };
            int[] expected = new int[5] { 9, 7, 6, 3, 8 };
            var result = solution.FirstChallenge(actual, 3);
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ChallengeOneTestTwo()
        {
            int[] actual = new int[3] { 0, 0, 0 };
            int[] expected = new int[3] { 0, 0, 0 };
            var result = solution.FirstChallenge(actual, 1);
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ChallengeOneTestThree()
        {
            int[] actual = new int[4] { 1, 2, 3, 4 };
            int[] expected = new int[4] { 1, 2, 3, 4 };
            var result = solution.FirstChallenge(actual, 4);
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ChallengeTwoTest()
        {
            int[] A = new int[7] { 9, 3, 9, 3, 9, 7, 9 };
            var result = solution.SecondChallenge(A);
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void ChallengeThreeTest()
        {
            var result = solution.ThirdChallenge(10, 85, 30);
            Assert.AreEqual(3, result);
        }
    }
}

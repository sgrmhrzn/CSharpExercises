using System;
using Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeekTwo;

namespace Test
{
    [TestClass]
    public class UnitTest
    {
        Solution solution = new Solution();
        [TestMethod]
        public void CheckUniqueString()
        {
            Unique checkUnique = new Unique();
            var result = checkUnique.CheckIfUnique("ABC");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void ReplaceString()
        {
            ReplaceSpace replaceSpace = new ReplaceSpace();
            var result = replaceSpace.Replace("Mr John Smith");
            Assert.AreEqual("Mr%20John%20Smith", result);
        }

        [TestMethod]
        public void CheckEdit()
        {
            CheckEdit checkEdit = new CheckEdit();
            var editOne = checkEdit.CheckIfEditCanBePerformed("pale", "ple");
            Assert.AreEqual(true, editOne);
            var editTwo = checkEdit.CheckIfEditCanBePerformed("pales", "pale");
            Assert.AreEqual(true, editTwo);
            var editThree = checkEdit.CheckIfEditCanBePerformed("pale", "bale");
            Assert.AreEqual(true, editThree);
            var editFour = checkEdit.CheckIfEditCanBePerformed("pale", "bake");
            Assert.AreEqual(false, editFour);
        }

        [TestMethod]
        public void CheckPermutation()
        {
            Permutation permutation = new Permutation();
            var result = permutation.CheckPermutation("pale", "elap");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void ChallengeOneTestOne()
        {
            int[] actual = new int[5] { 3, 8, 9, 7, 6 };
            int[] expected = new int[5] { 9, 7, 6, 3, 8 };
            var result = solution.RotateArray(actual, 3);
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ChallengeOneTestTwo()
        {
            int[] actual = new int[3] { 0, 0, 0 };
            int[] expected = new int[3] { 0, 0, 0 };
            var result = solution.RotateArray(actual, 1);
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ChallengeOneTestThree()
        {
            int[] actual = new int[4] { 1, 2, 3, 4 };
            int[] expected = new int[4] { 1, 2, 3, 4 };
            var result = solution.RotateArray(actual, 4);
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ChallengeTwoTest()
        {
            int[] A = new int[7] { 9, 3, 9, 3, 9, 7, 9 };
            var result = solution.FindUnpairedDigit(A);
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void ChallengeThreeTest()
        {
            var result = solution.FrogJump(10, 85, 30);
            Assert.AreEqual(3, result);
        }
    }
}

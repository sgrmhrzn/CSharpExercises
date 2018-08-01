using System;
using Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest
    {
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
    }
}

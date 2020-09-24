namespace KatasTests
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Katas.Gretta.Rocha;
    using NUnit.Framework;

    /// <summary>Define test cases for RemoveDuplicatedWords.</summary>
    [TestFixture]
    public class RemoveDuplicateWordsTests
    {
        /// <summary> Test RemoveDuplicateWords with string with duplicated.</summary>
        [Test]
        public void TestRemoveDuplicate01()
        {
            string cadena = new string("alpha beta beta gamma gamma gamma delta alpha beta beta gamma gamma gamma delta");
            string actual_result = RemoveDuplicateWords.RemoveDuplicated(cadena);
            string expected_result = "alpha beta gamma delta";
            Assert.AreEqual(expected_result, actual_result);
        }

        /// <summary> Test RemoveDuplicateWords with  string without duplicted.</summary>
        [Test]
        public void TestRemoveDuplicate02()
        {
            string cadena = new string("alpha beta gamma");
            string actual_result = RemoveDuplicateWords.RemoveDuplicated(cadena);
            string expected_result = "alpha beta gamma";
            Assert.AreEqual(expected_result, actual_result);
        }

        /// <summary> Test RemoveDuplicateWords with empty string.</summary>
        [Test]
        public void TestRemoveDuplicate03()
        {
            string cadena = new string(string.Empty);
            string actual_result = RemoveDuplicateWords.RemoveDuplicated(cadena);
            string expected_result = string.Empty;
            Assert.AreEqual(expected_result, actual_result);
        }
    }
}

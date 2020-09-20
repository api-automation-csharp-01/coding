namespace KatasTests.Gretta.Rocha
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Katas.Gretta.Rocha;
    using NUnit.Framework;

    /// <summary>
    /// Define MostFrequentItem test cases.
    /// </summary>
    [TestFixture]
    public class MostFrequentItemTest
    {
        /// <summary>
        /// Test mostFrequentItem with few elements.
        /// </summary>
        [Test]
        public void TestMostFrequentItem01()
        {
            int[] input = new int[] { 3, -1, -1 };
            int count = MostFrequentItem.GetMostFrequentItemCount(input);
            Assert.AreEqual(2, count);
        }

        /// <summary>
        /// Test mostFrequentItem with several elements.
        /// </summary>
        [Test]
        public void TestMostFrequentItem02()
        {
            int[] input = new int[] { 3, -1, -1, -1, 2, 3, -1, 3, -1, 2, 4, 9, 3 };
            int count = MostFrequentItem.GetMostFrequentItemCount(input);
            Assert.AreEqual(5, count);
        }

        /// <summary>
        /// Test mostFrequentItem with empty array.
        /// </summary>
        [Test]
        public void TestMostFrequentItem03()
        {
            int[] input = new int[] { };
            int count = MostFrequentItem.GetMostFrequentItemCount(input);
            Assert.AreEqual(0, count);
        }

        /// <summary>
        /// Test mostFrequentItem with only one repetitive element.
        /// </summary>
        [Test]
        public void TestMostFrequentItem04()
        {
            int[] input = new int[] { 5, 5, 5, 5, 5, 5, 5 };
            int count = MostFrequentItem.GetMostFrequentItemCount(input);
            Assert.AreEqual(7, count);
        }
    }
}

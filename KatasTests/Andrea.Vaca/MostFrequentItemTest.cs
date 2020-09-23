namespace KatasTests.Andrea.Vaca
{
    using Katas.Andrea.Vaca;
    using NUnit.Framework;

    /// <summary>
    /// Test.
    /// </summary>
    [TestFixture]
    public class MostFrequentItemTest
    {
        /// <summary>
        /// Test Most Frequent Item in a sequence.
        /// </summary>
        [Test]
        public void TestMostFrequentItem01()
        {
            int[] input = new int[] { 3, -1, -1, -1, 2, 3, -1, 3, -1, 2, 4, 9, 3 };
            int output = MostFrequentItem.GetMostFrequentItem(input);
            Assert.AreEqual(5, output);
        }

        /// <summary>
        /// Test Most Frequent Item in a sequence.
        /// </summary>
        [Test]
        public void TestMostFrequentItem02()
        {
            int[] input = new int[] { 3, -1, -1 };
            int output = MostFrequentItem.GetMostFrequentItem(input);
            Assert.AreEqual(2, output);
        }

        /// <summary>
        /// Test Most Frequent Item in an array with only 1 value.
        /// </summary>
        [Test]
        public void TestMostFrequentItem03()
        {
            int[] input = new int[] { 3 };
            int output = MostFrequentItem.GetMostFrequentItem(input);
            Assert.AreEqual(1, output);
        }

        /// <summary>
        /// Test Most Frequent Item for and empty array.
        /// </summary>
        [Test]
        public void TestMostFrequentItem04()
        {
            int[] input = new int[] { };
            int output = MostFrequentItem.GetMostFrequentItem(input);
            Assert.AreEqual(0, output);
        }
    }
}

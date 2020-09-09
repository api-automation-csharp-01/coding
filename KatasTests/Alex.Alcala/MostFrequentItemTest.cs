namespace KatasTests.Alex.Alcala
{
    using Katas.Alex.Alcala;
    using NUnit.Framework;

    /// <summary>
    /// Defines MostFrequentItem test.
    /// </summary>
    [TestFixture]
    public class MostFrequentItemTest
    {
        /// <summary>
        /// Tests MostFrequentItem with an output of five.
        /// </summary>
        [Test]
        public void TestMostFrequentItem01()
        {
            int[] input = new int[] { 3, -1, -1, -1, 2, 3, -1, 3, -1, 2, 4, 9, 3 };
            int output = MostFrequentItem.MostFrequentItemCount(input);
            Assert.AreEqual(5, output);
        }

        /// <summary>
        /// Tests MostFrequentItem with three inputs.
        /// </summary>
        [Test]
        public void TestMostFrequentItem02()
        {
            int[] input = new int[] { 3, -1, -1 };
            int output = MostFrequentItem.MostFrequentItemCount(input);
            Assert.AreEqual(2, output);
        }

        /// <summary>
        /// Tests MostFrequentItem with basic input.
        /// </summary>
        [Test]
        public void TestMostFrequentItemReturnZero()
        {
            int[] collection = { };
            int output = MostFrequentItem.MostFrequentItemCount(collection);
            Assert.AreEqual(0, output);
        }
    }
}
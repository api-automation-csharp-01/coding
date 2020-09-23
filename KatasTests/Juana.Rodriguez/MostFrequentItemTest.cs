namespace KatasTests.Juana.Rodriguez
{
    using Katas.Juana.Rodriguez;
    using NUnit.Framework;

    /// <summary>
    /// Defines intersector test.
    /// </summary>
    [TestFixture]
    public class MostFrequentItemTest
    {
        /// <summary>
        /// Tests most frecuent item with basic input.
        /// </summary>
        [Test]
        public void TestMostFrequentItem01()
        {
            int[] input = new int[] { 3, -1, -1 };
            int output = MostFrequentItem.GetMostFrecuent(input);
            Assert.AreEqual(2, output);
        }

        /// <summary>
        /// Tests most frecuent item with basic input.
        /// </summary>
        [Test]
        public void TestMostFrequentItem02()
        {
            int[] input = new int[] { 3, -1, -1, -1, 2, 3, -1, 3, -1, 2, 4, 9, 3 };
            int output = MostFrequentItem.GetMostFrecuent(input);
            Assert.AreEqual(5, output);
        }

        /// <summary>
        /// Tests most frecuent item with basic input.
        /// </summary>
        [Test]
        public void TestMostFrequentItem03()
        {
            int[] input = new int[] { 3, 3, 3 };
            int output = MostFrequentItem.GetMostFrecuent(input);
            Assert.AreNotEqual(5, output);
        }

        /// <summary>
        /// Tests most frecuent item with basic input.
        /// </summary>
        [Test]
        public void TestMostFrequentItem04()
        {
            int[] input = new int[] { 3, 3, 3 };
            int output = MostFrequentItem.GetMostFrecuent(input);
            Assert.AreEqual(3, output);
        }
    }
}

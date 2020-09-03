namespace KatasTests.Antonio.Rojas
{
    using Katas.Antonio.Rojas;
    using NUnit.Framework;

    /// <summary>
    /// Defines frequent test.
    /// </summary>
    [TestFixture]
    public class FrequentItemTest
    {
        /// <summary>
        /// Tests frequent item with basic input.
        /// </summary>
        [Test]
        public void TestFrequestItem01()
        {
            int[] input = new int[] { 3, -1, -1, -1, 2, 3, -1, 3, -1, 2, 4, 9, 3 };
            int output = FrequentItem.MostFrequentItemCount(input);
            Assert.AreEqual(5, output);
        }
    }
}

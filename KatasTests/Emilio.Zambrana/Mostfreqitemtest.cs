namespace KatasTests.Emilio.Zambrana
{
    using Katas.Emilio.Zambrana;
    using NUnit.Framework;

    /// <summary>
    /// Defines MOST req item test.
    /// </summary>
    [TestFixture]
    public class Mostfreqitemtest
    {
        /// <summary>
        /// Tests freq items with basic input.
        /// </summary>
        [Test]
        public void Test01()
        {
            int[] input = new int[] { 3, -1, -1, -1, 2, 3, -1, 3, -1, 2, 4, 9, 3 };
            int output = MostFreqItems.GetFreqitem(input);
            Assert.AreEqual(5, output);
        }

    }
}

namespace KatasTests.Daniela.Ticona
{
    using Katas.Daniela.Ticona;
    using NUnit.Framework;

    /// <summary>
    /// Test.
    /// </summary>
    public class FindCountofMostFrequentItemTest
    {
        /// <summary>
        /// Tests FindCountofMostFrequentItem with 3 items.
        /// </summary>
        [Test]
        public void FindCountofMostFrequentItem01()
        {
            int[] input = new int[] { 3, -1, -1 };
            int output = FindCountofMostFrequentItem.MostFrequentItemCount(input);
            Assert.AreEqual(2, output);
        }

        /// <summary>
        /// Test Most Frequent Item in a sequence.
        /// </summary>
        [Test]
        public void FindCountofMostFrequentItem02()
        {
            int[] input = new int[] { 3, -1, -1, -1, 2, 3, -1, 3, -1, 2, 4, 9, 3 };
            int output = FindCountofMostFrequentItem.MostFrequentItemCount(input);
            Assert.AreEqual(5, output);
        }

        /// <summary>
        /// Tests FindCountofMostFrequentItem with basic input.
        /// </summary>
        [Test]
        public void FindCountofMostFrequentItem03()
        {
            int[] input = new int[] { 0, 4, 5, 5, 5, 87, 7, 5, 99, 6, 0, 0, 0, 0, 0, 0, 0, 6 };
            int output = FindCountofMostFrequentItem.MostFrequentItemCount(input);
            Assert.AreEqual(8, output);
        }

        /// <summary>
        /// Tests FindCountofMostFrequentItem with 0 items.
        /// </summary>
        [Test]
        public void FindCountofMostFrequentItem04()
        {
            int[] input = new int[] { };
            int output = FindCountofMostFrequentItem.MostFrequentItemCount(input);
            Assert.AreEqual(0, output);
        }

        /// <summary>
        /// Tests FindCountofMostFrequentItem with .
        /// </summary>
        [Test]
        public void FindCountofMostFrequentItem05()
        {
            int[] input = new int[] {3};
            int output = FindCountofMostFrequentItem.MostFrequentItemCount(input);
            Assert.AreEqual(1, output);
        }

        /// <summary>
        /// Tests FindCountofMostFrequentItem without having numbers with more than 1 repetitions.
        /// </summary>
        [Test]
        public void FindCountofMostFrequentItem06()
        {
            int[] input = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            int output = FindCountofMostFrequentItem.MostFrequentItemCount(input);
            Assert.AreEqual(1, output);
        }

    }
}

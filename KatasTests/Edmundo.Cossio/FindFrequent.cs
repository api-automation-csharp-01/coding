namespace KatasTests.Edmundo.Cossio
{
    using Katas.Edmundo.Cossio;
    using NUnit.Framework;

    /// <summary>
    /// Defines The find frequent
    /// </summary>
    public class FindFrequent
    {
        /// <summary>
        /// Find Count of Most Frequent Item in an Array.
        /// </summary>
        [Test]
        public void Test01()
        {
            int[] list = new int[] { 3, -1, -1 };
            int result = MostFrequentItem.MostFrequentItemCount(list);
            Assert.AreEqual(2, result);
        }

        /// <summary>
        /// Find Count of Most Frequent Item in an Array.
        /// </summary>
        [Test]
        public void Test02()
        {
            int[] list = new int[] { 3, -1, -1, -1, 2, 3, -1, 3, -1, 2, 4, 9, 3 };
            int result = MostFrequentItem.MostFrequentItemCount(list);
            Assert.AreEqual(5, result);
        }
    }
}

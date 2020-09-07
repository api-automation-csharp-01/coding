namespace KatasTests.Ariel.Gonzales
{
    using Katas.Ariel.Gonzales;
    using NUnit.Framework;

    /// <summary>
    /// Define Find Count of Most Frequent Item in an Array tests.
    /// </summary>
    [TestFixture]
    public class FindCountOfMostFrequentItemInAnArrayTest
    {
        /// <summary>
        /// Tests FindCountOfMostFrequentItemInAnArray with 0 as input.
        /// </summary>
        [Test]
        public void MostFrequentItemCount_ZeroInput_ReturnZero()
        {
            int[] input = new int[] { };
            int output = FindCountOfMostFrequentItemInAnArray.MostFrequentItemCount(input);
            Assert.AreEqual(0, output);
        }

        /// <summary>
        /// Tests FindCountOfMostFrequentItemInAnArray with Array as input.
        /// </summary>
        [Test]
        public void MostFrequentItemCount_IntArrayInput_ReturnFive()
        {
            int[] input = new int[] { 3, -1, -1, -1, 2, 3, -1, 3, -1, 2, 4, 9, 3 };
            int output = FindCountOfMostFrequentItemInAnArray.MostFrequentItemCount(input);
            Assert.AreEqual(5, output);
        }

        /// <summary>
        /// Tests FindCountOfMostFrequentItemInAnArray with Array as input.
        /// </summary>
        [Test]
        public void MostFrequentItemCount_IntArrayInput_ReturnTwo()
        {
            int[] input = new int[] { 3, -1, -1 };
            int output = FindCountOfMostFrequentItemInAnArray.MostFrequentItemCount(input);
            Assert.AreEqual(2, output);
        }
    }
}

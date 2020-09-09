namespace KatasTests.Rodrigo.Espinoza
{
    using Katas.Rodrigo.Espinoza;
    using NUnit.Framework;

    class FindCountOfMostFrequentItemInAnArrayTest
    {
        /// <summary>
        /// Tests FindCountOfMostFrequentItemInAnArray zero arrays.
        /// </summary>
        [Test]
        public void MostFrequentItemCountReturnZero()
        {
            int[] input = new int[] { };
            int output = FindCountOfMostFrequentItemInAnArray.MostFrequentItemCount(input);
            Assert.AreEqual(0, output);
        }

        /// <summary>
        /// Tests FindCountOfMostFrequentItemInAnArray with a basic input.
        /// </summary>
        [Test]
        public void TestMostFrequentItem()
        {
            int[] input = new int[] { 3, -1, -1, -1, 2, 3, -1, 3, -1, 2, 4, 9, 3 };
            int output = FindCountOfMostFrequentItemInAnArray.MostFrequentItemCount(input);
            Assert.AreEqual(5, output);
        }
    }
}

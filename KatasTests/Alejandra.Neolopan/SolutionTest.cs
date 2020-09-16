namespace KatasTests.Alejandra.Neolopan
{
    using Katas.Alejandra.Neolopan;
    using NUnit.Framework;

    /// <summary>
    /// Set of tests for the katas exercise 1.
    /// </summary>
    [TestFixture]
    public class SolutionTest
    {
        private static readonly object[] BasicTestCases = new object[]
        {
            new object[] { new int[] { }, 0 },
            new object[] { new int[] { 3, -1, -1 }, 2 },
            new object[] { new int[] { 3, -1, -1, -1, 2, 3, -1, 3, -1, 2, 4, 9, 3 }, 5 },
        };

        /// <summary>
        /// Basic test case to assert 3 tests.
        /// </summary>
        /// <param name="test">The input of array of integers.</param>
        /// <param name="expected">The expected value.</param>
        [Test]
        [TestCaseSource(typeof(SolutionTest), "BasicTestCases")]
        public void Basic_Test(int[] test, int expected)
        {
            Assert.AreEqual(expected, MostFrequentItem.MostFrequentItemCount(test));
        }
    }
}

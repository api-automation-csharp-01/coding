namespace KatasTests.Alejandra.Neolopan
{
    using NUnit.Framework;

    /// <summary>
    /// Set of tests for the katas exercise 1.
    /// </summary>
    [TestFixture]
    [Description("Example tests")]
    public class RemoveDuplicatesTest
    {
        /// <summary>
        /// Basic test case to assert 3 tests.
        /// </summary>
        private static readonly object[] BasicTestCases = new object[]
        {
            new object[] { "alpha beta beta gamma gamma gamma delta alpha beta beta gamma gamma gamma delta", "alpha beta gamma delta" },
            new object[] { "alpha beta gamma", "alpha beta gamma" },
        };

        /// <summary>
        /// Test of examples.
        /// </summary>
        /// <param name="input">String to process.</param>
        /// <param name="expected">Result of unique strings.</param>
        [Test]
        [Description("Should handle sample case")]
        [TestCaseSource(typeof(RemoveDuplicatesTest), "BasicTestCases")]
        public void ExampleTest(string input, string expected)
        {
            Assert.That(Katas.Alejandra.Neolopan.RemoveDuplicateWords.RemoveDuplicateWordsMethod(input), Is.EqualTo(expected));
        }
    }
}

namespace KatasTests.Rodrigo.Espinoza
{
    using Katas.Rodrigo.Espinoza;
    using NUnit.Framework;

    /// <summary>
    /// Defines RemoveDuplicateWords test.
    /// </summary>
    [TestFixture]
    public class RemoveDulplicateWordsTest
    {
        /// <summary>
        /// Test RemoveDuplicateWords class with returning a single first words entries.
        /// </summary>
        [Test]
        public void TestRemoveDuplicateWords01()
        {
            string duplicateWords = "alpha beta beta gamma gamma gamma delta alpha beta beta gamma gamma gamma delta";
            Assert.That(
                RemoveDulplicateWords.RemoveDuplicateWords(duplicateWords), Is.EqualTo("alpha beta gamma delta"));
        }

        /// <summary>
        /// Return a single first words entries.
        /// </summary>
        [Test]
        public void TestRemoveDuplicateWords02()
        {
            string duplicateWords = "alpha beta gamma";
            Assert.That(
                RemoveDulplicateWords.RemoveDuplicateWords(duplicateWords), Is.EqualTo("alpha beta gamma"));
        }

        /// <summary>
        /// Return the first color names once.
        /// </summary>
        [Test]
        public void TestRemoveDuplicateWords03()
        {
            string duplicateWords = "red green orange red blue green orange black black orange red";
            Assert.That(
                RemoveDulplicateWords.RemoveDuplicateWords(duplicateWords), Is.EqualTo("red green orange blue black"));
        }
    }
}

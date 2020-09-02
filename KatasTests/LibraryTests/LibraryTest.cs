namespace KatasTests.LibraryTest
{
    using Katas.Library;
    using NUnit.Framework;

    /// <summary>
    /// Defines Library utiliy class unit tests.
    /// </summary>
    [TestFixture]
    public class LibraryTest
    {
        /// <summary>
        /// Tests library flag.
        /// </summary>
        [Test]
        public void TestLibraryValidation()
        {
            Assert.IsTrue(Library.Validate());
        }
    }
}

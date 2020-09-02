namespace KatasTests.Marcos.Lara
{
    using Katas.Marcos.Lara;
    using NUnit.Framework;

    /// <summary>
    /// Defines intersector test.
    /// </summary>
    [TestFixture]
    public class IntersectorTest
    {
        /// <summary>
        /// Tests intersector with basic input.
        /// </summary>
        [Test]
        public void TestIntersector01()
        {
            string[] input = new string[] { "1, 3, 4, 7, 13", "1, 2, 4, 13, 15" };
            string output = Intersector.GetIntersection(input);
            Assert.AreEqual("1,4,13", output);
        }

        /// <summary>
        /// Tests intersector with basic input.
        /// </summary>
        [Test]
        public void TestIntersector02()
        {
            string[] input = new string[] { "1, 3, 9, 10, 17, 18", "1, 4, 9, 10" };
            string output = Intersector.GetIntersection(input);
            Assert.AreEqual("1,9,10", output);
        }
    }
}

namespace KatasTests.Daniela.Ticona
{
    using System;
    using Katas.Daniela.Ticona;
    using NUnit;
    using NUnit.Framework;

   /// <summary>
    /// Test.
    /// </summary>
    public class RemoveDuplicateTests
    {
        /// <summary>
        /// Tests remove dublicates on large string.
        /// </summary>
        [Test]
        public void RemoveDublicatesOnLargeString()
        {
            string cadenaIn = "alpha beta beta gamma gamma gamma delta alpha beta beta gamma gamma gamma delta";
            string cadenaOut = RemoveDuplicate.RemoveDuplicateWords(cadenaIn);
            Console.WriteLine(cadenaOut);
            Assert.AreEqual("alpha beta gamma delta", cadenaOut);
        }

        /// <summary>
        /// Tests remove dublicates on short string.
        /// </summary>
        [Test]
        public void RemoveDublicatesOnShortString()
        {
            string cadenaIn = "Tres gatos miau";
            string cadenaOut = RemoveDuplicate.RemoveDuplicateWords(cadenaIn);
            Console.WriteLine(cadenaOut);
            Assert.AreEqual("Tres gatos miau", cadenaOut);
        }

        /// <summary>
        /// Test Remove duplicates in a string with single word.
        /// </summary>
        [Test]
        public void RemoveDuplicatesInASingleword()
        {
            string cadenaIn = "gato";
            string cadenaOut = RemoveDuplicate.RemoveDuplicateWords(cadenaIn);
            Console.WriteLine(cadenaOut);
            Assert.AreEqual("gato", cadenaOut);
        }
    }
}

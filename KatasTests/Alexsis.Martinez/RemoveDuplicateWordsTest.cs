namespace KatasTests.Alexsis.Martinez
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Katas.Alexsis.Martinez;
    using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Serialization;
    using NUnit.Framework;

    [TestFixture]
    public class RemoveDuplicateWordsTest
    {
        /// <summary>
        /// Remove Duplicate words from case 1.
        /// input = "alpha beta beta gamma gamma gamma delta alpha beta beta gamma gamma gamma delta".
        /// output = "alpha beta gamma delta".
        /// </summary>
        [Test]
        public void DuplicateTest()
        {
            string output = "alpha beta gamma delta";
            string input = "alpha beta beta gamma gamma gamma delta alpha beta beta gamma gamma gamma delta";
            string test = RemoveDuplicateWords.RemoveDuplicateString(input);
            Assert.That(output, Is.EqualTo(test));
        }

        /// <summary>
        /// Remove Duplicate words from case 2.
        /// input = "alpha beta gamma".
        /// output = "alpha beta gamma".
        /// </summary>
        [Test]
        public void SecondDuplicateTest()
        {
            string output = "alpha beta gamma";
            string input = "alpha beta gamma";
            string test = RemoveDuplicateWords.RemoveDuplicateString(input);
            Assert.That(output, Is.EqualTo(test));
        }
    }
}

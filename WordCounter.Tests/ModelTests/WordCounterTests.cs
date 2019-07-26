using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounters.Models;

namespace WordCounters.Tests
{
    [TestClass]
    public class WordCounterTests
    {
        [TestMethod]
        public void WordCounter_GetArray_ArrayWithoutPunct()
        {
            WordCounter testWords = new WordCounter("cat", "The cat is in the cathedral.");
            string[] result = testWords.RemovePunctuation(testWords.Sentence);
            string[] expected = new string[] { "the", "cat", "is", "in", "the", "cathedral", "" };
            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(result[i], expected[i]);
            }

        }
        [TestMethod]
        public void WordCounter_GetCount_CountWordTrue()
        {
            WordCounter testWords = new WordCounter("cat", "The cat is in the cathedral.");
            int result = testWords.CountWords(testWords.RemovePunctuation(testWords.Sentence), testWords.Word);
            Assert.AreEqual(result, 1);
        }
        [TestMethod]
        public void WordCounter_GetCount_CountWordFalse()
        {
            WordCounter testWords = new WordCounter("cat", "The dog is in the cathedral.");
            int result = testWords.CountWords(testWords.RemovePunctuation(testWords.Sentence), testWords.Word);
            Assert.AreEqual(result, 0);
        }
    }
}
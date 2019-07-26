namespace WordCounters.Models
{
    public class WordCounter
    {
        // Get and set words and sentences from User.
        public string Word { get; set; }
        public string Sentence { get; set; }

        // Constructor
        public WordCounter(string word, string sentence)
        {
            Word = word;
            Sentence = sentence;
        }
        // This removes the punctuation between words in sentences, including spaces. It also creates an array that holds individual word items.
        public string[] RemovePunctuation(string sentence)
        {
            string phrase = sentence;
            phrase = phrase.ToLower();
            string[] words = phrase.Split(new char[] { ' ', ',', '.', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '=', '+', '_', '/', '>', '<', '[', ']', '?', '|', '{', '}' });
            return words;
        }
        // This returns the amount of times Word is present within Sentence.
        public int CountWords(string[] words, string word)
        {
            string userWord = word.ToLower();
            int wordCount = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == word)
                {
                    wordCount += 1;
                }
                else
                {
                    wordCount += 0;
                }
            }
            return wordCount;
        }
    }
}
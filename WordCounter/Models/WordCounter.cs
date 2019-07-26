namespace WordCounters.Models
{
    public class WordCounter
    {
        public string Word { get; set; }
        public string Sentence { get; set; }

        public WordCounter(string word, string sentence)
        {
            Word = word;
            Sentence = sentence;
        }
        public string[] RemovePunctuation(string sentence)
        {
            string phrase = sentence;
            phrase = phrase.ToLower();
            string[] words = phrase.Split(new char[] { ' ', ',', '.', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '=', '+', '_', '/', '>', '<', '[', ']', '?', '|', '{', '}' });
            return words;
        }
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
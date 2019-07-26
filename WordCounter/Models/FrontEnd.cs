using WordCounters.Models;
using System;
using System.Threading;

namespace WordCounters.FrontEnd
{
    public class Program
    {
        public static void PrintCenter(string str)
        {
            string stringCenter = str;
            Console.SetCursorPosition((Console.WindowWidth - stringCenter.Length) / 2, Console.CursorTop);
            Console.WriteLine(stringCenter);
            Console.WriteLine();
            Console.SetCursorPosition((Console.WindowWidth - 20) / 2, Console.CursorTop);
        }
        public static void Main()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            PrintCenter("Hello, user. Today we are going to ask you to enter some things into your CONSOLE...");
            Thread.Sleep(1000);
            PrintCenter("First, input a single WORD");
            string userWordInput = Console.ReadLine();
            if (userWordInput.Contains(" "))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                PrintCenter("Input only a single word with no punctuation!");
                Thread.Sleep(2000);
                PrintCenter("Restarting...");
                Thread.Sleep(2000);
                Main();
            }
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.White;
            PrintCenter("You chose to input the word " + userWordInput);
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Green;
            PrintCenter("Now, input a SENTENCE...");
            string userSentenceInput = Console.ReadLine();
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.White;
            PrintCenter("You chose to input the sentence " + userSentenceInput);
            Thread.Sleep(1000);
            WordCounter userConstruction = new WordCounter(userWordInput, userSentenceInput);
            Console.ForegroundColor = ConsoleColor.Green;
            PrintCenter("Do you want me to tell you how many times your WORD is contained in your SENTENCE.");
            PrintCenter("(Yes/No)");
            string userReply = Console.ReadLine();
            userReply = userReply.ToLower();
            if (userReply == "yes")
            {
                Console.ForegroundColor = ConsoleColor.White;
                PrintCenter("You chose " + userReply.ToUpper());
                Thread.Sleep(1000);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Thread.Sleep(1000);
                PrintCenter("Your word is contained within your sentence " + userConstruction.CountWords(userConstruction.RemovePunctuation(userConstruction.Sentence), userConstruction.Word) + " time(s)!");
                Thread.Sleep(1000);
                PrintCenter("Check it for yourself!");
                Thread.Sleep(1000);
                PrintCenter("Your word: " + userConstruction.Word);

                PrintCenter("Your sentence: " + userConstruction.Sentence);

                Thread.Sleep(1000);
                PrintCenter("Would you like to try another sentence?");
                string userReply2 = Console.ReadLine();
                userReply2 = userReply2.ToLower();
                if (userReply2 == "yes")
                {
                    PrintCenter("Starting...");
                    Thread.Sleep(2000);
                    Main();
                }
                else if (userReply2 == "no")
                {
                    PrintCenter("You chose " + userReply2.ToUpper());
                    Thread.Sleep(1000);
                    PrintCenter("Thanks for participating!");
                    Thread.Sleep(2000);
                }

            }
            else if (userReply == "no")
            {
                PrintCenter("You chose " + userReply.ToUpper());
                Thread.Sleep(1000);
                PrintCenter("Thanks for participating!");
                Thread.Sleep(2000);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                PrintCenter("You chose " + userReply.ToUpper());
                Thread.Sleep(1000);
                PrintCenter("Unfortunately, that is not a valid option. Try again!");
                Thread.Sleep(1000);
                PrintCenter("Restarting...");
                Thread.Sleep(2000);
                Main();
            }
        }
    }
}
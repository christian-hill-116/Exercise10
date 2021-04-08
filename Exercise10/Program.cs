using System;

namespace Exercise10
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            int wordCounter = 0;
            // Read the file as one string. Turn string into an array
            string text = System.IO.File.ReadAllText(@"/Users/chill/OneDrive - Grand Canyon University/CST117/Week6/test.txt");
            string[] allWords = text.Split(' ');
            
            foreach (string word in allWords)
            {
                 if (word.EndsWith("e") || word.EndsWith("E") || word.EndsWith("t") || word.EndsWith("T"))
                 {

                     wordCounter++;
                }
               
            }

            // Display the file contents to the console. Variable text is a string.
            Console.WriteLine("There are " + wordCounter + " words that end in t or e.");


            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}

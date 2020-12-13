using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            //This prints 12 random letters from the alphabets
            string[] randomLetters = new string[12];

            for (int i = 0; i < randomLetters.Length; i++)
            {
                int lettersInUnicode = random.Next(65, 90);
                string result = Convert.ToChar(lettersInUnicode).ToString();


                randomLetters[i] = result;
            }

            foreach (var randomLetter in randomLetters)
            {
                Console.Write(randomLetter);
            }
        }
        }
}

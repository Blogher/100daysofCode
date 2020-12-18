using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            //This time the console would print out a string of random chars which would alphanumeric (CAPS + small) with special characters
            //string[] randomPasswords = new string[9];
            string randomPasswords="";

            for (int y = 0; y < 9; y++)
            {
                int capLettersinUnicode = random.Next(101, 132);
                int smallLettersInUnicode = random.Next(141,172);
                int numbersInUnicode = random.Next(60, 71);
                int symbolsInUnicode = random.Next(92, 96);
                
                
                string capLetters = Convert.ToChar(capLettersinUnicode).ToString();
                string smallLetters = Convert.ToChar(smallLettersInUnicode).ToString();
                string numbers = Convert.ToChar(numbersInUnicode).ToString();
                string symbols = Convert.ToChar(symbolsInUnicode).ToString();

                
               randomPasswords += capLetters + smallLetters + numbers + symbols;
            }
            //System.Console.WriteLine(randomPasswords);
            string finalPassword="";
           int i=0;
           while (i<9)
           {
            finalPassword+=randomPasswords[i];
            i++;
           }
           System.Console.WriteLine(finalPassword);
            //  string finalPassword = " ";
            //    foreach (var randomPassword in randomPasswords)
            // {
            //     Console.WriteLine(randomPassword);
            // }


        }
    }
}

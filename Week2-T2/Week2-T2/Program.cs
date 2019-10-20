using System;

namespace Week2_T2
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Palindrome("##$$##");
            //            RemoveDuplicatesFromLinkedList();
            LengthLastString(" gigi Kent");
        }

        static void Palindrome(string word)
        {
            var x = String.Compare(ReverseString(word), word);

            if (x == 0)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not palindrome");
            }
        }

        static void LengthLastString(string words)
        {

            string reverse = ReverseString(words);
            int countWords = 0;
            int countLetters = 0;

            for (int i = 0; i < reverse.Length; i++)
            {
                if (!(words[i] == ' ' && i == 0))
                {
                    if (words[i] == ' ')
                    {
                        countWords++;
                    }
                }

            }

            if (countWords > 0)
            {
                for (int i = 0; i < reverse.Length; i++)
                {
                    if (!(words[i] == ' ' && i == 0))
                    {
                        if (words[i] == ' ')
                        {
                            break;

                        }
                        countLetters++;
                    }

                }
            }
            Console.WriteLine(countLetters);



        }

        static string ReverseString(string word)
        {
            string reverseWord = String.Empty;
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverseWord = reverseWord + word[i];
            }

            return reverseWord;
        }

    }



}

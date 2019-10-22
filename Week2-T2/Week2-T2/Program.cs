using System;

namespace Week2_T2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] i = new int[] { 1, 3, 5, 8, 9, 1, 3, 6, 5, 9, 2, 5, 4, 7, 5, 6, 100, 2, 1, 3, 6, 9, 8, 5, 2, 1, 5 };
            //            Palindrome("##$$##");
            //            RemoveDuplicatesFromLinkedList();
            //            LengthLastString(" gigi Kent");
            //            FindIndexOfAnArray(i, 3);
            //            RemoveElement(i, 5);
            MaximAndMinOfAnArray(i);
            //            RemoveDuplicatesFromLinkedList();
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
        static void FindIndexOfAnArray(int[] arr, int value)
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                {
                    count++;
                }
            }
            int[] index = new int[count];
            int x = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                {
                    index[x] = i;
                    x++;
                }
            }
            Console.Write("For specific value: " + value + " the correspondent index is: ");
            for (int i = 0; i < index.Length; i++)
            {
                if (i == 0)
                {
                    Console.Write(index[i]);
                }
                else if (i == index.Length - 1)
                {
                    Console.Write(", " + index[i] + " ");
                }
                else
                {
                    Console.Write(", " + index[i]);
                }

            }
        }
        static void RemoveElement(int[] arr, int value)
        {

            int[] newArr = new int[arr.Length - 1];

            for (int i = 0; i < arr.Length; i++)
            {
                if (!(i == value || arr[i] == value))
                {
                    newArr[i] = arr[i];
                }
            }


        }
        static void MaximAndMinOfAnArray(int[] arr)
        {
            int[] arr2 = BubbleSort(arr);
            Console.WriteLine("Min: " + arr2[0]);
            Console.WriteLine("Max: " + arr2[arr2.Length - 1]);
        }

        static void RemoveDuplicatesFromLinkedList()
        {

        }


        #region



        public static int[] BubbleSort(int[] a)
        {
            for (int i = 1; i <= a.Length - 1; ++i)
            {
                for (int j = 0; j < a.Length - i; ++j)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
            return a;
        }

        static string ReverseString(string word)
        {
            string reverseWord = String.Empty;
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverseWord += word[i];
            }
            return reverseWord;
        }
        #endregion
    }



}

using System;

namespace Wantsome
{
    class Program
    {
        static void Main(string[] args)
        {
            EvenNumbers(15, 97);
            Console.WriteLine("-------------------");
            divbyt(20, 65);
            Console.WriteLine("-------------------");
            CountNr(1400, 2300);
            Console.WriteLine("-------------------");
            //            GuessANumber();
            Console.WriteLine("-------------------");
            PrintInReverse();
            Console.WriteLine("-------------------");
            PrintNumbersWithout(1, 10, 4, 7);
            Console.WriteLine("-------------------");
            Fibonacci(50);
            Console.WriteLine("-------------------");
            FizzBuzz(1, 1000);
            Console.WriteLine("-------------------");
            int[] i = new int[] { 1, 3, 5, 8, 9, 1, 3, 6, 5, 9, 2, 5, 4, 7, 5, 6, 100, 2, 1, 3, 6, 9, 8, 5, 2, 1, 5 };
            int[] j = new int[] { 2, 5, 4, 7, 5, 6, 2, 1, 3, 6, 9, 8, 5, 2, 1, 5, 20, 9, 100 };
            FreequencyOfEachElement(i);
            Console.WriteLine("-------------------");
            SeparateOddAndEven();
            Console.WriteLine("-------------------");
            CommonElementsBetweenArrays(i, j);
            Console.WriteLine("-------------------");
            StringWithUniqueCharacters("abcdefabcf");
            Console.WriteLine("-------------------");
            SumOfArray(i);
            Console.WriteLine("-------------------");
            RemoveDuplicatesFromLinkedList();
            Console.WriteLine("-------------------");
            PrimeOrNot();
            Console.WriteLine("-------------------");
            Palindrome();
            Console.WriteLine("-------------------");
            SumOfArray(i);
            Console.WriteLine("-------------------");
            AverageValueArray(i);
            Console.WriteLine("-------------------");
            FindIndexOfAnArray(i, 4);
            Console.WriteLine("-------------------");
            FindIndexOfAnArrayFromValue(i, 3);
            Console.WriteLine("-------------------");
            RemoveElement(i, 100, 0);
            Console.WriteLine("-------------------");
            InsertElementToSpecificPosition(i, 6, 25);
            Console.WriteLine("-------------------");
            MaximAndMinOfAnArray();
            Console.WriteLine("-------------------");
            CoppyElementFromOneArrayToAnother(i);

        }

        /// <summary>Print to console all even numbers between 15 and 97.</summary>
        /// <param name="nr1">The NR1.</param>
        /// <param name="nr2">The NR2.</param>
        /// 
        static void EvenNumbers(int nr1, int nr2)
        {
            for (int i = nr1; i <= nr2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        /// <summary>Print all numbers divisible by 3 between 20 and 65.</summary>
        /// <param name="nr1">The NR1.</param>
        /// <param name="nr2">The NR2.</param>
        static void divbyt(int nr1, int nr2)
        {
            for (int i = nr1; i <= nr2; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        /// <summary>Count all numbers divisible by 7 and multiple of 5, from 1400 to 2300 and print the result to console</summary>
        /// <param name="nr1">The NR1.</param>
        /// <param name="nr2">The NR2.</param>
        static void CountNr(int nr1, int nr2)
        {
            var count = 0;
            for (int i = nr1; i <= nr2; i++)
            {
                if (i % 7 == 0 || i % 5 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        /// <summary>Write a program to guess a number between 1 and 10. To generate a random
        /// number, use Random class from .NET Framework.</summary>
        static void GuessANumber()
        {
            int yourNumber = 0;
            Console.WriteLine("Enter your number");
            yourNumber = int.Parse(Console.ReadLine());
            int x = new Random().Next(1, 10);

            if (yourNumber == x)
            {
                Console.WriteLine("You guessed the number");
                Console.WriteLine(x);
            }
            else if (yourNumber > x)
            {
                Console.WriteLine("Your number is higher, enter a new number: ");
                Console.WriteLine(x);
                GuessANumber();
            }
            else if (yourNumber < x)
            {
                Console.WriteLine("Your number is lower, enter a new number: ");
                Console.WriteLine(x);
                GuessANumber();
            }
        }

        /// <summary>
        /// Read a text from console and print it reversed.
        /// </summary>
        static void PrintInReverse()
        {
            Console.WriteLine("Enter your text");
            string text = Console.ReadLine();
            for (int i = text.Length - 1; i >= 0; i--)
            {
                Console.Write(text[i]);
            }
        }

        /// <summary>
        /// Print numbers from 1 to 10 except 4 and 7.
        /// </summary>
        /// <param name="nr1">The NR1.</param>
        /// <param name="nr2">The NR2.</param>
        /// <param name="nr3">The NR3.</param>
        /// <param name="nr4">The NR4.</param>
        static void PrintNumbersWithout(int nr1, int nr2, int nr3, int nr4)
        {
            for (int i = nr1; i < nr2; i++)
            {
                if (i == 4 || i == 7)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Print the Fibonacci sequence from 0 to 50. (i.e. Exery next number is found by
        /// adding up those two before it: 0, 1, 1, 2, 3, 5, 8, 13, ...)
        /// </summary>
        /// <param name="nr2">The NR2.</param>
        static void Fibonacci(int nr2)
        {
            int x = 0;
            int a = 0;
            int b = 1;
            int fibnr = 0;

            do
            {
                if (fibnr <= nr2)
                {


                    Console.WriteLine(fibnr);
                    fibnr = a + b;
                    a = b;
                    b = fibnr;
                    x++;

                    if (fibnr > nr2)
                    {
                        break;
                    }

                }
            } while (x <= nr2);

        }

        /// <summary>
        /// FizzBuzz
        /// For all numbers from 1 to 1000, print the following:
        /// - If number is divisible by 3, print Fizz
        /// - If number is divisible by 5, print Buzz
        /// - If number is divisible by 3 and 5, print FizzBuzz
        /// - Otherwise, print the number
        /// </summary>
        /// <param name="nr1">The NR1.</param>
        /// <param name="nr2">The NR2.</param>
        static void FizzBuzz(int nr1, int nr2)
        {

            while (nr1 <= nr2)
            {
                if (nr1 % 3 == 0 && nr1 % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (nr1 % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (nr1 % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(nr1);
                }

                nr1++;
            }

        }

        /// <summary>
        /// Write a program to count the frequency of each element in an array
        /// </summary>
        /// <param name="arr">The arr.</param>
        static void FreequencyOfEachElement(int[] arr)
        {
            int[] freeq = new int[arr.Length];
            int visited = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                int count = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        freeq[j] = visited;
                    }

                }

                if (freeq[i] != visited)
                {
                    freeq[i] = count;
                }

            }
            for (int i = 0; i < freeq.Length; i++)
            {
                if (freeq[i] != visited)
                {
                    Console.WriteLine($"{arr[i]} has {freeq[i]} nr of elements");
                }

            }

        }

        /// <summary>
        /// Read an array from console and separate odd and even values into 2 arrays.
        /// </summary>
        /// <param name="arr">The arr.</param>
        static void SeparateOddAndEven()
        {
            int[] arr = new int[9];
            Console.WriteLine("Add integers to the array");
            int index = 0;
            while (index <= arr.Length - 1)
            {
                Console.WriteLine("Press enter after each integer");

                arr[index] = Convert.ToInt32(Console.ReadLine());
                if (index == 9)
                {
                    break;
                }

                index++;
                Console.WriteLine(index);
            }

            int countOdd = 0;
            int countEven = 0;

            for (int i = 0, j = 0, h = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    countEven++;
                    j++;
                }
                else
                {
                    countOdd++;
                    h++;
                }

            }
            int[] odd = new int[countOdd];
            int[] even = new int[countEven];
            for (int i = 0, j = 0, h = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even[j] = arr[i];
                    j++;
                }
                else
                {
                    odd[h] = arr[i];
                    h++;
                }

            }

            PrintArrays(even);
            PrintArrays(odd);
        }

        /// <summary>
        /// Find common elements between two arrays of integers.
        /// </summary>
        /// <param name="arr1">The arr1.</param>
        /// <param name="arr2">The arr2.</param>
        static void CommonElementsBetweenArrays(int[] arr1, int[] arr2)
        {
            int[] commonElements;
            int count = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr2[j] == arr1[i])
                    {
                        count++;
                    }
                }
            }
            commonElements = new int[count];
            count = 0;
            foreach (var i in arr1)
            {
                foreach (var j in arr2)
                {
                    if (i == j)
                    {
                        commonElements[count] = j;
                        count++;
                    }
                }
            }

            Console.WriteLine("Common elements between");
            PrintArrays(arr1);
            Console.WriteLine("and");
            PrintArrays(arr2);
            Console.WriteLine("are");
            PrintArrays(commonElements);
            FreequencyOfEachElement(commonElements);

        }

        /// <summary>
        /// Implement an algorithm to determine if a string has all unique characters.
        /// </summary>
        /// <param name="mystring">The mystring.</param>
        static void StringWithUniqueCharacters(string mystring)
        {
            bool flag = false;
            for (int i = 0; i < mystring.Length; i++)
            {
                int count = 1;
                for (int j = i + 1; j < mystring.Length; j++)
                {
                    if (mystring[i] == mystring[j])
                    {
                        flag = true;
                        Console.WriteLine("Duplicate character is: " + mystring[i]);
                        break;
                    }

                }
            }

            if (flag)
            {
                Console.WriteLine($"The string '{mystring}' doesn't contain unique characters");
            }
        }

        /// <summary>
        /// Removes the duplicates from linked list.
        /// </summary>
        static void RemoveDuplicatesFromLinkedList()
        {

        }


        /// <summary>
        /// Write a function to check if a number is prime or not.
        /// </summary>
        static void PrimeOrNot()
        {
            int n, i, m = 0, flag = 0;
            Console.Write("Enter the Number to check Prime: ");
            n = int.Parse(Console.ReadLine());
            m = n / 2;
            for (i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    Console.Write("Number is not Prime.");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.Write("Number is Prime.");

        }
        /// <summary>
        /// Check if a word is a palindrome 
        /// </summary>
        static void Palindrome()
        {

        }

        /// <summary>
        /// Sums the of array.
        /// </summary>
        /// <param name="arr">The arr.</param>
        /// <returns></returns>
        static int SumOfArray(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine("Sum = " + sum);
            return sum;
        }

        /// <summary>
        /// Averages the value array.
        /// </summary>
        /// <param name="arr">The arr.</param>
        static void AverageValueArray(int[] arr)
        {
            Console.WriteLine("Average = " + SumOfArray(arr) / arr.Length);
        }

        /// <summary>
        /// Finds the index of an array.
        /// </summary>
        /// <param name="arr">The arr.</param>
        /// <param name="index">The index.</param>
        static void FindIndexOfAnArray(int[] arr, int index)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == index)
                {
                    Console.WriteLine("For specific index: " + index + " the correspondent element is: " + arr[i]);
                    break;
                }
            }
        }

        static void FindIndexOfAnArrayFromValue(int[] arr, int value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                {
                    Console.WriteLine("For specific value: " + value + " the correspondent index is: " + i);
                    break;
                }
            }
        }

        /// <summary>
        /// Removes the element.
        /// </summary>
        static void RemoveElement(int[] arr, int value, int index)
        {
            int el = 0;
            if (value != 0)
            {
                el = value;
            }
            else if (index != 0)
            {
                el = index;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == el || arr[i] == el)
                {
                    Console.WriteLine("element to be removed " + i + " " + arr[i]);
                    arr[i] = 0;
                    break;
                }
            }


        }

        /// <summary>
        /// Inserts the element to specific position.
        /// </summary>
        static void InsertElementToSpecificPosition(int[] arr, int index, int value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == index)
                {
                    arr[i] = value;
                    Console.WriteLine("Value " + value + " inserted at index " + index);
                }
            }
        }

        /// <summary>
        /// Maxims the and minimum of an array.
        /// </summary>
        static void MaximAndMinOfAnArray()
        {

        }

        /// <summary>
        /// Coppies the element from one array to another.
        /// </summary>
        static void CoppyElementFromOneArrayToAnother(int[] arr)
        {
            int[] newArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }
        }
        /// <summary>
        /// Prints the arrays.
        /// </summary>
        /// <param name="arr">The arr.</param>
        static void PrintArrays(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------");
        }

    }
}

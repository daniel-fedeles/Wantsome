using System;

namespace Wantsome
{
    class Program
    {
        static void Main(string[] args)
        {
            //            EvenNumbers(15, 97);
            //            Console.WriteLine("-------------------");
            //            divbyt(20, 65);
            //            Console.WriteLine("-------------------");
            //            CountNr(1400, 2300);
            //            Console.WriteLine("-------------------");
            //            GuessANumber();
            //            Console.WriteLine("-------------------");
            //            PrintInReverse();
            //            Console.WriteLine("-------------------");
            //            PrintNumbersWithout(1, 10, 4, 7);
            //            Console.WriteLine("-------------------");
            //            Fibonacci(50);
            //            Console.WriteLine("-------------------");
            //            FizzBuzz(1, 1000);
            Console.WriteLine("-------------------");
            int[] i = new int[] { 1, 3, 5, 8, 9, 1, 3, 6, 5, 9, 2, 5, 4, 7, 5, 6, 2, 1, 3, 6, 9, 8, 5, 2, 1, 5 };
            //FreequencyOfEachElement(i);
            SeparateOddAndEven(i);


        }
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

        static void CountNr(int nr1, int nr2)
        {
            var count = 0;
            for (int i = nr1; i <= nr2; i++)
            {
                if (i % 7 == 0 || i % 5 == 0)
                {
                    count++;
                    //                    Console.WriteLine(i);
                }
            }
            Console.WriteLine(count);
        }

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

        static void PrintInReverse()
        {
            Console.WriteLine("Enter your text");
            string text = Console.ReadLine();
            for (int i = text.Length - 1; i >= 0; i--)
            {
                Console.Write(text[i]);
            }
        }

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

        static void SeparateOddAndEven(int[] arr)
        {
            int[] odd = new int[arr.Length];
            int[] even = new int[arr.Length];

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

        static void CommonElementsBetweenArrays()
        {

        }

        static void StringWithUniqueCharacters()
        {

        }

        static void RemoveDuplicatesFromLinkedList()
        {

        }

        static void PrimeOrNot()
        {

        }

        static void Palindrome()
        {

        }

        static void PrintArrays(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine("-----------------");
        }

    }
}

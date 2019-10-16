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

        static void FreequencyOfEachElement(int[]arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {

                
            }
        }

        static void SeparateOddAndEven(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {


            }
        }
    }
}

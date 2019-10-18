using System;

namespace week2
{
    class Program
    {
        static void Main(string[] args)
        {
            StartExercices();
        }

        static void StartExercices()
        {



            //Exercitiile de la tema 1.2
            int nr = 0;
            Console.WriteLine("------Choose exercise------");
            Console.WriteLine("---------------------------");
            Console.WriteLine("1. Division, Multiplication, MinAndMax");
            Console.WriteLine("2. Convert from C to F, From F to C, Convert days");


            try
            {
                nr = Int32.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

                if (nr == 1)
                {
                    string letter = "";
                    Console.WriteLine("1. Choose witch operation do you want to use");
                    Console.WriteLine("a. Division");
                    Console.WriteLine("b. Multiplication");
                    Console.WriteLine("c. Minandmax");
                    Console.WriteLine("---------------------------");
                    letter = Console.ReadLine();
                    switch (letter)
                    {
                        case "a":
                            Division();
                            StartExercices();
                            break;
                        case "b":
                            Multiplication();
                            StartExercices();
                            break;
                        case "c":
                            Minandmax();
                            StartExercices();
                            break;

                    }
                }
                else if (nr == 2)
                {
                    string letter = "";
                    Console.WriteLine("2. Choose witch operation do you want to use");
                    Console.WriteLine("d. Convert from F to C");
                    Console.WriteLine("e. Convert from C to F");
                    Console.WriteLine("f. Convert days");
                    Console.WriteLine("---------------------------");
                    letter = Console.ReadLine();
                    switch (letter)
                    {
                        case "d":
                            ConvertFromFtoC();
                            StartExercices();
                            break;
                        case "e":
                            ConvertFromCtoF();
                            StartExercices();
                            break;
                        case "f":
                            ConvertDaysC();
                            StartExercices();
                            break;

                    }
                }
                else if (nr != 1 || nr != 2)
                {
                    StartExercices();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                StartExercices();
            }


        }

        static void Division()
        {
            double nr1 = 0;
            double nr2 = 0;
            double r = 0;

            try
            {
                Console.WriteLine("Read first nr ");
                nr1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Read second nr ");
                nr2 = Int32.Parse(Console.ReadLine());
                if (nr1 == 0 || nr2 == 0)
                {
                    Console.WriteLine("Division by 0 is not possible");
                    Console.WriteLine("---------------------------");
                }
                else
                {
                    r = nr1 / nr2;
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("The division from " + nr1 + " and " + nr2 + " is " + r);
                    Console.WriteLine("---------------------------");
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        static void Multiplication()
        {
            int nr1 = 0;
            int nr2 = 0;

            try
            {
                Console.WriteLine("Read first nr ");
                nr1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Read second nr ");
                nr2 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("---------------------------");
                Console.WriteLine("The multiplication from " + nr1 + " and " + nr2 + " is " + nr1 * nr2);
                Console.WriteLine("---------------------------");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        static void Minandmax()
        {
            int nr1 = 0;
            int nr2 = 0;

            try
            {
                Console.WriteLine("Read first nr ");
                nr1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Read second nr ");
                nr2 = Int32.Parse(Console.ReadLine());
                if (nr1 > nr2)
                {
                    Console.WriteLine("Min And Max between " + nr1 + " and " + nr2 + " is " + nr1);
                }
                else if (nr2 > nr1)
                {
                    Console.WriteLine("Min And Max between " + nr1 + " and " + nr2 + " is " + nr2);
                }
                else if (nr1 == nr2)
                {
                    Console.WriteLine("nr1 " + nr1 + " is = nr2 " + nr2);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        static void ConvertFromCtoF()
        {


            Decimal F = 0;
            Decimal C = 0;
            Console.WriteLine("Read first C ");
            C = Int32.Parse(Console.ReadLine());
            F = C * 5 / 9 + 32;
            Console.WriteLine("F = " + F);


        }

        static void ConvertFromFtoC()
        {
            Decimal F = 0;
            Decimal C = 0;
            Console.WriteLine("Read first F ");
            F = Int32.Parse(Console.ReadLine());
            C = (F - 32) * 5 / 9;
            Console.WriteLine("C = " + C);

        }

        static void ConvertDaysC()
        {
            long days;
            long weeks;
            long months;
            long years;


            Console.WriteLine("Enter days:");
            days = Convert.ToInt32(Console.ReadLine());

            years = (days / 365);
            weeks = (days % 365) / 7;
            months = (days % 365) / 30;
            days = days - ((years * 365) + (weeks * 7));

            Console.WriteLine("Years : " + years);
            Console.WriteLine("months : " + months);
            Console.WriteLine("weeks : " + weeks);
            Console.WriteLine("Days : " + days);

        }
    }
}

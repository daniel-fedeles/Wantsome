using System;

namespace week3.course1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 1, 3, 6, 4, 5, 9, 7, 8, 2, 5, 10, 25, 45, 56, 96, 85, 76, 30, 6, 5 };
            int[] arr2 = { 1, 2, 3, 4, 5, 2, 2, 2, 2, 2, 2, 3, 3 };
            //            SumOfEnevNumbers(arr);
            //            SumOfPearsIsAGivenNumber(arr, 2);
            //            Console.WriteLine(FactorialRecursive(5));
            //            FactorialIterative(5);
            //            FindDuplicatesInArr(arr);
            //            Console.WriteLine(SumOfDigitsOfANumber(36956));
            //            FindThatNumber(arr2);
            //            Anagram("acba", "baca");
            //            Console.WriteLine(Fibonacci(6));
            //            CountBits(123);
            //            RemoveDuplicatesFromString("abccgbhcbfrc");
            //            ArmstrongNumber(371);
            //            PrimeOrNot();
            //            Palindrome(12321);
            //            RotateArrByAPivot(arr, 7);
            //            BubbleSort(arr);
            //            SelectionSort(arr);
            //            Fibonacciz(6);

        }

        static void SumOfEnevNumbers(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sum += arr[i];
                }
            }

            Console.WriteLine(sum);
        }

        static void SumOfPearsIsAGivenNumber(int[] arr, int nr)
        {

            int a = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == nr)
                    {
                        a++;
                    }
                }
            }
            int[] arr2 = new int[a];
            int[] arr3 = new int[a];
            a = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == nr)
                    {
                        arr2[a] = arr[i];
                        arr3[a] = arr[j];
                        a++;
                    }
                }
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i] + " " + arr3[i]);

            }
        }

        static int FactorialRecursive(int nr)
        {

            if (nr == 0)
            {
                return 1;
            }
            else
            {
                return nr * FactorialRecursive(nr - 1);
            }

        }

        static void FactorialIterative(int nr)
        {
            int fact = 1;
            for (int i = 1; i < nr + 1; i++)
            {
                fact = fact * i;
            }

            Console.WriteLine(fact);
        }

        static void FindDuplicatesInArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.Write("Value: " + arr[i] + " " + arr[j] + " ");
                        Console.Write("Index: " + i + " " + j);
                        Console.WriteLine();
                    }
                }
            }
        }

        static int SumOfDigitsOfANumber(int nr)
        {
            if (nr == 0) return 0;
            return (nr % 10 + SumOfDigitsOfANumber(nr / 10));
        }

        static void FindThatNumber(int[] arr)
        {
            int[] arr2 = new int[arr.Length];

            arr2 = FreequencyOfEachElement(arr);

            for (int i = 0; i < arr2.Length; i++)
            {
                if (arr2[i] != -1)
                {
                    if (arr2[i] > arr2.Length / 2)
                        Console.WriteLine($"{arr[i]} is present {arr2[i]} times");
                }

            }

        }

        static void Anagram(string a, string b)
        {
            string tempA = a;
            string tempB = b;
            var aArray = InsertionSort(a.ToLower().ToCharArray());
            var bArray = InsertionSort(b.ToLower().ToCharArray());
            a = new string(aArray);
            b = new string(bArray);
            if (a.Equals(b))
            {
                Console.WriteLine($"String {tempA} and string {tempB} are Anagrams");
            }
            else
            {
                Console.WriteLine($"String {tempA} and string {tempB} are not Anagrams");
            }
        }

        static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i < n - 1; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        static void Fibonacciz(int n)
        {
            int[] arr = new int[n];
            arr[0] = 0;
            arr[1] = 1;
            for (int i = 2; i < n; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }

            Console.WriteLine(arr[n - 1]);
        }

        static void CountBits(int nr)
        {
            string number = IntToBinaryString(nr);
            int cout = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == '1')
                {
                    cout++;
                }
            }
            Console.WriteLine(cout);
        }

        static void RemoveDuplicatesFromString(string word)
        {
            string table = "";

            string result = "";

            foreach (char value in word)
            {
                if (table.IndexOf(value) == -1)
                {
                    table += value;
                    result += value;
                }
            }

            Console.WriteLine(result);

        }

        static void ArmstrongNumber(int nr)
        {
            int temp = nr;
            int cout = 0;
            int r = 0;
            while (temp > 0)
            {
                temp /= 10;
                cout++;
            }
            temp = nr;
            double sum = 0;
            while (nr > 0)
            {
                r = nr % 10;
                sum = sum + Math.Pow(r, cout);
                nr /= 10;

            }
            Console.WriteLine($"sum = {sum}");

            if (sum == temp)
            {
                Console.WriteLine($"The number {temp} is an Armstrong number");
            }
            else
            {
                Console.WriteLine($"The number {temp} is not an Armstrong number");
            }



        }

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

        static void Palindrome(int nr)
        {
            string word = ConvertIntToString(nr);

            var x = String.Compare(ReverseString(word), word);

            if (x == 0)
            {
                Console.WriteLine($"The nr {nr} is Palindrome");
            }
            else
            {
                Console.WriteLine($"The nr {nr} is not palindrome");
            }
        }

        static void RotateArrByAPivot(int[] arr, int nr)
        {
            int[] newArr = new int[arr.Length];
            int i;
            int j = 0;
            for (i = nr + 1; i < arr.Length; i++)
            {
                newArr[j] = arr[i];
                j++;
            }
            for (int k = 0; k < nr; k++)
            {
                if (k == 0)
                {
                    newArr[j] = arr[nr];
                    j++;
                }
                newArr[j] = arr[k];
                j++;
            }
            PrintArrays(newArr);
        }

        static void SelectionSort(int[] arr)
        {
            int min = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                min = i;
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }

                int temp = arr[min];
                arr[min] = arr[i];
                arr[i] = temp;
            }

            PrintArrays(arr);
        }

        static void BubbleSort(int[] a)
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
            PrintArrays(a);
        }

        #region MyRegion
        static void PrintArrays(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------");
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
        static string ConvertIntToString(int nr)
        {
            return Convert.ToString(nr);
        }
        static string IntToBinaryString(int number)
        {
            const int mask = 1;
            var binary = string.Empty;
            while (number > 0)
            {
                // Logical AND the number and prepend it to the result string
                binary = (number & mask) + binary;
                number = number >> 1;
            }

            return binary;
        }
        static char[] InsertionSort(char[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                char key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }

                arr[j + 1] = key;
            }

            return arr;
        }
        static int[] FreequencyOfEachElement(int[] arr)
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
            return freeq;
        }
        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Mca_Console_cal
{
    internal class Program
    {
        static string NORMAL = Console.IsOutputRedirected ? "" : "\x1b[39m";
        static string RED = Console.IsOutputRedirected ? "" : "\x1b[91m";
        static string GREEN = Console.IsOutputRedirected ? "" : "\x1b[92m";
        static string YELLOW = Console.IsOutputRedirected ? "" : "\x1b[93m";
        static string BLUE = Console.IsOutputRedirected ? "" : "\x1b[94m";
        static string MAGENTA = Console.IsOutputRedirected ? "" : "\x1b[95m";
        static string CYAN = Console.IsOutputRedirected ? "" : "\x1b[96m";
        static string GREY = Console.IsOutputRedirected ? "" : "\x1b[97m";
        static void Main(string[] args)
        {
            Console.WriteLine($"{BLUE}First Assignment{NORMAL}");
            Program.Add();
            Program.Avarage();
            Program.Expensive();
            Program.CountGender();
            Program.History();
            Program.Factor();
            Program.Search();
            Program.SecondGreatest();
            Program.RemoveDuplicate();
            Program.FindCommonElement();
            ClassMethod Another = new ClassMethod();
            Another.TestTry();
            Console.ReadLine();
        }
        static void Add()
        {
            int[] transactions = { 200, -150, 340, 500, -100 };
            int sum = 0;
            for (int i = 0; i < transactions.Length; i++)
            {
                sum += transactions[i];
            }
            Console.WriteLine($"{YELLOW}Program  1 :- {NORMAL}{MAGENTA}Sum of array elemnt :{NORMAL} {GREEN}" + sum + $"{NORMAL}");
        }
        static void Avarage()
        {
            float[] scores = { 85.5f, 90.3f, 78.4f, 88.9f, 92.1f };
            float sum = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                sum += scores[i];
            }
            float avg = sum / scores.Length;
            Console.WriteLine($"{RED}Program  2 :-{NORMAL}{CYAN} Avarege of array element :  {NORMAL}{GREEN}" + sum + $"{NORMAL}");
        }
        static void Expensive()
        {
            int[] prices = { 1500, 2300, 999, 3200, 1750 };
            int largest = prices[0];
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] > largest)
                {
                    largest = prices[i];

                }
            }
            Console.WriteLine($"{YELLOW}Program  3 :-{NORMAL}{MAGENTA} Expensive stock : {GREEN}" + largest + $"{NORMAL}");
        }

        static void CountGender()
        {
            int[] participantCodes = { 102, 215, 324, 453, 536 };
            int even = 0, odd = 0;
            for (int i = 0; i < participantCodes.Length; i++)
            {
                if (participantCodes[i] % 2 == 0)
                {
                    even++;
                }
            }
            odd = participantCodes.Length - even;
            Console.WriteLine($"{RED}Program  4 :-{NORMAL}{CYAN} Count Odd Even : {GREEN}" + even + $" {NORMAL} Odd Element is: {GREEN}" + odd + $"{NORMAL}");
        }

        static void History()
        {
            int[] searchHistory = { 101, 202, 303, 404, 505 };
            int[] newArr = new int[searchHistory.Length];
            for (int i = searchHistory.Length - 1; i >= 0; i--)
            {
                newArr[i] = searchHistory[i];
            }
            Console.Write($"{YELLOW}Program  5 :-{NORMAL}{MAGENTA} Reverse Order History  ");
            for (int i = 0; i < newArr.Length; i++)
            {
                Console.Write($"{GREEN} " + newArr[i] + $"{NORMAL}");
            }
            Console.WriteLine();
        }
        static void Factor()
        {
            int[] measurements = { 2, 4, 6, 8 };
            int factor = 3;
            Console.Write($"{RED}Program  6 :-{NORMAL}{CYAN} Factor of Element  " + $"{NORMAL}");

            for (int i = 0; i < measurements.Length; i++)
            {
                Console.Write($"{GREEN}" + measurements[i] * factor + $"{NORMAL}  ");
            }
            Console.WriteLine();

        }
        static void Search()
        {
            int[] bookCodes = { 101, 203, 304, 405, 506 };
            int searchCode = 304;
            Console.Write($"{YELLOW}Program  7 :-{NORMAL}{MAGENTA} Search Element Index by Value ");

            for (int i = 0; i < bookCodes.Length; i++)
            {
                if (bookCodes[i] == searchCode)
                {
                    Console.Write($"{GREEN}" + i + $"{NORMAL}");
                    break;
                }
            }
            Console.WriteLine();

        }
        static void SecondGreatest()
        {
            Console.Write($"{RED}Program  8 :-{NORMAL}{CYAN} Second Greatest :");
            int[] grades = { 56, 78, 89, 45, 67 };
            int first = grades[0];
            int second = grades[0];
            foreach (int grade in grades)
            {
                if (grade > first)
                {
                    second = first;
                    first = grade;
                }
                else if (grade > second && grade < first)
                {
                    second = grade;
                }
            }
            if (second != grades[0])
            {
                Console.WriteLine($"{GREEN}" + second + $"{NORMAL}");
            }
        }

        static void RemoveDuplicate()
        {
            int[] ids = { 102, 215, 102, 324, 215 };
            Array.Sort(ids);
            int uniqueCount = 1;

            for (int i = 1; i < ids.Length; i++)
            {
                if (ids[i] != ids[i - 1])
                {
                    uniqueCount++;
                }
            }
            int[] uniqueIdsArray = new int[uniqueCount];
            int index = 0;
            uniqueIdsArray[index++] = ids[0];
            for (int i = 1; i < ids.Length; i++)
            {
                if (ids[i] != ids[i - 1])
                {
                    uniqueIdsArray[index++] = ids[i];
                }
            }
            Console.Write($"{YELLOW}Program  9 :-{NORMAL}{MAGENTA} Array after removing duplicates: ");
            foreach (int id in uniqueIdsArray)
            {
                Console.Write($"{GREEN}" + id + $"{NORMAL} ");
            }
            Console.WriteLine();
        }



        static void FindCommonElement()
        {
            int[] dataset1 = { 1, 2, 3, 4, 5 };
            int[] dataset2 = { 3, 4, 5, 6, 7 };

            HashSet<int> set1 = new HashSet<int>(dataset1);
            HashSet<int> set2 = new HashSet<int>(dataset2);

            set1.IntersectWith(set2);

            Console.Write($"{RED}Program 10 :-{NORMAL}{CYAN} Common elements:");
            foreach (int element in set1)
            {
                Console.Write($"{GREEN}" + element + $"{NORMAL}");
            }
            Console.WriteLine();
        }

    }
}
using CustomDelegate.Delegates;
using System;

namespace CustomDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 5, 10, 15, 20, 25 };

            ////Call back Function
            //GetNums(arr, IsEven);
            //GetNums(arr, IsOdd);
            //GetNums(arr, IsDevideByFive);
            ////Anonym Method
            //GetNums(arr, delegate (int eded)
            //{
            //    return eded % 4 == 0;
            //});
            ////lambda Expression
            //GetNums(arr, n => n % 3 == 0);
            ////GetNums(arr, (n, m, s) => n % 3 == 0);
            ////GetNums(arr, () => n % 3 == 0);
            //GetNums(arr, n =>
            //{
            //    Console.WriteLine("P229 Hello");

            //    return true;
            //});

            //Check check = new Check(IsEven);

            //check += IsOdd;

            //check += IsDevideByFive;
            //check -= IsEven;
            //check += delegate (int eded)
            //{
            //    Console.WriteLine("Anonym Method 1");
            //    return eded % 4 == 0;
            //};
            //check += n => 
            //{
            //    Console.WriteLine("lambda Expression 1");
            //    return n % 9 == 0;
            //};
            //check -= delegate (int eded)
            //{
            //    Console.WriteLine("Anonym Method 1");
            //    return eded % 4 == 0;
            //};
            //check -= n =>
            //{
            //    Console.WriteLine("lambda Expression 1");
            //    return n % 9 == 0;
            //};

            ////calling
            //check(5);
            //check.Invoke(5);
            //Console.WriteLine(check.Invoke(5));

            //Write write = s => Console.WriteLine(s.ToLower());
            //write += s => Console.WriteLine(s.ToUpper());

            //write("Hello world");
        }


        static int[] GetNums(int[] arr, CustomGenericTypeDelegate<int, bool>check)
        {
            int[] newArr = { };

            foreach (int item in arr)
            {
                if (check.Invoke(item))
                {
                    Array.Resize(ref newArr, newArr.Length + 1);
                    newArr[newArr.Length - 1] = item;
                }
            }

            return newArr;
        }

        //static int[] GetEvenNums(int[] arr)
        //{
        //    int[] newArr = { };

        //    foreach (int item in arr)
        //    {
        //        if (IsEven(item))
        //        {
        //            Array.Resize(ref newArr, newArr.Length + 1);
        //            newArr[newArr.Length - 1] = item;
        //        }
        //    }

        //    return newArr;
        //}

        //static int[] GetOddNums(int[] arr)
        //{
        //    int[] newArr = { };

        //    foreach (int item in arr)
        //    {
        //        if (IsOdd(item))
        //        {
        //            Array.Resize(ref newArr, newArr.Length + 1);
        //            newArr[newArr.Length - 1] = item;
        //        }
        //    }

        //    return newArr;
        //}

        //static int[] GetDevideByFive(int[] arr)
        //{
        //    int[] newArr = { };

        //    foreach (int item in arr)
        //    {
        //        if (IsDevideByFive(item))
        //        {
        //            Array.Resize(ref newArr, newArr.Length + 1);
        //            newArr[newArr.Length - 1] = item;
        //        }
        //    }

        //    return newArr;
        //}

        static bool IsDevideByFive(int num) 
        {
            Console.WriteLine("IsDevideByFive");
            return num % 5 == 0;
        }
        static bool IsOdd(int num)
        {
            Console.WriteLine("IsOdd");
            return num % 2 == 1;
        }
        static bool IsEven(int num)
        {
            Console.WriteLine("IsEven");
            return num % 2 == 0;
        }
    }
}

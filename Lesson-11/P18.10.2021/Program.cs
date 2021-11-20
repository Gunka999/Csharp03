using P18._10._2021;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;

namespace Solution
{

    class Solution
    {
        static void Main(string[] args)
        {
            //string email = "mina@gmail.com";
            //email.IsEmail();
            //int[] numbers = { 10, 20, 30, 3, 5, 9 };
            //Console.WriteLine(Sum(isDivisibleByFive, 2, 5, 9, 6, 4, 1, 8, 20)); //checkers
            #region Writer delegate
            //Writer writer = new Writer(WriterEven);
            //writer += WriterDivisibleBy3;
            //anonim method
            //writer += delegate (int x)
            //{
            //    Console.WriteLine($"Number {x} is {(x % 4 == 0 ? "divisible by 4" : "not divisible by 4")}");
            //};
            //lambda exp
            //writer = n =>
            //{
            //    Console.WriteLine($"Number {n} is {(n % 5 == 0 ? "divisible by 5" : "not divisible by 5")}");
            //};


            //writer.Invoke(20);
            //WriterEven(20);
            //WriterDivisible(20);
            #endregion

            #region Action delegate

            //Action<string, int> action = delegate (string name, int age)
            //  {
            //      Console.WriteLine($"Your name: {name}, age: {age}");
            //  };

            //action += WriterEven;

            //action += (n, a) =>
            // {
            //     Console.WriteLine($"new word {n}, new number {a}");
            // };
            //action.Invoke("Mina", 50);
            #endregion

            #region Func
            Func<Person, bool> check = CheckFromAzerbaijan;

            check += delegate (Person p) { return p.Name.Length > 2; }; //anonim

            check += p => p.Email.Contains("@");//lambda

            Person person = new Person
            {
                Name = "Mina",
                Email = "mina@gmail.com",
                Country = "Azerbaijan"
            };

            Console.WriteLine(check(person));
            #endregion
        }
        #region Func delegate
        static bool CheckFromAzerbaijan(Person p) { return p.Country == "Azerbaijan"; }

        class Person
        {
            public string  Name { get; set; }
            public string Email { get; set; }
            public string Country { get; set; }
        }
        #endregion

        static void WriterEven(string n, int h)
        {
            Console.WriteLine($"words {n} , numbersss {h}");
        }

        #region Writer delegate

        public delegate void Writer(int n);


        static void WriterEven(int n)
        {
            Console.WriteLine($"Number {n} is {(n % 2 == 0 ? "even" : "odd")}");
        }
        static void WriterDivisibleBy3(int n)
        {
            Console.WriteLine($"Number {n} is {(n % 3 == 0 ? "divisible by 3" : "not divisible by3")}");
        }
        #endregion

        #region Checkers delegate
        public delegate bool Checkers(int x);
        static bool isEven(int a) => a % 2 == 0;

        static bool isDivisibleByThree(int a) => a % 3 == 0;

        static bool isDivisibleByFive(int a) => a % 5 == 0;

        static int Sum(Checkers call, params int[] numbers)
        {
            int sum = 0;
            foreach (var item in numbers)
            {
                if (call(item))
                {
                    sum += item;
                }
            }
            return sum;
        }


        //static int SumEven(int [] arr)
        //{
        //    int result = 0;
        //    foreach (var item in arr)
        //    {
        //        if (item %2==0)
        //        {
        //            result += item;
        //        }
        //    }
        //    return result;
        //}

        //static void SumOdd(int[] arr)
        //{
        //    int result = 0;
        //    foreach (var item in arr)
        //    {
        //        if (item % 2 ==1)
        //        {
        //            result += item;
        //        }
        //    }
        //    Console.WriteLine(result);
        //}
        #endregion
    }
}
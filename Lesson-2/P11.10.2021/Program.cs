using System;
using System.Linq;
using System.Text;

namespace P11._10._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Casting and Boxing
            //COMPILE TIME VS RUNTIME

            //string number = "5salam";
            //int a = int.Parse(number);
            //Console.WriteLine(a);


            //CASTING -UP/DOWN -value typelar arasinda
            byte a = 255;
            int b = a; //upcasting

            //int c = 5;
            //byte m = (byte)c; //downcasting
            //Console.WriteLine(m);

            //boxing vs unboxing-value type-ref type cev zamani
            int f = 5;
            object f2 = f; //boxing

            object c2 = "5";
            if (c2 is int)
            {
                int g = (int)c2; //unboxing
                //Console.WriteLine(g);

            }

            #endregion

            #region Array
            //Console.WriteLine(Concat("salam","Sagol")); ;
            //METHOD OVERLOADING-method signature(name,method parametr count, type)

            //1
            int[] number = new int[5];
            //2
            int[] number2 = new int[5] { 3, 4, 5, 6,6 };
            //4
            string[] ms = new string[] {"dsfSD","dsfdsfd" };

            //3
            //int[] number3 = { 3, 4, 5, 6 };

            //int x=number3[0];
            //number3.SetValue(5, 0);

            //for (int i = 0; i < number3.Length; i++)
            //{
            //    Console.WriteLine(number3[i]);
            //}

            //int[] array = new int[2];
            //array[0] = 1;
            //array[1] = 5;
            //foreach (var item in array)
            //{
            //Console.WriteLine(item);
            //}
            int[] numbers = { 1, 2, 3, 4, 3, 55, 23, 2 ,23,4};
            int[] notDublicate = numbers.Distinct().ToArray();

            //Array.Sort(notDublicate);
            //foreach (var item in notDublicate)
            //{
            //    Console.WriteLine(item);
            //}
            //string[] animals = { "fox", "cat", "bear" };
            //Array.Sort(animals);
            //foreach (var item in animals)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            int[] numbers2 = { 1, 2, 3, 4, 3, 55, 23, 2 ,23,4};
            int arrayFirstElement = 55;
            for (int i = 0; i < numbers2.Length; i++)
            {
                if (numbers2[i] == arrayFirstElement)
                {
                    Console.WriteLine("Bu eded var");
                }
            }
        }
       

        #region Overloading method

        public static  string Concat(string line1,string line2)
        {
            return $"Result string: {line1} {line2}";

        }

        public static string Concat(string line1, int count)
        {
            return $"Result string: {line1}";

        }

        public static string Concat(string line1)
        {
            return $"Result string: {line1}";
        }

        public static int Concat(int line1)
        {
            return line1;
        }
        #endregion
    }


}

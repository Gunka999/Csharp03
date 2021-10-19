using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P18._10._2021
{
    class Program
    {
        static void Main(string[] args)
        {

            //string x = "Dsfdds";
            //Console.WriteLine(x.Length);
            //Console.WriteLine(GetLength("salam"));

            //Console.WriteLine(Substring(2, "salam"));
            //UseParams(2, 2, 4, 9, 8, 7, 6);
            //int[] nums = { 1, 5, 9, 10 };
            //UseParams2(nums);
            //UseParams2(2, 2, 4, 9, 8, 7, 6);

            //Car bmw = new Car("Bmw");
            //bmw.DoorCount = 2;
            //bmw.Motor();

            //Car kia = bmw;

            //Console.WriteLine(bmw.Name);
            //Console.WriteLine(kia.Name);
            //bmw.Name = "kIA";
            //Console.WriteLine(bmw.Name);
            //Console.WriteLine(kia.Name);
            Student[] students = new Student[2];
            //for (int i = 0; i < students.Length; i++)
            //{
            //    Console.WriteLine("Telebe adini daxil et");
            //    string name = Console.ReadLine();

            //    Console.WriteLine("Telebenin balini  daxil et");
            //    double point = Convert.ToDouble(Console.ReadLine());

            //    Student student = new Student(name,point);

            //    students[i] = student;
            
            //}
            //Console.WriteLine($"Telebelerin ortalamasi {CalculateStudentAvrg(students)}");

            ArrayList arrayList = new ArrayList();
            arrayList.Add("salam");
            arrayList.Add(5);
            arrayList.Add(true);
          

            ArrayList array2 = new ArrayList();
            array2.AddRange(arrayList);
            array2.Add(6);
            array2.Add(9);
            array2.Add(8);
       

            foreach (var item in array2)
            {
                Console.WriteLine(item);
            }

            //int x = (int)arrayList[0];


        }

        public static double CalculateStudentAvrg(Student[] students)
        {
            double sum = 0;
            foreach (var item in students)
            {
                sum += item.Point;
            }
            return sum/students.Length;
        }

        #region Params

        public static void UseParams(int len,int len2,params int[] list)
        {
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
        public static void UseParams2(int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }
        }


        public  static string Substring(int from,string x)
        {
            string result = null;
            for (int i = from; i < x.Length; i++)
            {
                result += x[i];
            }
            return result;
        }


        //public static int GetLength(string z)
        //{
        //    int count = 0;
        //    foreach (char item in z)
        //    {
        //        count++;
        //    }
        //    return count;
        //}

        #endregion
    }
  
}

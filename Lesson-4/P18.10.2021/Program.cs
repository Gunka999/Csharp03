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
            #region Student Homework
            //Student[] students = new Student[5];
            //for (int i = 0; i < students.Length; i++)
            //{
            //    Console.WriteLine("Please enter fullname");
            //    string fullname = Console.ReadLine();
            //    Console.WriteLine("Please enter age");
            //    byte age = Convert.ToByte(Console.ReadLine());
            //    Console.WriteLine("Please enter group name");
            //    string groupName = Console.ReadLine();

            //    Student student = new Student(fullname, groupName, age);
            //    students[i] = student;
            //    Console.WriteLine($"Student birthYear is {Student.GetBirthdayYear(student)}");
            //}
            //Console.WriteLine("Find length by group name");
            //string findGroupName = Console.ReadLine();
            //Console.WriteLine($"Qrupda {Student.GetLengthGroup(findGroupName, students)}");
            #endregion

            //Student student = new Student("Mina", "P110", 18);
            //Console.WriteLine(student.Nomre);
            //Student student2 = new Student("Emin", "P110", 18);
            //Console.WriteLine(student2.Nomre);

            Product product = new Product("Bakery", 20, 3);
            product.GetTotalPrice();
            Console.WriteLine(product.Code);
            Console.WriteLine(product.TotalPrice);
            Product milk = new Product("Milk", 100, 3);
            milk.GetTotalPrice();
            Console.WriteLine(milk.Code);
            Console.WriteLine(milk.TotalPrice);


        }
    }

  
}

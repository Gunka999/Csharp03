using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P18._10._2021
{
    public class Student
    { 
        public string Fullname;
        public string GroupNumber;
        public byte Age;
        public static int No;
        public int Nomre;
        public Student(string Fullname, string group,byte age)
        {
            this.Fullname = Fullname;
            GroupNumber = group;
            Age = age;
            No++;
            Nomre=No;
            Console.WriteLine("Static olmayan ctor");
        }   
        static Student()
        {
            Console.WriteLine("Static ctor");
        }


        public void GetFullName()
        {
            Console.WriteLine(Fullname +""+"Salam");
        }

        public static int GetBirthdayYear(Student student)
        {
            return DateTime.Now.Year - student.Age;
        }

        public static int GetLengthGroup(string group, Student[] student)
        {
            int len = 0;
            foreach (var item in student)
            {
                if (item.GroupNumber== group)
                {
                    len++;
                }
            }
            return len;
        }
    }
}

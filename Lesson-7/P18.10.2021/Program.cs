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
            //Bird bird = new Bird("Qaranqus", 15);
            //Console.WriteLine(bird.Name);
            //bird.Eat();
            //bird.Eat2();
            //Animal animal = new Animal();
            //Student student = new Student();
            //student.Email = "dsfsdfsd@fvgfd.ry";
            //Console.WriteLine(student.Email);
            //CheckEmail(student.Email);

            //CalculateSquare calculate = new CalculateSquare();
            //calculate.x = 5;
            //calculate.y = 6;
            //calculate.Calculate();
            //Console.WriteLine(calculate.Sahe);
            //calculate.Sahe = 90;

            Console.WriteLine(Add(2, 3));

        }
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }
    }


    #region Encapsulation
    class CalculateSquare
    {
        public int x { get; set; }
        public int y { get; set; }
        private int _sahe;
        public int Sahe { get { return this._sahe; } }

        public void Calculate()
        {
            this._sahe = this.x * this.y;
        }

    }

    class Student
    {
        private string _email;

        public string Email
        {

            get { return _email; }
            set
            {
                try
                {
                    MailAddress mailAddress = new MailAddress(value);
                    _email = value;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }


        public void SaveToDatabase()
        {
            Console.WriteLine("database geden datam" + _email);
        }

    }
    #endregion

    #region Inheritance lesson
    public abstract class Writer
    {
        public abstract void Write();
        public virtual void CalculateSize()
        {
            Console.WriteLine("size from base class");
        }
    }

    class WriteToDatabase : Writer
    {
        public override void Write()
        {
            throw new NotImplementedException();
        }
        public override void CalculateSize()
        {
            base.CalculateSize();
        }
    }

    class WriteToFile : Writer
    {
        public override void Write()
        {
            //some amazing code

        }
    }

    //base class -valideyn class,esas class
    abstract class Animal
    {
        public string Name { get; set; }

        public Animal(string nm)
        {
            Name = nm;
        }

        public abstract void Eat();
        public virtual void Eat2()
        {
            Console.WriteLine("base classdan gelen method");
        }
    }
    //derived class-toremis class
    class Bird : Animal
    {
        public int Age { get; set; }
        public Bird(string birdName, int age) : base(birdName)
        {
            Age = age;
        }

        public void Fly()
        {
            Console.WriteLine("Flying");
        }

        public override void Eat()
        {
            Console.WriteLine("DSfSDFS");
        }
    }
    //class X : Bird
    //{
    //    public X(string birdName,int x):base(birdName,x)
    //    {

    //    }
    //}

    //abstract class Mother
    //{
    //  //some amazing code
    //}
    //abstract class Father
    //{
    //    //some amazing code
    //}
    //class Child:Mother,Father
    //{

    //}
    #endregion

}
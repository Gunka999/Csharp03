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
            //Student student = new Student("Mina", "Farzali");
            //Student student1 = new Student("Mina2", "Farzali");
            //Student student2 = new Student("Mina3", "Farzali");
            //Student.Print();
            //*****ctor injec
            //Service1 s1 = new Service1();
            //Client c1 = new Client(s1);
            //Service2 s2 = new Service2();
            //c1 = new Client(s2);
            //property injec
            //Service1 service1 = new Service1();
            //Client c1 = new Client();
            //c1.Service = service1;
            //Service2 service2 = new Service2();
            //c1.Service = service2;
            //method injec
            Service1 service1 = new Service1();

            Client c1 = new Client();
            c1.Start(service1);
            Service2 service2 = new Service2();
            c1.Start(service2);


        }
    }
    class Student
    {
        public static int _counter = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Student(string name, string surname)
        {
            Name = name;
            Surname = surname;
            Id = ++_counter;
            Console.WriteLine(Name + " " + Surname + " " + Id);
        }

        public static void Print()
        {
            Console.WriteLine(_counter);
        }
    }
    #region Single 
    public class MailAdressValidation
    {
        public bool IsmailAdressValid(string mailadress)
        {
            ///fdgdfgdfgfd
            return true;
        }
    }

    public class SendEmail
    {
        private MailAdressValidation mailAdress = new MailAdressValidation();
        public bool SendEmailForX(string input, string mail)
        {
            if (!mailAdress.IsmailAdressValid(mail))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
    #endregion
    #region Open-closed

    public abstract class Developer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public abstract double CalculateBonus(double salary);

        //public double CalculateBonus(double salary)
        //{
        //    if (this.Position =="Senior")
        //    {
        //        return salary * 0.25;
        //    }
        //    else
        //    {
        //        return salary;
        //    }
        //}
    }
    public class JuniorDev : Developer
    {
        public override double CalculateBonus(double salary)
        {
            return salary * 0.5;
        }
    }
    public class SeniorDev : Developer
    {
        public override double CalculateBonus(double salary)
        {
            return salary * 0.25;
        }
    }
    #endregion

    #region Liskov
    public abstract class BasePrint
    {
        public abstract void Print();
    }

    interface IScan
    {
        void Scan();
    }
    public class HpPrinter : BasePrint
    {
        public override void Print()
        {
            //some amazing code
        }
    }
    public class CanonPrinter : BasePrint, IScan
    {
        public override void Print()
        {
            //some amazing code
        }

        public void Scan()
        {
            //some amazing code
        }
    }
    #endregion

    #region Interface Seg
    //public interface IDeveloper
    //{
    //    void Select(string database);
    //    void Create(string database);
    //    void Alter(string database);
    //    void Delete(string database);
    //}
    //public class Intern : IDeveloper
    //{
    //    public void Alter(string database)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Create(string database)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Delete(string database)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Select(string database)
    //    {
    //       //some amazing code
    //    }
    //}


    //yeni
    public interface IDML
    {
        void Create(string database);
        void Alter(string database);
        void Delete(string database);
    }

    public interface ISelect
    {
        void Select(string database);

    }
    public class JuniorDeveloper : IDML, ISelect
    {
        public void Alter(string database)
        {
            //some amazing code
        }

        public void Create(string database)
        {
            //some amazing code
        }

        public void Delete(string database)
        {
            //some amazing code
        }

        public void Select(string database)
        {
            //some amazing code
        }
    }
    public class Intern : ISelect
    {
        public void Select(string database)
        {
            //some amazing code

        }
    }
    #endregion

    //Ctor injection
    //public interface IService
    //{
    //    void Servis();
    //}
    //public class Service1 : IService
    //{
    //    public void Servis()
    //    {
    //        Console.WriteLine("Service 1 called");
    //    }
    //}
    //public class Service2 : IService
    //{
    //    public void Servis()
    //    {
    //        Console.WriteLine("Service 2 called");
    //    }
    //}
    //public class Client
    //{
    //    private IService _service;
    //    public Client(IService service)
    //    {
    //        _service = service;
    //    }
    //}
    //property injec
    //public interface IService
    //{
    //    void Servis();
    //}
    //public class Service1 : IService
    //{
    //    public void Servis()
    //    {
    //        Console.WriteLine("Service 1 called");
    //    }
    //}
    //public class Service2 : IService
    //{
    //    public void Servis()
    //    {
    //        Console.WriteLine("Service 2 called");
    //    }
    //}
    //public class Client
    //{
    //    private IService _service;
    //    public IService Service
    //    {
    //        set { this._service = value; }
    //    }
    //}


    //Method injection

    public interface IService
    {
        void Servis();
    }
    public class Service1 : IService
    {
        public void Servis()
        {
            Console.WriteLine("Service 1 called");
        }
    }
    public class Service2 : IService
    {
        public void Servis()
        {
            Console.WriteLine("Service 2 called");
        }
    }
    public class Client
    {
        private IService _service;
        public void Start(IService service)
        {
            service.Servis();
        }
    }
}
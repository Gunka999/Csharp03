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
            //List<User> users = new List<User>();

            //string password = Console.ReadLine();
            //User user = new User("mina@code.edu.az", password);
            //user.Fullname = "Mina";
            //user.ShofInfo();
            //users.Add(user);
            DemoClass demo = new DemoClass(5, 6);
            DemoClass c = demo;
            //Console.WriteLine(c.x);
            //Console.WriteLine(demo.x);
            //demo.x = 30;
            //Console.WriteLine(c.x);
            //Console.WriteLine(demo.x);

            #region Struct vs Class
            //DemoStruct demo1 = new DemoStruct();

            //DemoStruct demo1 = new DemoStruct(8, 9);
            //DemoStruct b = demo1;
            //Console.WriteLine(demo1.x);
            //Console.WriteLine(b.x);
            //demo1.x = 90;
            //Console.WriteLine(demo1.x);
            //Console.WriteLine(b.x);
            #endregion


            //Car car = new Car();
            //car.Brand = "Mercedes";
            //car.Color = "Blue";
            //car.FuelCapacity = 20;
            //car.CurrentFuel = 80;
            //car.FuelFor1Km = 2;
            //car.Drive(20);


            Milk milla = new Milk("Milla")
            {
                Price = 1.5,
                Count=60,
                Volume=1.5,
                FatRate=2
            };
            milla.Sell(3);
            milla.Sell(4);
        }
    }


    public abstract class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        private double _totalInCome { get; set; }
        public Product(string name)
        {
            Name = name;
        }
        public void Sell(int buyProductCount)
        {
            if (Count >= buyProductCount)
            {
                Count -= buyProductCount;
                double resultPrice = buyProductCount * Price;
                _totalInCome += resultPrice;
                Console.WriteLine($"{buyProductCount} mehsul satildi ve umumi qiymet{resultPrice} manat, " +
                    $"bazada ise umumi satisdan elde edilen gelir{_totalInCome} manat");

            }
            else
            {
                Console.WriteLine($"Bazada {Count} mehsul var, sizin isteyinize uygun deyil");
            }
        }
    }

    public class Milk : Product
    {
        public double Volume { get; set; }
        public double FatRate { get; set; }

        public Milk(string nm) : base(nm) { }

    }


    #region Vehicle
    public abstract class Vehicle
    {
        public string Color { get; set; }
        public string Brand { get; set; }
        public double Millage { get; set; }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Brand: {Brand} , Color:{Color}, Millage:{Millage}");
        }
        public abstract void Drive(double km);
    }

    public class Car : Vehicle
    {
        public double FuelCapacity { get; set; }
        public double FuelFor1Km { get; set; }
        private double _currentFuel;
        public double CurrentFuel
        {
            get
            {
                return _currentFuel;
            }
            set
            {
                if (value < this.FuelCapacity)
                {
                    _currentFuel = value;
                }
                else
                {
                    Console.WriteLine("Hazirki yanacaq bakin tutumundan cox ola bilmez");
                }
            }
        }

        public override void Drive(double km)
        {
            if (this.CurrentFuel >= km * this.FuelFor1Km)
            {
                this.Millage += km;
                this.CurrentFuel -= km * this.FuelFor1Km;
                Console.WriteLine("Gedildi!");
            }
            else
            {
                Console.WriteLine("Bu benzinle bu mesafeni getmek olmaz!");
            }
        }
    }


    public class Bycle : Vehicle
    {
        public override void Drive(double km)
        {
            this.Millage += km;
        }
    }

    #endregion


    #region Struct vs CLASS

    public struct DemoStruct
    {
        public int x, y;

        public DemoStruct(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }


    public class DemoClass
    {
        public int x, y;
        public DemoClass(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public DemoClass()
        {

        }
    }

    #endregion

    #region Account
    public abstract class Account
    {
        public abstract bool PasswordCheker(string password);
        public virtual void ShofInfo()
        {
            Console.WriteLine("hello");
        }

    }
    public class User : Account
    {
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User(string email, string password)
        {
            if (PasswordCheker(password) == true)
            {
                this.Password = password;
                this.Email = email;
            }
            else
            {
                Console.WriteLine("Xahis edirem passwordu duzgun teyin edin!");
            }

        }
        public override bool PasswordCheker(string password)
        {
            if (string.IsNullOrEmpty(password) == true || password.Length < 8 || password.ToUpper() == password || password.ToLower() == password)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public override void ShofInfo()
        {
            Console.WriteLine($"Fullname: {Fullname}, \n E-mail: {Email}");
        }

    }
    #endregion

}
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
            //ValutaExchanger valuta = new ValutaExchanger();
            //valuta.Exchanger(CurrencyType.USD, 50);
            //CashRegister cashRegister = new CashRegister(10);
            //Console.WriteLine(cashRegister.TotalSaleCount);
            //cashRegister.Currency = CurrencyType.USD;
            //cashRegister.AddSale(10, CurrencyType.TL);
            //cashRegister.AddSale(10, CurrencyType.EURO);
            //cashRegister.AddSale(10, CurrencyType.USD);

            //Console.WriteLine(cashRegister.TotalAmount);
            //Console.WriteLine(cashRegister.TotalSaleCount);

            //ATM atm = new ATM(500);
            ////ATM-e
            //atm.BalanceFinished += (n, m) =>
            //{
            //    Console.WriteLine($"ATMde {n} AZN mebleginde pul yoxdur.Balans {m} AZN");
            //};
            ////User
            //atm.BalanceFinished += UserBalanceFinished;

            ////ATM-e
            //atm.TransferSuccessfuly += (n, m, time) =>
            // {
            //     Console.WriteLine($"{time} tarixiinde {n}azn mebleginde emeliyyat gedib.Balans {m} azn");
            // };
            //atm.TransferSuccessfuly += (n, m, time) =>
            //{
            //    Console.WriteLine($"{time} tarixiinde {n}azn mebleginde emeliyyat gedib.");
            //};

            //atm.WithDraw(100);
            //atm.WithDraw(300);
            //atm.WithDraw(500);

            User registeredUser = new User("Mina");
            registeredUser.registerUserEvent += EmailVerification;
            registeredUser.registerUserEvent += SMSVerification;
            registeredUser.RegisteredUser();

            User registeredUser2 = new User("Emin");
            registeredUser2.registerUserEvent += EmailVerification;
            registeredUser2.registerUserEvent += SMSVerification;
            registeredUser2.RegisteredUser();
        }

        //public class User
        //{
        //    public string Name { get; set; }
        //    public event EventHandler registerUserEvent;
        //    public User(string name)
        //    {
        //        Name = name;
        //    }
        //    public void RegisteredUser()
        //    {
        //        Console.WriteLine("User registr oldu");
        //        registerUserEvent(this, EventArgs.Empty);
        //    }
        //}

        //public static void EmailVerification(object source,EventArgs e)
        //{
        //    Console.WriteLine($"Send email verific");
        //}
        //public static void SMSVerification(object source, EventArgs e)
        //{
        //    Console.WriteLine("Send sms verific");
        //}



        public class User
        {
            public string Name { get; set; }
            public delegate void RegisterUserEventHandler(object sender, RegisterUserEventArgs e);
            public event RegisterUserEventHandler registerUserEvent;
            public User(string name)
            {
                Name = name;
            }
            public void RegisteredUser()
            {
                Console.WriteLine($"{Name} registr oldu");
                registerUserEvent(this, new RegisterUserEventArgs(Name));
            }
        }

        public class RegisterUserEventArgs: EventArgs
        {
            public string NameArg { get; set; }
            public RegisterUserEventArgs(string name)
            {
                NameArg = name;
            }
        }
        public static void EmailVerification(object source, RegisterUserEventArgs e)
        {
            Console.WriteLine($"Send email verific {e.NameArg}");
        }
        public static void SMSVerification(object source, RegisterUserEventArgs e)
        {
            Console.WriteLine($"Send sms verific {e.NameArg}");
        }


        public static void UserBalanceFinished(double x, double y)
        {
            Console.WriteLine($"Hormetli musteri balansda teleb olunan meblegde {x} azn pul yoxdur");
        }
    }


}
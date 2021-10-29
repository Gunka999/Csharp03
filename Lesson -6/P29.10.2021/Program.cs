using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task
            //PhoneBook bestFriend = new PhoneBook();
            //PhoneBook bestFriends = new PhoneBook();
            //bestFriend.AddPerson("Mina", "0559288755");
            //bestFriend.AddPerson("Eli", "0509003030");
            //bestFriend.AddPerson("Mina", "0516663399");
            //bestFriend.List();
            //bestFriend.GetNumberByName("Eli");
            //bestFriend.GetNameByNumber("0516663399");
            //bestFriend.RemoveByName("fdfdfd");
            //bestFriend.RemoveByNumber("0509003030");
            //bestFriend.List();
            //bestFriend._phoneBook.Add("Mina", "8454646");
            #endregion

         
        }
    }

    

    #region Task
    class PhoneBook
    {
        private readonly Dictionary<string, string> _phoneBook; /*=*/ /*new Dictionary<string, string>()*/
        public PhoneBook()
        {
            _phoneBook = new Dictionary<string, string>();
        }

        public void AddPerson(string name, string number)
        {
            if (_phoneBook.ContainsKey(name))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{name} is exist");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Select one of the option \n 1.Kepp the number \n 2. Update the number");
                string option = Console.ReadLine();
                while (option != "1" && option != "2")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please select valid number");
                    Console.ForegroundColor = ConsoleColor.White;
                    option = Console.ReadLine();
                }
                if (option == "2")
                {
                    var a = _phoneBook[name];
                    _phoneBook[name] = number;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{number} was succesfully updated");
                    Console.ForegroundColor = ConsoleColor.White;

                }
            }
            else
            {
                _phoneBook.Add(name, number);
                Console.WriteLine($"{name} with {number} added");
            }
        }

        public void List()
        {
            Console.WriteLine("All people");
            foreach (var item in _phoneBook.Keys)
            {
                Console.WriteLine($"{item} ={_phoneBook[item]}");
            }
        }
        public void GetNumberByName(string name)
        {
            if (_phoneBook.ContainsKey(name))
            {
                Console.WriteLine(_phoneBook[name] + ' ' + name);
            }
            else
            {
                Console.WriteLine("Nobody exist this contact");
            }
        }

        public void GetNameByNumber(string number)
        {
            if (_phoneBook.ContainsValue(number))
            {
                foreach (var item in _phoneBook.Keys)
                {
                    if (_phoneBook[item] == number)
                    {
                        Console.WriteLine(number + " " + item);
                    }
                }
            }
        }

        public void RemoveByName(string name)
        {
            if (_phoneBook.ContainsKey(name))
            {
                _phoneBook.Remove(name);
                Console.WriteLine(name + " is deleted");
            }
            else
            {
                Console.WriteLine(" this person doesnt exist");

            }
        }

        public void RemoveByNumber(string number)
        {
            if (_phoneBook.ContainsValue(number))
            {
                foreach (var item in _phoneBook.Keys)
                {
                    if (_phoneBook[item] == number)
                    {
                        _phoneBook.Remove(item);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine(" this person doesnt exist");
            }

        }
    }
    #endregion
}
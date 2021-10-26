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
            //arrayList

            ArrayList arrayList = new ArrayList();
            //arrayList.Add(5);
            //arrayList.Add(55);
            //arrayList.Add(56);

            //foreach (var item in arrayList)
            //{

            //Console.WriteLine(item);
            //}

            #region Stack
            //Stack stack = new Stack();
            //stack.Push(20);
            //stack.Push("Salam");
            //stack.Push(true);

            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            //stack.Pop();
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(stack.Peek()); 
            //Console.WriteLine(stack.Count);
            //stack.Clear();
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Queue

            //Queue queue = new Queue();
            //queue.Enqueue(5);
            //queue.Enqueue("salammm");
            //queue.Enqueue(false);
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            //queue.Dequeue();
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Hashtable
            //Hashtable hashtable = new Hashtable();
            //hashtable.Add(1, "Mina");
            //hashtable.Add(2, "Nofel");
            //hashtable.Add("Mina", "05592887555");

            //foreach (DictionaryEntry item in hashtable)
            //{
            //    if (item.Value== "05592887555")
            //    {
            //        Console.WriteLine(item.Key);
            //    }
            //}
            //if (hashtable.ContainsKey("Mina"))
            //{
            //    Console.WriteLine(hashtable["Mina"]);
            //}

            #endregion

            //SortedList sortedList = new SortedList();
            //sortedList.Add("Mina", "05599999999");

            #region Task
            //Stack stack = new Stack();
            //stack.Push(20);
            //stack.Push(10);
            //stack.Push(30);

            //Queue queue = new Queue();
            //queue.Enqueue(20);
            //queue.Enqueue(10);
            //queue.Enqueue(33);

            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(15);
            //arrayList.Add(43);
            //arrayList.Add(22);
            //arrayList.AddRange(stack);
            //arrayList.Insert(2,25);
            //arrayList.Add(37);
            //arrayList.AddRange(queue);

            ////15,43,25,22,30,10,20,37,20,10,33

            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region List

            //List<int> Numbers = new List<int>();
            //Numbers.Add(5);
            //Numbers.Add(65);
            //Numbers.Add(35);
            //foreach (var item in Numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //List<Student> students = new List<Student>();
            //Student student = new Student("Mina");
            //Student student2 = new Student("Emin");
            //Student student3 = new Student("Veli");
            //students.Add(student);
            //students.Add(student2);
            //students.Add(student3);
            //foreach (Student item in students)
            //{
            //    Console.WriteLine(item.Fullname);
            //}
            //students.Remove(student2);
            //foreach (Student item in students)
            //{
            //    Console.WriteLine(item.Fullname);
            //}
            //if (students.Contains(student))
            //{
            //    Console.WriteLine("bU STUDENT MOVCUDDUR");
            //}

            #endregion

            #region QUeue
            //Queue<int> stacks = new Queue<int>();
            //stacks.Enqueue(10);
            //stacks.Enqueue(55);
            //stacks.Enqueue(85);
            //foreach (var item in stacks)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Dictionary

            //Dictionary<int, string> dictionary = new Dictionary<int, string>();
            //dictionary.Add(1, "Mina");
            //dictionary.Add(2, "Emin");

            //if (dictionary.ContainsKey(1))
            //{
            //    dictionary.Remove(1);
            //}

            //foreach (var item in dictionary)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}
            #endregion

            //string role = "User";
            //if (role==Role.User.ToString())
            //{
            //    Console.WriteLine("Welcome");
            //}

            BOOK bk1 = new BOOK("Sefiller","Huqo");
            BOOK bk2 = new BOOK("XXX","Y");
            BOOK bk3 = new BOOK("Programming","CSHARP8");
            BOOK bk4 = new BOOK("Programming", "CSHARP9");

            Library library = new Library();
            library.BOOKs = new List<BOOK> { bk1, bk2, bk3, bk4 };
            //library.FindAllBooksByName2("Programming");
            var x = library.FindAllBooksByName("Programming");
            foreach (var item in x)
            {
                Console.WriteLine(item.name +" " +item.Author);
            }
        }
    }

    enum Role
    {
        Admin =1,
        User=3,
        SuperAdmin=2
    }
  
}

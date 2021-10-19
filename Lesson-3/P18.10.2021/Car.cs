using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P18._10._2021
{
    public class Car
    {
        public string Name;
        public int DoorCount;
        public double MotorGucu;
        public static double MotorGucu2;

        public Car(string nm,double guc)
        {
            Name = nm;
            MotorGucu = guc;
        }
        public Car(string nm)
        {
            Name = nm;
        }

        public void Motor()
        {
            Console.WriteLine(Name+" "+ $"gucu {MotorGucu} At-la hesablanir");
        }

        public static void Motor2()
        {
            Console.WriteLine("gucu At-la hesablanir");
        }
    }
}

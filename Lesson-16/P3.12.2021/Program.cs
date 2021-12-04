using P18._10._2021;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;

namespace Solution
{

    class Solution
    {
        static void Main(string[] args)
        {
            Temperatur temperatur = new Temperatur();
            temperatur.TemperatureBelow20 += Chechk;
            temperatur.TemperatureBelow20 += Chechk2;
            temperatur.Temp = 10;
        }
        public static void Chechk(int x)
        {
            Console.WriteLine("20 dereceden asagidir");
        }
        public static void Chechk2(int x)
        {
            Console.WriteLine("20 dereceden asagidir 2");
        }
    }
    class Temperatur
    {
        public delegate void TemperaturHandler(int temperatur);
        public event TemperaturHandler TemperatureBelow20;
        private int temp;
        public int Temp
        {
            get
            {
                return temp;
            }
            set
            {
                if (value !=0)
                {
                    temp = value;
                    if (temp < 20)
                    {
                        TemperatureBelow20?.Invoke(temp);
                    }
                }
            }
        }
    }
}
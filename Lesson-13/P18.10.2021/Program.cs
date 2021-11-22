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

            //1. delagate 
            //2. menfi olub olmadigini
            //2.1 5-e bolunduyunu
            //2.1 cut olub olmadigini yoxlasin
            //3 anonim func istifade edesiz! mecburidir!


            Console.OutputEncoding = Encoding.UTF8;
            #region delagate keyword
            //Console.WriteLine("**Methods** \n 1. Ayin adini yazdirmaq \n 2. Feslin adini yazdirmaq");
            //Console.WriteLine("Bir method secin");
            //string method = Console.ReadLine();
            //Console.WriteLine("bir ay secin");
            //byte month = byte.Parse(Console.ReadLine());
            //ChooseMethod(method, month);
            #endregion

            Console.WriteLine("**Methods** \n 1. Ayin adini yazdirmaq \n 2. Feslin adini yazdirmaq");
            Action<string, byte> action;
            Console.WriteLine("Bir method secin");
            string method = Console.ReadLine();
            Console.WriteLine("bir ay secin");
            byte month = byte.Parse(Console.ReadLine());

            action = (method, month) => Console.ReadLine();
            {
                if (method == "1")
                {
                    PrintInfo("Daxil edilen reqeme uygun ay gosteren program");
                    string Month;
                    switch (month)
                    {
                        case 1:
                            Month = "Yanvar";
                            break;
                        case 2:
                            Month = "Fevral";
                            break;
                        case 3:
                            Month = "Mart";
                            break;
                        case 4:
                            Month = "Aprel";
                            break;
                        case 5:
                            Month = "May";
                            break;
                        case 6:
                            Month = "Iyun";
                            break;
                        case 7:
                            Month = "Iyul";
                            break;
                        case 8:
                            Month = "Avqust";
                            break;
                        case 9:
                            Month = "Sentyabr";
                            break;
                        case 10:
                            Month = "Oktyabr";
                            break;
                        case 11:
                            Month = "Noyabr";
                            break;
                        case 12:
                            Month = "Dekabr";
                            break;
                        default:
                            Month = "Bele bir ay yoxdur";
                            break;
                    }
                    Console.WriteLine(Month);
                }
                else if (method == "2")
                {
                    PrintInfo("Daxil edilen reqeme uygun fesil gosteren program");
                    string season;
                    switch (month)
                    {
                        case 12:
                        case 1:
                        case 2:
                            season = "Qış fəsli";
                            break;
                        case 3:
                        case 4:
                        case 5:
                            season = "Yaz fəsli";
                            break;
                        case 6:
                        case 7:
                        case 8:
                            season = "Yay fəsli";
                            break;
                        case 9:
                        case 10:
                        case 11:
                            season = "Payiz fəsli";
                            break;
                        default:
                            season = "Bele bir ay yoxdur!";
                            break;
                    }
                    Console.WriteLine(season);
                }
            }

        }
        #region delegate keyword
        public delegate string Print(byte Month);

        public static string TranslateMonthName(byte Month)
        {
            string month;
            switch (Month)
            {
                case 1:
                    month = "Yanvar";
                    break;
                case 2:
                    month = "Fevral";
                    break;
                case 3:
                    month = "Mart";
                    break;
                case 4:
                    month = "Aprel";
                    break;
                case 5:
                    month = "May";
                    break;
                case 6:
                    month = "Iyun";
                    break;
                case 7:
                    month = "Iyul";
                    break;
                case 8:
                    month = "Avqust";
                    break;
                case 9:
                    month = "Sentyabr";
                    break;
                case 10:
                    month = "Oktyabr";
                    break;
                case 11:
                    month = "Noyabr";
                    break;
                case 12:
                    month = "Dekabr";
                    break;
                default:
                    month = "Bele bir ay yoxdur";
                    break;
            }
            return month;
        }

        public static string PrintSeasonName(byte Month)
        {
            string season;

            switch (Month)
            {
                case 12:
                case 1:
                case 2:
                    season = "Qış fəsli";
                    break;
                case 3:
                case 4:
                case 5:
                    season = "Yaz fəsli";
                    break;
                case 6:
                case 7:
                case 8:
                    season = "Yay fəsli";
                    break;
                case 9:
                case 10:
                case 11:
                    season = "Payiz fəsli";
                    break;
                default:
                    season = "Bele bir ay yoxdur!";
                    break;
            }
            return season;
        }

        public static string ChooseMethod(string method, byte month)
        {
            Print print = null;
            string info;
            if (method == "1")
            {
                info= "Daxil edilen reqeme uygun ay gosteren program";
                PrintInfo(info);
                print = TranslateMonthName;
            }
            else if (method == "2")
            {
                info = "Daxil edilen reqeme uygun fesil gosteren program";
                PrintInfo(info);
                print = PrintSeasonName;
            }
            return print.Invoke(month);
        }

        public static void PrintInfo(string info)
        {
            Console.WriteLine(info);
        }
        #endregion
    }
}
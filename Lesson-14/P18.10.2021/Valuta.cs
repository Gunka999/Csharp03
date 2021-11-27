using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P18._10._2021
{
    public enum CurrencyType
    {
        USD,
        EURO,
        TL
    }

    public class ValutaExchanger
    {
        public CurrencyType type { get; set; }
        static Dictionary<CurrencyType, double> valuta;
        public ValutaExchanger()
        {
            valuta = new Dictionary<CurrencyType, double>();
        }
        public void Exchanger(CurrencyType currency, double mebleg)
        {
            valuta.Add(currency, mebleg);
            if (currency ==CurrencyType.EURO)
            {
                Console.WriteLine(mebleg*1.90);
            }else if(currency ==CurrencyType.TL){
                Console.WriteLine(mebleg*0.15);
            }
            else if (currency == CurrencyType.USD)
            {
                Console.WriteLine(mebleg*1.7);
            }
        }


    }
    

    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public static List<Student> students { get; set; }

        public void GetFullName()
        {
            Console.WriteLine(Name+ " "+Surname);
        }

    }
}

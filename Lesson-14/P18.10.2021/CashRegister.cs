using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P18._10._2021
{
    public enum PaymentType
    {
        Cash,
        Card
    }

    public class CashRegister
    {
        public double TotalAmount { get; set; }
        public CurrencyType Currency { get; set; }
        public PaymentType paymentType { get; set; }
        private int _totalSaleCount { get; set; }

        public int TotalSaleCount
        {
            get
            {
                return this._totalSaleCount;
            }
            set
            {
                _totalSaleCount = 0;
            }
        }

        public CashRegister(double totalAmount)
        {
            this.TotalAmount = totalAmount;
        }
        public void AddSale(double amount, CurrencyType curr)
        {
            if (curr != Currency)
            {
                if (Currency.ToString() == "USD")
                {
                    double exc = amount * (1.70);
                    if (exc >=amount)
                    {
                        double lazimliMebleg = exc - 10;
                        TotalAmount += exc;
                    }
                    else
                    {
                        Console.WriteLine("Yeniden odeyin");
                    }
                }

            }
            else
            {
                TotalAmount += amount;
            }

            _totalSaleCount++;
        }

        public void RemoveSale(double amount, CurrencyType curr)
        {
            if (curr != Currency)
            {
                double exc = amount * (double)Currency;
                TotalAmount -= exc;

            }
            else
            {
                TotalAmount -= amount;
            }
            _totalSaleCount--;


        }

    }
}

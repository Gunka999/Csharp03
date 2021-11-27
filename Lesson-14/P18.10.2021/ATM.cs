using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P18._10._2021
{
    class ATM
    {
        public event Action<double, double> BalanceFinished;
        public event Action<double, double,DateTime> TransferSuccessfuly;

        private double _balance;
        public double Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
        public ATM(double Balanceamount)
        {
            Balance = Balanceamount;
        }

        public void WithDraw(double amount)
        {
            if (Balance>=amount)
            {
                Balance -= amount;

                if (TransferSuccessfuly !=null)
                {
                    TransferSuccessfuly.Invoke(amount, Balance, DateTime.Now);
                }
                return;
            }
            else
            {
                    BalanceFinished?.Invoke(amount, Balance);
            }


        }
    }
}

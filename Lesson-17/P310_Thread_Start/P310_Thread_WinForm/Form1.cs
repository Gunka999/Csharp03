using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P310_Thread_WinForm
{
    public partial class Form1 : Form
    {
        private long? Total = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(Sum);
            thread.Start(100000000);

            while(Total == null)
            {
                label1.Text = "Waiting new Thread to finish calculation";
            }

            textBox1.Text = Total.ToString();
        }

        private void Sum(object number)
        {
            long sum = 0;
            for (int i = 0; i < Convert.ToInt64(number); i++)
            {
                sum += i;
            }

            Total = sum;
        }
    }
}

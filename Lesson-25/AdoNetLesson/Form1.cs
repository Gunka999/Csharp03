using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetLesson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["uniqeAd"].ConnectionString;
            //SqlConnection sqlConnection = null;
            //SqlCommand sqlCommand = null;
            //SqlDataReader sqlDataReader = null;

            //try
            //{

            //    sqlConnection = new SqlConnection(connString);
            //    sqlConnection.Open();

            //    string command = "Select * from Country";
            //    sqlCommand = new SqlCommand(command, sqlConnection);

            //    sqlDataReader = sqlCommand.ExecuteReader();

            //    while (sqlDataReader.Read())
            //    {
            //        cmbcountry.Items.Add(sqlDataReader[1]); //COLUMN QAYTARIR
            //    }
            //}
            //catch (Exception ex)
            //{

            //    throw;
            //}
            //finally
            //{
            //    sqlConnection.Close();
            //}

            using (SqlConnection sqlconnection = new SqlConnection(connString))
            {
                string command = "Select * from Country";

                using (SqlCommand sqlCommand = new SqlCommand(command, sqlconnection))
                {
                    sqlconnection.Open();

                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            cmbcountry.Items.Add(sqlDataReader[1]); //COLUMN QAYTARIR
                        }
                    }
                }

            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace BillingSystemm
{
    public partial class Form11 : Form
    {
        Thread th; private string conn;
        private MySqlConnection connect;
        public Form11()
        {
            InitializeComponent(); loadcategory(); loadall();
        }
        void formmain()
        {
            Application.Run(new Form2());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            th = new Thread(formmain);
            th.SetApartmentState(ApartmentState.STA);

            th.Start();
            this.Close();
        }
        private void db_connection()
        {
            try
            {
                conn = "Server=localhost;Database=billingsystem;Uid=root;Pwd=;";
                connect = new MySqlConnection(conn);
                connect.Open();
            }
            catch (MySqlException e)
            {
                throw;
            }
        }
        private void loadcategory()
        {
            string cquery = "SELECT Emri FROM kategori ORDER BY Emri";
            try
            {
                db_connection();
                MySqlCommand cc = new MySqlCommand(cquery, connect);
                MySqlDataReader crd;
                crd = cc.ExecuteReader();
                while (crd.Read())
                {
                    category.Items.Add(crd["Emri"]);
                }
            }
            catch (Exception e)
            {

            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void loadall()
        {
            string queryall = "SELECT MAX(ID) FROM depo";
            try
            {
                db_connection();
                MySqlCommand cmdall = new MySqlCommand(queryall, connect);
                MySqlDataReader allreader;
                allreader = cmdall.ExecuteReader();
                while (allreader.Read())
                {
                    totali.Text = allreader.GetValue(0).ToString();


                }
            }
            catch (Exception exc)
            {

            }
        }
       
        void loadmoney()
        {
           
           
        }
        

        private void category_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select count(*)  from depo  where Kategoria = '" + category.SelectedItem.ToString() + "'";

         
            try
            {
                db_connection();
                MySqlCommand cc = new MySqlCommand(query,connect);
                MySqlDataReader crd;
                crd = cc.ExecuteReader();
                while (crd.Read())
                {
                    numri.Text = crd.GetValue(0).ToString();

                   
                }

               
                
            }
            catch (Exception ez)
            {

            }

           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

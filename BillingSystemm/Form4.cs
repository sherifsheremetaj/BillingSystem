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
    public partial class Form4 : Form
    {
        Thread th;
        private string conn;
        private MySqlConnection connect;

        public Form4()
        {


            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (adminn.Checked)
            {
                db_connection();
                string aquery = "INSERT INTO login (Username,Password) values('" + this.username.Text + "','" + this.password.Text + "') ";

                MySqlCommand command = new MySqlCommand(aquery, connect);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("New Admin Added");
                }
                else
                {
                    MessageBox.Show("Error");
                }
                connect.Close();


            }
            if(stafff.Checked){
                db_connection();
                string squery = "INSERT INTO slogin (Username,Password) values('" + this.username.Text + "','" + this.password.Text + "') ";
                MySqlCommand command = new MySqlCommand(squery, connect);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("New Staff Added");
                }
                else
                {
                    MessageBox.Show("Error");
                }
                connect.Close();
            }
            if (adminn.Checked && stafff.Checked)
            {
                MessageBox.Show("Only one checkbox can be checked !");
            }
        }
    }
}
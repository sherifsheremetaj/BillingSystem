using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Threading;



namespace BillingSystemm
{
    public partial class Form1 : Form
    {
        Thread th;
        private string conn;
        private MySqlConnection connect;
        public static string adminstatus = "";
        public static string dorezoipagesen = "";
        

        public Form1()
        {
            InitializeComponent(); 
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
        
        private bool validate_login(string user, string pass)
        {
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Select * from login where username=@user and password=@pass";
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.Connection = connect;
            MySqlDataReader login = cmd.ExecuteReader();
            if (login.Read())
            {
                connect.Close();
                return true;
            }
            else
            {
                connect.Close();
                return false;
            }
        }
        private bool validates(string user, string pass)
        {
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Select * from slogin where username=@user and password=@pass";
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.Connection = connect;
            MySqlDataReader login = cmd.ExecuteReader();
            if (login.Read())
            {
                connect.Close();
                return true;
            }
            else
            {
                connect.Close();
                return false;
            }
        }
        private void opennewform(object obj)
        {

            Application.Run(new Form2());
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void uname(object sender, EventArgs e)
        {

        }

        private void unamenter(object sender, EventArgs e)
        {

        }

        private void pleave(object sender, EventArgs e)
        {

        }

        private void penter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (admin.Checked && staff.Checked)
            {
                MessageBox.Show("Selekto vetëm një checkbox!");
                
            }
            else if (admin.Checked)
            {
                adminstatus = "Logged : Admin";
                dorezoipagesen = username.Text;

         
              
                string user = username.Text;
                string pass = password.Text;

                if (user == "" || pass == "")
                {
                    MessageBox.Show("Plotësoni fushat !");
                    return;
                }
                bool r = validate_login(user, pass);
                if (r)
                {
                    this.Hide();
                    th = new Thread(opennewform);
                    th.SetApartmentState(ApartmentState.STA);

                    th.Start();
                }
                else
                    MessageBox.Show("Të dhënat gabim !");
            }



            if (staff.Checked)
            {
                adminstatus = "Logged : Staff";
                dorezoipagesen = username.Text;
                string privilege = "Staff";
                string user = username.Text;
                string pass = password.Text;

                if (user == "" || pass == "")
                {
                    MessageBox.Show("Plotësoni fushat !");
                    return;
                }
                bool r = validates(user, pass);
                if (r)
                {
                    this.Hide();
                    th = new Thread(opennewform);
                    th.SetApartmentState(ApartmentState.STA);

                    th.Start();
                }
                else
                    MessageBox.Show("Të dhënat gabim !");

            }
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
    
        
    
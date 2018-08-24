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
    public partial class Form3 : Form
    {
        Thread th;
        private string conn;
        private MySqlConnection connect;
        public Form3()
        {
            InitializeComponent();
        }
        private void opennewform(object obj)
        {

            Application.Run(new Form4());
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            if (Form1.adminstatus.Equals("Logged : Admin"))
            {
                th = new Thread(opennewform);
                th.SetApartmentState(ApartmentState.STA);

                th.Start();
            }
            else
            {
                addnew.Enabled = false;
                MessageBox.Show("Këtë privilegj e ka vetëm admini !");

            }
           
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
        private void button1_Click(object sender, EventArgs e)
        {
            if (admin.Checked)
            {
                      
         
              
                string user = username.Text;
                string pass = oldpassword.Text;

                if (user == "" || pass == "")
                {
                    MessageBox.Show("Empty Fields Detected ! Please fill up all the fields");
                    return;
                }
                bool r = validate_login(user, pass);
                if (r)
                {

                    db_connection();
                    string aquery = "UPDATE login SET Username='" + this.username.Text + "',Password='" + this.newpassword.Text + "'where Username='"+this.username.Text+"' ";

                    MySqlCommand command = new MySqlCommand(aquery, connect);
                    MySqlDataReader rd;
                    rd = command.ExecuteReader();
                    MessageBox.Show("Updated");
                    while (rd.Read())
                    {
                    }
                }
                else
                    MessageBox.Show("Incorrect Credentials");
            }



            if (staff.Checked)
            {
                
           
                string user = username.Text;
                string pass = oldpassword.Text;

                if (user == "" || pass == "")
                {
                    MessageBox.Show("Empty Fields Detected ! Please fill up all the fields");
                    return;
                }
                bool r = validates(user, pass);
                if (r)
                {
                   
                    db_connection();
                    string aquery = "UPDATE slogin SET Username='" + this.username.Text + "',Password='" + this.newpassword.Text + "'where Username='"+this.username.Text+"' ";

                    MySqlCommand command = new MySqlCommand(aquery, connect);
                    MySqlDataReader rd;
                    rd = command.ExecuteReader();
                    MessageBox.Show("Updated");
                    while (rd.Read())
                    {
                    }
                }
                else
                    MessageBox.Show("Incorrect Credentials");
                }
                else
                    MessageBox.Show("Incorrect  Credentials");

            }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }
        private void opennewformm(object obj)
        {

            Application.Run(new Form2());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            th = new Thread(opennewformm);
            th.SetApartmentState(ApartmentState.STA);
            this.Close();
            th.Start();
        }
            }
        }
    


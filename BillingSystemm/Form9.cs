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
    public partial class Form9 : Form
    {
        private string conn;
        private MySqlConnection connect;
        Thread th;

        DataTable data;
        public Form9()
        {
            InitializeComponent(); fetchdata();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }
        public void fetchdata()
        {
            db_connection();
            MySqlCommand cmd = new MySqlCommand("SELECT *FROM furnitoret", connect);
            MySqlDataAdapter fd = new MySqlDataAdapter();
            fd.SelectCommand = cmd;
            data = new DataTable();
            data.Columns.Add("Emri", typeof(string));
            data.Columns.Add("NrBiznesit", typeof(string));
            data.Columns.Add("NrFiskal", typeof(string));

            data.Columns.Add("NrTatimit", typeof(string));

            data.Columns.Add("Adresa", typeof(string));

           
            data.Columns.Add("Telefoni", typeof(string));
        
            fd.Fill(data);
            BindingSource fsource = new BindingSource();
            fsource.DataSource = data;
            tablef.DataSource = fsource;
            fd.Update(data);

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
        private void clear()
        {
            emri.ResetText();
            nrf.ResetText();
            nrb.ResetText();
            adr.ResetText();
            tel.ResetText();
            nrt.ResetText();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            db_connection();
            string aquery = "INSERT INTO furnitoret (Emri,NrBiznesit,NrFiskal,NrTatimit,Adresa,NrTelefonit) values('" + this.emri.Text + "','" + this.nrb.Text + "','" + this.nrf.Text + "','" + this.nrt.Text + "','" + this.adr.Text + "','" + this.tel.Text + "') ";

            MySqlCommand command = new MySqlCommand(aquery, connect);
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Furnitori është regjistruar!");
                fetchdata();
                clear();
            }
            else
            {
                MessageBox.Show("Furnitori nuk është regjistruar !");
            }


            connect.Close();
        }
        private void opennewformm(object obj)
        {
            Application.Run(new Form2());
        }
        private void button3_Click(object sender, EventArgs e)
        {
            th = new Thread(opennewformm);
            th.SetApartmentState(ApartmentState.STA);
            this.Close();
            th.Start();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fetchdata();
        }

        private void fshijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Form1.adminstatus.Equals("Logged : Admin"))
            {
                db_connection();

                string aquery = "DELETE From furnitoret  WHERE NrBiznesit='" + this.nrb.Text + "'";
                MySqlCommand command = new MySqlCommand(aquery, connect);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Furnitori është fshirë !!");

                    fetchdata();
                    clear();

                }
                else
                {
                    MessageBox.Show("Furnitori nuk është fshirë !");
                }
                connect.Close();
            }
            else
            {
                fshijToolStripMenuItem.Enabled = false;
                MessageBox.Show("Këtë privilegj e ka vetëm admini !");


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            db_connection();
            string uquery = "UPDATE  furnitoret  SET Emri='" + this.emri.Text + "',NrBiznesit='" + this.nrb.Text + "',NrFiskal='" + this.nrf.Text + "',NrTatimit='" + this.nrt.Text + "',Adresa='" + this.adr.Text + "',NrTelefonit='" + this.tel.Text + "' WHERE NrFiskal='" + this.nrf.Text + "'";
            MySqlCommand command = new MySqlCommand(uquery, connect);
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Furnitori është edituar!");
                fetchdata();
                clear();
            }
            else
            {
                MessageBox.Show("Furnitori nuk është edituar !");
            }
            connect.Close();
        }

        private void tablef_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.tablef.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                emri.Text = row.Cells[1].Value.ToString();
                nrb.Text = row.Cells[2].Value.ToString();
                nrf.Text = row.Cells[3].Value.ToString();
                nrt.Text = row.Cells[4].Value.ToString();
                adr.Text = row.Cells[5].Value.ToString();
                tel.Text = row.Cells[6].Value.ToString();
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            DataView dv = new DataView(data);
            dv.RowFilter = string.Format("Emri LIKE '%{0}%'", filterbox.Text);
            tablef.DataSource = dv;
        }
    }
}

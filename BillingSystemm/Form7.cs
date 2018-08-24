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
    public partial class Form7 : Form
    {
        Thread th;
      
        private string conn;
        private MySqlConnection connect; DataTable data;
        public Form7()
        {
            InitializeComponent(); fetchdata();
        }
        private void openmain(object obj)
        {
            Application.Run(new Form2());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            th = new Thread(openmain);
            th.SetApartmentState(ApartmentState.STA);

            th.Start();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void fetchdata()
        {
            db_connection();
            MySqlCommand cmd = new MySqlCommand("SELECT *FROM firma", connect);
            MySqlDataAdapter fd = new MySqlDataAdapter();
            fd.SelectCommand = cmd;
            data = new DataTable();

            data.Columns.Add("Emri", typeof(string));
            data.Columns.Add("NrBiznesit", typeof(string));
            data.Columns.Add("NrFiskal", typeof(string));

            data.Columns.Add("NrTatimit", typeof(string));

            data.Columns.Add("Adresa", typeof(string));

            data.Columns.Add("Vendi", typeof(string));
            data.Columns.Add("Telefoni", typeof(string));
            data.Columns.Add("Email", typeof(string));
            fd.Fill(data);
            BindingSource fsource = new BindingSource();
            fsource.DataSource = data;
            table.DataSource = fsource;
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
        private void button1_Click(object sender, EventArgs e)
        {
            db_connection();
            string aquery = "INSERT INTO firma (Emri,NrBiznesit,NrFiskal,NrTatimit,Adresa,Vendi,Telefoni,Email) values('" + this.emri.Text + "','" + this.nrb.Text + "','" + this.nrf.Text + "','" + this.nrt.Text + "','" + this.adr.Text + "','" + this.ven.Text + "','" + this.tel.Text + "','" + this.email.Text + "') ";

            MySqlCommand command = new MySqlCommand(aquery, connect);
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Detajet e firmës u shtuan !");
                fetchdata();
                clear();
            }
            else
            {
                MessageBox.Show("Detajet e firmës nuk u shtuan !");
            }
            connect.Close();

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Form1.adminstatus.Equals("Logged : Admin"))
            {
                db_connection();
                string uquery = "UPDATE  firma  SET Emri='" + this.emri.Text + "',NrBiznesit='" + this.nrb.Text + "',NrFiskal='" + this.nrf.Text + "',NrTatimit='" + this.nrt.Text + "',Adresa='" + this.adr.Text + "',Vendi='" + this.ven.Text + "',Telefoni='" + this.tel.Text + "',Email='" + this.email.Text + "' WHERE NrBiznesit='" + this.nrb.Text + "'";
                MySqlCommand command = new MySqlCommand(uquery, connect);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Detajet e firmës u edituan!!");
                    fetchdata();
                    clear();
                }
                else
                {
                    MessageBox.Show("Detajet e firmës nuk u edituan !");
                }
                connect.Close();
            }
            else
            {
                button3.Enabled = false;

                MessageBox.Show("Këtë privilegj e ka vetëm admini !");
            }
            connect.Close();
        }
        private void clear()
        {
            emri.Text = String.Empty;
            nrb.Text = String.Empty;
            nrf.Text = String.Empty;
            nrt.Text = String.Empty;
            adr.Text = String.Empty;
            ven.Text = String.Empty;
            tel.Text = String.Empty;
            email.Text = String.Empty;






        }
        private void fshijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Form1.adminstatus.Equals("Logged : Admin"))
            {
                db_connection();

                string aquery = "DELETE From firma  WHERE NrBiznesit='" + this.nrb.Text + "'";
                MySqlCommand command = new MySqlCommand(aquery, connect);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Detajet e firmës u fshinë !!");

                    fetchdata();
                    clear();

                }
                else
                {
                    MessageBox.Show("Detajet e firmës nuk u fshinë !");
                }
                connect.Close();
            }
            else
            {
                fshijToolStripMenuItem.Enabled = false;
                MessageBox.Show("Këtë privilegj e ka vetëm admini !");


            }
        }

        private void table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.table.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                emri.Text = row.Cells[1].Value.ToString();
                nrb.Text = row.Cells[2].Value.ToString();
                nrf.Text = row.Cells[3].Value.ToString();
                nrt.Text = row.Cells[4].Value.ToString();
                adr.Text = row.Cells[5].Value.ToString();
                ven.Text = row.Cells[6].Value.ToString();
                tel.Text = row.Cells[7].Value.ToString();
                email.Text = row.Cells[8].Value.ToString();

            }
        }

        private void rifreskoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fetchdata();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            DataView dv = new DataView(data);
            dv.RowFilter = string.Format("Emri LIKE '%{0}%'", filterbox.Text);
            table.DataSource = dv;
        }
    }
}

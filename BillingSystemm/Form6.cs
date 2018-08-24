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
    public partial class Form6 : Form
    {
        private string conn;
        private MySqlConnection connect;
        Thread th; DataTable data;

        public Form6()
        {
            InitializeComponent(); fetchdata();

        }

        private void button1_Click(object sender, EventArgs e)
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
        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void clear()
        {
            emri.Clear();
            nrbiznes.Clear();
            nrtatim.Clear();
            nrfiskal.Clear();
            adresa.Clear();
            vendi.Clear();



        }
            
        public void fetchdata()
        {
            db_connection();
            MySqlCommand cmd = new MySqlCommand("SELECT *FROM klientet", connect);
            MySqlDataAdapter fd = new MySqlDataAdapter();
            fd.SelectCommand = cmd;
          
            data = new DataTable();
            
            data.Columns.Add("Emri", typeof(string));
            data.Columns.Add("NrBiznesit", typeof(string));
            data.Columns.Add("NrFiskal", typeof(string));

            data.Columns.Add("NrTatimit", typeof(string));

            data.Columns.Add("Adresa", typeof(string));

            data.Columns.Add("Vendi", typeof(string));

          

            fd.Fill(data);
            BindingSource fsource = new BindingSource();
            fsource.DataSource = data;
            tb.DataSource = fsource;
            fd.Update(data);

        }
        private void Ruaj_Click(object sender, EventArgs e)
        {
            db_connection();
            string aquery = "INSERT INTO klientet (Emri,NrBiznesit,NrFiskal,NrTatimit,Adresa,Vendi) values('" + this.emri.Text + "','" + this.nrbiznes.Text + "','" + this.nrfiskal.Text + "','" + this.nrtatim.Text + "','" + this.adresa.Text + "','" + this.vendi.Text + "') ";

            MySqlCommand command = new MySqlCommand(aquery, connect);
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Klienti u regjistrua!");
                fetchdata();
                clear();
            }
            else
            {
                MessageBox.Show("Klienti nuk u regjistrua !");
            }

         
            connect.Close();


        }

        private void button1_Click_2(object sender, EventArgs e)
        {
        }
      
        private void tb_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip pop = new System.Windows.Forms.ContextMenuStrip();
                int position = tb.HitTest(e.X, e.Y).RowIndex;
                if (position >= 0)
                {
                    pop.Items.Add("Edito").Name = "Edito";
                    pop.Items.Add("Fshij").Name = "Fshij";

                }
                pop.Show(tb, new Point(e.X, e.Y));


            }
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

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fshijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Form1.adminstatus.Equals("Logged : Admin"))
            {
                db_connection();

                string aquery = "DELETE From klientet  WHERE NrBiznesit='"+this.nrbiznes.Text+"'";
                MySqlCommand command = new MySqlCommand(aquery, connect);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Klienti është fshirë !!");

                    fetchdata();
                    clear();

                }
                else
                {
                    MessageBox.Show("Klienti nuk është fshirë !");
                }
                connect.Close();
            }
            else
            {
                fshijToolStripMenuItem.Enabled = false;
                MessageBox.Show("Këtë privilegj e ka vetëm admini !");


            }
        }
        private void fetch(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void editoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void Edito_Click(object sender, EventArgs e)
        {
            db_connection();
            string uquery = "UPDATE  klientet  SET Emri='"+this.emri.Text+"',NrBiznesit='"+this.nrbiznes.Text+"',NrFiskal='"+this.nrfiskal.Text+"',NrTatimit='"+this.nrtatim.Text+"',Adresa='"+this.adresa.Text+"',Vendi='"+this.vendi.Text+"' WHERE NrFiskal='" + this.nrfiskal.Text + "'";
            MySqlCommand command = new MySqlCommand(uquery, connect);
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Klienti është edituar!!");
                fetchdata();
                clear();
            }
            else
            {
                MessageBox.Show("Klienti nuk është edituar !");
            }
            connect.Close();
        }

        private void rifreskoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

       

        private void tb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataclick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.tb.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                emri.Text = row.Cells[1].Value.ToString();
           nrbiznes.Text = row.Cells[2].Value.ToString();
           nrfiskal.Text = row.Cells[3].Value.ToString();
                nrtatim.Text = row.Cells[4].Value.ToString();
                adresa.Text = row.Cells[5].Value.ToString();
                vendi.Text = row.Cells[6].Value.ToString();
            }
        }

        private void filterbox_TextChanged(object sender, EventArgs e)
        {
            
                DataView dv = new DataView(data);
                dv.RowFilter = string.Format("Emri LIKE '%{0}%'", filterbox.Text);
                tb.DataSource = dv;
        }

      
    }
}

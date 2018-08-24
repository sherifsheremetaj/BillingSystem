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
using System.Globalization;

namespace BillingSystemm
{
    public partial class Form5 : Form
    {

        private string conn;
        private MySqlConnection connect;
        Thread th;
        String checkvalue; string ft; DataTable data; string cat;string dtsot;

        public Form5()
        {
            InitializeComponent(); int zero = 0;
            string zerocon = Convert.ToString(zero);
            zbritje.Text = zerocon; fetchdata(); loadname();  loadcategory();
         
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
        private void loadname()
        {

            string nquery = "SELECT Emri FROM furnitoret ORDER BY Emri";
            try
            {
                db_connection();
                MySqlCommand cmd = new MySqlCommand(nquery, connect);
                MySqlDataReader nrd;
                nrd = cmd.ExecuteReader();
                while (nrd.Read())
                {
                    furnitor.Items.Add(nrd["Emri"]);
                }
            }
            catch (Exception ex)
            {

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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void db_connection()
        {
            try
            {
                conn = "Server=localhost;Database=billingsystem;Uid=root;Pwd=;Convert Zero Datetime=True;";
                connect = new MySqlConnection(conn);
                connect.Open();
            }
            catch (MySqlException e)
            {
                throw;
            }
        }
        public void fetchdata()
        {
            db_connection();
            MySqlCommand cmd = new MySqlCommand("SELECT *FROM depo", connect);
            MySqlDataAdapter fd = new MySqlDataAdapter();
            fd.SelectCommand = cmd;
             data = new DataTable();
            data.Columns.Add("ID", typeof(int));
            data.Columns.Add("Barkodi", typeof(string));
            data.Columns.Add("Emertimi", typeof(string));
            data.Columns.Add("Kategoria", typeof(string));
            data.Columns.Add("Data", typeof(string));
            data.Columns.Add("Skadimi", typeof(string));
            data.Columns.Add("Sasia", typeof(string));

            data.Columns.Add("Cmimi", typeof(string));

            data.Columns.Add("TVSH", typeof(string));

            data.Columns.Add("Zbritje", typeof(string));

            data.Columns.Add("Furnitori", typeof(string));

            data.Columns.Add("Totali", typeof(double));

            fd.Fill(data);
            BindingSource fsource = new BindingSource();
            fsource.DataSource = data;
            tabled.DataSource = fsource;
            fd.Update(data);

        }
        private void llog18()
        {
            double sas = Convert.ToDouble(sasia.Text);
            double cmim = Convert.ToDouble(cmimi.Text);
            double shuma = sas * cmim;
          
            double percent = 0.18;
            double vlera = shuma ;
            double ftotal = vlera * percent;
            ft = ftotal.ToString();
            double fall = shuma - ftotal;
            double zbr = Convert.ToDouble(zbritje.Text);
            double zbrpercent = zbr / 100;
            double llogaritja = fall * zbrpercent;
            double finale = fall - llogaritja;
            totali.Text = finale.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            totali.Enabled = false;

            if (checkBox1.Checked && checkBox3.Checked)
            {
                MessageBox.Show("Selekto vetëm një checkbox !");
            }

            if (checkBox1.Checked)
            {
                string s = "";
                if (category.SelectedIndex >= 0)
                {
                    s = category.Items[category.SelectedIndex].ToString();
                }
                llog18();
                db_connection();

                string shortdate = datatime.Value.ToShortDateString();
                 dtsot = datatani.Value.ToShortDateString();
                string aquery = "INSERT INTO depo (Barkodi,Emertimi,Kategoria,Data,Skadimi,Sasia,Cmimi,TVSH,Zbritje,Furnitori,Totali) values('" + this.barkodi.Text + "','" + this.emertimi.Text + "','" + this.category.SelectedItem.ToString() + "','" + dtsot + "','" + shortdate + "','" + this.sasia.Text + "','" + this.cmimi.Text + "','" + this.ft + "','" + this.zbritje.Text + "','" + this.furnitor.SelectedItem.ToString() + "','" + this.totali.Text + "' ) ";

                MySqlCommand command = new MySqlCommand(aquery, connect);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Produkti u regjistrua !");
                    fetchdata();
                }
                else
                {
                    MessageBox.Show("Produkti nuk u regjistrua  !");
                }
            }
            if (checkBox3.Checked)
            {
                checkvalue = "0%";
                double sas = Convert.ToDouble(sasia.Text);
                double cmim = Convert.ToDouble(cmimi.Text);
                double shuma = sas * cmim;
                double zbr = Convert.ToDouble(zbritje.Text);

              


                double vlera = shuma - zbr;
                totali.Text = vlera.ToString();
                      dtsot = datatani.Value.ToShortDateString();
                string shortdate = datatime.Value.ToShortDateString();
                db_connection();
                string aquery = "INSERT INTO depo (Barkodi,Emertimi,Kategoria,Data,Skadimi,Sasia,Cmimi,TVSH,Zbritje,Furnitori,Totali) values('" + this.barkodi.Text + "','" + this.emertimi.Text + "','" + this.category.SelectedItem.ToString() + "','" + dtsot.ToString() + "','" + shortdate + "','" + this.sasia.Text + "','" + this.cmimi.Text + "','" + this.checkvalue + "','" + this.zbritje.Text + "','" + this.furnitor.SelectedItem.ToString() + "','" + this.totali.Text + "' ) ";

                MySqlCommand command = new MySqlCommand(aquery, connect);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Produkti u regjistrua !");
                    fetchdata();
                }
                else
                {
                    MessageBox.Show("Produkti nuk u regjistrua  !");
                }

                connect.Close();



            }




        }
        private void clear()
        {
            barkodi.ResetText();
            sasia.ResetText();
            cmimi.ResetText();
            zbritje.ResetText();
            totali.ResetText();
            emertimi.ResetText();
            checkBox3.Checked = false;
            checkBox1.Checked = false;
            furnitor.SelectedItem = false;


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                checkBox3.Checked = false;
            }
            else
            {
               
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Form1.adminstatus.Equals("Logged : Admin"))
            {
                db_connection();
                if (checkBox1.Checked)
                {
                    string shortdate = datatime.Value.ToShortDateString();

                    llog18();
                    string uquery = "UPDATE  depo  SET Barkodi='" + this.barkodi.Text + "',Emertimi='" + this.emertimi.Text + "',Kategoria='"+this.category.SelectedItem.ToString()+"',Skadimi='"+shortdate+"',Sasia='" + this.sasia.Text + "',Cmimi='" + this.cmimi.Text + "',TVSH='" + this.ft + "',Zbritje='" + this.zbritje.Text + "',Furnitori='" + this.furnitor.SelectedItem.ToString() + "',Totali='" + this.totali.Text + "' WHERE Barkodi='" + this.barkodi.Text + "'";
                    MySqlCommand command = new MySqlCommand(uquery, connect);
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Detajet e produktit janë edituar!");
                        fetchdata();
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Detajet e produktit nuk janë edituar! !");
                    }
                    connect.Close();
                }

                else if (checkBox3.Checked)
                {
                    string shortdate = datatime.Value.ToShortDateString();
                    checkvalue = "0";
                    string uquery = "UPDATE  depo  SET Barkodi='" + this.barkodi.Text + "',Emertimi='" + this.emertimi.Text + "',Kategoria='" + this.category.SelectedItem.ToString() + "',Skadimi='" + shortdate + "',Sasia='" + this.sasia.Text + "',Cmimi='" + this.cmimi.Text + "',TVSH='" + this.checkvalue + "',Zbritje='" + this.zbritje.Text + "',Furnitori='" + this.furnitor.SelectedItem.ToString() + "',Totali='" + this.totali.Text + "' WHERE Barkodi='" + this.barkodi.Text + "'";
                    MySqlCommand command = new MySqlCommand(uquery, connect);
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Detajet e produktit janë edituar!");
                        fetchdata();
                        clear();
                    }

                    else
                    {
                        MessageBox.Show("Detajet e produktit nuk janë edituar! !");
                    }
                    connect.Close();
                }

            }

            else
            {
                button3.Enabled = false;

                MessageBox.Show("Këtë privilegj e ka vetëm admini !");
            }
            connect.Close();

        }

        private void fshijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Form1.adminstatus.Equals("Logged : Admin"))
            {
                db_connection();

                string aquery = "DELETE From depo  WHERE Barkodi='" + this.barkodi.Text + "'";
                MySqlCommand command = new MySqlCommand(aquery, connect);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Produkti është fshirë !!");

                    fetchdata();
                    clear();

                }
                else
                {
                    MessageBox.Show("Produkti nukështë fshirë !");
                }
                connect.Close();
            }
            else
            {
                fshijToolStripMenuItem.Enabled = false;
                MessageBox.Show("Këtë privilegj e ka vetëm admini !");


            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox1.Checked = false;
            }
            else
            {

            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            datatani.Text = DateTime.Now.ToShortDateString();





        }

        private void rifreskoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fetchdata();
        }

        private void tabled_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.tabled.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                barkodi.Text = row.Cells[1].Value.ToString();
                emertimi.Text = row.Cells[2].Value.ToString();
                category.SelectedItem = row.Cells[3].Value.ToString();
            

                sasia.Text = row.Cells[6].Value.ToString();
                 cmimi.Text = row.Cells[7].Value.ToString();

                if (row.Cells[8].Value.ToString().Equals("0%"))
                {
                    checkBox3.Checked = true;
                }
                else
                {
                    checkBox1.Checked = true;
                }
                zbritje.Text = row.Cells[9].Value.ToString();
                furnitor.SelectedItem = row.Cells[10].Value.ToString();
                totali.Text = row.Cells[11].Value.ToString();

            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {


           
                DataView dv = new DataView(data);
                dv.RowFilter = string.Format("Emertimi LIKE '%{0}%'", filterbox.Text);
                tabled.DataSource = dv;

            
        }

        private void filterbox_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void furnitor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void zbritje_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

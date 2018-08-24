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
 using iTextSharp.text.pdf;
 using iTextSharp.text;
using System.IO;
using System.Diagnostics;
using System.Web;


namespace BillingSystemm
{
    public partial class Form10 : Form
    {
        Thread th; private string conn;
        private MySqlConnection connect; DataTable data; string ft; double tvshone; string xheroset; string cashset; string kk;
        public Form10()
        {
            InitializeComponent();
            fetchdata(); totali.Enabled = false; dorezoi.Enabled = false; loadshname(); loadbname(); kkpagesa.Enabled = false; cashpagesa.Enabled = false; banka.Enabled = false;
            datatime.Enabled = false; totali.Enabled = false; loadxhname(); string shemri; zbritje.Text = 0.ToString(); 

        }
        private void formmain(object obj)
        {
            Application.Run(new Form2());
        }
        public void strings()
        {

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
                conn = "Server=localhost;Database=billingsystem;Uid=root;Pwd=;Convert Zero Datetime=True;";
                connect = new MySqlConnection(conn);
                connect.Open();
            }
            catch (MySqlException e)
            {
                throw;
            }
        }
        private void loadxhname()
        {

            string nquery = "SELECT Xhirollogaria FROM xhirollogari ORDER BY Xhirollogaria";
            try
            {
                db_connection();
                MySqlCommand cmd = new MySqlCommand(nquery, connect);
                MySqlDataReader nrd;
                nrd = cmd.ExecuteReader();
                while (nrd.Read())
                {
                    banka.Items.Add(nrd["Xhirollogaria"]);
                }
            }
            catch (Exception ex)
            {

            }
        }
        
        private void loadshname()
        {

            string nquery = "SELECT Emri FROM firma ORDER BY Emri";
            try
            {
                db_connection();
                MySqlCommand cmd = new MySqlCommand(nquery, connect);
                MySqlDataReader nrd;
                nrd = cmd.ExecuteReader();
                while (nrd.Read())
                {
                    shitesi.Items.Add(nrd["Emri"]);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void loadbname()
        {

            string nquery = "SELECT Emri FROM klientet ORDER BY Emri";
            try
            {
                db_connection();
                MySqlCommand cmd = new MySqlCommand(nquery, connect);
                MySqlDataReader nrd;
                nrd = cmd.ExecuteReader();
                while (nrd.Read())
                {
                    bleresi.Items.Add(nrd["Emri"]);
                }
            }
            catch (Exception ex)
            {

            }
        }
        public void fetchdata()
        {
            db_connection();
            MySqlCommand cmd = new MySqlCommand("SELECT *FROM depo where sasia > 0 ", connect);
            MySqlDataAdapter fd = new MySqlDataAdapter();
            fd.SelectCommand = cmd;
            data = new DataTable();
            data.Columns.Add("ID", typeof(int));
            data.Columns.Add("Barkodi", typeof(string));
            data.Columns.Add("Emertimi", typeof(string));
            data.Columns.Add("Kategoria", typeof(string));
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
        void AutoComplete()
        {


        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            dorezoi.Text = Form1.dorezoipagesen;



        }

        private void search_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            DataView dv = new DataView(data);
            dv.RowFilter = string.Format("Emertimi LIKE '%{0}%'", filterbox.Text);
            tabled.DataSource = dv;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (cc.Checked)
            {

                kkpagesa.Text = Form1.dorezoipagesen;
                cash.Checked = false;
                cashpagesa.ResetText();
                banka.Enabled = true;
            }
            else
            {

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cash.Checked)
            {
                banka.Enabled = false;

                cc.Checked = false;
                cashpagesa.Text = Form1.dorezoipagesen;
                kkpagesa.ResetText();
            }
            else
            {
            }
        }
        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            string shitesiquery = "SELECT Emri,NrBiznesit,NrFiskal,NrTatimit,Adresa,Vendi,Telefoni,Email FROM firma WHERE Emri='" + this.shitesi.SelectedItem.ToString() + "'";
            try
            {
                db_connection();
                MySqlCommand cmd = new MySqlCommand(shitesiquery, connect);
                MySqlDataReader nrd;
                nrd = cmd.ExecuteReader();
                while (nrd.Read())
                {
                    string shemri = nrd["Emri"].ToString();
                    string shnrbiznesit = nrd["NrBiznesit"].ToString();
                    string shnrfiskal = nrd["NrFiskal"].ToString();
                    string shnrtatimit = nrd["NrTatimit"].ToString();
                    string shadresa = nrd["Adresa"].ToString();
                    string shvendi = nrd["Vendi"].ToString();
                    string shtelefoni = nrd["Telefoni"].ToString();
                    string shemail = nrd["Email"].ToString();
                    int faturanumber = 1;




                    string hd = "SH.P.K";
                    Document document = new Document();
                    string fn = "Fatura" + faturanumber;
                    PdfWriter.GetInstance(document, new FileStream(@"C:\Users\Sherif\Documents\Visual Studio 2013\Projects\BillingSystemm\fn5.pdf", FileMode.Create));
                    document.Open();




                    Paragraph header = new Paragraph(hd, FontFactory.GetFont("Arial", 15));
                    Paragraph shitesiemri = new Paragraph(shemri, FontFactory.GetFont("Arial", 20));
                    Paragraph shnr = new Paragraph(shnrbiznesit, FontFactory.GetFont("Arial ", 10));
                    Paragraph shnrf = new Paragraph(shnrfiskal, FontFactory.GetFont("Arial ", 10));
                    Paragraph shnrt = new Paragraph(shnrtatimit, FontFactory.GetFont("Arial", 10));
                    Paragraph shadr = new Paragraph(shadresa, FontFactory.GetFont("Arial", 10));
                    Paragraph shven = new Paragraph(shvendi, FontFactory.GetFont("Arial", 10));
                    Paragraph shtel = new Paragraph(shtelefoni, FontFactory.GetFont("Arial", 10));
                    Paragraph shem = new Paragraph(shemail, FontFactory.GetFont("Arial", 10));



                    document.Add(header);

                    document.Add(shitesiemri);
                    document.Add(shnr);
                    document.Add(shnrf);
                    document.Add(shadr);
                    document.Add(shven); document.Add(shtel); document.Add(shem);

                    document.Close();









                }
            }
            catch (Exception ex)
            {

            }


        }

        private void tabled_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.tabled.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                id.Text = row.Cells[0].Value.ToString();
                barkodi.Text = row.Cells[1].Value.ToString();
                emertimi.Text = row.Cells[2].Value.ToString();
                category.Text = row.Cells[3].Value.ToString();
                cmimi.Text = row.Cells[6].Value.ToString();


            }
        }
        public void llog18()
        {
           

        }
        private void button1_Click(object sender, EventArgs e)
        {
            double sas = Convert.ToDouble(sasia.Text);
            double cmim = Convert.ToDouble(cmimi.Text);
            double shuma = sas * cmim;

            double percent = 0.18;
            double vlera = shuma;
            double ftotal = vlera * percent;
            ft = ftotal.ToString();
            double fall = shuma - ftotal;
            double zbr = Convert.ToDouble(zbritje.Text);
            double zbrpercent = zbr / 100;
            double llogaritja = fall * zbrpercent;
            double finale = fall - llogaritja;

            totali.Text = finale.ToString();

            string shortdate = datatime.Value.ToShortDateString();
            cashset = "Cash";
            xheroset = "-";
            kk = "-";
            if (tvsh1.Checked && cash.Checked)
            {
                string tete = 18.ToString();
                tvshone = 18;

                db_connection();
              
                string aquery = "INSERT INTO shitjet (ID,Barkodi,Emertimi,Kategoria,Sasia,Cmimi,TVSH,Zbritje,Data,Shitesi,Bleresi,Pagesa,Xhirollogaria,Dorezoi,PPC,PPKK,Totali) VALUES('" + this.id.Text + "','" + this.barkodi.Text + "',+'" + this.emertimi.Text + "','"+this.category.Text+"','" + this.sasia.Text + "','" + this.cmimi.Text + "','" + fall + "', '" + this.zbritje.Text + "','" + shortdate + "','" + shitesi.SelectedItem.ToString() + "','" + this.bleresi.SelectedItem.ToString() + "','" + cashset + "','" + xheroset + "','" + dorezoi.Text + "','" + cashpagesa.Text + "','" + kk + "','" + this.totali.Text + "')";


                MySqlCommand command = new MySqlCommand(aquery, connect);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Produkti u shit !");
                    fetchdata();

                }
                else
                {
                    MessageBox.Show("Produkti nuk u shit !");
                }
                connect.Close();

            }
            if (tvsh1.Checked && cc.Checked)
            {
                cashset = "Xhirollogari";
                kk = "-";
                db_connection();
                string aquery = "INSERT INTO shitjet (ID,Barkodi,Emertimi,Kategoria,Sasia,Cmimi,TVSH,Zbritje,Data,Shitesi,Bleresi,Pagesa,Xhirollogaria,Dorezoi,PPC,PPKK,Totali) VALUES('" + this.id.Text + "','" + this.barkodi.Text + "',+'" + this.emertimi.Text + "','" + this.category.Text + "','" + this.sasia.Text + "','" + this.cmimi.Text + "','" + fall + "', '" + this.zbritje.Text + "','" + shortdate + "','" + shitesi.SelectedItem.ToString() + "','" + this.bleresi.SelectedItem.ToString() + "','" + cashset + "','" + banka.SelectedItem.ToString() + "','" + dorezoi.Text + "','" + kk + "','" + kkpagesa.Text + "','" + this.totali.Text + "')";


                MySqlCommand command = new MySqlCommand(aquery, connect);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Produkti u shit !");
                    fetchdata();

                }
                else
                {
                    MessageBox.Show("Produkti nuk u shit !");
                }
                connect.Close();

            }


            if (tvsh2.Checked && cash.Checked)
            {
                xheroset = "-";
                kk = "-";

                string tete = 18.ToString();
                tvshone = 0;
                
                db_connection();

                string aquery = "INSERT INTO shitjet (ID,Barkodi,Emertimi,Kategoria,Sasia,Cmimi,TVSH,Zbritje,Data,Shitesi,Bleresi,Pagesa,Xhirollogaria,Dorezoi,PPC,PPKK,Totali) VALUES('" + this.id.Text + "','" + this.barkodi.Text + "',+'" + this.emertimi.Text + "','" + this.category.Text + "','" + this.sasia.Text + "','" + this.cmimi.Text + "','" + tvshone + "', '" + this.zbritje.Text + "','" + shortdate + "','" + shitesi.SelectedItem.ToString() + "','" + this.bleresi.SelectedItem.ToString() + "','" + cashset + "','" + xheroset + "','" + dorezoi.Text + "','" + cashpagesa.Text + "','" + kk + "','" + this.totali.Text + "')";


                MySqlCommand command = new MySqlCommand(aquery, connect);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Produkti u shit !");
                    fetchdata();

                }
                else
                {
                    MessageBox.Show("Produkti nuk u shit !");
                }
                connect.Close();

            }

            if (tvsh2.Checked && cc.Checked)
            {
                cashset = "Xhirollogari";
                kk = "-";
                db_connection();
                string aquery = "INSERT INTO shitjet (ID,Barkodi,Emertimi,Kategoria,Sasia,Cmimi,TVSH,Zbritje,Data,Shitesi,Bleresi,Pagesa,Xhirollogaria,Dorezoi,PPC,PPKK,Totali) VALUES('" + this.id.Text + "','" + this.barkodi.Text + "',+'" + this.emertimi.Text + "','" + this.category.Text+ "','" + this.sasia.Text + "','" + this.cmimi.Text + "','" + fall + "', '" + this.zbritje.Text + "','" + shortdate + "','" + shitesi.SelectedItem.ToString() + "','" + this.bleresi.SelectedItem.ToString() + "','" + cashset + "','" + banka.SelectedItem.ToString() + "','" + dorezoi.Text + "','" + kk + "','" + kkpagesa.Text + "','" + this.totali.Text + "')";


                MySqlCommand command = new MySqlCommand(aquery, connect);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Produkti u shit !");
                    fetchdata();

                }
                else
                {
                    MessageBox.Show("Produkti nuk u shit !");
                }
                connect.Close();

            }



            string usasia="UPDATE depo SET Sasia=Sasia-'"+this.sasia.Text+"' WHERE ID='"+this.id.Text+"'";
            try
            {
                db_connection();
                MySqlCommand us = new MySqlCommand(usasia, connect);
                us.ExecuteNonQuery();
                fetchdata();

            }
            catch (Exception es)
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            id.ResetText();
            barkodi.ResetText();
            emertimi.ResetText();
            sasia.ResetText();
            cmimi.ResetText();
            totali.ResetText();
            zbritje.ResetText();
            tvsh1.Checked = false;
            tvsh2.Checked = false;
            bleresi.ResetText();
            shitesi.ResetText();
            cash.Checked = false;
            cc.Checked = false;
            cashpagesa.ResetText();
            kkpagesa.ResetText();


        }

        private void bleresi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sasia_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}


    
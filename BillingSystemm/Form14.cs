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
    public partial class Form14 : Form
    {
        Thread th; private string conn;
        private MySqlConnection connect; DataTable data;
        public Form14()
        {
            InitializeComponent(); fetchdata(); fetchdatanext();
        }

        private void Form14_Load(object sender, EventArgs e)
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
        public void fetchdata()
        {
            db_connection();
            MySqlCommand cmd = new MySqlCommand("SELECT *FROM depo where sasia=0", connect);
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
            table.DataSource = fsource;
            fd.Update(data);

        }
        public void fetchdatanext()
        {
            db_connection();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `depo` WHERE DATE(Skadimi) > (NOW() - INTERVAL 1 DAY)", connect);
            MySqlDataAdapter fd = new MySqlDataAdapter();
            fd.SelectCommand = cmd;
            data = new DataTable();
            data.Columns.Add("ID", typeof(int));
            data.Columns.Add("Barkodi", typeof(string));
            data.Columns.Add("Emertimi", typeof(string));
            data.Columns.Add("Kategoria", typeof(string));
            data.Columns.Add("Data", typeof(string));
            data.Columns.Add("Skadimi", typeof(DateTime));
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void openmain(){
            Application.Run(new Form2());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            th = new Thread(openmain);
            th.SetApartmentState(ApartmentState.STA);

            th.Start();
            this.Close();

        }
    }
}

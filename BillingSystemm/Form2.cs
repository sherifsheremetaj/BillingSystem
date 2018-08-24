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

namespace BillingSystemm
{
    public partial class Form2 : Form
    {
        Thread th;
        public Form2()
        {
            InitializeComponent();
        }

        private void openmain(object obj)
        {

            Application.Run(new Form7());
        }
        private void forma3(object obj)
        {

            Application.Run(new Form3());
        }
        private void hello(object obj)
        {

            Application.Run(new Form7());
        }
        private void info(object obj)
        {
            Application.Run(new Form8());
        }
        private void openstock(object obj)
        {

            Application.Run(new Form5());
        }
        private void openclients(object obj)
        {

            Application.Run(new Form6());
        }
        private void mainform(object obj)
        {
            Application.Run(new Form1());
        }
        private void open2()
        {
            Application.Run(new Form1());
        }
        private void shitja(object obj)
        {
            Application.Run(new Form10());

        }
        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            th = new Thread(forma3);
            th.SetApartmentState(ApartmentState.STA);

            th.Start();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            statuslog.Text = Form1.adminstatus;
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            th = new Thread(openstock);
            th.SetApartmentState(ApartmentState.STA);

            th.Start();
            this.Close();
        }

        private void clients_Click(object sender, EventArgs e)
        {
            th = new Thread(openclients);
            th.SetApartmentState(ApartmentState.STA);
            this.Close();
            th.Start();
        }

        private void sell_Click(object sender, EventArgs e)
        {
            th = new Thread(shitja);
            th.SetApartmentState(ApartmentState.STA);

            th.Start();
            this.Close();
        }

        private void bunifuTileButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton2_Click_2(object sender, EventArgs e)
        {
            th = new Thread(hello);
            th.SetApartmentState(ApartmentState.STA);
            this.Close();
            th.Start();
        }

        private void bunifuTileButton2_Click_3(object sender, EventArgs e)
        {
            th = new Thread(info);
            th.SetApartmentState(ApartmentState.STA);

            th.Start();
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            th = new Thread(open2);
            th.SetApartmentState(ApartmentState.STA);

            th.Start();
            this.Close();
        }
        private void fform(object obj)
        {
            Application.Run(new Form9());
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            th = new Thread(fform);
            th.SetApartmentState(ApartmentState.STA);

            th.Start();
            this.Close();
        }
        void productinfo()
        {
            Application.Run(new Form14());
        }
        private void bunifuTileButton8_Click(object sender, EventArgs e)
        {
            th = new Thread(productinfo);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }
        void mnform()
        {
            Application.Run(new Form11());
        }
        private void bunifuTileButton6_Click(object sender, EventArgs e)
        {
            th = new Thread(mnform);
            th.SetApartmentState(ApartmentState.STA);

            th.Start();
            this.Close();
        }
        void menuform()
        {
            Application.Run(new Form12());
        }
        private void bunifuTileButton7_Click(object sender, EventArgs e)
        {
            th = new Thread(menuform);
            th.SetApartmentState(ApartmentState.STA);

            th.Start();
            this.Close();
        }
        void openshitur()
        {
            Application.Run(new Form13());
        }
        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            th = new Thread(openshitur);
            th.SetApartmentState(ApartmentState.STA);

            th.Start();
            this.Close();
        }
    }
}

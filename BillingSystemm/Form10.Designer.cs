namespace BillingSystemm
{
    partial class Form10
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            this.tabled = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.filterbox = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.barkodi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emertimi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sasia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmimi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tvsh1 = new System.Windows.Forms.CheckBox();
            this.tvsh2 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.zbritje = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.totali = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.shitesi = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.bleresi = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.datatime = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.cash = new System.Windows.Forms.CheckBox();
            this.cc = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dorezoi = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cashpagesa = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.kkpagesa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.banka = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tabled)).BeginInit();
            this.SuspendLayout();
            // 
            // tabled
            // 
            this.tabled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabled.Location = new System.Drawing.Point(80, 73);
            this.tabled.Name = "tabled";
            this.tabled.Size = new System.Drawing.Size(1136, 332);
            this.tabled.TabIndex = 18;
            this.tabled.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabled_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID";
            // 
            // filterbox
            // 
            this.filterbox.Location = new System.Drawing.Point(990, 30);
            this.filterbox.Multiline = true;
            this.filterbox.Name = "filterbox";
            this.filterbox.Size = new System.Drawing.Size(226, 37);
            this.filterbox.TabIndex = 20;
            this.filterbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(100, 450);
            this.id.Multiline = true;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(182, 34);
            this.id.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 495);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "Barkodi";
            // 
            // barkodi
            // 
            this.barkodi.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barkodi.Location = new System.Drawing.Point(100, 518);
            this.barkodi.Multiline = true;
            this.barkodi.Name = "barkodi";
            this.barkodi.Size = new System.Drawing.Size(182, 34);
            this.barkodi.TabIndex = 23;
            this.barkodi.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 555);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 22);
            this.label3.TabIndex = 24;
            this.label3.Text = "Emertimi";
            // 
            // emertimi
            // 
            this.emertimi.Font = new System.Drawing.Font("Open Sans", 9.75F);
            this.emertimi.Location = new System.Drawing.Point(100, 582);
            this.emertimi.Multiline = true;
            this.emertimi.Name = "emertimi";
            this.emertimi.Size = new System.Drawing.Size(182, 34);
            this.emertimi.TabIndex = 25;
            this.emertimi.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 696);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 22);
            this.label4.TabIndex = 26;
            this.label4.Text = "Sasia";
            // 
            // sasia
            // 
            this.sasia.Font = new System.Drawing.Font("Open Sans", 9.75F);
            this.sasia.Location = new System.Drawing.Point(100, 721);
            this.sasia.Multiline = true;
            this.sasia.Name = "sasia";
            this.sasia.Size = new System.Drawing.Size(182, 34);
            this.sasia.TabIndex = 27;
            this.sasia.TextChanged += new System.EventHandler(this.sasia_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(349, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 22);
            this.label5.TabIndex = 28;
            this.label5.Text = "Çmimi";
            // 
            // cmimi
            // 
            this.cmimi.Font = new System.Drawing.Font("Open Sans", 9.75F);
            this.cmimi.Location = new System.Drawing.Point(353, 454);
            this.cmimi.Multiline = true;
            this.cmimi.Name = "cmimi";
            this.cmimi.Size = new System.Drawing.Size(182, 34);
            this.cmimi.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(349, 495);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 22);
            this.label6.TabIndex = 30;
            this.label6.Text = "TVSH";
            // 
            // tvsh1
            // 
            this.tvsh1.AutoSize = true;
            this.tvsh1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvsh1.Location = new System.Drawing.Point(353, 520);
            this.tvsh1.Name = "tvsh1";
            this.tvsh1.Size = new System.Drawing.Size(60, 26);
            this.tvsh1.TabIndex = 31;
            this.tvsh1.Text = "18%";
            this.tvsh1.UseVisualStyleBackColor = true;
            // 
            // tvsh2
            // 
            this.tvsh2.AutoSize = true;
            this.tvsh2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvsh2.Location = new System.Drawing.Point(459, 520);
            this.tvsh2.Name = "tvsh2";
            this.tvsh2.Size = new System.Drawing.Size(51, 26);
            this.tvsh2.TabIndex = 32;
            this.tvsh2.Text = "0%";
            this.tvsh2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(349, 555);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 22);
            this.label7.TabIndex = 33;
            this.label7.Text = "Zbritje";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // zbritje
            // 
            this.zbritje.Font = new System.Drawing.Font("Open Sans", 9.75F);
            this.zbritje.Location = new System.Drawing.Point(353, 580);
            this.zbritje.Multiline = true;
            this.zbritje.Name = "zbritje";
            this.zbritje.Size = new System.Drawing.Size(182, 34);
            this.zbritje.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(834, 555);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 22);
            this.label8.TabIndex = 35;
            this.label8.Text = "Totali";
            // 
            // totali
            // 
            this.totali.Location = new System.Drawing.Point(838, 579);
            this.totali.Multiline = true;
            this.totali.Name = "totali";
            this.totali.Size = new System.Drawing.Size(182, 71);
            this.totali.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(349, 696);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 22);
            this.label9.TabIndex = 37;
            this.label9.Text = "Shitësi";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // shitesi
            // 
            this.shitesi.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shitesi.FormattingEnabled = true;
            this.shitesi.Location = new System.Drawing.Point(353, 721);
            this.shitesi.Name = "shitesi";
            this.shitesi.Size = new System.Drawing.Size(182, 30);
            this.shitesi.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(605, 429);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 22);
            this.label10.TabIndex = 39;
            this.label10.Text = "Blerësi";
            // 
            // bleresi
            // 
            this.bleresi.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bleresi.FormattingEnabled = true;
            this.bleresi.Location = new System.Drawing.Point(609, 458);
            this.bleresi.Name = "bleresi";
            this.bleresi.Size = new System.Drawing.Size(182, 30);
            this.bleresi.TabIndex = 40;
            this.bleresi.SelectedIndexChanged += new System.EventHandler(this.bleresi_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(605, 555);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 22);
            this.label11.TabIndex = 41;
            this.label11.Text = "Xhirollogaria";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(349, 628);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 22);
            this.label12.TabIndex = 43;
            this.label12.Text = "Data";
            // 
            // datatime
            // 
            this.datatime.CalendarFont = new System.Drawing.Font("Open Sans", 9F);
            this.datatime.Font = new System.Drawing.Font("Open Sans", 12F);
            this.datatime.Location = new System.Drawing.Point(353, 654);
            this.datatime.Name = "datatime";
            this.datatime.Size = new System.Drawing.Size(182, 29);
            this.datatime.TabIndex = 44;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(605, 495);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 22);
            this.label13.TabIndex = 45;
            this.label13.Text = "Pagesa";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // cash
            // 
            this.cash.AutoSize = true;
            this.cash.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cash.Location = new System.Drawing.Point(615, 520);
            this.cash.Name = "cash";
            this.cash.Size = new System.Drawing.Size(66, 26);
            this.cash.TabIndex = 46;
            this.cash.Text = "Cash";
            this.cash.UseVisualStyleBackColor = true;
            this.cash.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cc
            // 
            this.cc.AutoSize = true;
            this.cc.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cc.Location = new System.Drawing.Point(687, 522);
            this.cc.Name = "cc";
            this.cc.Size = new System.Drawing.Size(116, 26);
            this.cc.TabIndex = 47;
            this.cc.Text = "Xhirollogari";
            this.cc.UseVisualStyleBackColor = true;
            this.cc.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(605, 628);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 22);
            this.label14.TabIndex = 48;
            this.label14.Text = "Dorëzoi";
            // 
            // dorezoi
            // 
            this.dorezoi.Font = new System.Drawing.Font("Open Sans", 9.75F);
            this.dorezoi.Location = new System.Drawing.Point(609, 649);
            this.dorezoi.Multiline = true;
            this.dorezoi.Name = "dorezoi";
            this.dorezoi.Size = new System.Drawing.Size(182, 34);
            this.dorezoi.TabIndex = 49;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(605, 696);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(167, 22);
            this.label15.TabIndex = 50;
            this.label15.Text = "Pranoi pagesën cash";
            // 
            // cashpagesa
            // 
            this.cashpagesa.Font = new System.Drawing.Font("Open Sans", 9.75F);
            this.cashpagesa.Location = new System.Drawing.Point(609, 724);
            this.cashpagesa.Multiline = true;
            this.cashpagesa.Name = "cashpagesa";
            this.cashpagesa.Size = new System.Drawing.Size(182, 34);
            this.cashpagesa.TabIndex = 51;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(834, 429);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(180, 22);
            this.label16.TabIndex = 52;
            this.label16.Text = "Pranoi pagesën me KK";
            // 
            // kkpagesa
            // 
            this.kkpagesa.Font = new System.Drawing.Font("Open Sans", 9.75F);
            this.kkpagesa.Location = new System.Drawing.Point(838, 458);
            this.kkpagesa.Multiline = true;
            this.kkpagesa.Name = "kkpagesa";
            this.kkpagesa.Size = new System.Drawing.Size(182, 34);
            this.kkpagesa.TabIndex = 53;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1075, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 34);
            this.button1.TabIndex = 54;
            this.button1.Text = "Shite";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1075, 514);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 38);
            this.button3.TabIndex = 55;
            this.button3.Text = "Eksporto PDF";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1075, 580);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 34);
            this.button4.TabIndex = 56;
            this.button4.Text = "Pastro";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // banka
            // 
            this.banka.Font = new System.Drawing.Font("Open Sans", 12F);
            this.banka.FormattingEnabled = true;
            this.banka.Location = new System.Drawing.Point(609, 579);
            this.banka.Name = "banka";
            this.banka.Size = new System.Drawing.Size(182, 30);
            this.banka.TabIndex = 57;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(1, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 36);
            this.button2.TabIndex = 17;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(96, 628);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 22);
            this.label17.TabIndex = 58;
            this.label17.Text = "Kategoria";
            // 
            // category
            // 
            this.category.Font = new System.Drawing.Font("Open Sans", 9.75F);
            this.category.Location = new System.Drawing.Point(100, 654);
            this.category.Multiline = true;
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(182, 34);
            this.category.TabIndex = 59;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 810);
            this.Controls.Add(this.category);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.banka);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kkpagesa);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cashpagesa);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dorezoi);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cc);
            this.Controls.Add(this.cash);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.datatime);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.bleresi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.shitesi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.totali);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.zbritje);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tvsh2);
            this.Controls.Add(this.tvsh1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmimi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sasia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.emertimi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.barkodi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.id);
            this.Controls.Add(this.filterbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabled);
            this.Controls.Add(this.button2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form10";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabled)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView tabled;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filterbox;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox barkodi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emertimi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sasia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cmimi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox tvsh1;
        private System.Windows.Forms.CheckBox tvsh2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox zbritje;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox totali;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox shitesi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox bleresi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker datatime;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox cash;
        private System.Windows.Forms.CheckBox cc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox dorezoi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox cashpagesa;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox kkpagesa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox banka;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox category;
    }
}
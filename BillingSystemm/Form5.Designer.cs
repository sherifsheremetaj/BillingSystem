namespace BillingSystemm
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.label1 = new System.Windows.Forms.Label();
            this.barkodi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.emertimi = new System.Windows.Forms.TextBox();
            this.sasia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmimi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.zbritje = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabled = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rifreskoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fshijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.totali = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.furnitor = new System.Windows.Forms.ComboBox();
            this.filterbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.datatime = new System.Windows.Forms.DateTimePicker();
            this.category = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.datatani = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.tabled)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Barkodi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // barkodi
            // 
            this.barkodi.Font = new System.Drawing.Font("Open Sans", 9.25F);
            this.barkodi.Location = new System.Drawing.Point(16, 87);
            this.barkodi.Multiline = true;
            this.barkodi.Name = "barkodi";
            this.barkodi.Size = new System.Drawing.Size(197, 31);
            this.barkodi.TabIndex = 18;
            this.barkodi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Emertimi";
            // 
            // emertimi
            // 
            this.emertimi.Font = new System.Drawing.Font("Open Sans", 9.25F);
            this.emertimi.Location = new System.Drawing.Point(16, 144);
            this.emertimi.Multiline = true;
            this.emertimi.Name = "emertimi";
            this.emertimi.Size = new System.Drawing.Size(197, 31);
            this.emertimi.TabIndex = 20;
            // 
            // sasia
            // 
            this.sasia.Font = new System.Drawing.Font("Open Sans", 9.25F);
            this.sasia.Location = new System.Drawing.Point(16, 355);
            this.sasia.Multiline = true;
            this.sasia.Name = "sasia";
            this.sasia.Size = new System.Drawing.Size(197, 31);
            this.sasia.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Çmimi";
            // 
            // cmimi
            // 
            this.cmimi.Font = new System.Drawing.Font("Open Sans", 9.25F);
            this.cmimi.Location = new System.Drawing.Point(16, 412);
            this.cmimi.Multiline = true;
            this.cmimi.Name = "cmimi";
            this.cmimi.Size = new System.Drawing.Size(197, 31);
            this.cmimi.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 446);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "TVSH";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(28, 469);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(58, 24);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "18%";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(124, 469);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(49, 24);
            this.checkBox3.TabIndex = 28;
            this.checkBox3.Text = "0%";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 496);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Zbritje";
            // 
            // zbritje
            // 
            this.zbritje.Font = new System.Drawing.Font("Open Sans", 9.25F);
            this.zbritje.Location = new System.Drawing.Point(16, 519);
            this.zbritje.Multiline = true;
            this.zbritje.Name = "zbritje";
            this.zbritje.Size = new System.Drawing.Size(197, 31);
            this.zbritje.TabIndex = 30;
            this.zbritje.TextChanged += new System.EventHandler(this.zbritje_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(238, 553);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 49);
            this.button1.TabIndex = 31;
            this.button1.Text = "Regjistro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(238, 621);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(197, 49);
            this.button3.TabIndex = 32;
            this.button3.Text = "Edito";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabled
            // 
            this.tabled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabled.ContextMenuStrip = this.contextMenuStrip1;
            this.tabled.Location = new System.Drawing.Point(238, 87);
            this.tabled.Name = "tabled";
            this.tabled.Size = new System.Drawing.Size(997, 445);
            this.tabled.TabIndex = 33;
            this.tabled.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabled_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rifreskoToolStripMenuItem,
            this.fshijToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(124, 52);
            // 
            // rifreskoToolStripMenuItem
            // 
            this.rifreskoToolStripMenuItem.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rifreskoToolStripMenuItem.Name = "rifreskoToolStripMenuItem";
            this.rifreskoToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.rifreskoToolStripMenuItem.Text = "Rifresko";
            this.rifreskoToolStripMenuItem.Click += new System.EventHandler(this.rifreskoToolStripMenuItem_Click);
            // 
            // fshijToolStripMenuItem
            // 
            this.fshijToolStripMenuItem.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fshijToolStripMenuItem.Name = "fshijToolStripMenuItem";
            this.fshijToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.fshijToolStripMenuItem.Text = "Fshij";
            this.fshijToolStripMenuItem.Click += new System.EventHandler(this.fshijToolStripMenuItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 616);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "Totali";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // totali
            // 
            this.totali.Font = new System.Drawing.Font("Open Sans", 9.25F);
            this.totali.Location = new System.Drawing.Point(16, 639);
            this.totali.Multiline = true;
            this.totali.Name = "totali";
            this.totali.Size = new System.Drawing.Size(197, 31);
            this.totali.TabIndex = 36;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(1, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 36);
            this.button2.TabIndex = 16;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 553);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "Furnitori";
            // 
            // furnitor
            // 
            this.furnitor.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.furnitor.FormattingEnabled = true;
            this.furnitor.Location = new System.Drawing.Point(16, 587);
            this.furnitor.Name = "furnitor";
            this.furnitor.Size = new System.Drawing.Size(197, 26);
            this.furnitor.TabIndex = 38;
            this.furnitor.SelectedIndexChanged += new System.EventHandler(this.furnitor_SelectedIndexChanged);
            // 
            // filterbox
            // 
            this.filterbox.Location = new System.Drawing.Point(1033, 49);
            this.filterbox.Multiline = true;
            this.filterbox.Name = "filterbox";
            this.filterbox.Size = new System.Drawing.Size(202, 32);
            this.filterbox.TabIndex = 39;
            this.filterbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.filterbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filterbox_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 40;
            this.label9.Text = "Kategoria";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 20);
            this.label10.TabIndex = 43;
            this.label10.Text = "Data e skadimit";
            // 
            // datatime
            // 
            this.datatime.Location = new System.Drawing.Point(16, 309);
            this.datatime.Name = "datatime";
            this.datatime.Size = new System.Drawing.Size(197, 20);
            this.datatime.TabIndex = 44;
            // 
            // category
            // 
            this.category.FormattingEnabled = true;
            this.category.Location = new System.Drawing.Point(16, 211);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(197, 21);
            this.category.TabIndex = 45;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "Sasia";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 235);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 20);
            this.label11.TabIndex = 48;
            this.label11.Text = "Data";
            // 
            // datatani
            // 
            this.datatani.Location = new System.Drawing.Point(16, 258);
            this.datatani.Name = "datatani";
            this.datatani.Size = new System.Drawing.Size(197, 20);
            this.datatani.TabIndex = 49;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 733);
            this.Controls.Add(this.datatani);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.category);
            this.Controls.Add(this.datatime);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.filterbox);
            this.Controls.Add(this.furnitor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.totali);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tabled);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.zbritje);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmimi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sasia);
            this.Controls.Add(this.emertimi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.barkodi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form5";
            this.Text = "Depo";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabled)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox barkodi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emertimi;
        private System.Windows.Forms.TextBox sasia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cmimi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox zbritje;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView tabled;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rifreskoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fshijToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox totali;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox furnitor;
        private System.Windows.Forms.TextBox filterbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker datatime;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker datatani;
    }
}
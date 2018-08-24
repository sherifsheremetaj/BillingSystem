namespace BillingSystemm
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.label1 = new System.Windows.Forms.Label();
            this.emri = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nrb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nrf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nrt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.adr = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tablef = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fshijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.filterbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablef)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 11.25F);
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emri";
            // 
            // emri
            // 
            this.emri.Font = new System.Drawing.Font("Open Sans", 9.25F);
            this.emri.Location = new System.Drawing.Point(16, 85);
            this.emri.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.emri.Multiline = true;
            this.emri.Name = "emri";
            this.emri.Size = new System.Drawing.Size(188, 41);
            this.emri.TabIndex = 1;
            this.emri.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 11.25F);
            this.label2.Location = new System.Drawing.Point(12, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nr.Biznesit";
            // 
            // nrb
            // 
            this.nrb.Font = new System.Drawing.Font("Open Sans", 9.25F);
            this.nrb.Location = new System.Drawing.Point(16, 168);
            this.nrb.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.nrb.Multiline = true;
            this.nrb.Name = "nrb";
            this.nrb.Size = new System.Drawing.Size(188, 41);
            this.nrb.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 11.25F);
            this.label3.Location = new System.Drawing.Point(12, 224);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nr.Fiskal";
            // 
            // nrf
            // 
            this.nrf.Font = new System.Drawing.Font("Open Sans", 9.25F);
            this.nrf.Location = new System.Drawing.Point(16, 247);
            this.nrf.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.nrf.Multiline = true;
            this.nrf.Name = "nrf";
            this.nrf.Size = new System.Drawing.Size(188, 41);
            this.nrf.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 11.25F);
            this.label4.Location = new System.Drawing.Point(12, 308);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nr.Tatimit";
            // 
            // nrt
            // 
            this.nrt.Font = new System.Drawing.Font("Open Sans", 9.25F);
            this.nrt.Location = new System.Drawing.Point(16, 331);
            this.nrt.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.nrt.Multiline = true;
            this.nrt.Name = "nrt";
            this.nrt.Size = new System.Drawing.Size(188, 41);
            this.nrt.TabIndex = 7;
            this.nrt.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 11.25F);
            this.label5.Location = new System.Drawing.Point(12, 392);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Adresa";
            // 
            // adr
            // 
            this.adr.Font = new System.Drawing.Font("Open Sans", 9.25F);
            this.adr.Location = new System.Drawing.Point(16, 415);
            this.adr.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.adr.Multiline = true;
            this.adr.Name = "adr";
            this.adr.Size = new System.Drawing.Size(188, 41);
            this.adr.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(16, 557);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 47);
            this.button1.TabIndex = 10;
            this.button1.Text = "Regjistro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(13, 622);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 47);
            this.button2.TabIndex = 11;
            this.button2.Text = "Edito";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tablef
            // 
            this.tablef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablef.ContextMenuStrip = this.contextMenuStrip1;
            this.tablef.Location = new System.Drawing.Point(223, 85);
            this.tablef.Name = "tablef";
            this.tablef.Size = new System.Drawing.Size(741, 371);
            this.tablef.TabIndex = 12;
            this.tablef.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablef_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.fshijToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 56);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Font = new System.Drawing.Font("Open Sans", 12F);
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // fshijToolStripMenuItem
            // 
            this.fshijToolStripMenuItem.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fshijToolStripMenuItem.Name = "fshijToolStripMenuItem";
            this.fshijToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.fshijToolStripMenuItem.Text = "Fshij";
            this.fshijToolStripMenuItem.Click += new System.EventHandler(this.fshijToolStripMenuItem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 11.25F);
            this.label6.Location = new System.Drawing.Point(13, 466);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nr.Telefonit";
            // 
            // tel
            // 
            this.tel.Font = new System.Drawing.Font("Open Sans", 9.25F);
            this.tel.Location = new System.Drawing.Point(16, 487);
            this.tel.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.tel.Multiline = true;
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(188, 41);
            this.tel.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(2, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 36);
            this.button3.TabIndex = 16;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // filterbox
            // 
            this.filterbox.Location = new System.Drawing.Point(775, 44);
            this.filterbox.Multiline = true;
            this.filterbox.Name = "filterbox";
            this.filterbox.Size = new System.Drawing.Size(189, 35);
            this.filterbox.TabIndex = 17;
            this.filterbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 692);
            this.Controls.Add(this.filterbox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tablef);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.adr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nrt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nrf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nrb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emri);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Open Sans", 7.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.MaximizeBox = false;
            this.Name = "Form9";
            this.Text = "Furnitorët";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablef)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nrb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nrf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nrt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox adr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView tablef;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fshijToolStripMenuItem;
        private System.Windows.Forms.TextBox filterbox;
    }
}
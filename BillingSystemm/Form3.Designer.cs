namespace BillingSystemm
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.oldpassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.newpassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.admin = new System.Windows.Forms.CheckBox();
            this.staff = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.addnew = new Bunifu.Framework.UI.BunifuTileButton();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 11F);
            this.label1.Location = new System.Drawing.Point(21, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Përdoruesi";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(25, 85);
            this.username.Multiline = true;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(168, 32);
            this.username.TabIndex = 1;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 11F);
            this.label2.Location = new System.Drawing.Point(21, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fjalëkalimi i vjetër";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // oldpassword
            // 
            this.oldpassword.Location = new System.Drawing.Point(25, 161);
            this.oldpassword.Multiline = true;
            this.oldpassword.Name = "oldpassword";
            this.oldpassword.Size = new System.Drawing.Size(168, 29);
            this.oldpassword.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 11F);
            this.label3.Location = new System.Drawing.Point(21, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fjalëkalimi i ri";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // newpassword
            // 
            this.newpassword.Location = new System.Drawing.Point(25, 216);
            this.newpassword.Multiline = true;
            this.newpassword.Name = "newpassword";
            this.newpassword.Size = new System.Drawing.Size(168, 29);
            this.newpassword.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 11F);
            this.label4.Location = new System.Drawing.Point(21, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Privilegji";
            // 
            // admin
            // 
            this.admin.AutoSize = true;
            this.admin.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin.Location = new System.Drawing.Point(25, 283);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(73, 24);
            this.admin.TabIndex = 7;
            this.admin.Text = "Admin";
            this.admin.UseVisualStyleBackColor = true;
            // 
            // staff
            // 
            this.staff.AutoSize = true;
            this.staff.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staff.Location = new System.Drawing.Point(25, 313);
            this.staff.Name = "staff";
            this.staff.Size = new System.Drawing.Size(59, 24);
            this.staff.TabIndex = 8;
            this.staff.Text = "Staff";
            this.staff.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(25, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 43);
            this.button1.TabIndex = 9;
            this.button1.Text = "Change";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addnew
            // 
            this.addnew.BackColor = System.Drawing.Color.SeaGreen;
            this.addnew.color = System.Drawing.Color.SeaGreen;
            this.addnew.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.addnew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addnew.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.addnew.ForeColor = System.Drawing.Color.White;
            this.addnew.Image = ((System.Drawing.Image)(resources.GetObject("addnew.Image")));
            this.addnew.ImagePosition = 20;
            this.addnew.ImageZoom = 50;
            this.addnew.LabelPosition = 41;
            this.addnew.LabelText = "Shto";
            this.addnew.Location = new System.Drawing.Point(236, 62);
            this.addnew.Margin = new System.Windows.Forms.Padding(6);
            this.addnew.Name = "addnew";
            this.addnew.Size = new System.Drawing.Size(151, 159);
            this.addnew.TabIndex = 10;
            this.addnew.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(25, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 36);
            this.button2.TabIndex = 11;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 434);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addnew);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.staff);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.newpassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.oldpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.Text = "Admin Detajet";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox oldpassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newpassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox admin;
        private System.Windows.Forms.CheckBox staff;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuTileButton addnew;
        private System.Windows.Forms.Button button2;
    }
}
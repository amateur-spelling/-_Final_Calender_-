namespace ___Final_Calender___
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.btexit = new System.Windows.Forms.Button();
            this.btclear = new System.Windows.Forms.Button();
            this.btdel = new System.Windows.Forms.Button();
            this.btsave = new System.Windows.Forms.Button();
            this.lbnote1 = new System.Windows.Forms.ListBox();
            this.tbnote1 = new System.Windows.Forms.TextBox();
            this.cbmonth = new System.Windows.Forms.ComboBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btRed = new System.Windows.Forms.Button();
            this.btBlue = new System.Windows.Forms.Button();
            this.btGreen = new System.Windows.Forms.Button();
            this.btTRNfnt = new System.Windows.Forms.Button();
            this.btBlack = new System.Windows.Forms.Button();
            this.btSUIfnt = new System.Windows.Forms.Button();
            this.gb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.btexit);
            this.gb1.Controls.Add(this.btclear);
            this.gb1.Controls.Add(this.btdel);
            this.gb1.Controls.Add(this.btsave);
            this.gb1.Controls.Add(this.lbnote1);
            this.gb1.Controls.Add(this.tbnote1);
            this.gb1.Controls.Add(this.cbmonth);
            this.gb1.Location = new System.Drawing.Point(12, 12);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(245, 299);
            this.gb1.TabIndex = 8;
            this.gb1.TabStop = false;
            this.gb1.Text = "2026";
            // 
            // btexit
            // 
            this.btexit.Location = new System.Drawing.Point(167, 245);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(72, 48);
            this.btexit.TabIndex = 6;
            this.btexit.Text = "Exit";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // btclear
            // 
            this.btclear.Location = new System.Drawing.Point(7, 245);
            this.btclear.Name = "btclear";
            this.btclear.Size = new System.Drawing.Size(72, 48);
            this.btclear.TabIndex = 6;
            this.btclear.Text = "Clear";
            this.btclear.UseVisualStyleBackColor = true;
            this.btclear.Click += new System.EventHandler(this.btclear_Click);
            // 
            // btdel
            // 
            this.btdel.Location = new System.Drawing.Point(85, 245);
            this.btdel.Name = "btdel";
            this.btdel.Size = new System.Drawing.Size(72, 48);
            this.btdel.TabIndex = 5;
            this.btdel.Text = "Delete";
            this.btdel.UseVisualStyleBackColor = true;
            this.btdel.Click += new System.EventHandler(this.btdel_Click);
            // 
            // btsave
            // 
            this.btsave.Location = new System.Drawing.Point(133, 208);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(73, 23);
            this.btsave.TabIndex = 4;
            this.btsave.Text = "Save";
            this.btsave.UseVisualStyleBackColor = true;
            this.btsave.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbnote1
            // 
            this.lbnote1.FormattingEnabled = true;
            this.lbnote1.ItemHeight = 15;
            this.lbnote1.Location = new System.Drawing.Point(4, 51);
            this.lbnote1.Name = "lbnote1";
            this.lbnote1.Size = new System.Drawing.Size(235, 154);
            this.lbnote1.TabIndex = 3;
            // 
            // tbnote1
            // 
            this.tbnote1.Location = new System.Drawing.Point(7, 208);
            this.tbnote1.Name = "tbnote1";
            this.tbnote1.Size = new System.Drawing.Size(120, 23);
            this.tbnote1.TabIndex = 2;
            // 
            // cbmonth
            // 
            this.cbmonth.FormattingEnabled = true;
            this.cbmonth.Location = new System.Drawing.Point(6, 22);
            this.cbmonth.Name = "cbmonth";
            this.cbmonth.Size = new System.Drawing.Size(121, 23);
            this.cbmonth.TabIndex = 0;
            // 
            // btRed
            // 
            this.btRed.Location = new System.Drawing.Point(272, 50);
            this.btRed.Name = "btRed";
            this.btRed.Size = new System.Drawing.Size(112, 37);
            this.btRed.TabIndex = 11;
            this.btRed.Text = "Red Text";
            this.btRed.UseVisualStyleBackColor = true;
            // 
            // btBlue
            // 
            this.btBlue.Location = new System.Drawing.Point(272, 137);
            this.btBlue.Name = "btBlue";
            this.btBlue.Size = new System.Drawing.Size(112, 37);
            this.btBlue.TabIndex = 12;
            this.btBlue.Text = "Blue Text";
            this.btBlue.UseVisualStyleBackColor = true;
            // 
            // btGreen
            // 
            this.btGreen.Location = new System.Drawing.Point(272, 93);
            this.btGreen.Name = "btGreen";
            this.btGreen.Size = new System.Drawing.Size(112, 37);
            this.btGreen.TabIndex = 13;
            this.btGreen.Text = "Green Text";
            this.btGreen.UseVisualStyleBackColor = true;
            this.btGreen.Click += new System.EventHandler(this.btGreen_Click);
            // 
            // btTRNfnt
            // 
            this.btTRNfnt.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btTRNfnt.Location = new System.Drawing.Point(272, 220);
            this.btTRNfnt.Name = "btTRNfnt";
            this.btTRNfnt.Size = new System.Drawing.Size(112, 43);
            this.btTRNfnt.TabIndex = 14;
            this.btTRNfnt.Text = "Times New Roman Font";
            this.btTRNfnt.UseVisualStyleBackColor = true;
            this.btTRNfnt.Click += new System.EventHandler(this.btTNRfnt_Click);
            // 
            // btBlack
            // 
            this.btBlack.Location = new System.Drawing.Point(272, 177);
            this.btBlack.Name = "btBlack";
            this.btBlack.Size = new System.Drawing.Size(112, 37);
            this.btBlack.TabIndex = 15;
            this.btBlack.Text = "Black Text";
            this.btBlack.UseVisualStyleBackColor = true;
            this.btBlack.Click += new System.EventHandler(this.btBlack_Click);
            // 
            // btSUIfnt
            // 
            this.btSUIfnt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btSUIfnt.Location = new System.Drawing.Point(272, 269);
            this.btSUIfnt.Name = "btSUIfnt";
            this.btSUIfnt.Size = new System.Drawing.Size(112, 42);
            this.btSUIfnt.TabIndex = 16;
            this.btSUIfnt.Text = "Segoe UI Font";
            this.btSUIfnt.UseVisualStyleBackColor = true;
            this.btSUIfnt.Click += new System.EventHandler(this.btSUIfnt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 355);
            this.Controls.Add(this.btSUIfnt);
            this.Controls.Add(this.btBlack);
            this.Controls.Add(this.btTRNfnt);
            this.Controls.Add(this.btGreen);
            this.Controls.Add(this.btBlue);
            this.Controls.Add(this.btRed);
            this.Controls.Add(this.gb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox gb1;
        private ComboBox cbmonth;
        private TextBox tbnote1;
        private Button btexit;
        private Button btdel;
        private Button btsave;
        private ListBox lbnote1;
        private Button btclear;
        private FontDialog fontDialog1;
        private Button btRed;
        private Button btBlue;
        private Button btGreen;
        private Button btSUIfnt;
        private Button btTRNfnt;
        private Button btBlack;
    }
}
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
            this.lbl = new System.Windows.Forms.Label();
            this.btexit = new System.Windows.Forms.Button();
            this.btclear = new System.Windows.Forms.Button();
            this.btdel = new System.Windows.Forms.Button();
            this.btsave = new System.Windows.Forms.Button();
            this.tbnote1 = new System.Windows.Forms.TextBox();
            this.cbd = new System.Windows.Forms.ComboBox();
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
            this.gb1.BackColor = System.Drawing.Color.LightBlue;
            this.gb1.Controls.Add(this.lbl);
            this.gb1.Controls.Add(this.btexit);
            this.gb1.Controls.Add(this.btclear);
            this.gb1.Controls.Add(this.btdel);
            this.gb1.Controls.Add(this.btsave);
            this.gb1.Controls.Add(this.tbnote1);
            this.gb1.Controls.Add(this.cbd);
            this.gb1.Location = new System.Drawing.Point(12, 12);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(245, 299);
            this.gb1.TabIndex = 8;
            this.gb1.TabStop = false;
            this.gb1.Text = "2026";
            // 
            // lbl
            // 
            this.lbl.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lbl.Location = new System.Drawing.Point(6, 49);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(233, 153);
            this.lbl.TabIndex = 7;
            // 
            // btexit
            // 
            this.btexit.BackColor = System.Drawing.Color.SkyBlue;
            this.btexit.Location = new System.Drawing.Point(167, 245);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(72, 48);
            this.btexit.TabIndex = 6;
            this.btexit.Text = "Exit";
            this.btexit.UseVisualStyleBackColor = false;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // btclear
            // 
            this.btclear.BackColor = System.Drawing.Color.SkyBlue;
            this.btclear.Location = new System.Drawing.Point(7, 245);
            this.btclear.Name = "btclear";
            this.btclear.Size = new System.Drawing.Size(72, 48);
            this.btclear.TabIndex = 6;
            this.btclear.Text = "Clear";
            this.btclear.UseVisualStyleBackColor = false;
            this.btclear.Click += new System.EventHandler(this.btclear_Click);
            // 
            // btdel
            // 
            this.btdel.BackColor = System.Drawing.Color.SkyBlue;
            this.btdel.Location = new System.Drawing.Point(85, 245);
            this.btdel.Name = "btdel";
            this.btdel.Size = new System.Drawing.Size(72, 48);
            this.btdel.TabIndex = 5;
            this.btdel.Text = "Delete";
            this.btdel.UseVisualStyleBackColor = false;
            this.btdel.Click += new System.EventHandler(this.btdel_Click);
            // 
            // btsave
            // 
            this.btsave.BackColor = System.Drawing.Color.SkyBlue;
            this.btsave.Location = new System.Drawing.Point(133, 208);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(73, 23);
            this.btsave.TabIndex = 4;
            this.btsave.Text = "Save";
            this.btsave.UseVisualStyleBackColor = false;
            this.btsave.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbnote1
            // 
            this.tbnote1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tbnote1.Location = new System.Drawing.Point(7, 208);
            this.tbnote1.Name = "tbnote1";
            this.tbnote1.Size = new System.Drawing.Size(120, 23);
            this.tbnote1.TabIndex = 2;
            // 
            // cbd
            // 
            this.cbd.BackColor = System.Drawing.Color.LightCyan;
            this.cbd.FormattingEnabled = true;
            this.cbd.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday "});
            this.cbd.Location = new System.Drawing.Point(6, 22);
            this.cbd.Name = "cbd";
            this.cbd.Size = new System.Drawing.Size(121, 23);
            this.cbd.TabIndex = 0;
            // 
            // btRed
            // 
            this.btRed.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btRed.ForeColor = System.Drawing.Color.Red;
            this.btRed.Location = new System.Drawing.Point(272, 50);
            this.btRed.Name = "btRed";
            this.btRed.Size = new System.Drawing.Size(112, 37);
            this.btRed.TabIndex = 11;
            this.btRed.Text = "Red Text";
            this.btRed.UseVisualStyleBackColor = false;
            this.btRed.Click += new System.EventHandler(this.btRed_Click);
            // 
            // btBlue
            // 
            this.btBlue.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btBlue.ForeColor = System.Drawing.Color.Blue;
            this.btBlue.Location = new System.Drawing.Point(272, 137);
            this.btBlue.Name = "btBlue";
            this.btBlue.Size = new System.Drawing.Size(112, 37);
            this.btBlue.TabIndex = 12;
            this.btBlue.Text = "Blue Text";
            this.btBlue.UseVisualStyleBackColor = false;
            this.btBlue.Click += new System.EventHandler(this.btBlue_Click);
            // 
            // btGreen
            // 
            this.btGreen.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btGreen.ForeColor = System.Drawing.Color.Green;
            this.btGreen.Location = new System.Drawing.Point(272, 93);
            this.btGreen.Name = "btGreen";
            this.btGreen.Size = new System.Drawing.Size(112, 37);
            this.btGreen.TabIndex = 13;
            this.btGreen.Text = "Green Text";
            this.btGreen.UseVisualStyleBackColor = false;
            this.btGreen.Click += new System.EventHandler(this.btGreen_Click);
            // 
            // btTRNfnt
            // 
            this.btTRNfnt.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btTRNfnt.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btTRNfnt.Location = new System.Drawing.Point(272, 220);
            this.btTRNfnt.Name = "btTRNfnt";
            this.btTRNfnt.Size = new System.Drawing.Size(112, 43);
            this.btTRNfnt.TabIndex = 14;
            this.btTRNfnt.Text = "Times New Roman Font";
            this.btTRNfnt.UseVisualStyleBackColor = false;
            this.btTRNfnt.Click += new System.EventHandler(this.btTNRfnt_Click);
            // 
            // btBlack
            // 
            this.btBlack.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btBlack.Location = new System.Drawing.Point(272, 177);
            this.btBlack.Name = "btBlack";
            this.btBlack.Size = new System.Drawing.Size(112, 37);
            this.btBlack.TabIndex = 15;
            this.btBlack.Text = "Black Text";
            this.btBlack.UseVisualStyleBackColor = false;
            this.btBlack.Click += new System.EventHandler(this.btBlack_Click);
            // 
            // btSUIfnt
            // 
            this.btSUIfnt.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btSUIfnt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btSUIfnt.Location = new System.Drawing.Point(272, 269);
            this.btSUIfnt.Name = "btSUIfnt";
            this.btSUIfnt.Size = new System.Drawing.Size(112, 42);
            this.btSUIfnt.TabIndex = 16;
            this.btSUIfnt.Text = "Segoe UI Font";
            this.btSUIfnt.UseVisualStyleBackColor = false;
            this.btSUIfnt.Click += new System.EventHandler(this.btSUIfnt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
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
        private ComboBox cbd;
        private TextBox tbnote1;
        private Button btexit;
        private Button btdel;
        private Button btsave;
        private Button btclear;
        private FontDialog fontDialog1;
        private Button btRed;
        private Button btBlue;
        private Button btGreen;
        private Button btSUIfnt;
        private Button btTRNfnt;
        private Button btBlack;
        private Label lbl;
    }
}

namespace ___Final_Calender___
{
    public partial class Form1 : Form
    {
     //   Form MainForm = Form1;
        public Form1()
        {
            InitializeComponent();
        }
        // !!!! Important Notes !!!!
        // Try label instead of listbox on 6/3

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> note = new List<string>();
            for (int i = 0; i < note.Count; i++)
            {
                lbnote1.Items.Add(note[i]);
            }
             //   note.Add(tbnote1.Text);
            //string.Join(", ", note);
            // needs to be tested
        }

        private void btdel_Click(object sender, EventArgs e)
        {
            lbnote1.Items.Clear();
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btclear_Click(object sender, EventArgs e)
        {
            tbnote1.Text = "";
        }

        private void btRed_Click(object sender, EventArgs e)
        {
            Color Red         = Color.FromArgb(255, 8, 8);
            tbnote1.ForeColor = Red;
            lbnote1.ForeColor = Red;
        }

        private void btBlue_Click(object sender, EventArgs e)
        {
            Color Blue        = Color.FromArgb(8, 135, 255);
            tbnote1.ForeColor = Blue;
            lbnote1.ForeColor = Blue;
        }

        private void btGreen_Click(object sender, EventArgs e)
        {
            Color Green       = Color.FromArgb(41, 178, 24);
            tbnote1.ForeColor = Green;
            lbnote1.ForeColor = Green;
        }

        private void btBlack_Click(object sender, EventArgs e)
        {
            Color Black       = Color.FromArgb(0, 0, 0);
            tbnote1.ForeColor = Black;
            lbnote1.ForeColor = Black;
        }

        private void btTNRfnt_Click(object sender, EventArgs e)
        {
            lbnote1.Font = new Font("Times New Roman", 9);
            tbnote1.Font = new Font("Times New Roman", 9);
        }

        private void btSUIfnt_Click(object sender, EventArgs e)
        {
            lbnote1.Font = new Font("Segoe UI", 9);
            tbnote1.Font = new Font("Segoe UI", 9);
        }

        // !! Delete later - Extra code - Delete later !!

        //private void Form1_Load(object sender, EventArgs e)
        //{

        //}
        // !!! Delete Later !!!
        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //  for (int i = 0; i <= tLen - sLen; i++)
        //     if (text.Substring(i, sLen) == search)
        //int tlen = cbtheme.Text.Length;
        //int dlen = 9;
        //int glen = 10;
        //int i = 0;
        // variabletype variablename = (value or input)
        // Green theme (test)
        //Color Green  = Color.FromArgb(41, 178, 24);
        //Color DGreen = Color.FromArgb(21, 111, 10);
        //Color LGreen = Color.FromArgb(47, 240, 24);

        // Dark mode
        //Color Gray  = Color.FromArgb(125, 127, 125);
        //Color DGray = Color.FromArgb(81, 81, 81);
        //Color LGray = Color.FromArgb(169, 169, 169);

        // ! Themes/Colors variables templates !
        // [Color] theme
        //Color [name] = Color.FromArgb([color code]);
        //Color [name] = Color.FromArgb([color code]);
        //Color [name] = Color.FromArgb([color code]);
        //  for (i <= tlen - glen; i++ ;) {
        //     lbnote1.ForeColor = Green;
        //     Form1.BackColor   = DGreen;
        //     gb1.BackColor     = LGreen;
        //   }

        //  if (result) == ("Dark mode"); {
        //      lbnote1.ForeColor = Color.FromArgb(125, 127, 125);
        //      Form1.BackColor   = Color.FromArgb(81, 81, 81);
        //      gb1.BackColor     = Color.FromArgb(169, 169, 169);
        //  }
        //}
        //private void btfont_Click(object sender, EventArgs e)
        //{
        //    lbnote1.Font = new Font("Times New Roman", 12);
        //    tbnote1.Font = new Font("Times New Roman", 12);
        //}

    }
}
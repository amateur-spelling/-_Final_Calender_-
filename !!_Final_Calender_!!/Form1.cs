namespace ___Final_Calender___
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // !!!! Important Notes !!!!
        // Month based system

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            
            //string note = "";
            string note  = tbnote1.Text;
            lbnote1.Text = note;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        private void button9_Click(object sender, EventArgs e)
        {
            // Green theme (test)
            Color Green  = Color.FromArgb(41, 178, 24);
            Color DGreen = Color.FromArgb(21, 111, 10);
            Color LGreen = Color.FromArgb(47, 240, 24);
            if cbtheme.Text = "Green mode" {
                
            }

            // Dark mode
            Color [Gray]  = Color.FromArgb([125, 127, 125]);
            Color [DGray] = Color.FromArgb([81, 81, 81]);
            Color [LGray] = Color.FromArgb([169, 169, 169]);

            // ! Themes/Colors variables templates !
            // [Color] theme
            //Color [name] = Color.FromArgb([color code]);
            //Color [name] = Color.FromArgb([color code]);
            //Color [name] = Color.FromArgb([color code]);
        }

        private void btdel_Click(object sender, EventArgs e)
        {

        }

        private void btexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btclear_Click(object sender, EventArgs e)
        {
            tbnote1.Text = "";
        }

        //private void Form1_Load(object sender, EventArgs e)
        //{

        //}
    }
}
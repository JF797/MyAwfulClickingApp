namespace MyAwfulClickingApp
{
    public partial class Form1 : Form
    {
        int clickerCounter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            clickerCounter += 1;
            textBox_clickCount.Text = clickerCounter.ToString();
            if (clickerCounter >= 10)
            {
                textBox_wow.Visible = true;
            }
            if (clickerCounter >= 20)
            {
                textBox_seriously.Visible = true;
            }
            if (clickerCounter >= 30)
            {
                textBox_aaa.Visible = true;
                button_clicker.Visible = false;  
                button_clicker.Enabled = false;
            }
        }
    }
}
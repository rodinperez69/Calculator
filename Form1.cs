namespace CALCULTOR_TITE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c;
            if (radioButton1.Checked)
            {
                c = a + b;
                label4.Text = "Total:" + c.ToString();
            }
            if (radioButton2.Checked)
            {
                c = a + b;
                label4.Text = "Different" + c.ToString();
            }
            if (radioButton3.Checked)
            {
                c = a * b;
                label4.Text = "multiply:" + c.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label4.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

using System.Numerics;

namespace Decimal_to_binary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int dec = 0;
        int bin = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int.TryParse(textBox1.Text, out dec);
                textBox2.Text = Convert.ToString(dec, 2);
            }

            if (textBox2.Text != "")
            {
                int.TryParse(textBox2.Text, out bin);
                textBox1.Text = Convert.ToInt32(textBox2.Text, 2).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dec = 0;
            bin = 0;
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}

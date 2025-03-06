using System.Drawing.Imaging;
using System.Text;

namespace jurnalmod3_103022300017
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int hasil = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            String[] angka = textBox1.Text.Split('+');
            foreach (var angkaPlus in angka)
            {
                hasil += Convert.ToInt32(angkaPlus);
            }
            label1.Text = "Hasil penjumlahan adalah : " + hasil;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }
    }
}

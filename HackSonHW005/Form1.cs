namespace HackSonHW005
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            decimal input = decimal.Parse(textBox1.Text);
            decimal temperature = 0;
            if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("還沒選擇轉換溫度。");
            }
            else
            {
                if (radioButton1.Checked == true)
                {
                    temperature = 9 / 5 * input + 32;
                    label1.Text = ($"結果是：{input}°C = {temperature}°F");
                }
                else if (radioButton2.Checked == true)
                {
                    temperature = (input - 32) * 5 / 9;
                    label1.Text = ($"結果是：{input}°F = {temperature:F2}°C");
                }

                
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            label1.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

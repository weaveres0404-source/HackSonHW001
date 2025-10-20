using System;
using System.Runtime.CompilerServices;

namespace HackSonHW003
{
    public partial class Form1 : Form
    {
        List<int> ab;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random();

            if (button3.Enabled == false) 
            {
                button3.Enabled = true;
            }

            MessageBox.Show("�ж}�l�q�Ʀr");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //int input = int.Parse(textBox1.Text);
            string input = textBox1.Text;

            var result = new List<int>();
            result = input.Select(x => int.Parse(x.ToString())).ToList();

            //var number = string.Join("", ab);
            //var r = string.Join("", result);
            int[] end = { 0, 0 };

            foreach (int i in result)
            {
                for (int f = 0; f < ab.Count; f++)
                {
                    if (i == ab[f] && result[f] == ab[f])
                    {
                        end[0]++;
                        end[1]--;
                    }
                }
                if (ab.Contains(i))
                {
                    end[1]++;

                }
            }

            richTextBox1.AppendText($"{input}:{end[0]}A{end[1]}B" + Environment.NewLine);

            if (end[0] == 4)
            {
                MessageBox.Show("�L���A�A�u�O�ӱj�F�I");
                button3.Enabled = false;
            }


        }

        public void Random()
        {
            Random rnd = new Random();
            var random = new List<int>();
            int v = rnd.Next(0, 10);

            while (random.Count < 4)
            {
                if (random.Contains(v))
                {
                    v = rnd.Next(0, 10);
                }
                else
                {
                    random.Add(v);
                }
            }
            this.ab = random;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ab == null)
            {
                MessageBox.Show("�٨S���Ʀr�@");
            }
            else
            {
                var value = string.Join("", ab);
                MessageBox.Show($"���׬��G{value}");

            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
        }
    }
}

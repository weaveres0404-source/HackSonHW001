using System.Reflection.Metadata;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HackSonHW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            DateTime selectDateTime = dateTimePicker1.Value;
            var s = dateTimePicker1.Value.ToString("yyyy,MM,dd");
            var result = s.SelectMany(x => x.ToString().Split(',').Where(x => x != ""));
            var number = result.Select(x => int.Parse(x));
            int sum = number.Sum();
            while (sum > 9)
            {
                result = sum.ToString().Select(x => x.ToString());
                number = result.Select(x => int.Parse(x));
                sum = number.Sum();
            }

            var month = dateTimePicker1.Value.ToString("MM");
            var day = dateTimePicker1.Value.ToString("dd");
            int dayy = int.Parse(day);
            string constellation = string.Empty;
            if (month == "04")
            {
                constellation = dayy < 20 ? "�d��" : "����";
            }
            else if (month == "05")
            {
                constellation = dayy < 21 ? "����" : "���l";
            }
            else if (month == "06")
            {
                constellation = dayy < 21 ? "���l" : "����";
            }
            else if (month == "07")
            {
                constellation = dayy < 23 ? "����" : "��l";
            }
            else if (month == "08")
            {
                constellation = dayy < 23 ? "��l" : "�B�k";
            }
            else if (month == "09")
            {
                constellation = dayy < 23 ? "�B�k" : "�ѯ�";
            }
            else if (month == "10")
            {
                constellation = dayy < 23 ? "�ѯ�" : "����";
            }
            else if (month == "11")
            {
                constellation = dayy < 22 ? "����" : "�g��";
            }
            else if (month == "12")
            {
                constellation = dayy < 22 ? "�g��" : "�]�~";
            }
            else if (month == "01")
            {
                constellation = dayy < 20 ? "�]�~" : "���~";
            }
            else if (month == "02")
            {
                constellation = dayy < 19 ? "���~" : "����";
            }
            else if (month == "04")
            {
                constellation = dayy < 21 ? "����" : "�d��";
            }

            string filePath = "�ͩR�F��.txt";
            string[] fileContent = File.ReadAllLines(filePath);
            List<string> file = new List<string>();
            file.AddRange(fileContent);
            var filefn = file.Where(x => x != string.Empty).Select(x => string.Join("", x)).ToArray();

            var _constellation = new Dictionary<string, int>()
            {
                { "�d��", 0 }, { "����", 1 }, { "���l", 2 }, { "����", 3 }, { "��l", 4 }, { "�B�k", 5 },
                { "�ѯ�", 6 }, { "����", 7 }, { "�g��", 8 }, { "�]�~", 9 }, { "���~", 10 }, { "����", 11 }
            };

            foreach (var x in _constellation)
            {
                if (constellation == x.Key)
                {
                    int _value = x.Value;
                    int pathnumber = (_value * 10) + sum;
                    label1.Text = filefn[pathnumber];
                }
            }

            label3.Text = ($"�A���P�y�O�G{constellation}");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
    }
}

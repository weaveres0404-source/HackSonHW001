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
                constellation = dayy < 20 ? "牡羊" : "金牛";
            }
            else if (month == "05")
            {
                constellation = dayy < 21 ? "金牛" : "雙子";
            }
            else if (month == "06")
            {
                constellation = dayy < 21 ? "雙子" : "巨蟹";
            }
            else if (month == "07")
            {
                constellation = dayy < 23 ? "巨蟹" : "獅子";
            }
            else if (month == "08")
            {
                constellation = dayy < 23 ? "獅子" : "處女";
            }
            else if (month == "09")
            {
                constellation = dayy < 23 ? "處女" : "天秤";
            }
            else if (month == "10")
            {
                constellation = dayy < 23 ? "天秤" : "天蠍";
            }
            else if (month == "11")
            {
                constellation = dayy < 22 ? "天蠍" : "射手";
            }
            else if (month == "12")
            {
                constellation = dayy < 22 ? "射手" : "魔羯";
            }
            else if (month == "01")
            {
                constellation = dayy < 20 ? "魔羯" : "水瓶";
            }
            else if (month == "02")
            {
                constellation = dayy < 19 ? "水瓶" : "雙魚";
            }
            else if (month == "04")
            {
                constellation = dayy < 21 ? "雙魚" : "牡羊";
            }

            string filePath = "生命靈數.txt";
            string[] fileContent = File.ReadAllLines(filePath);
            List<string> file = new List<string>();
            file.AddRange(fileContent);
            var filefn = file.Where(x => x != string.Empty).Select(x => string.Join("", x)).ToArray();

            var _constellation = new Dictionary<string, int>()
            {
                { "牡羊", 0 }, { "金牛", 1 }, { "雙子", 2 }, { "巨蟹", 3 }, { "獅子", 4 }, { "處女", 5 },
                { "天秤", 6 }, { "天蠍", 7 }, { "射手", 8 }, { "魔羯", 9 }, { "水瓶", 10 }, { "雙魚", 11 }
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

            label3.Text = ($"你的星座是：{constellation}");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
    }
}

namespace HackSonHW002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一個數字");
            var input = Decimal.Parse(Console.ReadLine());

            List<Taxrate> price = new List<Taxrate>
            {
                new Taxrate{minvalue = 0 ,maxvalue = 540000 , tax = 0.05m},
                new Taxrate{minvalue = 540000 ,maxvalue = 1210000 , tax = 0.12m},
                new Taxrate{minvalue = 1210000 ,maxvalue = 2420000 , tax = 0.20m},
                new Taxrate{minvalue = 2420000 ,maxvalue = 4530000 , tax = 0.30m},
                new Taxrate{minvalue = 4530000 ,maxvalue = 10310000 , tax = 0.40m},
                new Taxrate{minvalue = 10310000 ,maxvalue = input , tax = 0.50m}
            };

            decimal total = price.Where(x => input > x.minvalue).Select(x => 
            {
                decimal a = Math.Min(input, x.maxvalue);
                decimal b = a - x.minvalue;
                return b * x.tax;
            }).Sum();  

            Console.WriteLine($"{total}");
        }
    }

    public class Taxrate 
    {
       public decimal minvalue { get; set; }
       public decimal maxvalue { get; set; }
       public decimal tax { get; set; }
    }
}



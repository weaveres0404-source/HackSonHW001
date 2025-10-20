namespace HackSonHW004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入一段文字");
            var input = Console.ReadLine().Split(" ").ToList();
            var result = input.GroupBy(x => x , StringComparer.OrdinalIgnoreCase).Select(x => new
            {
                text = x.Key,
                Count = x.Count()
            });

            foreach (var x in result)
            {
                Console.WriteLine($"{x.text} : {x.Count}個");
            }
        }
    }
}

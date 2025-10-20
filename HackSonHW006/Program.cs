namespace HackSonHW006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一個整數");
            var input = int.Parse(Console.ReadLine());
            for(int i = 1; i <= input; i++) 
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Dann");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Build");
                }
                else if (i % 5 == 0) 
                {
                    Console.WriteLine("School");
                }
                Console.WriteLine(i);
            }
        }
    }
}

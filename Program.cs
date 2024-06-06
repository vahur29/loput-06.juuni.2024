namespace loputöö_06.juuni._2024
{
    class Data
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Vali meetod:");
                Console.WriteLine("1. Count ja Sum");
                Console.WriteLine("2. If ja else faili meetod");
                Console.WriteLine("3. For loopi meetod (püramiid)");
                Console.WriteLine("4. Välju");
                int valik = int.Parse(Console.ReadLine());

                switch (valik)
                {

                    case 1:
                        CountAndSum();
                        break;
                    case 2:
                        FileMethod();
                        break;
                    case 3:
                        NumberPyramid();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Vale valik, proovi uuesti.");
                        break;
                }
            }
        }

        static void CountAndSum()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            int count = numbers.Count();
            int sum = numbers.Sum();
            Console.WriteLine("Count: " + count);
            Console.WriteLine("Sum: " + sum);
        }
        static void FileMethod()
        {
            Console.WriteLine("Sisesta tekst, mida soovid salvestada:");
            string text = Console.ReadLine();
            Console.WriteLine("sisesta failitee:");
            string path = Console.ReadLine();
            try
            {
                File.WriteAllText(path, text);
                Console.WriteLine("fail eukalt salvestatud");
            }

            catch (Exception e)
            {
                Console.WriteLine($"Tekkis viga: {e.Message}");
            }
        }
        static void NumberPyramid()
        {
            int i, j, n;

            Console.Write("Loo püramiid tärnidest: \n");
            Console.Write("----------------------");
            Console.Write("\n\n");
            Console.WriteLine("Sisesta püramiidi suurus");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i <= n; i++)
            {
                for (j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}

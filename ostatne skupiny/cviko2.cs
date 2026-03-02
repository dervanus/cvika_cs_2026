namespace App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cisla = Console.ReadLine().Split(' ');
            int n = cisla.Length;
            int sucet = 0;
            foreach (string c in cisla)
            {
                int a = int.Parse(c);
                sucet += a;
            }
            double priemer = (double)sucet / n;
            Console.WriteLine(priemer);
        }
    }
}
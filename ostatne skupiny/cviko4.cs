using System.Collections.Immutable;

namespace prvocisla
{
    internal class Program
    {
        public static bool prvocislo(int cislo)
        {
            for(int i = 2; i < cislo; i++)
            {
                if (cislo % i == 0)
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int a, b, n;
            n = int.Parse(Console.ReadLine());
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            int[] cisla = new int[n];
            Random rng = new Random();
            for (int i = 0; i < n; i++)
            {
                cisla[i] = rng.Next(a, b - 1);
            }

            //zoradenie
            Array.Sort(cisla);
            string s = "";
            foreach (var x in cisla)
            {
                s += x + " ";
            }
            Console.WriteLine(s);

            //najmensie cislo
            Console.WriteLine("najmensie cislo: " + cisla[0]);

            //najvacsie cislo
            Console.WriteLine("najvacsie cislo: " + cisla[^1]);

            List<int> prvocisla = new List<int>();
            s = "";
            foreach (int i in cisla)
            {
                if (prvocislo(i))
                {
                    prvocisla.Add(i);
                    s += i + " ";
                }
            }
            Console.WriteLine("prvocisla: " + s);
            //najmensie prvocislo
            Console.WriteLine("najmensie prvocislo: " + prvocisla[0]);
            //najvacsie prvocislo
            Console.WriteLine("najvacsie prvocislo: " + prvocisla[^1]);
        }
    }
}

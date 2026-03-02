namespace App
{
    public class PriemerKalkulacka
    {
        //atributy
        public string[] cisla;
        private int n;
        
        //konstruktor
        public PriemerKalkulacka(string[] cisla)
        {
            this.cisla = cisla;
            this.n = cisla.Length;
        }

        //metoda
        public double aritmetickyPriemer()
        {
            int sucet = 0;
            foreach(string s in cisla)
            {
                sucet += int.Parse(s);
            }
            return (double)sucet/n;
        }

        public double geometrickyPriemer()
        {
            double sucin = 1;
            foreach(string s in cisla)
            {
                sucin*=int.Parse(s);
            }
            return Math.Pow(sucin, 1.0/n);
        }

    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string[] vstup = Console.ReadLine()!.Split(' ');
            //instanciacia = volanie konstruktora
            PriemerKalkulacka k = new PriemerKalkulacka(vstup);

            //volanie metody
            Console.WriteLine(k.aritmetickyPriemer());
            
        }
    }
}
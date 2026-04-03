namespace mesta
{
    public abstract class Sidlo
    {
        public double danovyKoeficient = 1.0;
        public int pocetObyvatelov { get; set; }
        public double rozloha { get; set; }

        public void ZmenPocetObyvatelov(int delta)
        {
            pocetObyvatelov = pocetObyvatelov + delta;
        }
        //overloaded (pretazena) metoda
        public void ZmenPocetObyvatelov(int narodenia, int umrtia, int pristahovani, int odstahovani)
        {
            pocetObyvatelov = pocetObyvatelov + narodenia - umrtia + pristahovani - odstahovani;
        }
        //metody na prekrytie (overriding)
        public virtual double VypocitajDaneNaObyvatela()
        {
            return 100 * danovyKoeficient;
        }
        public abstract string Popis();
    }
    public class Mesto : Sidlo
    {
        public bool okresneMesto { get; set; }
        public Sidlisko[] sidliska = new Sidlisko[20];
        public Mesto(int pocetObyvatelov, double rozloha, bool okresneMesto)
        {
            this.pocetObyvatelov = pocetObyvatelov;
            this.rozloha = rozloha;
            this.okresneMesto = okresneMesto;

            this.danovyKoeficient = 1.1;

            for (int i = 0; i < 20; i++)
            {
                sidliska[i] = new Sidlisko();
            }
        }
        //pretazena virtualna metoda
        public override double VypocitajDaneNaObyvatela()
        {
            double zaklad = base.VypocitajDaneNaObyvatela();
            //double zaklad = danovyKoeficient * pocetObyvatelov;
            return okresneMesto ? zaklad * 1.05 : zaklad;
        }
        //pretazena abstraktna metoda
        public override string Popis()
        {
            return okresneMesto ? "Okresne mesto" : "Obycajne mesto";
        }

    }

    public class Sidlisko
    {
        public string nazov { get; set; }
        public List<string> ulice = new List<string>();
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Mesto hlohovec = new Mesto(19458, 64.19, true);
            Console.WriteLine("Hlohovec stats");
            Console.WriteLine("status: " + hlohovec.Popis());
            Console.WriteLine("dane: " + hlohovec.VypocitajDaneNaObyvatela());
            hlohovec.ZmenPocetObyvatelov(14);
            hlohovec.ZmenPocetObyvatelov(250, 0, 23, 11);
        }
    }
}
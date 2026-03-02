namespace mesta
{
    public abstract class Sidlo
    {
        #region fields
        //staticky clen
        public static int pocetSidel = 0;
        //protected clen
        protected double danovyKoeficient = 1.0;
        #endregion
        #region properties
        public int pocetObyvatelov { get; set; }
        public double rozloha { get; set; }
        #endregion

        #region methods
        //expression-bodied metoda
        public double Hustota() => Math.Round(pocetObyvatelov / rozloha, 3);
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
        #endregion
    }
    public class Mesto : Sidlo
    {
        public bool okresneMesto { get; set; }
        public Mesto(int pocetObyvatelov, double rozloha, bool okresneMesto)
        {
            this.pocetObyvatelov = pocetObyvatelov;
            this.rozloha = rozloha;
            this.okresneMesto = okresneMesto;

            this.danovyKoeficient = 1.1;
            pocetSidel++;
        }
        //kopirovaci konstruktor
        public Mesto(Mesto other)
        {
            this.pocetObyvatelov = other.pocetObyvatelov;
            this.rozloha = other.rozloha;
            this.okresneMesto = other.okresneMesto;
            this.danovyKoeficient = other.danovyKoeficient;
            pocetSidel++;
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

    public sealed class Dedina : Sidlo
    {
        public Dedina(int pocetObyvatelov, double rozloha)
        {
            this.pocetObyvatelov = pocetObyvatelov;
            this.rozloha = rozloha;
            pocetSidel++;
        }
        //pretazena abstraktna metoda
        public override string Popis()
        {
            return pocetObyvatelov > 5000 ? "Velka dedina" : "Mala dedina";
        }
        //metoda Clone
        public Dedina Clone()
        {
            return new Dedina(this.pocetObyvatelov, this.rozloha);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Mesto hlohovec = new Mesto(19458, 64.19, true);
            Console.WriteLine("Hlohovec stats");
            Console.WriteLine("hustota: " + hlohovec.Hustota());
            Console.WriteLine("status: " + hlohovec.Popis());
            Console.WriteLine("dane: " + hlohovec.VypocitajDaneNaObyvatela());
            hlohovec.ZmenPocetObyvatelov(14);
            hlohovec.ZmenPocetObyvatelov(250, 0, 23, 11);

            var novyHlohovec = new Mesto(hlohovec);
            Console.WriteLine("\nNový Hlohovec stats");
            Console.WriteLine("hustota: " + hlohovec.Hustota());
            Console.WriteLine("status: " + hlohovec.Popis());

            Dedina madunice = new Dedina(2340, 12);
            Console.WriteLine("\nMadunice stats");
            Console.WriteLine("hustota: " + madunice.Hustota());
            Console.WriteLine("status: " + madunice.Popis());
            Console.WriteLine("dane: " + madunice.VypocitajDaneNaObyvatela());

            var noveMadunice = madunice.Clone();
            Console.WriteLine("\nPocet sidel: " + Sidlo.pocetSidel);
        }
    }
}

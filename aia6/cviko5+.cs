namespace linq
{
    public class Zamestnanec
    {
        public string meno {  get; set; }
        public string oddelenie { get; set; }
        public int rokySkusenosti { get; set; }
        public double hodnotenie { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //kolekcia objektov
            List<Zamestnanec> zamestnanci = new List<Zamestnanec>()
            {
                new Zamestnanec() {meno="Fero", 
                                   oddelenie="Vratnica", 
                                   rokySkusenosti=10, 
                                   hodnotenie=4 },
                new Zamestnanec() {meno="Jožo",
                                   oddelenie="HR",
                                   rokySkusenosti=12,
                                   hodnotenie=2 },
                new Zamestnanec() {meno="Miro",
                                   oddelenie="Serverovna",
                                   rokySkusenosti=2,
                                   hodnotenie=5 },
                new Zamestnanec() {meno="Gabo",
                                   oddelenie="PR",
                                   rokySkusenosti=1,
                                   hodnotenie=1 },
                new Zamestnanec() {meno="Jaro",
                                   oddelenie="Serverovna",
                                   rokySkusenosti=8,
                                   hodnotenie=4.5 },
            };
            var mena = zamestnanci.Select(x => x.meno);
            Console.WriteLine(mena.Aggregate((a, b) => a + " " + b));
            var elity = zamestnanci
                    .Where(e => e.oddelenie == "Serverovna" && e.rokySkusenosti > 5)
                    .Where(e => e.hodnotenie >= 4.0)
                    .OrderByDescending(e => e.hodnotenie)
                    .Select(e => $"{e.meno.ToUpper()} ({e.rokySkusenosti} rokov)")
                    .ToList();
            bool suElity = elity.Any();
            int pocetElit = elity.Count();
            Console.WriteLine(elity.Aggregate((e1, e2) => e1 + "\n" + e2));

            //kolekcia jednoduchych hodnot
            int[] pole = { 2, 5, 7, 3, 8, 11, 3 };
            int[] druheMocniny = pole.Select(x => x * x).ToArray();
            var parneCisla = pole.Where(x => x % 2 == 0);
            var parneIndexy = pole.Where((x, i) => i % 2 == 0);
            var zoradene = pole.OrderBy(x => x);
            Console.WriteLine(pole.Max());
            Console.WriteLine(pole.Count(x => x > 3));
            Console.WriteLine(
                Console.ReadLine().Split(' ')
                .Select(x => int.Parse(x))
                .Average());
        }
    }
}
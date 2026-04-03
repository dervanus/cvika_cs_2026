namespace banka
{
    public class ucet
    {
        public int id;
        public string meno;
        public double naUcte;

        public void vlozit(double penaze)
        {
            naUcte += penaze;
        }

        public void vybrat(double penaze)
        {
            naUcte -= penaze;
        }
    }
    internal class Program
    {
        public static List<ucet> ucty;
        public static ucet vytvoritUcet(string meno)
        {
            ucet novyUcet = new ucet();
            novyUcet.id = ucty.Count;
            novyUcet.meno = meno;
            novyUcet.naUcte = Random.Shared.Next(50, 100);
            ucty.Add(novyUcet);
            return novyUcet;
        }
        public static void precitatZCSV()
        {
            try
            {
                var u = File.ReadAllLines("ucty.csv");
                foreach (var x in u)
                {
                    var line = x.Split(',');
                    ucet ucet = new ucet();
                    ucet.id = int.Parse(line[0]);
                    ucet.meno = line[1];
                    ucet.naUcte = double.Parse(line[2]);
                    ucty.Add(ucet);
                }
            }
            catch { }
        }
        public static void ulozitDoCSV()
        {
            File.WriteAllText("ucty.csv","");
            foreach(var u in ucty)
            {
                string line = u.id + "," + u.meno + "," + u.naUcte + "\n";
                File.AppendAllText("ucty.csv",line);
            }
        }
        static void Main(string[] args)
        {
            ucty = new List<ucet>();
            precitatZCSV();
            while (true)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("1 - vytvorit ucet");
                Console.WriteLine("2 - ulozit peniaze");
                Console.WriteLine("3 - vybrat peniaze");
                Console.WriteLine("4 - zobrazit ucty");
                Console.WriteLine("0 - koniec");
                int a;
                try
                {
                    a = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("neplatny vyber");
                    continue;
                }
                int id;
                double penaze;
                if (a == 0)
                {
                    ulozitDoCSV();
                    break;
                }
                switch (a)
                {
                    case 1:
                        Console.WriteLine("uvedte svoje meno");
                        string meno = Console.ReadLine();
                        vytvoritUcet(meno);
                        Console.WriteLine("ucet vytvoreny");
                        break;
                    case 2:
                        try
                        {
                            Console.WriteLine("uvedte svoje id");
                            id = int.Parse(Console.ReadLine());
                            var ucet = ucty[id];
                            try
                            {
                                Console.WriteLine("zadajte hodnotu vkladu");
                                penaze = double.Parse(Console.ReadLine());
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("neplatna hodnota vyberu");
                                break;
                            }
                            ucet.vlozit(penaze);
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            Console.WriteLine("id neexistuje");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("neplatne cislo uctu");
                        }
                        break;
                    case 3:
                        try
                        {
                            Console.WriteLine("uvedte svoje id");
                            id = int.Parse(Console.ReadLine());
                            var ucet = ucty[id];
                            try
                            {
                                Console.WriteLine("zadajte hodnotu vyberu");
                                penaze = double.Parse(Console.ReadLine());
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("neplatna hodnota vyberu");
                                break;
                            }
                            ucet.vybrat(penaze);
                        }
                        catch(ArgumentOutOfRangeException)
                        {
                            Console.WriteLine("neexistujuci ucet");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("neplatne cislo uctu");
                        }
                        break;
                    case 4:
                        foreach(var u in ucty)
                        {
                            Console.WriteLine(u.id + " " + u.meno + " " + u.naUcte);
                        }
                        break;
                    default:
                        Console.WriteLine("neplatny vyber");
                        break;

                }

            }
        }
    }
}

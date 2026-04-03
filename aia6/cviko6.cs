namespace files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cesta k súboru: " + Path.GetFullPath("vstup.txt"));
            try
            {
                Console.WriteLine("Zadaj text ktorý zapíše do súboru:");
                string zadanyText = Console.ReadLine();
                if (File.Exists("vstup.txt"))
                {
                    Console.WriteLine("Súbor už existuje. Prepísať? a/n");
                    string volba = Console.ReadLine();
                    if (volba == "a" || volba == "A")
                    {
                        File.WriteAllText("vstup.txt", zadanyText);
                        Console.WriteLine("Súbor bol prepísaný");
                    }
                    else
                    {
                        File.AppendAllText("vstup.txt", zadanyText);
                        Console.WriteLine("Text pridaný na koniec súboru");
                    }
                }
                else
                {
                    File.WriteAllText("vstup.txt", zadanyText);
                    Console.WriteLine("Subor bol vytvorený");
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Chyba pri práci so súborom");
            }
            try
            {
                string[] riadky = File.ReadAllLines("vstup.txt");
                int pocet = 0;
                Console.WriteLine("V súbore: ");
                foreach (string riadok in riadky)
                {
                    pocet++;
                    Console.WriteLine(pocet.ToString("###") + " " + riadok);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Nemôžem otvoriť súbor.");
            }
            catch (IOException)
            {
                Console.WriteLine("Chyba pri práci so súborom");
            }

            // Pre informáciu o súbore môžeme použiť objekt FileInfo
            FileInfo info = new FileInfo("vstup.txt");
            Console.WriteLine("Meno súboru : " + info.Name);
            Console.WriteLine("Dĺžka súboru: " + info.Length);
            Console.WriteLine("Prípona : " + info.Extension);
            Console.WriteLine("Adresár : " + info.DirectoryName);
            // V prípade že by sme chceli získať obsah celého adresára môžeme použiť objekt Directory
            string[] subory = Directory.GetFiles("c:\\windows\\", "*.exe");

            foreach (string subor in subory)
            {
                Console.WriteLine(subor);
            }
            Console.WriteLine();
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}

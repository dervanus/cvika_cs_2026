## výnimky
- ak funkcia alebo premenná dostane neočakávaný vstup, program vyhodí výnimku
- úlohou developera je výnimky odhaľovať a ošetriť, teda zabrániť nočakávaným hodnotám a zabezpečiť ďalšiu logiku programu v prípade takýchto okolností
- v C# ošetrovanie výnimiek prebieha za pomoci tzv. `try`/`catch` blokov, ktoré sa skladajú z dvoch alebo troch častí:
  - `try` - blok kódu, v ktorom môže nastať neočakávaná situácia (byť vyvolaná výnimka)
  - `catch` - blok kódu, ktorý sa vykoná, ak bola v `try` bloku vyvolaná výnimka
  - `finally` - (nepovinný) blok kódu, ktorý sa vykonná bez ohľadu na to, či bola výnimka vyvolaná alebo nie

- najčastejšie prípady výnimiek:
  - `FormatException` - argument funkcie nebol v správnom formáte (napr. `int.Parse` nedostal číslicový string)
  - `ArgumentOutOfRangeException` - prístup k neexistujúcemu prvku
  - `IndexOutOfRangeException` - prístup k neexistujúcemu prvku poľa (záporný index, index za hranicami poľa)
  - `DivideByZeroException` - delenie nulou (iba pri intoch)

```cs
            try
            {
                int a = int.Parse(Console.ReadLine());
                int[] pole = { 1 / a, 2 / a };
                Console.WriteLine(pole[-2]);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
```

- `throw` - slúži na vyvolanie používateľskej výnimky, predovšetkým vhodné ak implementujeme kód modulárne
- `catch` nemusí mať žiadny parameter, prípadne môže mať ako parameter iba triedu výnimky
- `Exception` je všeobecná výnimka

## súbory
- práca so súbormi prebieha za pomoci triedy `File`, tried `StreamWriter` / `StreamReader` alebo triedy `FileStream`, pričom tri posledné zmienené najčastejšie pracujú so správou pamäte za pomoci `using`

### File
- `using System.IO`
- poskytuje metódy na
  - zapisovanie do súboru (`File.WriteAllText`, `File.WriteAllLines`)
  - pridávanie do súboru (`File.AppendAllText`, `File.AppendAllLines`)
  - čítanie zo súboru (`File.ReadAllText`, `File.ReadAllLines`)
  - a iné
- `AllText` metódy pracujú so stringom, `AllLines` pracujú s poľom stringov
- ak pri čítaní zo súboru požadovaný súbor neexistuje, program vyhodí výnimku `FileNotFoundException`
- ak pri zapisovaní do súboru požadovaný súbor existuje, program ho prepíše

### StreamWriter/StreamReader
- https://www.geeksforgeeks.org/c-sharp/basics-of-file-handling-in-c-sharp/

### FileStream
- https://www.programiz.com/csharp-programming/files
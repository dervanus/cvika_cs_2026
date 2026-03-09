## polia
- kolekcie so statickou veľkosťou
  - rozšírenie cez `Array.Resize()` funguje viac-menej ako `realloc`, takže na pozadí sa iba prekopíruje obsah poľa do väčšieho
- vytvorenie 
  - `int[] poleA = new int[5];` - prázdne (všetky prvky 0)
  - `int[] poleB = { 1, 2, 3, 4, 5 };`
  - `int[] poleC = new int[5] { 1, 2, 3, 4, 5 };`
  - `int[] poleD = new int[] { 1, 2, 3, 4, 5 };`
- vždy dynamicky alokované, takže na pozadí pointery
- platí v princípe všetko ako v c, s niekoľkými novinkami (napr. je ich možné posielať ako návratový typ funkcie)
- k prvkom sa pristupuje cez indexy `int x = pole[2]`
- od .NET Core 3.x a .NET Standard 2.1 dva nové operátory pri práci s poľami
  - index from end operator - `pole[^1]` je posledný prvok, `pole[^2]` predposledný prvok apod.
  - range operator - `pole[a..b]` vráti podmnožinu poľa od indexu `a` (vrátane) po `b` (nepočítajúc) (obe hodnoty nepovinné)
  
### viacrozmerné polia (matice)
- vytvorenie - `int[,] matica = new int[3, 2]`
- prístup k prvkom `var d = cisla[0, 2]`
- práca rovnaká ako v c
- rozmery sa dajú získať pomocou `matica.GetUpperBound(rozmer)` (0 - počet riadkov, 1 - počet stĺpcov atď) - vráti najvyšší index, takže reálny počet riadkov/stĺpcov bude o 1 väčší

#### zubaté polia (jagged arrays)
- viacrozmerné polia s rozličnými veľkosťami rozmerov, napr. v matici môže mať každý riadok inú dĺžku
```cs
int[][] zubatePole = new int[2][];
zubatePole[0] = new int[4];
zubatePole[1] = new int[8];
```

## stringy
- rovnako ako polia vystupujú ako triedy/objekty
- podobná práca ako s poľami, majú niekoľko špeciálnych metód
- spájanie (konkatenácia) stringov - cez + (`string x = "hello " + "world"`)
- sú nemenné (immutable), takže jednotlivé znaky sú read-only

## zoznamy
- namespace `System.Collections.Generic`
- dynamické polia, ich veľkosť sa dá počas behu programu meniť
- vytvorenie `List<int> zoznam = new List<int>()`
  - nepovinný argument konštruktora - kapacita
- nové prvky sa vždy pridávajú na koniec pomocou `zoznam.Add(prvok)`
- prístup cez indexy

## základné atribúty a metódy polí, zoznamov a stringov

| akcia | pole | zoznam | string `s`[^1] |
| ----- | ---- | ------ | ---------- |
| dĺžka | `int x = pole.Length` | `int x = zoznam.Count` | `int x = s.Length` |
| pridanie prvku na koniec | | `zoznam.Add(prvok)` | `s += prvok` |
| pridanie prvku na index | | `zoznam.Insert(index, prvok)` | |
| odstránenie prvku z konca | | `zoznam.Remove()` | `s = s.Trim()`[^2] |
| odstránenie prvého zodpovedajúceho prvku | | `zoznam.Remove(prvok)` | |
| odstránenie prvku z indexu | | `zoznam.RemoveAt(index)` | |
| | | | |
| kontrola prítomnosti prvku | | `bool x = zoznam.Contains(prvok)` | `bool x = s.Contains(prvok)` |
| zoradenie | `Array.Sort(pole)` | `zoznam.Sort()` | |
| otočenie | `Array.Reverse(pole)` | `zoznam.Reverse()` | |
| index prvého výskytu prvku | `int x = Array.IndexOf(pole, prvok)` | `int x = zoznam.IndexOf(prvok)` | `int x = s.IndexOf(prvok)` |
| index posledného výskytu prvku | `int x = Array.LastIndexOf(pole, prvok)` | `int x = zoznam.LastIndexOf(prvok)` | `int x = s.LastIndexOf(prvok)` |
| vymazanie/vynulovanie | `Array.Clear(pole)` | `zoznam.Clear()` | `s = ""` alebo `s = string.Empty` |
| podmnožina[^3] | `DT[] sub = pole[a..b]` | `List<DT> sub = zoznam[a..b]` | `string x = s[a..b]` alebo `string x = s.Substring(index, dĺžka)`[^4] |
| klonovanie | `DT[] klon = (DT[])pole.Clone()` | `List<DT> klon = new List<DT>(zoznam)` | `string klon = new string(s)` |
| pretypovanie na pole | | `DT[] pole = zoznam.ToArray()` | `char[] pole = s.ToCharArray()` |
| pretypovanie na zoznam | `List<DT> zoznam = pole.ToList()` | | `List<char> list = new List<char>(s)` |
| pretypovanie na string | `string s = new string(pole)` | | |

[^1]: v prípade stringov môže byť prvkom aj string, nielen char
[^2]: `Trim()` odstráni whitespacey z oboch strán stringu, `TrimStart()` zo začiatku a `TrimEnd()` z konca; argumentom môže byť aj znak, ktorý bude odstránený
[^3]: range operátor `[a..b]` (dostupný od .NET Core 3.x a .NET Standard 2.1) pracuje s inkluzívnym začiatkom (prvý prvok zahrnutý v podmnožine) a exkluzívnym koncom (prvý prvok už nezahrnutý do podmnožiny), oba môžu byť vynechané
[^4]: `index` je index prvého znaku prekladného do substringu a `dĺžka` je dĺžka substringu
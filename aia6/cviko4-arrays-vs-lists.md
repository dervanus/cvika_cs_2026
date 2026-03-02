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
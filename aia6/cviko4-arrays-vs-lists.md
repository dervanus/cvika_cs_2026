| akcia | pole | zoznam | string `s`[^A] |
| ----- | ---- | ------ | ---------- |
| dĺžka | `int x = pole.Length` | `int x = zoznam.Count` | `int x = s.Length` |
| pridanie prvku na koniec | | `zoznam.Add(prvok)` | `s += prvok` |
| pridanie prvku na index | | `zoznam.Insert(index, prvok)` | |
| odstránenie prvku z konca | | `zoznam.Remove()` | `s = s.Trim()` |
| odstránenie prvého zodpovedajúceho prvku | | `zoznam.Remove(prvok)` | |
| odstránenie prvku z indexu | | `zoznam.RemoveAt(index)` | |
| | | | |
| | | | |	
| kontrola prítomnosti prvku | | `bool x = zoznam.Contains(prvok)` | `bool x = s.Contains(prvok)` |
| zoradenie | `Array.Sort(pole)` | `zoznam.Sort()` | |
| otočenie | `Array.Reverse(pole)` | `zoznam.Reverse()` | |
| index prvého výskytu prvku | `int x = Array.IndexOf(pole, prvok)` | `int x = zoznam.IndexOf(prvok)` | `int x = s.IndexOf(prvok)` |
| index posledného výskytu prvku | `int x = Array.LastIndexOf(pole, prvok)` | `int x = zoznam.LastIndexOf(prvok)` | `int x = s.LastIndexOf(prvok)` |
| vymazanie/vynulovanie | `Array.Clear(pole)` | `zoznam.Clear()` | `s = ""`<br>`s = string.Empty` |
| podmnožina | `DT[] sub = pole[a..b]` | `List<DT> sub = zoznam[a..b]` | `string x = s[a..b]`<br>`string x = s.Substring(index, dĺžka)` |
| klonovanie | `DT[] klon = (DT[])pole.Clone()` | `List<DT> klon = new List<DT>(zoznam)` | `string klon = new string(s)` |
| pretypovanie na pole | | `DT[] pole = zoznam.ToArray()` | `char[] pole = s.ToCharArray()` |
| pretypovanie na zoznam | `List<DT> zoznam = pole.ToList()` | | `List<char> list = new List<char>(s)` |
| pretypovanie na string | `string s = new string(pole)` | | |

[^A]: v prípade stringov môže byť prvkom aj string, nielen char
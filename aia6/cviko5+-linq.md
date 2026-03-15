## delegáty
- premenné, ktoré uchovávajú odkaz na funkciu (v podstate pointery na funkciu)
- tri základné druhy sú `Func`, `Action` a `Predicate`, môžu obsahovať ľubovoľný počet parametrov (aj žiadny) a líšia sa v návratovej hodnote:
  - `Func` - ľubovoľný dátový typ
  - `Action` - void
  - `Predicate` - bool

```cs
        public static int sum(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Func<int, int, int> add = sum; //prve dva inty su parametre, treti je navratovy DT
            var f = add(1, 2);
            Console.WriteLine(f);
        }
```

## lambda výrazy
- delegáty sa dajú zapísať aj v rámci jedného riadku pomocou tzv. lambda výrazov, ktorých syntax je vždy `parametre => návratová hodnota`, kde `=>` je tzv. lambda operátor
```cs
        static void Main(string[] args)
        {
            Func<int, int, int> add = (a, b) => a + b; //(a,b) su parametre, "a+b" je navratova hodnota
            var f = add(1, 2);
            Console.WriteLine(f);
        }
```

## LINQ
- `using System.Linq;`
- knižnica/menný priestor založený explicitne na SQL pre jednoduchšiu prácu s kolekciami
- metódy vracajú vždy nejakú jednu hodnotu (napr. `.Sum()`, `.Count()` a pod.) alebo kolekciu (napr. `Select(...)`, `.Where(...)`), pričom táto kolekcia je vždy `IEnumerable` a musí byť pretypovaná (`.ToArray()`, `.ToList()` a pod)
- argumenty sú vždy buď žiadne alebo delegáty, pričom najčastejšie sa využívajú práve lambda výrazy, ktoré sú aplikované na každý jeden prvok kolekcie
- `Func` a `Action` spravidla upravujú každý prvok kolekcie alebo vykonávajú s ním operáciu, kým `Predicate` slúži hlavne na filtrovanie
- ak LINQ metóda pracuje na vstupe iba s jednou kolekciou, lambda výraz môže mať aj druhý parameter, ktorý je vždy index

### základné LINQ metódy
#### Select
- základná metóda na operáciu na každom prvku kolekcie, argument je `Func`

```cs
var druheMocniny = pole.Select(x => x * x); //z kazdeho prvku pola vypocita druhu mocninu
var stringy = pole.Select(x => x.ToString()); //kazdy prvok pola pretypuje na string
var nahodneCisla = pole.Select(x => Random.Shared.Next()); //pre kazdy prvok pola vygeneruje nahodne cislo
```

#### Where
- základná metóda pre filtráciu, argument je `Predicate`
- výsledná kolekcia bude obsahovať iba prvky zodpovedajúce predikátu

```cs
var parneCisla = pole.Where(x => x % 2 == 0); //vrati kolekciu, v ktorej budu z povodnej iba parne cisla (cisla zodpovedajuce podmienke x % 2 == 0)
var parneIndexy = pole.Where((x, i) => i % 2 == 0); //vrati kolekciu, v ktorej budu z povodnej iba cisla na parnych indexoch
```

#### Aggregate
- spojenie kolekcie do jednej premennej, spravidla `string`
- argument je `Func`

```cs
string[] kolekcia = { "nad", "tatrou", "sa", "blyska" };
string veta = kolekcia.Aggregate((x, y) => x + " " + y);
```
- `x` je akumulátor, ku ktorému sa postupne pridávajú v zmysle `x + " " + y`

#### prehľad základných metód
- v tabuľke, `kol` je kolekcia (pole, zoznam atď)

| metóda | argument | návratový DT | popis |
| ------ | -------- | -------- | ----- |
| `kol.OrderBy()` | `Func` | `IEnumerable` | zoradenie vzostupne[^1] |
| `kol.OrderByDescending()` | `Func` | `IEnumerable ` | zoradenie zostupne |
| `kol.ThenBy()` / `kol.ThenByDescending()` | `Func` | `IEnumerable` | druhotné zoraďovanie[^2] |
| `kol.All()` | `Predicate` | `bool` | či všetky prvky kolekcie zodpovedajú predikátu |
| `kol.Any()` | `Predicate` | `bool` | či aspoň jeden prvok kolekcie zodpovedá predikátu |
| `kol.Contains()` | prvok | `bool` | či kolekcia obsahuje daný prvok |
| `kol.Average()` | nepovinne `Func` | `double` | priemer |
| `kol.Count()` | nepovinne `Predicate` | `int` | počet hodnôt |
| `kol.Max()` / `kol.Min()` | nepovinne `Func` | DT kolekcie | najväčšia/najmenšia hodnota |
| `kol.Sum()` | nepovinne `Func` | DT kolekcie | suma hodnôt |
| `kol.ElementAt()` | `int` | DT kolekcie | prvok na danom indexe[^3] |
| `kol.First()` | `Predicate` | DT kolekcie | prvý prvok zodpovedajúci predikátu[^3] |
| `kol.Last()` | `Predicate` | DT kolekcie | posledný prvok zodpovedajúci predikátu[^3] |
| `kol.Single()` | `Predicate` | DT kolekcie | jedinečný prvok zodpovedajúci predikátu[^4] [^3] |
| `kol.SequenceEqual()` | druhá kolekcia | `bool` | či sú dve kolekcie zhodné v počte a hodnotách prvkov |
| `kol.Distinct()` | - | `IEnumerable` | kolekcia zložená z jedinečných prvkov kolekcie |
| `kol.Except()` | druhá kolekcia | `IEnumerable` | rozdiel množín (prvky prvej kolekcie okrem tých, čo sú aj v druhej) |
| `kol.Intercept()` | druhá kolekcia | `IEnumerable` | prienik množín (prvky, ktoré majú obe kolekcie spoločné) |
| `kol.Union()` | druhá kolekcia | `IEnumerable` | zjednotenie množín (prvky oboch kolekcií) |
| `Enumerable.Empty<DT>()` | - | `IEnumerable` | prázdna kolekcia |
| `Enumerable.Range()` | `int` (začiatok rozsahu), `int` (veľkosť rozsahu) | `IEnumerable` | rozsah čísel |
| `Enumerable.Repeat<DT>()` | prvok, `int` (počet opakovaní) | `IEnumerable` | kolekcia so zopakovaným prvkom |

[^1]: pri jednoduchých premenných argument `x => x`, pri objektoch `x => x.atribut`
[^2]: používa sa predovšetkým pri zoraďovaní objektov, `OrderBy` zoradí podľa jedného atribútu a ak viaceré objekty majú rovnakú hodnotu toho atribútu, `ThenBy` zoradí podľa druhého atribútu
[^3]: tieto štyri metódy, ak taký prvok neexistuje, vyhodia výnimku; ich alternatívy `ElementAtOrDefault`, `FirstOrDefault`, `LastOrDefault` a `SingleOrDefault`, ak prvok neexistuje, vrátia defaultnú hodnotu DT
[^4]: vyhodí výnimku aj keď ich predikátu zodpovedá viac
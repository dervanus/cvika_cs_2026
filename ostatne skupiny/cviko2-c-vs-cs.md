## __dátové typy__ 
rovnaké ako v c/c++, niektoré nové  
- celočíselné: **int**, long, short...
- desatinné: **double**, **float**, decimal
- znakový: **char** (`char a = 'q';`)
- **bool** (`bool a = true;`)
- reťazec: **string** (`string a = "retazec";`)
- implicitný dátový typ: **var** (pri definícii nahrádza ostatné dátové typy, funguje iba ak do neho rovno aj priraďujeme hodnotu, či už literál, objekt alebo funkciu)
```cs
var x = 4; //x je int
var y = "slovo"; //y je string
var z = new int[10]; //z je intove pole
```
- *špeciálny dátový typ pre fajnšmekrov: dynamic*

## __pretypovávanie__ 
- medzi číselnými typmi a objektmi - niekedy je potrebná explicitná konverzia, niekedy stačí implicitná (podľa toho ako bude kompilátor papuľovať alebo potreby):
```cs
int a = 4;
double b = (int)a;
```
- z číselných dátových typov alebo objektov na string - opäť, niekedy stačí implicitná, keď kompilátor papuľuje treba explicitná: metóda `.ToString()`
```cs
int a = 4;
string b = a.ToString();
```
- zo stringu na číselné dátové typy - vždy explicitná: buď `DT.Parse()`, `Convert.ToDT()` alebo pre fajnšmekrov `DT.TryParse()`
```cs
string a = "56";
int a1 = int.Parse(a); //moznost 1
int a2 = Convert.ToInt32(a); //moznost 2
int.TryParse(a, out int a3); //moznost 3 pre fajnsmekrov
```

## __načítavanie z konzoly a výpis do konzoly__
```cs
//nacitavanie
int a = Console.Read(); //nacita iba jeden znak, treba pretypovat na char
string A = Console.ReadLine(); //odporucane, nacita jeden riadok, vzdy vracia string

//vypis
Console.Write(a); //vypise na riadok bez enteru
Console.WriteLine(a); //odporucane, vypise na riadok s enterom
```

## __polia__
- vždy dynamicky alokované, nie je potrebná dealokácia, inak práca v princípe identická s c/c++; hranaté zátvorky sa dávajú k dátovému typu
```cs
int[] pole = new int[n];
int[] pole2 = {2, 4, 5, 9};
```

## __rozhodovanie__
- úplne rovnaké ako v c/c++, je však možné v `switch`i použiť ako argument aj string a ternárny operátor musí vracať hodnotu (teda, nie je možné tam použiť void funkcie)

## __cykly__
- `while`, `do..while` aj `for` fungujú rovnako ako v c/c++, pribudol však nový cyklus `foreach`, ktorý traverzuje kolekciou (poľom, zoznamom, enumom)
```cs
foreach(int x in pole){
  //telo
}
```

## __ostatné rozdiely__
- nie sú tu makrá (`#define`)
- spravidla sa pointery nepoužívajú
- štruktúry fungujú v princípe rovnako ako v c++ (nie v c!) a ich funkcionality spravidla nahrádzajú triedy

## príklad k cviku 1 
- načítanie *n* čísel a výpočet ich aritmetického priemeru
### __verzia 1__
- každé číslo na novom riadku (naivný C prístup)
```cs
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sucet = 0;
            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                sucet += a;
            }
            double priemer = (double)sucet / n;
            Console.WriteLine(priemer);
        }
```
vstup:  
4  
1  
2  
3  
5  
výstup:  
2,75  

### __verzia 2__
- načítanie v jednom riadku bez udania počtu
```cs
        static void Main(string[] args)
        {
            string[] cisla = Console.ReadLine().Split(' ');
            int n = cisla.Length;
            int sucet = 0;
            foreach (string c in cisla)
            {
                int a = int.Parse(c);
                sucet += a;
            }
            double priemer = (double)sucet / n;
            Console.WriteLine(priemer);
        }
```
vstup: 1 2 3 5  
výstup: 2,75
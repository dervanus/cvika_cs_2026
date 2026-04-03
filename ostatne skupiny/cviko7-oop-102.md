## dedičnosť
- dedičnosť - schopnosť triedy vytvárať potomkov (triedy s aspoň rovnakými členmi) alebo byť potomkom inej triedy (=> mať rovnaké členy ako predok)
  - základná trieda (base class/parent class) - trieda, z ktorej sa dedia členy
  - odvodená trieda (derived class/child class) - trieda, ktorá zdedila členy
- reťazenie konštruktora (constructor chaining) - spôsob dedenia konštruktora, konštruktor zdedí funkcionalitu (cez base)
```cs
    public class Kalkulacka
    {
        public string[] cisla;
        public int n;
        public Kalkulacka(string[] cisla)
        {
            this.cisla = cisla;
            this.n = cisla.Length;
        }
    }
    public class PriemerKalkulacka : Kalkulacka
    {
        public PriemerKalkulacka(string[] cisla) : base(cisla)
        {

        }
        
        public double aritmetickyPriemer()
        {
            int sucet = 0;
            foreach(string s in cisla)
            {
                sucet += int.Parse(s);
            }
            return (double)sucet/n;
        }
    }
```

## vlastnosti
- gettery/settery - dvojica špeciálnych metód ktoré slúžia na prístup (nastavovanie alebo čítanie) vlastnosti `public int pocetObyvatelov { get; set; }`
- atribút (data member) - premenná triedy
  - vlastnosť (property) - premenná triedy slúžiaca na vonkajší opis triedy (zvyčajne `public`)
  - field - lokálna premenná triedy slúžiaca predovšetkým pre doplnkové účely (zvyčajne `private`)
  - spravidla (ale nie vždy), property = field + getter/setter
  
## modifiery

| modifier | trieda | člen |
| -------- | ------ | ------ |
| `protected` | - | je prístupný iba z danej triedy a potomkov |
| `abstract` | nemôže byť inštanciovaná, ale môže byť dedená | metóda nie je implementovaná (iba hlavička) a v potomkovi musí byť implementovaná (iba v `abstract` triedach) |
| `virtual` | - | metóda môže (ale nemusí) byť prekrytá |
| `override` | - | metóda prekrýva `abstract` alebo `virtual` metódu rodiča |
| `sealed` | nemôže byť dedená | metóda nemôže byť prekrytá |
  
## polymorfizmus 
- schopnosť členov (predovšetkým metód) meniť svoje správanie na základe implementácie
- základné druhy:
  1. ad-hoc polymorfizmus - preťažovanie metód, preťažovanie operátorov
  2. parametrický polymorfizmus - pomocou generík
  3. podtypový (inkluzívny) polymorfizmus - prekrývanie metód
  4. koerčný polymorfizmus - možnosť využitia premennej iného dátového typu ako metóda žiada kvôli implicitnému (alebo explicitnému) pretypovaniu

### preťažovanie metód (method overloading) 
- dve a viac metód majú rovnaký názov, ale odlišné parametre
```cs
        public void ZmenPocetObyvatelov(int delta)
        {
            pocetObyvatelov = pocetObyvatelov + delta;
        }
        public void ZmenPocetObyvatelov(int narodenia, int umrtia, int pristahovani, int odstahovani)
        {
            pocetObyvatelov = pocetObyvatelov + narodenia - umrtia + pristahovani - odstahovani;
        }
```

### prekrývanie metód (method overriding) 
- metóda potomka má iné správanie ako metóda rodiča
```cs
//metody v base class (rodicovi)
        public virtual double VypocitajDaneNaObyvatela()
        {
            return 100 * danovyKoeficient;
        }
        public abstract string Popis();
```
```cs
//metody v derived class (potomkovi)
        public override double VypocitajDaneNaObyvatela()
        {
            double zaklad = base.VypocitajDaneNaObyvatela();
            return okresneMesto ? zaklad * 1.05 : zaklad;
        }
        public override string Popis()
        {
            return okresneMesto ? "Okresne mesto" : "Obycajne mesto";
        }
```
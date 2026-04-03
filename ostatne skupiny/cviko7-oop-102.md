## metódy
- gettery/settery - dvojica špeciálnych metód ktoré slúžia na prístup (nastavovanie alebo čítanie) vlastnosti `public int pocetObyvatelov { get; set; }`
  
## modifiery

| modifier | trieda | člen |
| -------- | ------ | ------ |
| `protected` | - | je prístupný iba z danej triedy a potomkov |
| `abstract` | nemôže byť inštanciovaná, ale môže byť dedená | metóda nie je implementovaná (iba hlavička) a v potomkovi musí byť implementovaná (iba v `abstract` triedach) |
| `virtual` | - | metóda môže (ale nemusí) byť prekrytá |
| `override` | - | metóda prekrýva `abstract` alebo `virtual` metódu rodiča |
| `sealed` | nemôže byť dedená | metóda nemôže byť prekrytá |
  
## dedičnosť (pokračovanie)
- `base.` - volanie rodičovskej triedy
  
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
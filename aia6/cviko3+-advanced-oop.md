## metódy
- gettery/settery - dvojica špeciálnych metód ktoré slúžia na prístup (nastavovanie alebo čítanie) vlastnosti `public int pocetObyvatelov { get; set; }`
- expression-bodied metódy - metóda je zjednodušená pomocou => operátora v štýle "metóda(parametre) => návratová hodnota" `public double Hustota() => pocetObyvatelov / rozloha;`
- expression-bodied atribúty - atribút je vypočítaný na základe iných atribútov pomocou => operátora v štýle "atribút => hodnota" `public double hustota => pocetObyvatelov / rozloha;`
  
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

## klonovanie
- keďže objekty sú implementované na heape (odkazové typy), naivné vytvorenie kópie `Class object2 = object1;` bude odkazovať na rovnaký objekt
- existuje viacero spôsobov ako klonovať, napr.:
### 1. pomocou kopírovacieho konštruktora (copy constructor)
- v triede je vytvorený druhý konštruktor s jedným parametrom s typom funkcie a jednotlivé vlastnosti sa prekopírujú
```cs
        public Mesto(Mesto other)
        {
            this.pocetObyvatelov = other.pocetObyvatelov;
            this.rozloha = other.rozloha;
            this.okresneMesto = other.okresneMesto;
            this.danovyKoeficient = other.danovyKoeficient;
            pocetSidel++;
        }
```
- inštanciácia: `Mesto noveMesto = new Mesto(stareMesto);`

### 2. pomocou .Clone() 
- v triede je vytvorená metóda, ktorá vracia inštanciu triedy
```cs
        public Dedina Clone()
        {
            return new Dedina(this.pocetObyvatelov, this.rozloha);
        }
```
- inštanciácia: `Dedina novaDedina = staraDedina.Clone();`

### 3. reflekcia
- coming soon
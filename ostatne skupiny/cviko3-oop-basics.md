# **__OOP__**
## __základné pojmy__
- menný priestor (namespace) - kontajner pre triedy a iné menné priestory, funguje ako knižnica a volá sa pomocou `using` (`using System;`)
- trieda (class) - šablóna, podľa ktorej sa vytvárajú objekty, zoskupuje vlastnosti a správanie objektu reálneho sveta
- objekt (object) - jedna inštancia triedy
- atribút (data member) - premenná triedy
  - vlastnosť (property) - premenná triedy slúžiaca na vonkajší opis triedy (zvyčajne `public`)
  - field - lokálna premenná triedy slúžiaca predovšetkým pre doplnkové účely (zvyčajne `private`)
- metóda (method) - funkcia, ktorá popisuje aspekt správania triedy
- člen triedy (member) - súhrnný názov pre atribúty a metódy, pristupuje sa k nim cez . (ako v štruktúrach v C)
- konštruktor (constructor) - špeciálna metóda volaná iba raz, pri inštanciovaní triedy (vytváraní objektu), nemá dátový typ a má rovnaké meno ako trieda
- `this.` - špecifikácia pri prístupe k členom danej triedy (ekvivalentné `self.` v Pythone, len nie je nutné posielať ako parameter/argument)

## štyri piliere OOP
- abstrakcia - triedy v princípe neobsahujú žiadne konkrétne dáta, iba štruktúru
- enkapsulácia - triedy zoskupujú vlastnosti aj správanie objektu
- dedičnosť - triedy môžu byť buď potomkom inej triedy (a obsahovať rovnaké metódy a atribúty), alebo mať potomkov (ktorí obsahujú rovnaké metódy a atribúty)
- polymorfizmus - člen triedy (predovšetkým metóda) môže mať iné správanie v závislosti od implementácie

## modifiers
- upravujú prístup k triede alebo členu

| modifiers | trieda | člen |
| --------- | ------ | ---- |
| `public` | prístupná z akejkoľvek triedy | prístupný z akejkoľvek triedy |
| `private` | - | prístupný iba v rámci danej triedy |
| `static` | nedá sa inštanciovať, nedá sa z nej dediť a môže obsahovať iba `static` členy |  je ho možné volať aj bez inštanciácie triedy, je zdieľaný medzi všetkými objektmi a triedou; nemôže používať `this.` ani pristupovať k nestatickým premenným

## systémové triedy
- `Main` v triede `Program` je defaultne `static` a preto aj ostatné členy tej triedy musia byť `static`
- väčšina systémových tried je `static`, príklady volaných metód takýchto tried
```cs
Console.WriteLine(a); //static trieda Console, static metoda WriteLine
var x = Console.ReadLine(); //static trieda Console, static metoda ReadLine

//matematicke funkcie
Math.Sin(4); //static trieda Math, static metoda Sin
Math.Pi; //static trieda Math, static proberty Pi
```
- niektoré systémové triedy nie sú statické (teda, sú inštančné) a je možné vytvoriť ich inštanciu
```cs
Random rng = new Random();
double x = rng.Next();

DateTime date = new DateTime(2026, 2, 23);
```

- základné dátové typy tiež vystupujú ako triedy (a ich inštancie ako objekty) alebo štruktúry
```cs
int A;
string B = A.ToString(); //"instancia" A ("struktury" int), static metoda ToString
int C = int.Parse(B); //static "struktura" int, static metoda Parse
```
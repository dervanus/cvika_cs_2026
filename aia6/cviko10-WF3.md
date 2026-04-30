## Okná
### Modálne vs. nemodálne okná
- modálne okná (modal windows) nepovoľujú počas ich otvorenia prístup k oknu, ktoré ich vyvolalo
  - vykonávanie kódu v rodičovskom okne sa "zastaví"
  - v drvivej väčšine prípadov sa otvára pomocou metódy `ShowDialog`, s výnimkou `MessageBox`, ktorý má metódu `Show`
  - metóda `ShowDialog` vracia enum typu `DialogResult`, ktorý popisuje tlačidlo stlačené používateľom (`OK`, `Cancel` a pod.)
  - okrem používateľských okien k nim patria aj `OpenFileDialog`, `SaveFileDialog`, 
- nemodálne okná (modeless windows) povoľujú prístup aj k pôvodnému oknu
  - vykonávanie kódu v rodičovskom okne pokračuje ďalej
  - vždy pomocou metódy `Show`, ktorá je typu `void`
  - patria tam predovšetkým používateľské okná

### MessageBox
- vyskakovacie okno, ktoré nie je potrebné inštanciovať
- má viacero preťažení, pri jednom argumente ide o text okna, pri dvoch je druhý nadpis okna
```cs
MessageBox.Show("(c) Janko Hraško, 2026");
MessageBox.Show("(c) Janko Hraško, 2026", "O autoroch");
```

### Používateľské okná
- používateľ si môže vytvoriť vlastné okno 
  - klik pravým na projekt -> Add -> Form (Windows Forms)...
- volá sa inštanciovaním a metódou `Show` alebo `ShowDialog`
```cs
VedlajsieOkno o = new VedlajsieOkno();
o.ShowDialog();
```
- ak do druhého okna potrebujeme dostať nejakú informáciu, preberáme ju cez konštruktor

## Práca so súbormi
### OpenFileDialog
- dialógové okno pre otvorenie súboru
- množstvo vlastností, ktoré definujú napr. defaultný adresár pri otvorení okna (`InitialDirectory`) a podobne
- dôležitá vlastnosť je `Filter`, ktorá definuje možné formáty súborov
```cs
openFileDialog1.Filter = "Textové súbory|*.txt|Všetky súbory|*.*";
```
- volá sa pomocou `ShowDialog`

### SaveFileDialog
- dialógové okno pre uloženie súboru
- všetko isté platí ako v `OpenFileDialog`
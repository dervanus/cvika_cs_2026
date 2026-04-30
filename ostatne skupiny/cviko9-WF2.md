## Kontajnery
- využívajú sa pre zoskupenie prvkov, či už z dôvodov lepšieho manažmentu prvkov (napr. ak chceme rovnaké vlastnosti, napr. `Enabled` alebo `Visible`, pre skupinu prvkov), alebo v niektorých prípadoch z nutnosti
  - typickým príkladom je zoskupovanie `RadioButton`ov, z ktorých niekedy chceme aby si používateľ zvolil jeden `RadioButton` z jednej skupiny prvkov a jeden z druhej skupiny prvkov
  - keďže ich materský kontajner je defaultne `Form`, defaultne si môže zvoliť iba jeden `RadioButton` zo všetkých prvkov
- vo WF sú dva kontajnery `Panel` a `GroupBox`, ktoré sa odlišujú iba vizuálne (`GroupBox` má okraje a nadpis)
- ich prvky musia byť uložené "na nich"; pri pohybe s kontajnerom sa musia hýbať zároveň aj prvky

## Vytváranie spoločných udalostí pre skupinu prvkov
- dokážeme vytvárať udalosti pre skupinu prvkov, predovšetkým ak sa jedná o prvky rovnakého druhu
- vybratie viacerých prvkov -> Events -> konkrétna udalosť
- výhodné predovšetkým ak viacero prvkov bude vykonávať rovnakú alebo podobnú logiku

## Parametre udalostí
### sender
- parameter typu `object`
- konkrétny prvok, ktorý vyvoláva danú udalosť (tlačidlo, radio button atď.)
- kvôli polymorfizmu je typu `object` ale v praxi sa musí vždy pretypovať
```cs
RadioButton rb = (RadioButton)sender;
//alebo, predovšetkým v novších verziách .netu
RadioButton rb = sender as RadioButton;
```
- vhodné predovšetkým v udalostiach spoločných pre viacero prvkov

### EventArgs
- samé osebe bez hlbšieho významu, dôležité predovšetkým vo verziách `KeyEventArgs` (v `Key` udalostiach, napr. `KeyDown`, `KeyUp` apod.) a `MouseEventArgs` (v `Mouse` udalostiach)
- `KeyEventArgs` - obsahujú informácie o stlačených klávesách (napr. konkrétny kód cez `KeysCode`)
- `MouseEventArgs` - obsahujú informácie o stlačených tlačidlách myši (okrem kódov aj napr. pozíciu kurzora relatívne k danému prvku)
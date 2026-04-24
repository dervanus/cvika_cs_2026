# .NET
- .NET nám všeobecne dovoľuje vytvárať okrem konzolových aplikácií aj oknové/desktopové (Windows Forms, WPF), webové (ASP.NET: MVC, Razor, Blazor apod.) či mobilné (MAUI)

# Windows Forms
- framework slúžiaci na návrh frontendu aj backendu oknových aplikácií
- oproti WPF legacy technológia

## Prostredie
- viď Solution Explorer: defaultne sa vytvoria tri .cs súbory: Program.cs, (defaultne) Form1.cs a Form1.Designer.cs

### Program.cs
- štartovacie miesto aplikácie, všeobecne sa tam môže aj zvoliť aj ktorý formulár (okno) sa spúšťa defaultne
```cs
namespace Kalkulacka
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
```

### Form1.cs
- má dve verzie, Code a Designer, medzi ktorými sa prechádza po kliknutý pravým -> View Code alebo View Designer

#### Designer
- vo VS a v Rideri nám IDE povoľuje drag-and-drop návrh okna pomocou GUI
- prvky, ktoré môžeme vkladať do priestoru okna, sú v Toolboxi (View -> Toolbox)
- každý prvok má svoju sadu vlastností a udalostí, ku ktorým sa dá pristupovať cez klik pravým na prvok -> Properties
![okno Properties](../_images/props.png)
- prvé dve ikony definujú spôsob akým sú vlastnosti/udalosti vymenované (prvá ikona kategoricky, druhá ikona abecedne), druhé dve ikony slúžia na prehadzovanie medzi vlastnosťami a udalosťami
- všetky vlastnosti tu definované sú nastavované na defaultnú hodnotu, dajú sa meniť (defaultne aj počas behu programu) v kóde

#### Code
- tu je popísaná logika programu a jednotlivých prvkov
- defaultne je v kóde iba konštruktor
```cs
namespace Kalkulacka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
}
```
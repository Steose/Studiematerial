# Duplantis världsrekordanalys

## Bakgrundshistoria
Du arbetar som statistiker för Sveriges Olympiska Kommitté och ska analysera Armand "Mondo" Duplantis fantastiska världsrekord i stavhopp. Du har fått i uppdrag att räkna ut hur mycket han i genomsnitt förbättrar sitt rekord varje gång, och hur mycket han totalt har förbättrat sedan första rekordet.

## Din uppgift

```csharp
using System;

namespace DuplantisAnalys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MONDO DUPLANTIS - VÄRLDSREKORDANALYS");
            Console.WriteLine("====================================");

            // Duplantis första världsrekord: 6.17 meter (8 februari 2020)
            // Hans senaste rekord här: 6.25 meter (25 augusti 2024, OS i Paris)
            // Totalt antal rekord i denna analys: 10 stycken (se tabellen nedan)

            // Skapa variabler för första och senaste rekordhöjd (använd double för decimaler)

            // Skapa variabel för antal rekord

            // Beräkna total förbättring (senaste - första)

            // Beräkna genomsnittlig förbättring per rekord

            // Skriv ut rapporten
            Console.WriteLine("Första världsrekord: [höjd] meter");
            Console.WriteLine("Senaste världsrekord: [höjd] meter");
            Console.WriteLine("Antal världsrekord: [antal]");
            Console.WriteLine("Total förbättring: [förbättring] meter");
            Console.WriteLine("Genomsnittlig förbättring per rekord: [genomsnitt] meter");

            // Bonus: Räkna ut hur högt han skulle hoppa efter 20 rekord
            // om han fortsätter med samma genomsnittliga förbättring

            Console.WriteLine("Om Mondo fortsätter i samma takt...");
            Console.WriteLine("Efter 20 rekord skulle han hoppa: [framtida höjd] meter");
        }
    }
}
```

## Förväntad output
```
MONDO DUPLANTIS - VÄRLDSREKORDANALYS
====================================
Första världsrekord: 6,17 meter
Senaste världsrekord: 6,25 meter
Antal världsrekord: 10
Total förbättring: 0,08 meter
Genomsnittlig förbättring per rekord: 0,008 meter
Om Mondo fortsätter i samma takt...
Efter 20 rekord skulle han hoppa: 6,33 meter
```

<details>
<summary><strong>💡 Tips 1: Decimaltal</strong></summary>

För att arbeta med höjder som 6.17 meter behöver du `double` datatyp:

```csharp
double förstaRekord = 6.17;
double senasteRekord = 6.25;
```

Använd punkt (.) som decimaltecken i koden, även om utskriften visar komma.

</details>

<details>
<summary><strong>💡 Tips 2: Beräkna genomsnitt</strong></summary>

För att beräkna genomsnittlig förbättring per rekord, dela total förbättring med antal rekord:

```csharp
double totalFörbättring = senasteRekord - förstaRekord;
double genomsnitt = totalFörbättring / antalRekord;
```

Division med `/` operatorn ger dig medelvärdet.

</details>

<details>
<summary><strong>💡 Tips 3: Framtidsprojektion</strong></summary>

För att beräkna en framtida höjd, använd multiplikation:

```csharp
double framtidaHöjd = förstaRekord + (genomsnitt * framtidaAntalRekord);
```

Detta tar första rekordet och lägger till förbättringen gånger antalet rekord.

</details>

<details>
<summary><strong>💡 </strong></summary>

```csharp
using System;

namespace DuplantisAnalys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MONDO DUPLANTIS - VÄRLDSREKORDANALYS");
            Console.WriteLine("====================================");

            // Duplantis rekorddata
            double förstaRekord = 6.17;    // meter (8 februari 2020)
            double senasteRekord = 6.25;   // meter (25 augusti 2024, OS Paris)
            int antalRekord = 10;

            // Beräkna total förbättring
            double totalFörbättring = senasteRekord - förstaRekord;

            // Beräkna genomsnittlig förbättring per rekord
            double genomsnittligFörbättring = totalFörbättring / antalRekord;

            // Skriv ut rapporten
            Console.WriteLine("Första världsrekord: " + förstaRekord + " meter");
            Console.WriteLine("Senaste världsrekord: " + senasteRekord + " meter");
            Console.WriteLine("Antal världsrekord: " + antalRekord);
            Console.WriteLine("Total förbättring: " + totalFörbättring + " meter");
            Console.WriteLine("Genomsnittlig förbättring per rekord: " + genomsnittligFörbättring + " meter");

            // Bonus: Framtida projektion
            int framtidaAntalRekord = 20;
            double framtidaHöjd = förstaRekord + (genomsnittligFörbättring * framtidaAntalRekord);

            Console.WriteLine("Om Mondo fortsätter i samma takt...");
            Console.WriteLine("Efter " + framtidaAntalRekord + " rekord skulle han hoppa: " + framtidaHöjd + " meter");
        }
    }
}
```

</details>

## Riktiga data - Duplantis världsrekord (urval)

Här är några av Mondos riktiga världsrekord som du kan använda för att kontrollera dina beräkningar:

| Datum | Höjd | Plats | Kommentar |
|-------|------|-------|-----------|
| 8 feb 2020 | 6,17 m | Toruń, Polen | Första världsrekordet (indoor) |
| 15 feb 2020 | 6,18 m | Glasgow, Skottland | Andra rekordet |
| 7 sep 2020 | 6,15 m | Rom, Italien | Första outdoor-rekordet |
| 17 sep 2020 | 6,19 m | Rom, Italien | Nytt outdoor-rekord |
| 6 mar 2022 | 6,19 m | Belgrad, Serbien | VM-guld med världsrekord |
| 24 jul 2022 | 6,21 m | Eugene, USA | VM-rekord outdoor |
| 19 feb 2023 | 6,22 m | Auburn, USA | Indoor-rekord |
| 12 aug 2023 | 6,23 m | Budapest, Ungern | VM-rekord |
| 20 apr 2024 | 6,24 m | Xiamen, Kina | Diamond League |
| 25 aug 2024 | 6,25 m | Paris, Frankrike | OS-rekord |

*Källa: World Athletics, European Athletics, Svenska Friidrottsförbundet*

## Kul fakta om Mondo Duplantis
- Han är född i USA men tävlar för Sverige (mammas hemland)
- Hans smeknamn "Mondo" kommer från italienska morfar
- Han höjer ofta rekordet med bara 1 cm åt gången för maximal effekt
- Vid 25 års ålder har han slagit världsrekordet över 10 gånger!
- Strategin med små ökningar maximerar både prestige och prispengarna

## Källor för vidare läsning
- World Athletics: [worldathletics.org](https://worldathletics.org)
- Svenska Friidrottsförbundet: [friidrott.se](https://friidrott.se)
- European Athletics: [european-athletics.com](https://european-athletics.com)

## Lärdomar från uppgiften
- Hur man använder `double` för decimaltal
- Division för att beräkna genomsnitt
- Subtraktion för att hitta skillnader
- Multiplikation för framtidsprojektioner
- Arbeta med verkliga sportstatistik

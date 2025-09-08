# Rymdforskaren på Kepler-442b

## 🎯 Mål med övningen

Efter den här övningen kommer du att kunna:

- Skapa variabler av olika datatyper (`string`, `int`, `double`)
- Använda operatorer (`*`, `+`, `-`, `+=`, `-=`, `/`)
- Skriva ut resultat i konsolen med string concatenation
- Arbeta med decimaltal (double) för precisionsberäkningar

---

## 🧩 Upptäcktsresan

Commander Zara Nova har just landat på den mystiska planeten Kepler-442b. Hon är den första människan som sätter sin fot på denna avlägsna värld, 1200 ljusår från jorden. Hennes uppdrag: kartlägga planeten och undersöka de främmande varelserna som hennes satelliter har upptäckt.

Zaras skanners visar att de lokala varelserna, kallade **Lumens**, har en genomsnittlig energinivå på **25** enheter. Men Zara som erfaren rymdforskare har **tre gånger så hög energinivå** som en genomsnittlig Lumen.

## 🚀 Kom igång: Första dagen (tänk själv!)

```csharp
using System;

namespace SpaceExploration
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rymdforskarens namn (text)
            // Vi lagrar namn i en variabel så vi kan återanvända det genom programmet
            // Detta följer DRY-principen: Don't Repeat Yourself - om vi behöver ändra namnet senare, gör vi det på ett ställe
            // Skapa en string variabel som heter "explorerName" och sätt värdet till "Commander Zara Nova"
```

<details>
<summary>💡 Tips</summary>

```csharp
            string explorerName = "Commander Zara Nova";
```

</details>

```csharp
            // En Lumens energinivå (heltal)
            // Vi behöver en "konstant" som representerar baslinjen för jämförelser
            // I riktiga program kommer sådana värden ofta från konfigurationsfiler eller databaser
            // Skapa en int variabel som heter "lumenEnergy" och sätt värdet till 25
```

<details>
<summary>💡 Tips</summary>

```csharp
            int lumenEnergy = 25;
```

</details>

```csharp
            // Zaras energinivå (tre gånger så hög som en Lumen)
            // Istället för att hardkoda 75, beräknar vi från lumenEnergy
            // Detta gör koden flexibel - om lumenEnergy ändras, uppdateras zaraEnergy automatiskt
            // Skapa en int variabel som heter "zaraEnergy" och beräkna: lumenEnergy * 3
```

<details>
<summary>💡 Tips</summary>

```csharp
            int zaraEnergy = lumenEnergy * 3;
```

</details>

```csharp
            Console.WriteLine("Upptäcktslogg startar. Jag är " + explorerName + ".");
            Console.WriteLine(explorerName + " har " + zaraEnergy + " energienheter tillgängliga!");

            // Antal Lumens som upptäckts
            // Vi behöver hålla reda på tillståndet (state) genom programmet
            // Denna variabel kommer att uppdateras senare - det kallas för mutable state
            // Skapa en int variabel som heter "discoveredLumens" och sätt värdet till 12
```

<details>
<summary>💡 Tips</summary>

```csharp
            int discoveredLumens = 12;
```

</details>

```csharp
            Console.WriteLine("Sensorer visar " + discoveredLumens + " Lumens i närområdet");

            // Kommunikationsförsök - energikostnad per försök  
            // Vi använder double för precision - energi kan vara 3.5, inte bara heltal
            // Detta representerar "cost per unit" - ett vanligt mönster i programmering
            // Skapa en double variabel som heter "commCostPerAttempt" och sätt värdet till 3.5
```

<details>
<summary>💡 Tips</summary>

```csharp
            double commCostPerAttempt = 3.5;
```

</details>

```csharp
            // Antal kommunikationsförsök
            // Att separera "antal" från "kostnad per" gör koden modulär och testbar
            // Nu kan vi enkelt ändra antalet försök utan att påverka kostnaden per försök
            // Skapa en int variabel som heter "commAttempts" och sätt värdet till 4
```

<details>
<summary>💡 Tips</summary>

```csharp
            int commAttempts = 4;
```

</details>

```csharp
            // Total energikostnad för kommunikation
            // Computed values: vi beräknar från andra variabler istället för att gissa
            // Detta eliminerar mänskliga räknefel och gör koden självdokumenterande
            // Skapa en double variabel som heter "totalCommCost" och beräkna: commCostPerAttempt * commAttempts
```

<details>
<summary>💡 Tips</summary>

```csharp
            double totalCommCost = commCostPerAttempt * commAttempts;
```

</details>

```csharp
            Console.WriteLine("Kommunikationsförsök påbörjas...");
            Console.WriteLine("Energikostnad för " + commAttempts + " försök: " + totalCommCost + " enheter");

            // Uppdatera Zaras energinivå efter kommunikationsförsöken
            // Resource management: vi spårar konsumtion av begränsade resurser
            // I verkliga system: batteriladdning, minnesutrymme, nätverksbandbredd, API-calls, etc.
            // Skapa en double variabel som heter "zaraRemainingEnergy" och beräkna: zaraEnergy - totalCommCost
```

<details>
<summary>💡 Tips</summary>

```csharp
            double zaraRemainingEnergy = zaraEnergy - totalCommCost;
```

</details>

```csharp
            Console.WriteLine(explorerName + " har " + zaraRemainingEnergy + " energienheter kvar");

            // Antal vänliga Lumens som svarade
            // Business logic: detta representerar resultatet av en operation
            // I riktiga appar: antal framgångsrika transaktioner, lyckade login-försök, godkända ansökningar
            // Skapa en int variabel som heter "friendlyLumens" och sätt värdet till 7
```

<details>
<summary>💡 Tips</summary>

```csharp
            int friendlyLumens = 7;
```

</details>

```csharp
            Console.WriteLine("Genombrott! " + friendlyLumens + " Lumens svarade vänligt!");
            Console.WriteLine(explorerName + " har etablerat första kontakten med en främmande civilisation!");
        }
    }
}
```

## ✅ Förväntat resultat efter första dagen

```
Upptäcktslogg startar. Jag är Commander Zara Nova.
Commander Zara Nova har 75 energienheter tillgängliga!
Sensorer visar 12 Lumens i närområdet
Kommunikationsförsök påbörjas...
Energikostnad för 4 försök: 14 enheter
Commander Zara Nova har 61 energienheter kvar
Genombrott! 7 Lumens svarade vänligt!
Commander Zara Nova har etablerat första kontakten med en främmande civilisation!
```

---

## ⚔️ Andra dagen och framåt (nu vet du hur det funkar!)

Nu när Zara har etablerat kontakt fortsätter utforskningen. **12 Lumens** upptäcktes totalt och Zara fortsätter sina forskningsaktiviteter:
- **Energiskanningar**: 2.5 enheter per skanning
- **Provtagning**: 4 försök som kostar totalt 12 enheter
- **Datalogging**: Ytterligare kommunikation som förbrukar energi

Fortsätt med resten av koden:

```csharp
            // Andra dagens aktiviteter
            double scanCost = 2.5;
            int numberOfScans = 6;
            double dailyScanCost = scanCost * numberOfScans;
            zaraRemainingEnergy = zaraRemainingEnergy - dailyScanCost;

            Console.WriteLine("Dag 2: " + numberOfScans + " energiskanningar genomförda");
            Console.WriteLine("Energikostnad: " + dailyScanCost + " enheter");
            Console.WriteLine(explorerName + " har " + zaraRemainingEnergy + " energienheter kvar");

            // Tredje dagen - provtagning
            int sampleCost = 12;
            zaraRemainingEnergy -= sampleCost; // Kort version av samma sak

            Console.WriteLine("Dag 3: Provtagning av Lumen-habitat genomförd");
            Console.WriteLine("Energikostnad: " + sampleCost + " enheter");
            Console.WriteLine(explorerName + " har " + zaraRemainingEnergy + " energienheter kvar");

            // Fjärde dagen - ytterligare kommunikation
            totalCommCost += commCostPerAttempt * 2; // Två extra försök
            zaraRemainingEnergy -= commCostPerAttempt * 2;

            Console.WriteLine("Dag 4: Fördjupad kommunikation med Lumens");
            Console.WriteLine("Total kommunikationskostnad: " + totalCommCost + " enheter");
            Console.WriteLine(explorerName + " har " + zaraRemainingEnergy + " energienheter kvar");

            // Femte dagen - uppdragssumma
            discoveredLumens += friendlyLumens - 2; // Vissa Lumens var blyga och gömde sig
            
            Console.WriteLine("Uppdrag slutfört!");
            Console.WriteLine("Totalt antal Lumens dokumenterade: " + discoveredLumens);
            Console.WriteLine(explorerName + " återvänder till rymdskeppet med historiska upptäckter!");
        }
    }
}
```

## ✅ Fullständigt förväntat resultat

```
Upptäcktslogg startar. Jag är Commander Zara Nova.
Commander Zara Nova har 75 energienheter tillgängliga!
Sensorer visar 12 Lumens i närområdet
Kommunikationsförsök påbörjas...
Energikostnad för 4 försök: 14 enheter
Commander Zara Nova har 61 energienheter kvar
Genombrott! 7 Lumens svarade vänligt!
Commander Zara Nova har etablerat första kontakten med en främmande civilisation!
Dag 2: 6 energiskanningar genomförda
Energikostnad: 15 enheter
Commander Zara Nova har 46 energienheter kvar
Dag 3: Provtagning av Lumen-habitat genomförd
Energikostnad: 12 enheter
Commander Zara Nova har 34 energienheter kvar
Dag 4: Fördjupad kommunikation med Lumens
Total kommunikationskostnad: 21 enheter
Commander Zara Nova har 27 energienheter kvar
Uppdrag slutfört!
Totalt antal Lumens dokumenterade: 17
Commander Zara Nova återvänder till rymdskeppet med historiska upptäckter!
```

## 💡 Lärdomar

**Första dagen lärde dig:**
- **String concatenation**: Sammanslagning av text med `+` operatorn
- **Datatyper**: `string` för text, `int` för heltal, `double` för decimaltal
- **Matematiska operationer**: Multiplikation (`*`), addition (`+`), subtraktion (`-`)
- **Precision**: Skillnaden mellan `int` och `double` för exakta beräkningar

**Andra dagen och framåt lärde dig:**
- **Compound assignment**: `+=` och `-=` för att förändra variabelns värde
- **Mixed operations**: Arbeta med både heltal och decimaltal i samma program
- **Variabelanvändning**: Återanvända och uppdatera värden över flera dagar/operationer
- **Realistiska beräkningar**: Energikostnader och resurshantering som i verkliga program

Commander Zara Nova visar att programmering handlar om att organisera data och beräkningar för att lösa komplexa problem - precis som i rymdforskning!
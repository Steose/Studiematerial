# Skattjakt i grottan: Var är guldet?

## Bakgrund

Du har hittat en gammal skattkarta som leder till en mystisk grotta! Kartan visar **8 platser** inne i grottan, men bara **EN** innehåller det äkta guldet. Resten är **fällor** med farliga överraskningar...

Din uppgift: Använd **loopar** och **if-satser** för att leta igenom grottan och hitta skatten!

## Grottkartan

```
[1] [2] [3] [4]
[5] [6] [7] [8]
```

**Platserna kan innehålla:**
- **Guld** 💰 (det du letar efter!)
- **Fälla** 💀 (spindlar, giftgas, fallgropar...)

## Uppgift

Skriv ett program som:

1. Spara vad som finns på varje plats i en `bool[] hasGold` array
2. Använd en **for-loop** för att leta igenom alla platser
3. När du hittar guldet: skriv ut **vilken plats** det är på
4. Räkna hur många **fällor** du passerade innan du hittade skatten

## Startkod

```csharp
using System;

class Program
{
    static void Main()
    {
        // --- Grottans innehåll ---
        bool[] hasGold = { false, false, false, true, false, false, false, false };

        Console.WriteLine("💰 SKATTJAKT I GROTTAN");
        Console.WriteLine("======================");
        Console.WriteLine("Du kliver in i den mörka grottan...");
        Console.WriteLine("8 platser att undersöka:\n");

        Console.WriteLine("[1] [2] [3] [4]");
        Console.WriteLine("[5] [6] [7] [8]\n");

        Console.WriteLine("🔍 Börjar leta...\n");

        // Din kod här - använd en for-loop!

    }
}
```

**Vad ska din loop göra?**
1. För varje plats: kontrollera om `hasGold[i] == true`
2. Om det inte är guld: skriv "Plats X: Fälla! 💀"
3. Om det är guld: skriv "Plats X: SKATTEN HITTAD! 💰"
4. Räkna fällorna

## Exempel på utskrift

```
💰 SKATTJAKT I GROTTAN
======================
Du kliver in i den mörka grottan...
8 platser att undersöka:

[1] [2] [3] [4]
[5] [6] [7] [8]

🔍 Börjar leta...

Plats 1: Fälla! 💀 (Giftiga spindlar!)
Plats 2: Fälla! 💀 (Fallgrop!)
Plats 3: Fälla! 💀 (Giftgas!)
Plats 4: SKATTEN HITTAD! 💰

🎉 GRATTIS! Du hittade guldet på plats 4!
⚠️  Du passerade 3 fällor innan du lyckades.
```

## Experiment att testa

* **Flytta skatten**: Ändra `true` till en annan plats i arrayen
* **Flera skatter**: Sätt `true` på flera platser - vad händer?
* **Ingen skatt**: Sätt alla till `false` - hantera detta fall!

<details>
<summary>💡 Lösning</summary>

```csharp
using System;

class Program
{
    static void Main()
    {
        // --- Grottans innehåll ---
        bool[]   hasGold   = { false , false , false , true  , false , false , false , false };
        string[] trapTypes = { "Giftiga spindlar" , "Fallgrop" , "Giftgas" , "" , "Skelett" , "Spökande ljud" , "Kall vind" , "Stenblock" };


        Console.WriteLine("💰 SKATTJAKT I GROTTAN");
        Console.WriteLine("======================");
        Console.WriteLine("Du kliver in i den mörka grottan...");
        Console.WriteLine("8 platser att undersöka:\n");

        Console.WriteLine("[1] [2] [3] [4]");
        Console.WriteLine("[5] [6] [7] [8]\n");

        Console.WriteLine("🔍 Börjar leta...\n");

        int trapsFound = 0;
        bool treasureFound = false;
        int treasureLocation = -1;

        for (int i = 0; i < hasGold.Length; i++)
        {
            int placeNumber = i + 1; // Array index 0-7, men platser 1-8

            if (hasGold[i])
            {
                Console.WriteLine($"Plats {placeNumber}: SKATTEN HITTAD! 💰");
                treasureFound = true;
                treasureLocation = placeNumber;
                break; // Sluta leta när vi hittat skatten
            }
            else
            {
                Console.WriteLine($"Plats {placeNumber}: Fälla! 💀 ({trapTypes[i]}!)");
                trapsFound++;
            }
        }

        Console.WriteLine();

        if (treasureFound)
        {
            Console.WriteLine($"🎉 GRATTIS! Du hittade guldet på plats {treasureLocation}!");
            Console.WriteLine($"⚠️  Du passerade {trapsFound} fällor innan du lyckades.");
        }
        else
        {
            Console.WriteLine("😞 Ingen skatt hittades... Kartan måste vara felaktig!");
        }
    }
}
```

**Vad händer när du kör?** Du hittar skatten på plats 4 efter 3 fällor!

</details>

## Bonusuppgifter

<details>
<summary>🚀 Utökad version med olika skatter</summary>

```csharp
// Lägg till efter hasGold:
string[] treasureTypes  = { "" , "" , "" , "Guldmynt" , "" , "" , "" , "" };
int[]    treasureValues = {  0 ,  0 ,  0 ,      1000 ,  0 ,  0 ,  0 ,  0 };


// I loopen när skatt hittas:
if (hasGold[i])
{
    Console.WriteLine($"Plats {placeNumber}: {treasureTypes[i]} värt {treasureValues[i]} kr! 💰");
}
```

</details>

<details>
<summary>🗺️ Interactive version med val</summary>

```csharp
// Lägg till innan loopen:
Console.WriteLine("Vilken plats vill du undersöka först? (1-8): ");
// Här kan man lägga till input och låta användaren välja ordning
```

</details>

<details>
<summary>🎲 Random version</summary>

```csharp
// Lägg till längst upp:
Random random = new Random();
int goldLocation = random.Next(0, hasGold.Length);

// Sätt guldet på slumpmässig plats:
for (int i = 0; i < hasGold.Length; i++)
{
    hasGold[i] = (i == goldLocation);
}
```

</details>

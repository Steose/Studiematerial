# Övning 1: Avengers Team Management System

## 🎯 Mål med övningen

Efter den här övningen kommer du att kunna:

- Skapa och initialisera arrays i C#
- Komma åt array-element med index
- Loopa genom arrays med for och foreach
- Förstå array.Length egenskapen

## 🧩 Uppgiften

Nu ska ni bygga Nick Furys Avengers-management system! Tänk er att ni arbetar för S.H.I.E.L.D. och behöver hålla koll på alla superhjältar som är tillgängliga för uppdrag.

Systemet ska kunna:

- Lagra en lista med hjältar
- Visa alla tillgängliga hjältar
- Hitta en specifik hjälte
- Räkna hur många hjältar som finns

## 🚀 Kom igång: Startkod

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== S.H.I.E.L.D. AVENGERS MANAGEMENT ===");
        Console.WriteLine();

        // TODO: Skapa en array med 6 Avengers-medlemmar
        // Iron Man, Captain America, Thor, Black Widow, Hulk, Hawkeye

        // TODO: Visa alla tillgängliga hjältar
        ShowAllHeroes(heroes);

        // TODO: Sök efter en specifik hjälte
        FindHero(heroes, "Thor");

        // TODO: Visa total antal hjältar
        ShowTotalCount(heroes);
    }

    static void ShowAllHeroes(string[] heroes)
    {
        // DIN KOD HÄR - visa alla hjältar
    }

    static void FindHero(string[] heroes, string searchName)
    {
        // DIN KOD HÄR - hitta och visa position för hjälten
    }

    static void ShowTotalCount(string[] heroes)
    {
        // DIN KOD HÄR - visa totalt antal hjältar
    }
}
```

## ✅ Förväntat resultat

När ni kör er färdiga kod, borde terminalen visa något i stil med:

```
=== S.H.I.E.L.D. AVENGERS MANAGEMENT ===

🦸‍♂️ Available Heroes:
1. Iron Man
2. Captain America
3. Thor
4. Black Widow
5. Hulk
6. Hawkeye

🔍 Searching for Thor...
✅ Thor found at position 2 (index 2)

📊 Total heroes in roster: 6
Mission ready!
```

## 🕵️‍♂️ Hur testar vi att det funkar?

1. **Som Nick Fury vill jag se alla tillgängliga hjältar för att planera uppdrag**
2. **Som operatör vill jag snabbt hitta en specifik hjälte och deras position**
3. **Som chef vill jag veta hur stort mitt team är totalt**
4. **Som användare vill jag att programmet inte kraschar med tomma arrays**

## 🤔 Diskussion i paret

Snacka ihop er!

1. Varför börjar array-index på 0 istället för 1?
2. Vad händer om vi försöker komma åt index som inte finns?
3. Vilka andra sätt finns det att loopa genom en array?

## 💡 Tips

- Använd `array.Length` för att få arrayens storlek
- `foreach` är ofta lättare än `for` när du ska visa alla element
- Tänk på att index börjar på 0 men vi vill visa nummer från 1 till användaren

<details>
<summary>💡 Klicka här för ett </summary>

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== S.H.I.E.L.D. AVENGERS MANAGEMENT ===");
        Console.WriteLine();

        // Skapa Avengers roster
        string[] heroes = {
            "Iron Man",
            "Captain America",
            "Thor",
            "Black Widow",
            "Hulk",
            "Hawkeye"
        };

        ShowAllHeroes(heroes);
        Console.WriteLine();

        FindHero(heroes, "Thor");
        Console.WriteLine();

        ShowTotalCount(heroes);
    }

    static void ShowAllHeroes(string[] heroes)
    {
        Console.WriteLine("🦸‍♂️ Available Heroes:");

        for (int i = 0; i < heroes.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {heroes[i]}");
        }
    }

    static void FindHero(string[] heroes, string searchName)
    {
        Console.WriteLine($"🔍 Searching for {searchName}...");

        for (int i = 0; i < heroes.Length; i++)
        {
            if (heroes[i] == searchName)
            {
                Console.WriteLine($"✅ {searchName} found at position {i + 1} (index {i})");
                return;
            }
        }

        Console.WriteLine($"❌ {searchName} not found in roster");
    }

    static void ShowTotalCount(string[] heroes)
    {
        Console.WriteLine($"📊 Total heroes in roster: {heroes.Length}");
        Console.WriteLine("Mission ready!");
    }
}
```

**Förklaring av lösningen:**

- Vi använder array initializer syntax `{ }` för enkel skapelse
- `for`-loop med `i + 1` för att visa nummer från 1 till användaren
- `return` i FindHero för att avsluta sökningen när vi hittat hjälten
- Felhantering om hjälten inte finns i listan

</details>

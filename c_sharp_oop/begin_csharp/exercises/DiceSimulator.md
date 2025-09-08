# 🎲 Tärningssimulator

> Simulera 10 tärningskast och räkna resultat.

## 🎯 Träningsmål

Detta projekt är designat för att träna följande koncept:

*   `Random, array/dictionary, loopar.`

## 🚀 Så kör du projektet från Visual Studio eller Rider

Tryck på den gröna play-knappen i Visual Studio eller Rider för att köra projektet.

## 🚀 Så kör du projektet

Skapa ett nytt console-projekt och följ kraven ovan.

<details>
<summary><strong>💡 </strong></summary>

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        // --- Del 1: Initialisering och välkomstmeddelande ---

        // Skapar en instans av Random-klassen. Detta objekt kan generera slumptal.
        // Det är viktigt att bara skapa ett Random-objekt och återanvända det.
        Random randomGenerator = new Random();

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("--- 🎲 Tärningssimulator ---");
        Console.WriteLine("Vi kastar en tärning och ser hur ofta vi får en sexa.");
        Console.ResetColor();
        Console.WriteLine();

        // --- Del 2: Inmatning från användaren ---

        Console.Write("Hur många gånger ska tärningen kastas? ");
        int numberOfRolls = int.Parse(Console.ReadLine());

        // --- Del 3: Simulering med en loop ---

        // En variabel för att hålla reda på antalet sexor.
        int sixesCounter = 0;

        // En for-loop som körs 'numberOfRolls' gånger.
        // 'i' är en loop-variabel som räknar från 0 upp till (men inte inklusive) numberOfRolls.
        for (int i = 0; i < numberOfRolls; i++)
        {
            // Genererar ett slumptal. .Next(1, 7) ger ett heltal från 1 till 6.
            // Den övre gränsen (7) är exklusiv.
            int rollResult = randomGenerator.Next(1, 7);

            // En if-sats som kollar om kastet blev en sexa.
            if (rollResult == 6)
            {
                // Om det är en sexa, öka räknaren med 1.
                sixesCounter++; // Samma som sixesCounter = sixesCounter + 1;
            }
        }

        // --- Del 4: Presentation av resultat ---

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine();
        Console.WriteLine($"Efter {numberOfRolls} kast fick du {sixesCounter} sexor.");
        Console.ResetColor();

        // Pausar programmet.
        Console.WriteLine("\nTryck på valfri tangent för att avsluta...");
        Console.ReadKey();
    }
}
```

</details>

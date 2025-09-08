# 🔢 Gissa talet

> Datorn tänker på ett tal – gissa vilket!

## 🎯 Träningsmål

Detta projekt är designat för att träna följande koncept:

*   `Random, while-loop, if/else.`

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
        // --- Del 1: Initialisering ---
        Random randomGenerator = new Random();
        // Datorn "tänker" på ett tal mellan 1 och 100.
        int secretNumber = randomGenerator.Next(1, 101); // Övre gränsen är exklusiv, så 101 ger 1-100.

        int userGuess = 0; // Användarens gissning, startar på 0.
        int guessCount = 0; // Räknare för antal försök (för bonusen).

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("--- 🎲 Gissa Talet ---");
        Console.WriteLine("Jag tänker på ett tal mellan 1 och 100. Kan du gissa vilket?");
        Console.ResetColor();
        Console.WriteLine();

        // --- Del 2: Spelloopen (while) ---
        // Loopen fortsätter så länge användarens gissning INTE är lika med det hemliga talet.
        while (userGuess != secretNumber)
        {
            Console.Write("Din gissning: ");
            userGuess = int.Parse(Console.ReadLine());

            // Ökar räknaren för varje gissning.
            guessCount++;

            // --- Del 3: Jämförelse (if-else if-else) ---
            if (userGuess < secretNumber)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("För lågt! Försök igen.");
                Console.ResetColor();
            }
            else if (userGuess > secretNumber)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("För högt! Försök igen.");
                Console.ResetColor();
            }
        }

        // --- Del 4: Avslutning ---
        // Denna kod nås bara när loopen har avslutats, dvs. när användaren gissat rätt.
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine();
        Console.WriteLine($"Rätt! Det hemliga talet var {secretNumber}.");
        Console.WriteLine($"Du klarade det på {guessCount} försök!"); // Bonusen!
        Console.ResetColor();

        Console.WriteLine("\nTryck på valfri tangent för att avsluta...");
        Console.ReadKey();
    }
}
```

</details>

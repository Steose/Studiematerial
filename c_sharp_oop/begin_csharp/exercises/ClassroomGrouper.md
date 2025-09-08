# 🎒 Övning: Klassrumsgruppering

## Mål

Detta är en bra sammanfattande övning där du får återanvända kunskaper om heltalsdivision och modulus-operatorn (`%`) för att lösa ett vanligt problem: att dela upp en helhet i grupper och hantera en eventuell rest.

## Beskrivning

En lärare vill dela in sina elever i mindre grupper. Du ska skapa ett program som hjälper läraren att räkna ut hur många fulla grupper det blir och hur många elever som eventuellt blir över.

## Krav

1.  Fråga användaren hur många elever det finns totalt i klassen.
2.  Fråga användaren hur många elever som ska vara i varje grupp.
3.  Använd heltalsdivision för att räkna ut hur många *fulla* grupper som kan skapas.
4.  Använd modulus-operatorn för att räkna ut hur många elever som blir över (inte får plats i en full grupp).
5.  Presentera resultatet tydligt för användaren.
6.  All output till användaren ska vara på svenska.
7.  All kod (variabler, metoder etc.) ska vara på engelska.
8.  Koden ska vara kommenterad på svenska.

### Flödesdiagram

```mermaid
graph TD
    A[Start] --> B[Fråga efter totalt antal elever];
    B --> C[Läs in svar];
    C --> D[Fråga efter gruppstorlek];
    D --> E[Läs in svar];
    E --> F{Beräkna antal grupper (heltalsdivision)};
    F --> G{Beräkna elever över (modulus)};
    G --> H[Visa resultat för användaren];
    H --> I[Slut];
```

## Bonusutmaning

Lägg till en `if`-sats som ger olika meddelanden beroende på resultatet:

*   Om det går jämnt upp (inga elever över), skriv ut ett glatt meddelande som "Perfekt! Det blir jämna grupper."
*   Om det blir elever över, skriv ut ett meddelande som "OBS! Det blir X elever över som behöver en egen grupp."

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
        // --- Del 1: Välkomstmeddelande ---
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("--- 🎒 Klassrumsgruppering ---");
        Console.WriteLine("Dela in elever i grupper.");
        Console.ResetColor();
        Console.WriteLine();

        // --- Del 2: Inmatning ---
        Console.Write("Ange totalt antal elever: ");
        int totalStudents = int.Parse(Console.ReadLine());

        Console.Write("Ange önskad gruppstorlek: ");
        int groupSize = int.Parse(Console.ReadLine());

        // --- Del 3: Beräkning ---
        // Heltalsdivision ger antalet fulla grupper.
        int numberOfGroups = totalStudents / groupSize;

        // Modulus ger resten, dvs. de som blir över.
        int leftoverStudents = totalStudents % groupSize;

        // --- Del 4: Presentation av resultat ---
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine();
        Console.WriteLine($"Resultat: Det blir {numberOfGroups} fulla grupper med {leftoverStudents} elever över.");
        Console.ResetColor();

        // --- Bonus: Anpassade meddelanden ---
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine();
        Console.WriteLine("--- Bonus: Anpassat meddelande ---");
        Console.ResetColor();

        if (leftoverStudents == 0)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Perfekt! Det blir jämna grupper utan att någon är över.");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"OBS! De {leftoverStudents} eleverna som är över behöver bilda en egen, mindre grupp.");
            Console.ResetColor();
        }

        // Pausar programmet.
        Console.WriteLine("\nTryck på valfri tangent för att avsluta...");
        Console.ReadKey();
    }
}
```

</details>

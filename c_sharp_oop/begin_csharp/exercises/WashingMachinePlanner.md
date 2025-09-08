# 🧺 Övning: Tvättmaskinsplaneraren

## Mål

I den här övningen får du lära dig att hantera division som resulterar i decimaltal och hur man använder `Math.Ceiling()` för att alltid avrunda ett tal *uppåt* till närmaste heltal. Detta är användbart när man inte kan ha "halva" enheter, som en halv tvättmaskin.

## Beskrivning

Du ska skapa ett program som hjälper någon att planera sin tvätt. Programmet ska räkna ut hur många tvättmaskiner som behövs för en viss mängd tvätt, givet att varje maskin har en maxkapacitet.

## Krav

1.  Programmet ska ha en fast kapacitet för en tvättmaskin (t.ex. 8 kg).
2.  Fråga användaren hur många kilo tvätt de har totalt.
3.  Beräkna hur många maskiner som behövs. Eftersom man inte kan köra en halv maskin, måste man alltid avrunda uppåt. Om resultatet är 2.3 maskiner, behövs alltså 3 maskiner.
4.  Använd `Math.Ceiling()` för att utföra avrundningen uppåt.
5.  Presentera resultatet för användaren.
6.  All output till användaren ska vara på svenska.
7.  All kod (variabler, metoder etc.) ska vara på engelska.
8.  Koden ska vara kommenterad på svenska.

### Flödesdiagram

```mermaid
graph TD
    A[Start] --> B[Definiera maskinkapacitet];
    B --> C[Fråga efter total vikt på tvätt];
    C --> D[Läs in svar];
    D --> E{Beräkna antal maskiner (division)};
    E --> F{Avrunda uppåt till närmaste heltal};
    F --> G[Visa resultat för användaren];
    G --> H[Slut];
```

## Bonusutmaning

Lägg till en tidsaspekt. Anta att varje tvättmaskin tar 90 minuter att köra. Beräkna och presentera den totala tiden det kommer att ta att tvätta allt om man bara har **en** maskin och måste köra dem efter varandra.

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
        // --- Del 1: Konfiguration och välkomstmeddelande ---
        const double machineCapacityKg = 8.0;

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("--- 🧧 Tvättmaskinsplaneraren ---");
        Console.WriteLine($"Hur många maskiner behövs? Varje maskin rymmer {machineCapacityKg} kg tvätt.");
        Console.ResetColor();
        Console.WriteLine();

        // --- Del 2: Inmatning ---
        Console.Write("Ange total vikt på tvätten (kg): ");
        double totalWeight = double.Parse(Console.ReadLine());

        // --- Del 3: Beräkning med Math.Ceiling ---

        // Först dividerar vi den totala vikten med kapaciteten per maskin.
        // Detta ger oss ett exakt antal, t.ex. 2.3.
        // Eftersom vi inte kan köra 0.3 maskiner, måste vi avrunda uppåt.
        // Math.Ceiling() gör precis det - den tar ett decimaltal och returnerar nästa högre heltal.
        // Exempel: Math.Ceiling(2.3) blir 3.0.
        double machinesNeeded = Math.Ceiling(totalWeight / machineCapacityKg);

        // --- Del 4: Presentation av resultat ---
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine();
        Console.WriteLine($"För {totalWeight} kg tvätt behöver du köra {machinesNeeded} maskiner.");
        Console.ResetColor();

        // --- Bonus: Beräkna total tid ---
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine();
        Console.WriteLine("--- Bonus: Total tvättid ---");
        Console.ResetColor();

        const int timePerMachineMinutes = 90;
        double totalTime = machinesNeeded * timePerMachineMinutes;

        Console.WriteLine($"Om varje maskin tar {timePerMachineMinutes} minuter, kommer allt att ta {totalTime} minuter att tvätta.");

        // Pausar programmet.
        Console.WriteLine("\nTryck på valfri tangent för att avsluta...");
        Console.ReadKey();
    }
}
```

</details>

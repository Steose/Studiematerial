# 🧮 Enkel Kalkylator

## Mål
Att hantera användarinmatning, konvertera datatyper (parsing) och använda villkorssatser (`if/else` eller `switch`) för att utföra grundläggande logik.

## Beskrivning
Detta är en kommandoradsbaserad kalkylator som kan utföra de fyra grundläggande räknesätten: addition, subtraktion, multiplikation och division. Användaren matar in två tal och en operator, och programmet returnerar resultatet.

## Krav
1.  Be användaren att mata in ett första tal.
2.  Be användaren att mata in en operator (+, -, *, /).
3.  Be användaren att mata in ett andra tal.
4.  Validera inmatningen för att säkerställa att det är giltiga tal.
5.  Använd en `switch`-sats (eller `if/else`) för att avgöra vilken operation som ska utföras.
6.  Hantera division med noll på ett säkert sätt.
7.  Skriv ut resultatet till konsolen.

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
        Console.WriteLine("--- Enkel Kalkylator ---");

        Console.Write("Ange det första talet: ");
        if (!double.TryParse(Console.ReadLine(), out double num1))
        {
            Console.WriteLine("Ogiltig inmatning. Ange ett tal.");
            return;
        }

        Console.Write("Ange en operator (+, -, *, /): ");
        string? operatorInput = Console.ReadLine();

        Console.Write("Ange det andra talet: ");
        if (!double.TryParse(Console.ReadLine(), out double num2))
        {
            Console.WriteLine("Ogiltig inmatning. Ange ett tal.");
            return;
        }

        double result = 0;

        switch (operatorInput)
        {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Fel: Kan inte dividera med noll.");
                    return;
                }
                break;
            default:
                Console.WriteLine("Ogiltig operator.");
                return;
        }

        Console.WriteLine($"Resultat: {num1} {operatorInput} {num2} = {result}");
    }
}
```

</details>

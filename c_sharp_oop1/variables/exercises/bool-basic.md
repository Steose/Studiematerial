## title: Övning Är du gammal nog parent: Övningar layout: default

# Övning: Är du gammal nog?

## 🎯 Vad du kommer lära dig

- Att läsa in data från en användare.
- Att konvertera en `string` till en `int`.
- Att skapa en `bool`-variabel baserat på ett villkor.
- Att använda en `if`-sats för att presentera olika meddelanden.

## 🧩 Uppgift

Skapa ett program som frågar användaren om deras ålder. Programmet ska sedan lagra i en `bool`-variabel om personen är 18 år eller äldre. Slutligen ska programmet skriva ut ett meddelande som talar om ifall användaren är gammal nog för att komma in på krogen.

## 🚀 Steg-för-steg-guide

1.  Skapa ett nytt konsolprojekt.
2.  Använd `Console.WriteLine` för att fråga efter användarens ålder.
3.  Använd `Console.ReadLine` för att läsa in svaret. Kom ihåg att detta ger dig en `string`.
4.  Konvertera strängen till en `int` med `int.Parse()`.
5.  Skapa en `bool` med namnet `isOldEnough` och ge den värdet från jämförelsen `age >= 18`.
6.  Skriv en `if/else`-sats som använder `isOldEnough` för att skriva ut antingen "Välkommen in\!" eller "Du är tyvärr för ung.".

## 💡 Tips

- `Console.ReadLine()` returnerar alltid en sträng. `int.Parse()` är din vän för att göra om den till ett tal som du kan räkna med.
- Testa med att ange olika åldrar för att se hur programmet beter sig.
- Testa med att skriva in ogiltiga värden (som bokstäver) för att se hur programmet hanterar det. Hur kan man hantera felaktig inmatning? (Detta är en bra övning för att tänka på användarvänlighet!)

<details>
<summary>💡 Klicka här för facit</summary>

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Hur gammal är du? ");
        string input = Console.ReadLine(); // Läs in användarens inmatning
        int age = int.Parse(input); // Konvertera strängen till ett heltal

        bool isOldEnough = age >= 18; // Skapa en bool som kollar om användaren är 18 eller äldre

        if (isOldEnough) // Om användaren är gammal nog
        {
            Console.WriteLine("Välkommen in på krogen!"); // Skriv ut välkomstmeddelande
        }
        else
        {   // GTFO!
            Console.WriteLine("Du är tyvärr för ung för att komma in."); // Skriv ut meddelande om att användaren är för ung
        }
    }
}
```

</details\>


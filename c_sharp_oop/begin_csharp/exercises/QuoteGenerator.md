# 💬 Citatgenerator

## Mål

Att använda grundläggande C#-syntax, inklusive arrayer och slumpmässig nummergenerering, för att skapa ett enkelt men engagerande konsolprogram.

## Beskrivning

Programmet visar ett slumpmässigt utvalt citat från en fördefinierad lista varje gång det körs. Detta är en utmärkt övning för att förstå variabler, arrayer och `Random`-klassen.

Tänk på att detta projekt kräver att du använder ett Random objekt och en array eller en lista för att lagra citaten.

Random objektet kan skapas så här:

```csharp
// Simulerar en tärning
Random random = new Random();
int dice = random.Next(1, 7); // Slumpar ett tal mellan 1 och 6
Console.WriteLine("Tärningen visar: " + dice);
```

och en array kan skapas så här:

```csharp
string[] starWards = new string[] { "Luke", "Leia", "Han", "Chewbacca", "Yoda", "Darth Vader" };
// Skriv ut det första namnet i arrayen
Console.WriteLine(starWards[0]); // Skriver ut "Luke"
```

En lista kan skapas så här:

```csharp
List<string> harryPotter = new List<string>() { "Harry", "Ron", "Hermione", "Dumbledore", "Voldemort", "Snape" };
// Skriv ut ett slumpmässigt namn från listan
Random random = new Random();
int selectedIndex = random.Next(harryPotter.Count); // Slumpar ett index mellan 0 och antalet element i listan
Console.WriteLine(harryPotter[selectedIndex]); // Skriver ut ett slumpmässigt
```

## Krav för projektet

1.  Skapa en lista (array eller `List<string>`) med minst 5 inspirerande eller roliga citat.
2.  Använd `Random`-klassen för att välja ett slumpmässigt index från listan.
3.  Skriv ut det valda citatet till konsolen.
4.  Programmet ska avslutas efter att citatet har visats.

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
        Console.WriteLine("Dagens citat:");
        Console.WriteLine("-------------");

        string[] quotes = new string[]
        {
            "The only way to do great work is to love what you do. - Steve Jobs",
            "Strive not to be a success, but rather to be of value. - Albert Einstein",
            "The mind is everything. What you think you become. - Buddha",
            "Your time is limited, don't waste it living someone else's life. - Steve Jobs",
            "The future belongs to those who believe in the beauty of their dreams. - Eleanor Roosevelt",
            "It does not matter how slowly you go as long as you do not stop. - Confucius",
            "Everything you can imagine is real. - Pablo Picasso"
        };

        Random rand = new Random();
        int index = rand.Next(quotes.Length);

        Console.WriteLine(quotes[index]);
        Console.WriteLine("-------------");
    }
}
```

</details>

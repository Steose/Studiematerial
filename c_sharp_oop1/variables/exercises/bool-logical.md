## title: Övning Kombinera logiska operatorer

# Övning: Klubbvakten

## 🎯 Vad du kommer lära dig

- Att använda den logiska operatorn `&&` (OCH).
- Att använda den logiska operatorn `||` (ELLER).
- Att kombinera flera villkor i en och samma `if`-sats.

## 🧩 Uppgift

Du ska bygga logiken för en klubbvakt. För att komma in på klubben måste en gäst uppfylla ett av följande två krav:

1.  Vara minst 20 år gammal **OCH** ha betalat inträde.
2.  Vara en VIP-gäst (då spelar ålder och inträde ingen roll).

Skapa ett program med tre `bool`-variabler: `isVip`, `hasPaidEntry` och en `int` för `age`. Testa olika värden och se till att programmet bara skriver ut "Välkommen in\!" om reglerna följs.

## 🚀 Steg-för-steg-guide

1.  Skapa ett nytt konsolprojekt.
2.  Skapa variablerna `age`, `hasPaidEntry`, och `isVip`. Ge dem några startvärden.
3.  Skriv en `if`-sats som kollar villkoren. Du kommer behöva använda både `&&` och `||`.
4.  Presentera resultatet med `Console.WriteLine`.
5.  Testa att ändra värdena i dina variabler och kör programmet igen för att se att logiken fungerar för alla scenarion\!

## 💡 Tips

- Tänk på parenteser\! Precis som i matte kan du använda parenteser `()` för att styra i vilken ordning villkoren ska utvärderas. `if (isVip || (age >= 20 && hasPaidEntry))` är ett väldigt tydligt sätt att skriva logiken.

<details>
<summary>💡 Klicka här för facit</summary>

```csharp
using System;

class Program
{
    static void Main()
    {
        // Ändra dessa värden för att testa olika scenarion!
        int age = 22; // Användarens ålder
        bool hasPaidEntry = true; // Har användaren betalat inträde?
        bool isVip = false; // Är användaren en VIP-gäst?

        Console.WriteLine($"Ålder: {age}, Betalat: {hasPaidEntry}, VIP: {isVip}");

        // Här är logiken.
        // Antingen är du VIP...
        // ...ELLER så måste du vara minst 20 OCH ha betalat.
        if (isVip || (age >= 20 && hasPaidEntry)) // Om du är VIP eller uppfyller ålder och betalningskrav
        {
            Console.WriteLine("Välkommen in!"); // Skriv ut välkomstmeddelande
        }
        else
        {  // GTFO!
            Console.WriteLine("Tyvärr, du får inte komma in."); // Skriv ut meddelande om att användaren inte får komma in
        }
    }
}
```

Detta kan självklart förenklas ytterligare med att vi kollar först om användaren är VIP, och sedan bara kollar ålder och betalning om de inte är det. Det för samma sak, men är enklare att läsa.

```csharp
if (isVip)
{
    Console.WriteLine("Välkommen in, VIP-gäst!");
}
else if (age >= 20 && hasPaidEntry)
{
    Console.WriteLine("Välkommen in!");
}
else
{   // GTFO!
    Console.WriteLine("Tyvärr, du får inte komma in.");
}
```

Vi kan även göra det riktigt kompakt genom att använda en enda `if`-sats med logiska operatorer:

```csharp
string message = (isVip || (age >= 20 && hasPaidEntry)) ? "Välkommen in!" : "Tyvärr, du får inte komma in.";
Console.WriteLine(message);
```

Men det är lite svårare att läsa, så det är bättre att använda den första eller andra varianten om du är nybörjare.

Vilket sätt du väljer att skriva det på är upp till dig. Det viktiga är att du förstår logiken bakom och kan anpassa den efter dina behov. Det betyder med andra ord att du ska kunna **förstå** koden, **ändra** i den vid behov och även **förklara** den för någon annan.

</details>

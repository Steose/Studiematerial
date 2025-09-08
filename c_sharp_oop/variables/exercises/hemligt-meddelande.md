# Hemligt meddelande

## Bakgrundshistoria
Din kompis har skickat dig ett meddelande som verkar helt vanligt, men hen sa att det finns ett hemligt meddelande gömt i texten. Du behöver plocka ut specifika tecken från vissa positioner för att avslöja det riktiga meddelandet!

## Din uppgift

```csharp
using System;

namespace HemligtMeddelande
{
    class Program
    {
        static void Main(string[] args)
        {
            // Det synliga meddelandet från din kompis
            string meddelande = "GOOD MORNING TO YOU, HELLO!";

            Console.WriteLine("Synligt meddelande: " + meddelande);
            Console.WriteLine("Avkodar hemligt meddelande...");

            // Plocka ut tecken från dessa positioner (börjar räkna från 0):
            // Position 0: första tecknet
            // Position 1: andra tecknet
            // Position 13: fjortonde tecknet
            // Position 16: sjuttonde tecknet
            // Position 20: tjugoförsta tecknet
            // Position 23: tjugofjärde tecknet
            // Position 24: tjugofemte tecknet
            // Position 25: tjugosjätte tecknet

            // Använd meddelande[position] för att hämta ett tecken
            // Exempel: meddelande[0] ger första tecknet

            // Skapa det hemliga meddelandet genom att sätta ihop tecknen
            // Glöm inte mellanslag mellan orden!

            Console.WriteLine("HEMLIGT MEDDELANDE: [skriv det hemliga meddelandet här]");
        }
    }
}
```

## Förväntad output
```
Synligt meddelande: GOOD MORNING TO YOU, HELLO!
Avkodar hemligt meddelande...
HEMLIGT MEDDELANDE: [Du får lista ut vad det blir! 😈]
```

<details>
<summary><strong>💡 Tips 1: String-indexering</strong></summary>

För att plocka ut ett tecken från en specifik position i en sträng, använd hakparanteser:

```csharp
char förstaTecken = meddelande[0];  // Första tecknet (position 0)
char andraTecken = meddelande[1];   // Andra tecknet (position 1)
```

Kom ihåg att datorer räknar från 0, inte 1!

</details>

<details>
<summary><strong>💡 Tips 2: Char-variabler</strong></summary>

Använd `char` datatyp för att lagra enskilda tecken:

```csharp
char g = meddelande[0];   // G
char o = meddelande[1];   // O
// Fortsätt med andra positioner...
```

</details>

<details>
<summary><strong>💡 Tips 3: Sätta ihop tecken</strong></summary>

För att skapa en ny sträng från tecken, använd `+` operatorn:

```csharp
string hemligtMeddelande = "" + tecken1 + tecken2 + " " + tecken3 + tecken4;
```

Använd `" "` för att lägga till mellanslag mellan ord.

</details>

<details>
<summary><strong>💡 </strong></summary>

```csharp
using System;

namespace HemligtMeddelande
{
    class Program
    {
        static void Main(string[] args)
        {
            // Det synliga meddelandet från din kompis
            string meddelande = "GOOD MORNING TO YOU, HELLO!";

            Console.WriteLine("Synligt meddelande: " + meddelande);
            Console.WriteLine("Avkodar hemligt meddelande...");

            // Plocka ut tecken från specifika positioner för "GO TO HELL"
            char g = meddelande[0];   // G
            char o1 = meddelande[1];  // O
            char t = meddelande[13];  // T
            char o2 = meddelande[16]; // O
            char h = meddelande[20];  // H
            char e = meddelande[23];  // E
            char l1 = meddelande[24]; // L
            char l2 = meddelande[25]; // L

            // Sätt ihop det hemliga meddelandet
            string hemligtMeddelande = "" + g + o1 + " " + t + o2 + " " + h + e + l1 + l2;

            Console.WriteLine("HEMLIGT MEDDELANDE: " + hemligtMeddelande);
        }
    }
}
```

</details>

## Tips
- Kom ihåg att C# räknar positioner från 0, så första tecknet är position 0
- Du kan använda `char` variabler för att lagra enskilda tecken
- För att sätta ihop tecken till en sträng, använd `"" + tecken1 + tecken2 + ...`
- Mellanslag skrivs som `" "` mellan citattecken

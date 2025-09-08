# Hello World - Ditt första C#-program

Det första programmet alla programmerare skriver är "Hello World". Det här exemplet visar den grundläggande strukturen för ett C#-program.

## Kod

```csharp
using System;

namespace MinaProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
```

## Förklaring

- `using System;` - Importerar grundläggande funktionalitet från .NET
- `namespace MinaProgram` - Skapar ett namnområde för vårt program
- `class Program` - Definierar en klass som innehåller vår kod
- `static void Main(string[] args)` - Huvudmetoden där programmet börjar köra
- `Console.WriteLine("Hello World!");` - Skriver ut texten "Hello World!" till konsolen

## Resultat

När du kör programmet kommer följande text att visas:

```
Hello World!
```

## Prova själv

> Tänk på att om din laptop har den fruktansvärda FN knappen, så kan du behöva trycka på `Fn` + `F5`
> för att köra programmet i Visual Studio. Eller se till att låsa FN så dina Ftangenter fungerar som de ska.

**I Visual Studio:**
1. Skapa ett nytt Console App-projekt
2. Ersätt koden i `Program.cs` med exemplet ovan
3. Tryck F5 eller klicka på "Start" för att köra

**I Rider:**
1. Skapa ett nytt Console Application-projekt
2. Ersätt koden i `Program.cs` med exemplet ovan
3. Tryck Ctrl+F5 eller klicka på "Run" för att köra

## Variationer att testa

### Grundläggande ändringar
Prova att ändra texten inom citattecknen:

```csharp
Console.WriteLine("Hej, mitt namn är [ditt namn]!");
Console.WriteLine("Välkommen till C#-programmering!");
Console.WriteLine("Idag är en bra dag för kodning!");
```

### Leka med Visual Studio funktioner

**1. Testa IntelliSense (kodhjälp):**
```csharp
Console.WriteLine("Hello World!");
Console.  // <-- Tryck mellanslag här och se vad som händer!
```

**2. Lägg till flera rader:**
```csharp
Console.WriteLine("Rad 1");
Console.WriteLine("Rad 2");
Console.WriteLine("Rad 3");
Console.WriteLine("Rad 4");
Console.WriteLine("Rad 5");
```

**3. Prova att lägga till fel (för att se felmeddelanden):**
```csharp
Console.WriteLine("Denna rad är OK");
Console.WriteLine("Glöm att stänga citattecknet här...
Console.WriteLine("Denna rad kommer att vara röd!");
```

**4. Experimentera med olika tecken:**
```csharp
Console.WriteLine("★ ☆ ♥ ♦ ♣ ♠");
Console.WriteLine("🎮 🚀 💻 📱 🎯");
Console.WriteLine("ASCII-konst:");
Console.WriteLine("  /\\_/\\  ");
Console.WriteLine(" ( o.o ) ");
Console.WriteLine("  > ^ <  ");
```

**5. Skapa en enkel "om mig"-sida:**
```csharp
Console.WriteLine("================================");
Console.WriteLine("       OM MIG");
Console.WriteLine("================================");
Console.WriteLine("Namn: [Ditt namn här]");
Console.WriteLine("Ålder: [Din ålder]");
Console.WriteLine("Favoritfärg: [Din favoritfärg]");
Console.WriteLine("Favoritmat: [Din favoritmat]");
Console.WriteLine("Drömjobb: [Ditt drömjobb]");
Console.WriteLine("================================");
```

## Tips för Visual Studio/Rider

- **Ctrl+Z** - Ångra senaste ändring
- **Ctrl+Y** - Gör om ändring
- **Ctrl+S** - Spara fil
- **F5** - Kör programmet
- **Ctrl+F5** - Kör utan debugger
- Klicka på den röda texten för att se felmeddelanden
- Håll muspekaren över röd understrykning för att se vad som är fel
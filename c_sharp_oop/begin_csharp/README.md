# 🌟 Begin C# - Dina första steg

Välkommen till C#! Här börjar din resa inom programmering med C#. Detta är grunden som allt annat bygger på.

## 🎯 Vad du kommer att lära dig

- Grundläggande C# syntax
- Hur man skapar och kör Console-applikationer  
- Grundläggande programstruktur
- Din första "Hello World"-app
- Enkla input/output operationer

## 📚 Innehåll

### 📖 Exempel och demos
- **[if-exempel.md](if-exempel.md)** - Grundläggande if-satser med C#
- **[loop-exempel.md](loop-exempel.md)** - Enkla loop-exempel för nybörjare
- **[print-exempel.md](print-exempel.md)** - Olika sätt att skriva ut data

### 💻 Livecode-material
- **[hello.md](livecode/hello.md)** - Ditt första C#-program
- **[pushit.md](livecode/pushit.md)** - Git workflow och kodhantering

### 🏋️ Praktiska övningar
Se **[exercises/](exercises/)** mappen för alla övningar:

#### Grundläggande övningar (perfecta att börja med!)
- **[QuoteGenerator.md](exercises/QuoteGenerator.md)** - Slumpmässiga citat med arrays
- **[SimpleCalculator.md](exercises/SimpleCalculator.md)** - Enkel räknare med operationer

#### Nybörjarövningar
- **[BMICalculator.md](exercises/BMICalculator.md)** - Beräkna BMI
- **[MeterToCentimeter.md](exercises/MeterToCentimeter.md)** - Enhetskonvertering
- **[MultiplicationTable.md](exercises/MultiplicationTable.md)** - Skapa multiplikationstabell

#### Praktiska program
- **[BeraknaMoms.md](exercises/BeraknaMoms.md)** - Momsberäkning
- **[BoolTester.md](exercises/BoolTester.md)** - Testa boolean-logik
- **[TimeConverter.md](exercises/TimeConverter.md)** - Tid-konvertering

#### Mer utmanande
- **[DiceSimulator.md](exercises/DiceSimulator.md)** - Tärningssimulerare
- **[GuessTheNumber.md](exercises/GuessTheNumber.md)** - Gissa-talet-spel
- **[WordFinder.md](exercises/WordFinder.md)** - Sök ord i text

Se **[utmaningar.md](exercises/utmaningar.md)** för extra utmaningar!

## 🚀 Så kommer du igång

### 1. Förberedelse
- Se till att du har Visual Studio eller Rider installerat
- Kolla att .NET SDK fungerar med `dotnet --version` i terminal

### 2. Ditt första program
```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        Console.WriteLine("Jag kan programmera C#!");
        
        Console.WriteLine("Tryck valfri tangent för att avsluta...");
        Console.ReadKey();
    }
}
```

### 3. Rekommenderad studieordning
1. **Börja med hello.md** - Förstå grundstrukturen
2. **Gör QuoteGenerator** - Din första "riktiga" app
3. **Prova SimpleCalculator** - Input och output
4. **Välj övningar som intresserar dig** - Motivation är nyckeln!

## 💡 Viktiga grundkoncept

### Program struktur
```csharp
using System;           // Importera namespaces

class Program          // Huvudklass
{
    static void Main(string[] args)  // Startpunkt
    {
        // Din kod här
    }
}
```

### Basic input/output
```csharp
// Skriva ut
Console.WriteLine("Text med radbrytning");
Console.Write("Text utan radbrytning");

// Läsa in
string input = Console.ReadLine();
```

### Variabler (grunden!)
```csharp
string name = "Anna";
int age = 25;
double price = 99.99;
bool isStudent = true;
```

## ⚠️ Vanliga nybörjarmisstag

- **Glöm inte semicolon (;)** - Varje statement måste sluta med ;
- **Case sensitivity** - `String` och `string` är olika saker
- **Parenteser och brackets** - Matcha alltid { med } och ( med )
- **Main metoden** - Måste ha exakt denna signatur: `static void Main(string[] args)`

## 🎯 När du är klar med detta område

Du kommer kunna:
- ✅ Skapa och köra enkla C#-program
- ✅ Använda variabler för att lagra data
- ✅ Ta input från användare och visa output
- ✅ Förstå grundläggande programstruktur
- ✅ Vara redo för nästa steg: [variables](../variables/)

## 💪 Extra tips för framgång

1. **Skriv kod själv** - Kopiera inte, skriv varje rad
2. **Experimentera** - Ändra värden och se vad som händer
3. **Läs felmeddelanden** - De berättar vad som är fel
4. **Testa ofta** - Kör programmet regelbundet
5. **Ha tålamod** - Alla har varit nybörjare!

---

**Lycka till med dina första C#-program! 🎉**

*Nästa steg: [variables](../variables/) för att lära dig mer om datatyper*
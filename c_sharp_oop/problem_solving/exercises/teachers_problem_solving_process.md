# En Lärares Tankegång: Från Problem till Kod

## Inledning

I denna guide följer vi en erfaren programmeringslärares tankegång när han planerar och implementerar ett projekt från scratch. Genom att förstå hur en erfaren utvecklare tänker kan du lära dig att strukturera din egen problemlösningsprocess.

**Projektexempel**: Ett program som räknar ut hur många dagar det är kvar till jul.

## Fas 1: Problemidentifiering och Målsättning

### Första Frågan: Vad Ska Programmet Göra?

> "Min första fråga är alltid: vad ska programmet göra? Vad är målet? Vad ska det göra och vad ska det INTE göra?"

**I vårt exempel:**
- **Mål**: Räkna ut hur många dagar det är kvar till jul
- **Vad det ska göra**: Visa antalet dagar från idag till nästa jul
- **Vad det inte ska göra**: Hantera andra helger, visa timmar/minuter, hantera olika tidszoner

### Varför Är Detta Viktigt?

Att tydligt definiera målsättningen hjälper till att:
- Undvika scope creep (att projektet växer okontrollerat)
- Fokusera på det essentiella
- Göra det lättare att veta när projektet är klart
- Kommunicera tydligt med andra utvecklare

## Fas 2: Kravanalys - Vad Behöver Vi?

### Grundläggande Krav

> "Jag behöver veta dagens datum och jag behöver veta när jul är."

**Datainhäntning:**
- Dagens datum (från systemet)
- Juldatum (25 december)
- Logik för att hantera när jul redan passerat detta år

**Beräkningar:**
- Skillnad mellan två datum
- Hantera årsskifte

**Output:**
- Visa resultatet på ett användarvänligt sätt

### Fördjupad Kravanalys

**Funktionella krav:**
1. Hämta aktuellt datum automatiskt
2. Bestämma nästa juldatum (25 december)
3. Beräkna dagsskillnad
4. Visa resultatet

**Icke-funktionella krav:**
1. Programmet ska vara snabbt (< 1 sekund)
2. Ska fungera oberoende av aktuellt datum
3. Ska hantera årsskifte korrekt
4. Ska vara lätt att förstå och underhålla

## Fas 3: Algoritmdesign

### Steg-för-steg Planering

> "Jag behöver en algoritm som kan räkna ut hur många dagar det är kvar till jul."

**Algoritm översikt:**
1. Ta reda på dagens datum
2. Bestäm juldatum för aktuellt år
3. Om jul redan passerat → lägg till ett år
4. Beräkna dagsskillnad
5. Visa resultatet

### Detaljerad Algoritm

```plaintext
ALGORITM: Räkna dagar till jul

INPUT: Inget (systemet ger dagens datum)
OUTPUT: Antal dagar till jul

STEG:
1. currentDate = dagens datum från systemet
2. christmasYear = currentDate.år
3. christmas = 25 december i christmasYear
4. OM christmas < currentDate DÅ
     christmas = 25 december i (christmasYear + 1)
5. daysDiff = christmas - currentDate
6. VISA "Det är {daysDiff} dagar kvar till jul!"
```

## Fas 4: Metoddekomposition

### Identifiera Metoder

> "Vi behöver olika metoder för olika delar av problemet."

**Metodplanering:**
1. `GetChristmasDate(int year)` - Bestäm juldatum
2. `GetDaysBetween(DateTime start, DateTime end)` - Beräkna dagsskillnad
3. `PrintDaysToChristmas(int days)` - Visa resultat
4. `Main()` - Orkestrera allt

### Metodsignaturer

```csharp
// Huvudmetod som koordinerar allt
public static void Main(string[] args)

// Få juldatum för ett givet år (eller nästa år om jul passerat)
private static DateTime GetChristmasDate(int year)

// Beräkna antal dagar mellan två datum
private static int GetDaysBetween(DateTime start, DateTime end)

// Visa resultatet på ett trevligt sätt
private static void PrintDaysToChristmas(int days)
```

### Varför Dela Upp i Metoder?

- **Enklare att testa**: Varje metod kan testas isolerat
- **Återanvändbar kod**: Metoderna kan användas i andra sammanhang
- **Lättare att förstå**: Varje metod har en klar uppgift
- **Enklare att debugga**: Problem kan isoleras till specifika metoder

## Fas 5: Implementation

### Fullständig Implementation

```csharp
using System;

public static class ChristmasCountdown
{
    public static void Main(string[] args)
    {
        // Steg 1: Få dagens datum
        DateTime today = DateTime.Now.Date; // .Date för att bara få datum, inte tid

        // Steg 2: Bestäm juldatum
        DateTime christmas = GetChristmasDate(today.Year);

        // Steg 3: Beräkna dagsskillnad
        int daysToChristmas = GetDaysBetween(today, christmas);

        // Steg 4: Visa resultat
        PrintDaysToChristmas(daysToChristmas);
    }

    /// <summary>
    /// Bestämmer juldatum för ett givet år. Om jul redan passerat
    /// detta år, returneras juldatum för nästa år.
    /// </summary>
    /// <param name="year">År att kontrollera</param>
    /// <returns>Nästa juldatum</returns>
    private static DateTime GetChristmasDate(int year)
    {
        // Skapa juldatum för detta år
        DateTime christmas = new DateTime(year, 12, 25);

        // Om jul redan passerat detta år
        if (christmas < DateTime.Today)
        {
            // Använd nästa års jul
            christmas = christmas.AddYears(1);
        }

        return christmas;
    }

    /// <summary>
    /// Beräknar antal hela dagar mellan två datum.
    /// </summary>
    /// <param name="start">Startdatum</param>
    /// <param name="end">Slutdatum</param>
    /// <returns>Antal dagar</returns>
    private static int GetDaysBetween(DateTime start, DateTime end)
    {
        TimeSpan difference = end - start;
        return difference.Days;
    }

    /// <summary>
    /// Visar antalet dagar till jul på ett användarvänligt sätt.
    /// </summary>
    /// <param name="days">Antal dagar</param>
    private static void PrintDaysToChristmas(int days)
    {
        if (days == 0)
        {
            Console.WriteLine("Det är jul idag! 🎄");
        }
        else if (days == 1)
        {
            Console.WriteLine("Det är 1 dag kvar till jul! 🎅");
        }
        else
        {
            Console.WriteLine($"Det är {days} dagar kvar till jul! ⭐");
        }

        // Extra feature: visa även veckor om det är många dagar
        if (days > 14)
        {
            int weeks = days / 7;
            int remainingDays = days % 7;
            Console.WriteLine($"Det är ungefär {weeks} veckor och {remainingDays} dagar.");
        }
    }
}
```

## Fas 6: Förbättringar och Utvidgningar

### Möjliga Förbättringar

**1. Bättre Felhantering**
```csharp
private static DateTime GetChristmasDate(int year)
{
    try
    {
        DateTime christmas = new DateTime(year, 12, 25);
        if (christmas < DateTime.Today)
        {
            christmas = christmas.AddYears(1);
        }
        return christmas;
    }
    catch (ArgumentOutOfRangeException ex)
    {
        throw new ArgumentException($"Ogiltigt år: {year}", ex);
    }
}
```

**2. Konfigurerbart Datum**
```csharp
private static DateTime GetTargetDate(int year, int month, int day)
{
    DateTime targetDate = new DateTime(year, month, day);
    if (targetDate < DateTime.Today)
    {
        targetDate = targetDate.AddYears(1);
    }
    return targetDate;
}

// Användning: GetTargetDate(DateTime.Now.Year, 12, 25) för jul
```

**3. Internationalisering**
```csharp
private static void PrintDaysToChristmas(int days, string holidayName = "jul")
{
    if (days == 0)
    {
        Console.WriteLine($"Det är {holidayName} idag! 🎄");
    }
    // ... etc
}
```

## Fas 7: Testning och Validering

### Testscenarier

**Edge Cases att testa:**
1. När det faktiskt är jul (25 december)
2. Dagen efter jul (26 december) - ska visa nästa års jul
3. Nyårsafton - ska fungera med årsskifte
4. Skottår - kontrollera att datumsberäkningar fungerar

**Manuell testning:**
```csharp
public static void TestChristmasCalculator()
{
    // Test 1: Simulera att det är jul
    Console.WriteLine("Test 1: Det är 25 december");
    // Kräver mer avancerad testning med mockade datum

    // Test 2: Kontrollera GetDaysBetween
    DateTime start = new DateTime(2024, 1, 1);
    DateTime end = new DateTime(2024, 1, 31);
    int days = GetDaysBetween(start, end);
    Console.WriteLine($"Dagar mellan 1 jan och 31 jan: {days}"); // Ska vara 30
}
```

## Reflektion och Lärdomar

### Vad Fungerade Bra

1. **Tydlig problemdefinition** från början
2. **Stegvis nedbrytning** av problemet
3. **Metoduppdelning** för separation of concerns
4. **Gradvis implementation** från enkelt till komplext

### Lärdomar för Framtiden

1. **Planering sparar tid**: "Mycket planering för lite kod... men man slipper huvudvärken av att skriva om koden flera gånger."
2. **Börja enkelt**: Implementera kärnfunktionaliteten först
3. **Tänk på edge cases**: Vad händer på juldagen? Efter jul?
4. **Dokumentera tankegången**: Kommentarer hjälper framtida dig

## Generaliserbara Principer

### 1. Always Start With "Why"

Förstå problemet innan du börjar koda:
- Vad är det verkliga problemet?
- Vem är användaren?
- Vad är success criteria?

### 2. Break Down Systematically

- Identifiera huvudkomponenter
- Dela upp i hanterbara delar
- Skapa en implementation roadmap

### 3. Think About Data Flow

- Vad kommer in i systemet?
- Hur bearbetas datan?
- Vad kommer ut ur systemet?

### 4. Plan Your Methods

- En metod = en uppgift
- Tänk på återanvändbarhet
- Dokumentera vad varje metod gör

## Övningar

### Övning 1: Tillämpa Samma Process

Använd Marcus's tankegång för att planera ett program som:
"Räknar ut hur många dagar du har levt"

Gå igenom varje fas:
1. Problemidentifiering
2. Kravanalys
3. Algoritmdesign
4. Metoddekomposition
5. Implementation

### Övning 2: Utvidga Christmas Calculator

Lägg till funktionalitet för:
- Räkna dagar till födelsedag
- Räkna dagar till valfritt datum
- Visa hur många jul du har upplevt
- Spara favorit-datum i en fil

### Övning 3: Reflektion

Skriv en kort analys (200-300 ord) om:
- Vilka steg i Marcus's process du tycker var mest värdefulla
- Hur detta skiljer sig från hur du vanligtvis planerar kod
- Vilka delar du kommer att börja använda i dina egna projekt

## Sammanfattning

Marcus's approach visar vikten av:

1. **Tydlig problemdefinition** - förstå vad som ska byggas
2. **Systematisk nedbrytning** - dela stora problem i små delar
3. **Metodtänk** - strukturera kod i logiska enheter
4. **Iterativ förbättring** - börja enkelt, lägg till komplexitet gradvis
5. **Reflektion** - lär från varje projekt

Som Marcus säger: "Mycket planering för lite kod... men man slipper huvudvärken av att skriva om koden flera gånger."

Denna invesering i planering sparar tid, minskar buggar och resulterar i bättre, mer underhållbar kod. 🎯


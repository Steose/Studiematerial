# Praktiska Exempel på Uppgiftsdekomposition

## Inledning

Att lära sig uppgiftsdekomposition genom teorin är en sak, men att se hur det tillämpas i praktiken är minst lika viktigt. I denna övning jämför vi två olika typer av projekt för att visa hur principerna för uppgiftsdekomposition kan tillämpas universellt.

## Jämförelse: Kladdkaka vs Programmeringsprojekt

En intressant way att förstå uppgiftsdekomposition är att jämföra välbekanta aktiviteter med programmering. Båda kräver planering, ordning och att följa steg i rätt sekvens.

### Exempel 1: Baka Kladdkaka

**Översiktlig uppgift**: Baka en läcker kladdkaka

**Planering och Förberedelse:**

**Steg 1: Samla ingredienser**
- 100g smör
- 2 dl socker
- 3 ägg
- 3 dl vetemjöl
- 2 dl kakao
- En nypa salt

**Steg 2: Förbereda utrustning**
- Ugn (sätt på 175°C)
- Kastrull (för att smälta smör)
- Bakform
- Vispar/träslev
- Måttbägare

**Steg 3: Utförande (i rätt ordning!)**
1. Sätt ugnen på 175 grader
2. Smält 100g smör i kastrull
3. Blanda smält smör med 2 dl socker i skål
4. Tillsätt 3 ägg i blandningen, vispa väl
5. I separat skål: blanda torra ingredienser (3 dl vetemjöl, 2 dl kakao, nypa salt)
6. Tillsätt torra ingredienser i våtblandningen gradvis
7. Häll blandningen i smord och mjölad form
8. Grädda i ugnen i 20 minuter
9. Testa med tandpetare (ska komma upp nästan ren)
10. Låt svalna innan servering

### Exempel 2: Skapa Måttenhetsomvandlare i C#

**Översiktlig uppgift**: Skapa en klass som kan omvandla mellan olika måttenheter

**Planering och Förberedelse:**

**Steg 1: Analysera krav**
- Vilka måttenheter ska stödjas? (längd, vikt, temperatur)
- Vilka specifika omvandlingar behövs?
- Hur ska felhantering implementeras?
- Ska det finnas ett användargränssnitt?

**Steg 2: Designa lösningen**
- Skapa klassdiagram
- Definiera metod-signaturer
- Planera datastrukturer

**Steg 3: Förbereda utvecklingsmiljö**
- Öppna Visual Studio eller VS Code
- Skapa nytt C#-projekt
- Strukturera projektmappar

**Steg 4: Implementering (i logisk ordning!)**

```plaintext
1. Skapa grundläggande projektstruktur
   - Skapa solution och projekt
   - Sätt upp grundläggande mappar

2. Implementera UnitConverter-klassen
   - Skapa klassfil
   - Definiera grundläggande struktur

3. Implementera längdomvandlingar
   - Meter till kilometer
   - Kilometer till mil
   - Feet till meter

4. Implementera viktomvandlingar
   - Kilogram till pund
   - Gram till ounces

5. Implementera temperaturomvandlingar
   - Celsius till Fahrenheit
   - Fahrenheit till Celsius
   - Celsius till Kelvin

6. Lägg till felhantering
   - Validera input-värden
   - Hantera null-värden
   - Kasta meningsfulla undantag

7. Skapa tester
   - Unit tests för varje metod
   - Edge case testing
   - Integration tests

8. Implementera användargränssnitt (console app)
   - Visa meny med alternativ
   - Läs användarinput
   - Visa resultat formaterat

9. Kodgranskning och refaktorering
   - Förbättra kodkvalitet
   - Lägg till kommentarer
   - Optimera prestanda

10. Dokumentation
    - Skapa README.md
    - XML-kommentarer för API
    - Användarmanual
```

## Detaljerad Implementation Plan

### Fas 1: Grundläggande Struktur (1-2 timmar)

**Uppgifter:**
```plaintext
□ Skapa nytt Console Application projekt
□ Skapa UnitConverter.cs klass-fil
□ Definiera grundläggande klassstruktur
□ Skapa enum för olika enhetstyper
□ Implementera grundläggande konstruktor
```

**Kod-skelett:**
```csharp
public class UnitConverter
{
    public enum UnitType
    {
        Length,
        Weight,
        Temperature
    }

    public enum LengthUnit
    {
        Meter,
        Kilometer,
        Mile,
        Feet,
        Inch
    }

    // Kommer att implementeras steg för steg...
}
```

### Fas 2: Längdomvandlingar (2-3 timmar)

**Uppgifter:**
```plaintext
□ Implementera meter till kilometer
□ Implementera kilometer till meter
□ Implementera meter till mil
□ Implementera mil till meter
□ Implementera feet till meter
□ Implementera meter till feet
□ Testa alla metoder
```

**Implementationsexempel:**
```csharp
public static double MetersToKilometers(double meters)
{
    if (meters < 0)
        throw new ArgumentException("Meters cannot be negative");

    return meters / 1000;
}

public static double KilometersToMeters(double kilometers)
{
    if (kilometers < 0)
        throw new ArgumentException("Kilometers cannot be negative");

    return kilometers * 1000;
}
```

### Fas 3: Viktomvandlingar (1-2 timmar)

**Uppgifter:**
```plaintext
□ Implementera kilogram till pund
□ Implementera pund till kilogram
□ Implementera gram till ounces
□ Implementera ounces till gram
□ Testa alla viktmetoder
```

### Fas 4: Temperaturomvandlingar (2-3 timmar)

**Uppgifter:**
```plaintext
□ Implementera Celsius till Fahrenheit
□ Implementera Fahrenheit till Celsius
□ Implementera Celsius till Kelvin
□ Implementera Kelvin till Celsius
□ Hantera absoluta nollpunktsbegränsningar
□ Testa alla temperaturmetoder
```

### Fas 5: Felhantering och Validering (1-2 timmar)

**Uppgifter:**
```plaintext
□ Lägg till input-validering för alla metoder
□ Implementera custom exceptions vid behov
□ Lägg till värdeområdesskontroller
□ Testa edge cases (negativa värden, extrema värden)
□ Dokumentera alla möjliga undantag
```

### Fas 6: Användargränssnitt (2-3 timmar)

**Uppgifter:**
```plaintext
□ Skapa huvudmeny som visar alternativ
□ Implementera input-läsning från användare
□ Lägg till sub-menyer för olika enhetstyper
□ Formatera output på ett användarvänligt sätt
□ Lägg till "prova igen"-funktionalitet
□ Implementera "avsluta"-alternativ
```

### Fas 7: Tester och Kvalitetssäkring (2-4 timmar)

**Uppgifter:**
```plaintext
□ Skapa unit test projekt
□ Skriv tester för alla konverteringsmetoder
□ Testa edge cases och felhantering
□ Genomför integration testing
□ Manuell testing av användargränssnitt
□ Performance testing för stora värden
```

### Fas 8: Dokumentation och Slutförande (1-2 timmar)

**Uppgifter:**
```plaintext
□ Skriv XML-kommentarer för alla publika metoder
□ Skapa README.md med användningsinstruktioner
□ Dokumentera kända begränsningar
□ Skapa exempel på användning
□ Slutgiltig kodgranskning
```

## Övningar för Praktisk Tillämpning

### Övning 1: Egen Projektplanering

Välj ett av följande projekt och skapa en detaljerad uppgiftsplan:

**Alternativ A: Bankkonto-simulator**
- Hantera olika kontotyper
- Insättningar och uttag
- Transaktionshistorik
- Ränteberäkningar

**Alternativ B: Enkel spelsamling**
- Sten, sax, påse
- Gissa numret
- Enkelt hangman-spel
- Menybaserat gränssnitt

**Alternativ C: Studenthanteringssystem**
- Registrera studenter
- Hantera kurser och betyg
- Beräkna medelbetyg
- Generera rapporter

### Övning 2: Tidsestimering

För det projekt du valde i Övning 1:
1. Uppskatta tid för varje fas
2. Identifiera beroenden mellan uppgifter
3. Skapa en tidslinje för projektet
4. Planera för buffert-tid (lägg till 20-30% extra)

### Övning 3: Risk Assessment

Identifiera potentiella risker för ditt projekt:
- Tekniska utmaningar
- Tidsbrist
- Kunskapsbegränsningar
- Externa beroenden

För varje risk, planera en mildring eller alternativ approach.

### Övning 4: Implementation och Reflektion

1. Implementera den första fasen av ditt projekt
2. Dokumentera vad som tog längre/kortare tid än beräknat
3. Justera dina planer för kommande faser
4. Reflektera över vilka dekompositionstekniker som fungerade bäst

## Jämförelse av Processer

### Likheter mellan Kladdkaka och Programmering

| Aspekt | Kladdkaka | Programmering |
|--------|-----------|---------------|
| **Planering** | Kolla ingredienser och recept | Analysera krav och design |
| **Förberedelse** | Värma ugn, mäta ingredienser | Sätta upp miljö, struktura projekt |
| **Ordningsföljd** | Våta först, sedan torra ingredienser | Grundläggande klasser först, sedan avancerade features |
| **Testning** | Tandpetare-test | Unit tests och debugging |
| **Kvalitetskontroll** | Smaka, kontrollera konsistens | Code review, integration testing |
| **Iteration** | Justera recept för nästa gång | Refaktorering och förbättring |

### Viktiga Lärdomar

1. **Ordning Spelar Roll**: Både i bakning och programmering är sekvensen av steg kritisk
2. **Förberedelse är Nyckeln**: Att ha alla "ingredienser" redo först sparar tid
3. **Små Steg är Säkrare**: Gradvis progression minskar risk för stora misstag
4. **Testning Löpande**: Kontrollera resultat kontinuerligt, inte bara i slutet
5. **Dokumentation Hjälper**: Recept och kod-kommentarer gör upprepning möjlig

## Sammanfattning

Genom att jämföra programmering med välbekanta aktiviteter som bakning, ser vi att principerna för uppgiftsdekomposition är universella:

- **Bryt ner i hanterbara steg**
- **Planera resurser och förutsättningar**
- **Följ en logisk ordningsföljd**
- **Testa och validera löpande**
- **Dokumentera för framtida användning**

Den stora skillnaden är att programmering ofta kräver mer iteration och felhantering än bakning, men grundprinciperna är desamma.

Genom att använda dessa tekniker kommer dina programmeringsprojekt att bli mer strukturerade, förutsägbara och framgångsrika - precis som när du följer ett bra bakrecept! 🍰💻


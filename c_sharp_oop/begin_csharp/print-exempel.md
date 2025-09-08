---
layout: default
title: Enkla utskrifter
parent: Börja med C#
nav_order: 2
---

# Enkla utskrifter med Console

Att skriva ut information till konsolen är en grundläggande färdighet. Här lär du dig olika sätt att visa text och värden.

## Grundläggande utskrifter

### Console.WriteLine()

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Detta är en rad text");
        Console.WriteLine("Detta är nästa rad");
        Console.WriteLine(); // Tom rad
        Console.WriteLine("Efter en tom rad");
    }
}
```

**Resultat:**
```
Detta är en rad text
Detta är nästa rad

Efter en tom rad
```

### Console.Write()

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Detta skrivs ");
        Console.Write("på samma rad");
        Console.WriteLine(); // Ny rad
        Console.WriteLine("Detta på nästa rad");
    }
}
```

**Resultat:**
```
Detta skrivs på samma rad
Detta på nästa rad
```

## Variabler och värden

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        string namn = "Anna";
        int ålder = 25;
        double längd = 1.75;
        
        Console.WriteLine("Namn: " + namn);
        Console.WriteLine("Ålder: " + ålder);
        Console.WriteLine("Längd: " + längd + " meter");
    }
}
```

**Resultat:**
```
Namn: Anna
Ålder: 25
Längd: 1,75 meter
```

## String interpolation (modern metod)

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        string stad = "Stockholm";
        int temperatur = 15;
        
        Console.WriteLine($"I {stad} är det {temperatur} grader");
        Console.WriteLine($"Beräkning: 10 + 5 = {10 + 5}");
    }
}
```

**Resultat:**
```
I Stockholm är det 15 grader
Beräkning: 10 + 5 = 15
```

## Formatering av tal

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        double pris = 123.456789;
        
        Console.WriteLine($"Pris: {pris}"); // Alla decimaler
        Console.WriteLine($"Pris: {pris:F2}"); // Två decimaler
        Console.WriteLine($"Pris: {pris:C}"); // Valuta-format
    }
}
```

**Resultat:**
```
Pris: 123,456789
Pris: 123,46
Pris: 123,46 kr
```

## Prova själv

Experimentera med dessa variationer:

```csharp
// Olika datatyper
int heltal = 42;
bool sant = true;
char bokstav = 'A';

Console.WriteLine($"Heltal: {heltal}");
Console.WriteLine($"Boolean: {sant}");
Console.WriteLine($"Tecken: {bokstav}");

// Flera variabler
string förnamn = "Erik";
string efternamn = "Andersson";
Console.WriteLine($"Fullständigt namn: {förnamn} {efternamn}");
```
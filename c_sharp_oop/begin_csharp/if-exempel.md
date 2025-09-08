---
layout: default
title: Enkla if-satser
parent: Börja med C#
nav_order: 4
---

# Enkla if-satser för beslut

If-satser används för att göra beslut i koden baserat på olika villkor. Här lär du dig grunderna.

## Grundläggande if-sats

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        int ålder = 18;

        if (ålder >= 18)
        {
            Console.WriteLine("Du är myndig!");
        }

        Console.WriteLine("Programmet fortsätter...");
    }
}
```

**Resultat:**
```
Du är myndig!
Programmet fortsätter...
```

## If-else

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        int temperatur = 15;

        if (temperatur > 20)
        {
            Console.WriteLine("Det är varmt ute!");
        }
        else
        {
            Console.WriteLine("Det är kallt ute!");
        }
    }
}
```

**Resultat:**
```
Det är kallt ute!
```

## If-else if-else

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        int poäng = 85;

        if (poäng >= 90)
        {
            Console.WriteLine("Betyg: A - Utmärkt!");
        }
        else if (poäng >= 80)
        {
            Console.WriteLine("Betyg: B - Mycket bra!");
        }
        else if (poäng >= 70)
        {
            Console.WriteLine("Betyg: C - Bra!");
        }
        else if (poäng >= 60)
        {
            Console.WriteLine("Betyg: D - Godkänt!");
        }
        else
        {
            Console.WriteLine("Betyg: F - Underkänt");
        }
    }
}
```

**Resultat:**
```
Betyg: B - Mycket bra!
```

## Jämförelseoperatorer

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 10;
        int b = 5;

        Console.WriteLine($"a = {a}, b = {b}");

        if (a == b) Console.WriteLine("a är lika med b");
        if (a != b) Console.WriteLine("a är inte lika med b");
        if (a > b) Console.WriteLine("a är större än b");
        if (a < b) Console.WriteLine("a är mindre än b");
        if (a >= b) Console.WriteLine("a är större än eller lika med b");
        if (a <= b) Console.WriteLine("a är mindre än eller lika med b");
    }
}
```

**Resultat:**
```
a = 10, b = 5
a är inte lika med b
a är större än b
a är större än eller lika med b
```

## Logiska operatorer

### AND-operator (&&)

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        int ålder = 25;
        bool harKörkort = true;

        if (ålder >= 18 && harKörkort) // underförstått: ålder >= 18  OCH harKörkort == true
        {
            Console.WriteLine("Du får köra bil!");
        }
        else
        {
            Console.WriteLine("Du får inte köra bil!");
        }
    }
}
```

Du kanske la märke till att vi skrev `harKörkort` istället för `harKörkort == true`. Detta fungerar eftersom `harKörkort` redan är en `bool` och kan användas direkt i villkoret. Jämför vi mot bool-värden så är det vanligt att utelämna `== true` eller `== false` för att göra koden mer läsbar.

OM harKörkort vore `false` så skulle vi kunna skriva:

```csharp
if (ålder >= 18 && !harKörkort) // underförstått: ålder >= 18  OCH harKörkort == false
{
    Console.WriteLine("Du får inte köra bil!");
}
```

Utropstecknet `!` framför `harKörkort` betyder "inte", alltså "om harKörkort är inte sant" (dvs. är falskt).

I modernare C# kan vi också använda "mönstermatchning" för att göra samma sak:

```csharp
    if (ålder >= 18 && harKörkort) { ... }
```
kan ersättas med
```csharp
    if (ålder is >= 18 && harKörkort) { ... }
```
vilket kan vara mer läsbart i vissa sammanhang och faktum är att då inser vi hur bra det är med engelska namn på variabler och metoder i koden.

### OR-operator (||)

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        string dag = "lördag";

        if (dag == "lördag" || dag == "söndag")
        {
            Console.WriteLine("Det är helg!");
        }
        else
        {
            Console.WriteLine("Det är vardag!");
        }
    }
}
```

Även här kan vi använda mönstermatchning:

```csharp
    if (dag is "lördag" or "söndag") { ... }
```



### NOT-operator (!)

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        bool ärRegn = false;

        if (!ärRegn)
        {
            Console.WriteLine("Det regnar inte - bra väder för promenad!");
        }
        else
        {
            Console.WriteLine("Det regnar - ta med paraply!");
        }
    }
}
```

och här kan mönstermatchning användas:

```csharp
    if (ärRegn is false) { ... }
```

## Praktiska exempel

### Enkel kalkylator

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        int tal1 = 10;
        int tal2 = 3;
        char operation = '/';

        if (operation == '+') // mönstermatchning: operation is '+'
        {
            Console.WriteLine($"{tal1} + {tal2} = {tal1 + tal2}");
        }
        else if (operation == '-') // mönstermatchning: operation is '-'
        {
            Console.WriteLine($"{tal1} - {tal2} = {tal1 - tal2}");
        }
        else if (operation == '*') // mönstermatchning: operation is '*'
        {
            Console.WriteLine($"{tal1} × {tal2} = {tal1 * tal2}");
        }
        else if (operation == '/') // mönstermatchning: operation is '/'
        {
            if (tal2 != 0) // mönstermatchning: tal2 is not 0
            {
                Console.WriteLine($"{tal1} ÷ {tal2} = {(double)tal1 / tal2}"); // Beräkningen görs inne i WriteLine
            }
            else
            {
                Console.WriteLine("Fel: Division med noll!");
            }
        }
        else
        {
            Console.WriteLine("Okänd operation!");
        }
        {
            Console.WriteLine($"{tal1} - {tal2} = {tal1 - tal2}");
        }
        else if (operation == '*')
        {
            Console.WriteLine($"{tal1} × {tal2} = {tal1 * tal2}");
        }
        else if (operation == '/')
        {
            if (tal2 != 0)
            {
                Console.WriteLine($"{tal1} ÷ {tal2} = {(double)tal1 / tal2}");
            }
            else
            {
                Console.WriteLine("Fel: Division med noll!");
            }
        }
        else
        {
            Console.WriteLine("Okänd operation!");
        }
    }
}
```

## Prova själv

Testa dessa exempel:

```csharp
// Kontrollera om ett tal är jämnt eller udda
int nummer = 7;
if (nummer % 2 == 0)
{
    Console.WriteLine($"{nummer} är jämnt");
}
else
{
    Console.WriteLine($"{nummer} är udda");
}

// Kontrollera årstider
int månad = 12;
if (månad == 12 || månad == 1 || månad == 2) // mönstermatchning: månad is 12 or 1 or 2
{
    Console.WriteLine("Det är vinter");
}
else if (månad >= 3 && månad <= 5) // mönstermatchning: månad is >= 3 and <= 5
{
    Console.WriteLine("Det är vår");
}
else if (månad >= 6 && månad <= 8) // mönstermatchning: månad is >= 6 and <= 8
{
    Console.WriteLine("Det är sommar");
}
else
{
    Console.WriteLine("Det är höst");
}
```

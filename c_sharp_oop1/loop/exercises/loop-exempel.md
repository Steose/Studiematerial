# Enkla loopar för repetition

Loopar används för att upprepa kod. Här är de grundläggande looptyperna du behöver känna till.

## For-loop

En for-loop används när du vet exakt hur många gånger du vill upprepa något.

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Räknar från 1 till 5:");
        
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Nummer: {i}");
        }
        
        Console.WriteLine("Klar!");
    }
}
```

**Resultat:**
```
Räknar från 1 till 5:
Nummer: 1
Nummer: 2
Nummer: 3
Nummer: 4
Nummer: 5
Klar!
```

## While-loop

En while-loop fortsätter så länge ett villkor är sant.

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Räknar nedåt:");
        
        int nummer = 5;
        while (nummer > 0)
        {
            Console.WriteLine($"Nummer: {nummer}");
            nummer--; // Minska med 1
        }
        
        Console.WriteLine("Start!");
    }
}
```

**Resultat:**
```
Räknar nedåt:
Nummer: 5
Nummer: 4
Nummer: 3
Nummer: 2
Nummer: 1
Start!
```

## Foreach-loop

En foreach-loop används för att gå igenom alla element i en samling.

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        string[] frukt = {"äpple", "banan", "apelsin", "päron"};
        
        Console.WriteLine("Fruktlista:");
        
        foreach (string item in frukt)
        {
            Console.WriteLine($"- {item}");
        }
    }
}
```

**Resultat:**
```
Fruktlista:
- äpple
- banan
- apelsin
- päron
```

## Praktiska exempel

### Multiplikationstabell

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        int tal = 7;
        Console.WriteLine($"Multiplikationstabell för {tal}:");
        
        for (int i = 1; i <= 10; i++)
        {
            int resultat = tal * i;
            Console.WriteLine($"{tal} × {i} = {resultat}");
        }
    }
}
```

### Summera tal

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        int summa = 0;
        
        Console.WriteLine("Summerar tal från 1 till 10:");
        
        for (int i = 1; i <= 10; i++)
        {
            summa += i; // samma som: summa = summa + i
            Console.WriteLine($"Adderar {i}, summa är nu: {summa}");
        }
        
        Console.WriteLine($"Total summa: {summa}");
    }
}
```

## Prova själv

Testa dessa variationer:

```csharp
// Hoppa över jämna tal
for (int i = 1; i <= 10; i += 2)
{
    Console.WriteLine(i); // 1, 3, 5, 7, 9
}

// Gå baklänges
for (int i = 10; i >= 1; i--)
{
    Console.WriteLine(i); // 10, 9, 8... 1
}

// Loop med strängar
string[] dagar = {"måndag", "tisdag", "onsdag"};
foreach (string dag in dagar)
{
    Console.WriteLine($"Idag är det {dag}");
}
```
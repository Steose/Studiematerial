# 🧮 Kalkylator med metoder

## Beskrivning av övningen

Skapa en enkel kalkylator som använder olika metoder för att utföra grundläggande matematiska operationer. Detta är en perfekt övning för att lära sig hur man strukturerar kod med metoder och returnerar värden.

## Uppgift

Skapa fyra metoder som utför följande operationer:
1. Addition av två tal
2. Subtraktion av två tal  
3. Multiplikation av två tal
4. Division av två tal (tänk på division med noll!)

## Kodmall

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        // Testa dina metoder här
        double a = 10;
        double b = 5;
        
        Console.WriteLine($"Addition: {a} + {b} = {Add(a, b)}");
        Console.WriteLine($"Subtraktion: {a} - {b} = {Subtract(a, b)}");
        Console.WriteLine($"Multiplikation: {a} * {b} = {Multiply(a, b)}");
        Console.WriteLine($"Division: {a} / {b} = {Divide(a, b)}");
        
        // Testa division med noll
        Console.WriteLine($"Division med noll: {a} / 0 = {Divide(a, 0)}");
    }
    
    public static double Add(double x, double y)
    {
        // Implementera addition här
    }
    
    public static double Subtract(double x, double y)
    {
        // Implementera subtraktion här
    }
    
    public static double Multiply(double x, double y)
    {
        // Implementera multiplikation här
    }
    
    public static double Divide(double x, double y)
    {
        // Implementera division här (tänk på division med noll!)
    }
}
```

#### Förväntad output

```
Addition: 10 + 5 = 15
Subtraktion: 10 - 5 = 5
Multiplikation: 10 * 5 = 50
Division: 10 / 5 = 2
Division med noll: 10 / 0 = Kan inte dividera med noll!
```

#### Facit

<details><summary>Klicka här för att se facit</summary>

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        double a = 10;
        double b = 5;
        
        Console.WriteLine($"Addition: {a} + {b} = {Add(a, b)}");
        Console.WriteLine($"Subtraktion: {a} - {b} = {Subtract(a, b)}");
        Console.WriteLine($"Multiplikation: {a} * {b} = {Multiply(a, b)}");
        Console.WriteLine($"Division: {a} / {b} = {Divide(a, b)}");
        
        Console.WriteLine($"Division med noll: {a} / 0 = {Divide(a, 0)}");
    }
    
    public static double Add(double x, double y)
    {
        return x + y;
    }
    
    public static double Subtract(double x, double y)
    {
        return x - y;
    }
    
    public static double Multiply(double x, double y)
    {
        return x * y;
    }
    
    public static double Divide(double x, double y)
    {
        if (y == 0)
        {
            Console.WriteLine("Kan inte dividera med noll!");
            return 0; // eller throw new DivideByZeroException();
        }
        return x / y;
    }
}
```

</details>
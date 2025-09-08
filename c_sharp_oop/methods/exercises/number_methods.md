# 🔢 Talhantering med metoder

## Beskrivning av övningen

Skapa olika metoder som utför operationer på tal. Detta hjälper dig att förstå hur man strukturerar kod och arbetar med matematiska funktioner.

## Uppgift

Skapa metoder som utför följande operationer:
1. Kontrollera om ett tal är jämnt eller udda
2. Hitta det största av tre tal
3. Beräkna fakultet av ett tal (5! = 5×4×3×2×1 = 120)
4. Kontrollera om ett tal är ett primtal

## Kodmall

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        int number1 = 15;
        int number2 = 12;
        int number3 = 8;
        int factorial = 5;
        int prime = 17;
        
        Console.WriteLine($"Är {number1} jämnt? {IsEven(number1)}");
        Console.WriteLine($"Största talet av {number1}, {number2}, {number3}: {GetLargest(number1, number2, number3)}");
        Console.WriteLine($"Fakultet av {factorial}: {CalculateFactorial(factorial)}");
        Console.WriteLine($"Är {prime} ett primtal? {IsPrime(prime)}");
    }
    
    public static bool IsEven(int number)
    {
        // Implementera kontroll för jämnt tal här
    }
    
    public static int GetLargest(int a, int b, int c)
    {
        // Implementera funktion för att hitta största talet här
    }
    
    public static long CalculateFactorial(int number)
    {
        // Implementera fakultetsberäkning här
    }
    
    public static bool IsPrime(int number)
    {
        // Implementera primtalskontroll här
    }
}
```

#### Förväntad output

```
Är 15 jämnt? False
Största talet av 15, 12, 8: 15
Fakultet av 5: 120
Är 17 ett primtal? True
```

#### Facit

<details><summary>Klicka här för att se facit</summary>

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        int number1 = 15;
        int number2 = 12;
        int number3 = 8;
        int factorial = 5;
        int prime = 17;
        
        Console.WriteLine($"Är {number1} jämnt? {IsEven(number1)}");
        Console.WriteLine($"Största talet av {number1}, {number2}, {number3}: {GetLargest(number1, number2, number3)}");
        Console.WriteLine($"Fakultet av {factorial}: {CalculateFactorial(factorial)}");
        Console.WriteLine($"Är {prime} ett primtal? {IsPrime(prime)}");
    }
    
    public static bool IsEven(int number)
    {
        return number % 2 == 0;
    }
    
    public static int GetLargest(int a, int b, int c)
    {
        if (a >= b && a >= c)
            return a;
        else if (b >= a && b >= c)
            return b;
        else
            return c;
        
        // Alternativ lösning:
        // return Math.Max(Math.Max(a, b), c);
    }
    
    public static long CalculateFactorial(int number)
    {
        if (number < 0)
            throw new ArgumentException("Fakultet kan inte beräknas för negativa tal");
        
        if (number == 0 || number == 1)
            return 1;
        
        long result = 1;
        for (int i = 2; i <= number; i++)
        {
            result *= i;
        }
        return result;
    }
    
    public static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;
        
        if (number == 2)
            return true;
        
        if (number % 2 == 0)
            return false;
        
        for (int i = 3; i * i <= number; i += 2)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }
}
```

</details>
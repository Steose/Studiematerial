# 🌡️ Temperaturkonverterare

## Beskrivning av övningen

Skapa en temperaturkonverterare som kan konvertera mellan Celsius, Fahrenheit och Kelvin. Detta är en praktisk övning för att förstå metodparametrar och returvärden.

## Uppgift

Skapa metoder som konverterar temperaturer mellan olika skalor:
1. Celsius till Fahrenheit
2. Fahrenheit till Celsius
3. Celsius till Kelvin
4. Kelvin till Celsius
5. Fahrenheit till Kelvin
6. Kelvin till Fahrenheit

**Formler:**
- Celsius till Fahrenheit: F = C × 9/5 + 32
- Fahrenheit till Celsius: C = (F - 32) × 5/9
- Celsius till Kelvin: K = C + 273.15
- Kelvin till Celsius: C = K - 273.15

## Kodmall

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        double celsius = 25;
        double fahrenheit = 77;
        double kelvin = 298.15;
        
        Console.WriteLine($"{celsius}°C = {CelsiusToFahrenheit(celsius)}°F");
        Console.WriteLine($"{fahrenheit}°F = {FahrenheitToCelsius(fahrenheit):F2}°C");
        Console.WriteLine($"{celsius}°C = {CelsiusToKelvin(celsius)}K");
        Console.WriteLine($"{kelvin}K = {KelvinToCelsius(kelvin)}°C");
        Console.WriteLine($"{fahrenheit}°F = {FahrenheitToKelvin(fahrenheit):F2}K");
        Console.WriteLine($"{kelvin}K = {KelvinToFahrenheit(kelvin):F2}°F");
    }
    
    public static double CelsiusToFahrenheit(double celsius)
    {
        // Implementera C till F konvertering
    }
    
    public static double FahrenheitToCelsius(double fahrenheit)
    {
        // Implementera F till C konvertering
    }
    
    public static double CelsiusToKelvin(double celsius)
    {
        // Implementera C till K konvertering
    }
    
    public static double KelvinToCelsius(double kelvin)
    {
        // Implementera K till C konvertering
    }
    
    public static double FahrenheitToKelvin(double fahrenheit)
    {
        // Implementera F till K konvertering
    }
    
    public static double KelvinToFahrenheit(double kelvin)
    {
        // Implementera K till F konvertering
    }
}
```

#### Förväntad output

```
25°C = 77°F
77°F = 25.00°C
25°C = 298.15K
298.15K = 25°C
77°F = 298.15K
298.15K = 77.00°F
```

#### Facit

<details><summary>Klicka här för att se facit</summary>

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        double celsius = 25;
        double fahrenheit = 77;
        double kelvin = 298.15;
        
        Console.WriteLine($"{celsius}°C = {CelsiusToFahrenheit(celsius)}°F");
        Console.WriteLine($"{fahrenheit}°F = {FahrenheitToCelsius(fahrenheit):F2}°C");
        Console.WriteLine($"{celsius}°C = {CelsiusToKelvin(celsius)}K");
        Console.WriteLine($"{kelvin}K = {KelvinToCelsius(kelvin)}°C");
        Console.WriteLine($"{fahrenheit}°F = {FahrenheitToKelvin(fahrenheit):F2}K");
        Console.WriteLine($"{kelvin}K = {KelvinToFahrenheit(kelvin):F2}°F");
    }
    
    public static double CelsiusToFahrenheit(double celsius)
    {
        return celsius * 9.0 / 5.0 + 32;
    }
    
    public static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5.0 / 9.0;
    }
    
    public static double CelsiusToKelvin(double celsius)
    {
        return celsius + 273.15;
    }
    
    public static double KelvinToCelsius(double kelvin)
    {
        return kelvin - 273.15;
    }
    
    public static double FahrenheitToKelvin(double fahrenheit)
    {
        double celsius = FahrenheitToCelsius(fahrenheit);
        return CelsiusToKelvin(celsius);
    }
    
    public static double KelvinToFahrenheit(double kelvin)
    {
        double celsius = KelvinToCelsius(kelvin);
        return CelsiusToFahrenheit(celsius);
    }
}
```

</details>
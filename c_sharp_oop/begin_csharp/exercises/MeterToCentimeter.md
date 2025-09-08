# 📏 Meter till Centimeter

## Mål

Att förstå grundläggande in- och utmatning, variabeldeklaration och grundläggande typkonvertering.

## Beskrivning

Programmet ska be användaren att mata in ett antal meter, omvandla det till centimeter och sedan skriva ut resultatet. Detta är en grundläggande övning i att hantera användarinmatning och utföra enkla beräkningar.

## Krav

1.  Be användaren om ett tal (meter).
2.  Läs in användarens svar.
3.  Omvandla inmatningen från meter till centimeter (1 meter = 100 cm).
4.  Skriv ut resultatet i ett tydligt meddelande, t.ex. """1.5 meter är 150 centimeter."""

## 🚀 Så kör du projektet från Visual Studio eller Rider

Tryck på den gröna play-knappen i Visual Studio eller Rider för att köra projektet.

## 🚀 Så kör du projektet

Skapa ett nytt console-projekt och följ kraven ovan.

<details>
<summary><strong>💡 </strong></summary>

```csharp
// Program: MeterToCentimeter
// Description: A simple C# console application to convert meters to centimeters.

Console.WriteLine("--- Meter to Centimeter Converter ---");
Console.Write("Enter a value in meters: ");

// Read user input
string? input = Console.ReadLine();

// Try to convert the input string to a double
if (double.TryParse(input, out double meters))
{
    // Conversion logic: 1 meter = 100 centimeters
    double centimeters = meters * 100;

    // Display the result
    Console.WriteLine($"{meters} meter(s) is equal to {centimeters} centimeter(s).");
}
else
{
    // Handle invalid input
    Console.WriteLine("Invalid input. Please enter a valid number.");
}

Console.WriteLine("\nPress any key to exit.");
Console.ReadKey();
```

</details>

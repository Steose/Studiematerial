# 💰 Räkna ut momsen

## Mål

Att arbeta med decimaltal, utföra matematiska beräkningar och formatera utskrifter.

## Beskrivning

Du ska skapa ett program som räknar ut momsen (mervärdesskatt) för ett givet belopp. Programmet ska fråga efter ett pris utan moms och sedan beräkna och visa momsbeloppet och totalpriset inklusive moms.

## Krav

1.  Fråga användaren efter ett pris exklusive moms.
2.  Använd en fast momssats på 25%.
3.  Beräkna momsbeloppet (pris * 0.25).
4.  Beräkna totalpriset (pris * 1.25).
5.  Skriv ut både momsbeloppet och det totala priset, snyggt formaterat.

## 🚀 Så kör du projektet från Visual Studio eller Rider

Tryck på den gröna play-knappen i Visual Studio eller Rider för att köra projektet.

## 🚀 Så kör du projektet

Skapa ett nytt console-projekt och följ kraven ovan.

<details>
<summary><strong>💡 </strong></summary>

```csharp
// Program: BeraknaMoms
// Description: A C# console application to calculate VAT (Moms).

Console.WriteLine("--- VAT Calculator (Moms) ---");
Console.Write("Enter the price without VAT: ");

// Read user input
string? input = Console.ReadLine();

// Define the VAT rate (e.g., 25% = 0.25)
const double vatRate = 0.25;

// Try to convert the input string to a double
if (double.TryParse(input, out double priceWithoutVat))
{
    // Calculate the VAT amount
    double vatAmount = priceWithoutVat * vatRate;

    // Calculate the total price
    double totalPrice = priceWithoutVat + vatAmount;

    // Display the results, rounded to 2 decimal places
    Console.WriteLine($"\nPrice without VAT: {Math.Round(priceWithoutVat, 2):F2} SEK");
    Console.WriteLine($"VAT ({vatRate * 100}%):         {Math.Round(vatAmount, 2):F2} SEK");
    Console.WriteLine("---------------------------------");
    Console.WriteLine($"Total Price (incl. VAT): {Math.Round(totalPrice, 2):F2} SEK");
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

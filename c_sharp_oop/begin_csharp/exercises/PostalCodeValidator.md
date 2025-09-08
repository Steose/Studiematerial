# 📮 Postnummer-validerare

> Användaren matar in ett postnummer – programmet säger om det är giltigt.

## 🎯 Träningsmål

Detta projekt är designat för att träna följande koncept:

*   `string, Length, int.TryParse.`

## 🚀 Så kör du projektet från Visual Studio eller Rider

Tryck på den gröna play-knappen i Visual Studio eller Rider för att köra projektet.

## 🚀 Så kör du projektet

Skapa ett nytt console-projekt och följ kraven ovan.

<details>
<summary><strong>💡 </strong></summary>

```csharp
// Program: PostalCodeValidator
// Description: A C# console application to validate a Swedish postal code.

Console.WriteLine("--- Postal Code Validator ---");
Console.Write("Enter a postal code to validate (e.g., 12345): ");

// Read user input
string? input = Console.ReadLine();

// Trim whitespace from the input
string postalCode = input?.Trim() ?? "";

// Validate the postal code
// 1. It must be exactly 5 characters long.
// 2. It must consist only of digits.
if (postalCode.Length == 5 && int.TryParse(postalCode, out _))
{
    Console.WriteLine($"\n'{postalCode}' is a valid postal code format.");
}
else
{
    Console.WriteLine($"\n'{postalCode}' is NOT a valid postal code. It must be exactly 5 digits.");
}

Console.WriteLine("\nPress any key to exit.");
Console.ReadKey();
```

</details>

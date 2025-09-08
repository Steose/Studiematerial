# ✖️ Multiplikationstabell

> Visa 5:ans tabell upp till 10.

## 🎯 Träningsmål

Detta projekt är designat för att träna följande koncept:

*   `loopar, formatsträngar.`

## 🚀 Så kör du projektet från Visual Studio eller Rider

Tryck på den gröna play-knappen i Visual Studio eller Rider för att köra projektet.

## 🚀 Så kör du projektet

Skapa ett nytt console-projekt och följ kraven ovan.

<details>
<summary><strong>💡 </strong></summary>

```csharp
// Program: MultiplicationTable
// Description: A C# console application to generate a multiplication table for a given number.

Console.WriteLine("--- Multiplication Table Generator ---");
Console.Write("Enter a number to generate its multiplication table: ");

// Read user input
string? input = Console.ReadLine();

// Try to convert the input string to an integer
if (int.TryParse(input, out int number))
{
    Console.WriteLine($"\n--- Multiplication Table for {number} ---");

    // Loop from 1 to 10 to generate the table
    for (int i = 1; i <= 10; i++)
    {
        int result = number * i;
        Console.WriteLine($"{number} x {i,2} = {result}");
    }
}
else
{
    // Handle invalid input
    Console.WriteLine("Invalid input. Please enter a valid integer.");
}

Console.WriteLine("\nPress any key to exit.");
Console.ReadKey();
```

</details>

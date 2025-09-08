# 🧠 Bool-testare

> Visa true eller false beroende på inmatade villkor.

## 🎯 Träningsmål

Detta projekt är designat för att träna följande koncept:

*   `bool, jämförelseoperatorer, if-satser.`

## 🚀 Så kör du projektet från Visual Studio eller Rider

Tryck på den gröna play-knappen i Visual Studio eller Rider för att köra projektet.

## 🚀 Så kör du projektet

Skapa ett nytt console-projekt och följ kraven ovan.

<details>
<summary><strong>💡 </strong></summary>

```csharp
// Program: BoolTester
// Description: A C# console application to demonstrate boolean expressions.

Console.WriteLine("--- Boolean Expression Tester ---");
Console.WriteLine("This program will take two numbers and show the results of different comparisons.");

Console.Write("Enter the first number (A): ");
string? inputA = Console.ReadLine();

Console.Write("Enter the second number (B): ");
string? inputB = Console.ReadLine();

// Try to convert both inputs to integers
if (int.TryParse(inputA, out int numberA) && int.TryParse(inputB, out int numberB))
{
    Console.WriteLine($"\n--- Comparing A ({numberA}) and B ({numberB}) ---");

    // Equality
    bool isEqual = (numberA == numberB);
    Console.WriteLine($"Is A equal to B? (A == B) -> {isEqual}");

    // Inequality
    bool isNotEqual = (numberA != numberB);
    Console.WriteLine($"Is A not equal to B? (A != B) -> {isNotEqual}");

    // Greater than
    bool isGreater = (numberA > numberB);
    Console.WriteLine($"Is A greater than B? (A > B) -> {isGreater}");

    // Less than
    bool isLess = (numberA < numberB);
    Console.WriteLine($"Is A less than B? (A < B) -> {isLess}");

    // Greater than or equal to
    bool isGreaterOrEqual = (numberA >= numberB);
    Console.WriteLine($"Is A greater than or equal to B? (A >= B) -> {isGreaterOrEqual}");

    // Less than or equal to
    bool isLessOrEqual = (numberA <= numberB);
    Console.WriteLine($"Is A less than or equal to B? (A <= B) -> {isLessOrEqual}");
}
else
{
    // Handle invalid input
    Console.WriteLine("Invalid input. Please enter valid integers for both numbers.");
}

Console.WriteLine("\nPress any key to exit.");
Console.ReadKey();
```

</details>

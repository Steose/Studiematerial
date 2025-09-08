# ⚖️ BMI-räknare

> Beräkna BMI utifrån vikt och längd.

## 🎯 Träningsmål

Detta projekt är designat för att träna följande koncept:

*   `double, division, avrundning.`

## 🚀 Så kör du projektet från Visual Studio eller Rider

Tryck på den gröna play-knappen i Visual Studio eller Rider för att köra projektet.

## 🚀 Så kör du projektet

Skapa ett nytt console-projekt och följ kraven ovan.

<details>
<summary><strong>💡 </strong></summary>

```csharp
// Program: BMICalculator
// Description: A C# console application to calculate Body Mass Index (BMI).

Console.WriteLine("--- BMI Calculator ---");

Console.Write("Enter your weight in kilograms (e.g., 75.5): ");
string? weightInput = Console.ReadLine();

Console.Write("Enter your height in meters (e.g., 1.75): ");
string? heightInput = Console.ReadLine();

// Try to convert inputs to doubles
if (double.TryParse(weightInput, out double weight) && double.TryParse(heightInput, out double height))
{
    // Ensure height is not zero to avoid division by zero
    if (height > 0)
    {
        // Calculate BMI: weight (kg) / [height (m)]^2
        double bmi = weight / (height * height);

        // Determine the BMI category
        string category;
        if (bmi < 18.5)
        {
            category = "Underweight";
        }
        else if (bmi < 25)
        {
            category = "Normal weight";
        }
        else if (bmi < 30)
        {
            category = "Overweight";
        }
        else
        {
            category = "Obesity";
        }

        // Display the result, rounded to 1 decimal place
        Console.WriteLine($"\nYour BMI is: {Math.Round(bmi, 1):F1}");
        Console.WriteLine($"This is considered: {category}");
    }
    else
    {
        Console.WriteLine("Height must be greater than zero.");
    }
}
else
{
    // Handle invalid input
    Console.WriteLine("Invalid input. Please enter valid numbers for weight and height.");
}

Console.WriteLine("\nPress any key to exit.");
Console.ReadKey();
```

</details>

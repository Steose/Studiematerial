# 🔎 Ordsökare

> Skriv in en text och sök efter ett ord.

## 🎯 Träningsmål

Detta projekt är designat för att träna följande koncept:

*   `string.Contains, ToLower, if.`

## 🚀 Så kör du projektet från Visual Studio eller Rider

Tryck på den gröna play-knappen i Visual Studio eller Rider för att köra projektet.

## 🚀 Så kör du projektet

Skapa ett nytt console-projekt och följ kraven ovan.

<details>
<summary><strong>💡 </strong></summary>

```csharp
// Program: WordFinder
// Description: A C# console application to find a word within a given text.

Console.WriteLine("--- Word Finder ---");

Console.Write("Enter a sentence or text: ");
string? text = Console.ReadLine();

Console.Write("Enter the word to find: ");
string? searchTerm = Console.ReadLine();

// Ensure neither input is null or empty
if (!string.IsNullOrWhiteSpace(text) && !string.IsNullOrWhiteSpace(searchTerm))
{
    // Convert both to lower case for a case-insensitive search
    string textLower = text.ToLower();
    string searchTermLower = searchTerm.ToLower();

    // Check if the text contains the search term
    if (textLower.Contains(searchTermLower))
    {
        // Bonus: Find the position of the first occurrence
        int index = textLower.IndexOf(searchTermLower);
        Console.WriteLine($"\nSuccess! The word '{searchTerm}' was found in the text.");
        Console.WriteLine($"It first appears at character position {index}.");
    }
    else
    {
        Console.WriteLine($"\nSorry, the word '{searchTerm}' was not found in the text.");
    }
}
else
{
    Console.WriteLine("\nBoth text and search term must be provided.");
}

Console.WriteLine("\nPress any key to exit.");
Console.ReadKey();
```

</details>

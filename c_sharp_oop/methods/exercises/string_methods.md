# 📝 Texthantering med metoder

## Beskrivning av övningen

Skapa metoder som utför olika textoperationer. Detta hjälper dig att förstå hur man arbetar med strängar och skapar återanvändbara funktioner.

## Uppgift

Skapa metoder som utför följande operationer:
1. Räkna antalet ord i en text
2. Vänd en sträng baklänges
3. Kontrollera om en sträng är ett palindrom
4. Ta bort alla mellanslag från en sträng

## Kodmall

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        string text = "Hello world this is a test";
        string palindrome = "Anna";
        string textWithSpaces = "H e l l o   W o r l d";
        
        Console.WriteLine($"Text: '{text}'");
        Console.WriteLine($"Antal ord: {CountWords(text)}");
        Console.WriteLine($"Baklänges: '{ReverseString(text)}'");
        Console.WriteLine($"Är '{palindrome}' ett palindrom? {IsPalindrome(palindrome)}");
        Console.WriteLine($"Utan mellanslag: '{RemoveSpaces(textWithSpaces)}'");
    }
    
    public static int CountWords(string text)
    {
        // Implementera ordräkning här
    }
    
    public static string ReverseString(string text)
    {
        // Implementera omvändning av sträng här
    }
    
    public static bool IsPalindrome(string text)
    {
        // Implementera palindromkontroll här
    }
    
    public static string RemoveSpaces(string text)
    {
        // Implementera borttagning av mellanslag här
    }
}
```

#### Förväntad output

```
Text: 'Hello world this is a test'
Antal ord: 6
Baklänges: 'tset a si siht dlrow olleH'
Är 'Anna' ett palindrom? True
Utan mellanslag: 'HelloWorld'
```

#### Facit

<details><summary>Klicka här för att se facit</summary>

```csharp
using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string text = "Hello world this is a test";
        string palindrome = "Anna";
        string textWithSpaces = "H e l l o   W o r l d";
        
        Console.WriteLine($"Text: '{text}'");
        Console.WriteLine($"Antal ord: {CountWords(text)}");
        Console.WriteLine($"Baklänges: '{ReverseString(text)}'");
        Console.WriteLine($"Är '{palindrome}' ett palindrom? {IsPalindrome(palindrome)}");
        Console.WriteLine($"Utan mellanslag: '{RemoveSpaces(textWithSpaces)}'");
    }
    
    public static int CountWords(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return 0;
        
        string[] words = text.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }
    
    public static string ReverseString(string text)
    {
        if (string.IsNullOrEmpty(text))
            return text;
        
        char[] chars = text.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }
    
    public static bool IsPalindrome(string text)
    {
        if (string.IsNullOrEmpty(text))
            return true;
        
        string cleaned = text.ToLower().Replace(" ", "");
        string reversed = ReverseString(cleaned);
        return cleaned == reversed;
    }
    
    public static string RemoveSpaces(string text)
    {
        if (string.IsNullOrEmpty(text))
            return text;
        
        return text.Replace(" ", "");
    }
}
```

</details>
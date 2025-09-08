# Invertera en array

#### Beskrivning av övningen

Skriv en metod som tar emot en array av strängar och inverterar ordningen på elementen i arrayen. Metoden ska returnera den resulterande inverterade arrayen.

Det är bra om du kan lösa uppgiften utan att använda LINQ. Om du vill kan du också lösa uppgiften med hjälp av LINQ. Det är dock inte ett krav. Men det är alltid bra att vara bekant med LINQ. Även om du helst inte vill använda LINQ i denna uppgift kan det vara bra att lösa uppgiften med hjälp av LINQ också för att se hur det kan göras.

Om du löser det utan Linq har du lärt dig algorithmiskt tänkande. Om du löser det med LINQ har du lärt dig att använda LINQ. Båda är bra att kunna. Men i detta fall rekommenderar jag att du försöker lösa det utan LINQ först.

#### Kodmall

```csharp
public static string[] ReverseArray(string[] words)
{
    // Implementera kod här
}

// Exempelanvändning
string[] words = { "Katt", "Hund", "Kanin", "Capybara" };
string[] reversed = ReverseArray(words);
Console.WriteLine(string.Join(", ", reversed));
```

#### Förväntad output

```
Capybara, Kanin, Hund, Katt
```

#### Facit

<details><summary>Klicka här för att se facit</summary>

```csharp
public static string[] ReverseArray(string[] words)
{
    string[] reversed = new string[words.Length];
    int index = 0;
    for (int i = words.Length - 1; i >= 0; i--)
    {
        reversed[index] = words[i];
        index++;
    }
    return reversed;
}
```

OBS! Detta kan också lösas med hjälp av LINQ:

```csharp
public static string[] ReverseArray(string[] words)
{
    return words.Reverse().ToArray(); // Reverse returnerar en IEnumerable, så vi måste konvertera tillbaka till array med ToArray().
    // IEnumerable är en mer generell typ än array. Den gör inte lika många antaganden om hur data är lagrad, så den är mer flexibel.
    // Det är lugnt, vi ska läsa om IEnumerable senare i kursen. ;)
}
```

Men det är bra att kunna lösa det utan LINQ också, mest för att förstå tanken bakom algoritmer.

</details>

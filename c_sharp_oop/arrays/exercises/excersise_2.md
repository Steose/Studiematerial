# Hitta det största elementet i en array

#### Beskrivning av övningen

Skriv en metod som tar emot en array av heltal och returnerar det största elementet i arrayen.

Det är bra om du kan lösa uppgiften utan att använda LINQ. Om du vill kan du också lösa uppgiften med hjälp av LINQ. Det är dock inte ett krav. Men det är alltid bra att vara bekant med LINQ. Även om du helst inte vill använda LINQ i denna uppgift kan det vara bra att lösa uppgiften med hjälp av LINQ också för att se hur det kan göras.

Om du löser det utan Linq har du lärt dig algorithmiskt tänkande. Om du löser det med LINQ har du lärt dig att använda LINQ. Båda är bra att kunna. Men i detta fall rekommenderar jag att du försöker lösa det utan LINQ först.

#### Kodmall

```csharp
public static int FindLargestElement(int[] numbers)
{
    // Implementera kod här
}

// Exempelanvändning
int[] numbers = { 5, 8, 2, 11, 3 };
int largest = FindLargestElement(numbers);
Console.WriteLine(largest);
```

#### Förväntad output

```
11
```

#### Facit

<details><summary>Klicka här för att se facit</summary>

```csharp
public static int FindLargestElement(int[] numbers)
{
    int largest = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] > largest)
        {
            largest = numbers[i];
        }
    }
    return largest;
}
```

OBS! Detta kan också lösas med hjälp av LINQ:

```csharp
public static int FindLargestElement(int[] numbers)
{
    return numbers.Max();
}
```

Men det är bra att kunna lösa det utan LINQ också, mest för att förstå tanken bakom algoritmer.

</details>

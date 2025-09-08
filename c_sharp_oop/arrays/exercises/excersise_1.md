# Summera element i en array

## Beskrivning av övningen

Skriv en metod som tar emot en array av heltal och summerar alla element i arrayen. Returnera den resulterande summan.

Det är bra om du kan lösa uppgiften utan att använda LINQ. Om du vill kan du också lösa uppgiften med hjälp av LINQ. Det är dock inte ett krav. Men det är alltid bra att vara bekant med LINQ. Även om du helst inte vill använda LINQ i denna uppgift kan det vara bra att lösa uppgiften med hjälp av LINQ också för att se hur det kan göras.

Om du löser det utan Linq har du lärt dig algorithmiskt tänkande. Om du löser det med LINQ har du lärt dig att använda LINQ. Båda är bra att kunna. Men i detta fall rekommenderar jag att du försöker lösa det utan LINQ först.

## Kodmall

```csharp
public static int SumArray(int[] numbers)
{
    // Implementera kod här
}

// Exempelanvändning
int[] numbers = { 1, 2, 3, 4, 5 };
int sum = SumArray(numbers);
Console.WriteLine(sum);
```

#### Förväntad output

```
15
```

#### Facit

<details><summary>Klicka här för att se facit</summary>

```csharp
public static int SumArray(int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }
    return sum;
}
```

OBS! Detta kan också lösas med hjälp av LINQ:

```csharp
public static int SumArray(int[] numbers)
{
    return numbers.Sum(); // Kräver using System.Linq;
}
```

Men det är bra att kunna lösa det utan LINQ också, mest för att förstå tanken bakom algoritmer.

</details>

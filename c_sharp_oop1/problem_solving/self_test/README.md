# Self Test: Problemlösning

Testa dina kunskaper inom problemlösning med C# genom att besvara följande frågor. Använd det du lärt dig från övningarna för att ge genomtänkta svar.

## Allmänna frågor om problemlösning

### 1. Planering och design
- Varför är det viktigt att planera din lösning innan du börjar koda?
- Vilka fördelar finns det med att skriva pseudokod?
- Hur kan du bryta ner komplexa problem i mindre, hanterbara delar?

### 2. Algoritmisk tänkande
- Vad är skillnaden mellan iteration och rekursion för problemlösning?
- När bör du välja en for-loop över en foreach-loop?
- Hur påverkar valet av datastruktur (array vs List) din lösning?

## Specifika tekniska frågor

### 3. Array-manipulation
- Skriv pseudokod för att hitta det näst största talet i en array
- Hur skulle du kontrollera om en array är sorterad?
- Vad är tidskomplexiteten för att söka genom en osorterad array?

### 4. Strängbearbetning
- Beskriv tre olika sätt att vända på en sträng i C#
- Hur hanterar du mellanslag och skiljetecken vid ordräkning?
- Vad är skillnaden mellan `string.Equals()` och `==` för strängjämförelse?

### 5. Objektorienterad design
- Vilka principer följer du när du designar en klass som BankAccount?
- Varför använder vi private fält och public metoder?
- Hur kan du förhindra att en klass används på fel sätt?

## Praktiska uppgifter

### 6. Debugging-scenario
Du har skrivit följande kod som ska hitta medelvärdet av positiva tal:

```csharp
static double AveragePositive(int[] numbers)
{
    int sum = 0;
    int count = 0;

    foreach (int num in numbers)
    {
        if (num > 0)
        {
            sum += num;
            count++;
        }
    }

    return sum / count;
}
```

- Vilka potentiella problem finns med denna kod?
- Hur skulle du förbättra den?

### 7. Designval
Du ska implementera en metod som kontrollerar om en lista av ord är sorterad alfabetiskt.

- Vilka olika tillvägagångssätt kan du använda?
- Vilka fördelar och nackdelar har varje metod?
- Hur hanterar du stora och små bokstäver?

## Reflektionsfrågor

### 8. Kodkvalitet
- Vad gör kod läsbar och underhållbar?
- Hur balanserar du prestanda mot kodtydlighet?
- När bör du kommentera din kod och när är koden självkommenterande?

### 9. Felhantering
- Vilka typer av fel kan uppstå i problemlösningsalgoritmer?
- Hur designar du robust kod som hanterar edge cases?
- Vad är skillnaden mellan att förhindra fel och att hantera fel?

### 10. Vidareutveckling
- Hur skulle du utöka BankAccount-klassen med nya funktioner?
- Vilka designmönster kan vara användbara för problemlösning?
- Hur testar du att dina lösningar fungerar korrekt?

## Svar och diskussion

<details>
<summary>Tips för att besvara frågorna</summary>

- **Var specifik**: Använd konkreta exempel från övningarna
- **Förklara varför**: Motivera dina val och resonemang
- **Jämför alternativ**: Diskutera olika lösningsmetoder
- **Tänk praktiskt**: Hur skulle du använda detta i verkliga projekt?
- **Reflektera över lärandet**: Vad har varit svårast och vad behöver du öva mer på?

</details>

<details>
<summary>Självbedömning</summary>

Efter att ha besvarat frågorna, bedöm din förståelse:

- **Grundläggande (1-2)**: Kan lösa enkla problem med stöd
- **Utvecklande (3-4)**: Kan självständigt lösa de flesta problem
- **Säker (5-6)**: Kan lösa komplexa problem och förklara lösningar
- **Avancerad (7-8)**: Kan optimera lösningar och designa robusta system
- **Expert (9-10)**: Kan undervisa andra och skapa eleganta lösningar

</details>

Kom ihåg att problemlösning är en färdighet som utvecklas över tid. Fortsätt öva och experimentera med olika tillvägagångssätt!

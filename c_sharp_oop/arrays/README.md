# 🗂️ Arrays - Lagra flera värden

Lär dig använda arrays för att hantera många värden av samma typ. Arrays är grunden för all datahantering i programmering.

## 📚 Innehåll

### 📖 Lectures och teori
- **[arrays.md](lecture/arrays.md)** - Komplett guide till arrays, minneshantering och best practices

### 🏋️ Praktiska övningar
Se **[exercises/](exercises/)** för alla övningar:

#### Grundläggande array-operationer
- **[Summera element i en array](exercises/excersise_1.md)** - Grundläggande iteration
- **[Array-övning 2](exercises/excersise_2.md)** - Mer avancerade operationer  
- **[Array-övning 3](exercises/excersise_3.md)** - Komplexa array-manipulationer

#### Praktiska tillämpningar
- **[Array Copy](exercises/arrayCopy.md)** - Kopiera arrays säkert
- **[📊 Betygsanalysator](exercises/grade_analyzer.md)** - Analysera studentbetyg med statistik

## 🎯 Array-grunderna

### Skapa arrays
```csharp
// Med värden direkt
int[] numbers = {1, 2, 3, 4, 5};
string[] names = {"Anna", "Erik", "Maria"};

// Tom array med specifik storlek
int[] scores = new int[10];  // 10 tomma platser

// Få längd
int length = numbers.Length; // 5
```

### Komma åt element
```csharp
// Läsa värden (index börjar på 0!)
int first = numbers[0];      // 1
int last = numbers[4];       // 5
int lastAlt = numbers[numbers.Length - 1]; // Säkrare sätt

// Ändra värden
numbers[2] = 100;            // Ändra tredje elementet
```

### Loopa genom arrays
```csharp
// For-loop med index
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"Index {i}: {numbers[i]}");
}

// Foreach - enklare när du inte behöver index
foreach (int number in numbers)
{
    Console.WriteLine(number);
}
```

## 💡 Viktiga koncept

### Minneseffektivitet
Arrays lagrar element bredvid varandra i minnet = supersnabb åtkomst (O(1))

### Index-baserad åtkomst
- Första elementet: `array[0]`
- Sista elementet: `array[array.Length - 1]`
- **Varning:** Försök inte komma åt `array[array.Length]` - det ger error!

### Fast storlek
När du skapat en array kan du inte ändra dess storlek. Använd `List<T>` för dynamiska samlingar.

Arrays är grunden - behärska dem så blir resten enklare! 🚀
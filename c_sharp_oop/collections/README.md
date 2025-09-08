# 📊 Collections - Dynamiska datastrukturer

Lär dig använda moderna collections som List<T> och Dictionary<TKey, TValue> för att hantera data smart och effektivt.

## 📚 Innehåll

### 🏋️ Praktiska övningar
Se **[exercises/](exercises/)** för alla övningar från nybörjare till avancerad nivå:

#### Grundläggande collections (Perfekt att börja med!)
- **[📋 Grundläggande List-operationer](exercises/list_basics.md)** - Dynamiska listor, CRUD-operationer
- **[📞 Telefonkatalog med Dictionary](exercises/dictionary_phonebook.md)** - Key-value pairs och snabb sökning

#### Praktiska tillämpningar  
- **[📦 Lagerhanteringssystem](exercises/inventory_management.md)** - Kombinera List och Dictionary
  
#### Avancerade system
- **[🎵 Spotify Playlist Manager](exercises/collections-mastery.md)** - Komplext system med LINQ och design patterns

## 🎯 Varför Collections?

### Arrays vs Collections
```csharp
// Arrays - fast storlek
int[] numbers = new int[5];     // Exakt 5 element, inte mer, inte mindre

// List - dynamisk storlek  
List<int> numbers = new List<int>(); // Kan växa och krympa
numbers.Add(10);                     // Lägg till
numbers.Remove(10);                  // Ta bort
```

### Vanligaste Collections

#### List<T> - Dynamiska arrays
```csharp
List<string> names = new List<string>();
names.Add("Anna");              // Lägg till
names.Insert(0, "Första");      // Lägg till på specifik position  
names.Remove("Anna");           // Ta bort första förekomst
bool exists = names.Contains("Anna"); // Kontrollera om finns
```

#### Dictionary<TKey, TValue> - Snabba uppslagningar
```csharp
Dictionary<string, int> ages = new Dictionary<string, int>();
ages["Anna"] = 25;              // Lägg till/uppdatera
ages.Add("Erik", 30);           // Lägg till (error om key finns)
bool hasKey = ages.ContainsKey("Anna");  // Kontrollera key
int age = ages["Anna"];         // Hämta värde
```

## 💡 LINQ - Superkraften

LINQ gör collections ännu kraftfullare:

```csharp
List<int> numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

// Filtrera
var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();

// Sortera
var sorted = numbers.OrderByDescending(n => n).ToList();

// Transformera
var doubled = numbers.Select(n => n * 2).ToList();

// Beräkna
int sum = numbers.Sum();
double average = numbers.Average();
int max = numbers.Max();
```

## 🚀 När använda vad?

- **Array**: När storleken är känd och fix, maximal performance
- **List<T>**: När storleken varierar, behöver lägg-till/ta-bort funktionalitet  
- **Dictionary<TKey, TValue>**: När du behöver snabb uppslagning via nyckel
- **Queue<T>**: FIFO (först in, först ut) - kösystem
- **Stack<T>**: LIFO (sist in, först ut) - undo-funktionalitet

Collections gör dina program flexibla och kraftfulla! 💪
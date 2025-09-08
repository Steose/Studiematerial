# 📊 Collections och Datastrukturer - Övningar

Här hittar du övningar för att lära dig använda olika collections i C#. Collections hjälper dig att lagra och hantera samlingar av data på ett effektivt sätt.

## Vad är Collections?

Collections är datastrukturer som kan lagra flera element. De vanligaste typerna är:

- **Array**: Fast storlek, snabb åtkomst via index
- **List<T>**: Dynamisk storlek, kan växa och krympa
- **Dictionary<TKey, TValue>**: Nyckel-värde par för snabb uppslagning
- **Queue<T>**: FIFO (först in, först ut)
- **Stack<T>**: LIFO (sist in, först ut)

## Grundläggande övningar

### 1. **[📋 Grundläggande List-operationer](list_basics.md)**
- Lär dig skapa och hantera listor
- Lägg till, ta bort och sök element
- Beräkna statistik från data i listor
- **Svårighetsgrad**: Nybörjare
- **Fokus**: List<T>, grundläggande CRUD-operationer

### 2. **[📞 Telefonkatalog med Dictionary](dictionary_phonebook.md)**
- Förstå nyckel-värde struktur
- Snabb uppslagning med Dictionary
- Hantera dubletter och uppdateringar
- **Svårighetsgrad**: Nybörjare till Mellannivå
- **Fokus**: Dictionary<TKey, TValue>, sökning och uppdatering

### 3. **[📦 Lagerhantering med Collections](inventory_management.md)**
- Kombinera List och Dictionary
- Skapa mer komplexa datastrukturer
- Hantera kategoriserad data
- **Svårighetsgrad**: Mellannivå
- **Fokus**: Kombination av collections, klasser

## Avancerade övningar

### 4. **[🎵 Spotify Playlist Manager - Collections Mastery](collections-mastery.md)**
- Komplett system med flera collections
- LINQ för kraftfull datamanipulation
- Avancerad objektstruktur
- **Svårighetsgrad**: Avancerad
- **Fokus**: Alla collections, LINQ, designmönster

## Vilken övning ska jag börja med?

**Om du är ny med collections:**
1. Börja med **List-operationer** för att förstå grunderna
2. Gå vidare till **Dictionary** för att lära dig nyckel-värde par
3. Prova **Lagerhantering** för att se hur collections samarbetar

**Om du redan kan grunderna:**
- Hoppa direkt till **Lagerhantering** eller **Spotify Playlist Manager**
- Fokusera på att förstå när man ska använda vilken collection

## Viktiga begrepp att lära sig

### List<T>
```csharp
List<string> names = new List<string>();
names.Add("Anna");              // Lägg till
names.Remove("Anna");           // Ta bort
int count = names.Count;        // Antal element
names[0] = "Erik";             // Ändra via index
```

### Dictionary<TKey, TValue>
```csharp
Dictionary<string, int> ages = new Dictionary<string, int>();
ages["Anna"] = 25;             // Lägg till/uppdatera
ages.Remove("Anna");           // Ta bort
bool exists = ages.ContainsKey("Anna");  // Kontrollera
```

### LINQ för Collections
```csharp
var adults = people.Where(p => p.Age >= 18).ToList();
var average = grades.Average();
var sorted = products.OrderBy(p => p.Price).ToList();
```

## Tips för framgång

1. **Börja enkelt**: Använd enkla datatyper (string, int) innan du går till komplexa objekt
2. **Testa ofta**: Använd Console.WriteLine() för att se vad som händer
3. **Förstå prestanda**: List är bra för ordnade data, Dictionary för snabb uppslagning
4. **Använd LINQ**: Gör din kod mer läsbar och kraftfull
5. **Felhantering**: Kontrollera om element finns innan du använder dem

## Vanliga misstag att undvika

- ❌ Försöka komma åt element som inte finns
- ❌ Använda fel collection för uppgiften
- ❌ Glömma att kontrollera om collections är tomma
- ❌ Ändra collections medan du loopar genom dem
- ❌ Inte använda rätt jämförelsemetod för custom objects

## Nästa steg

När du behärskar dessa övningar är du redo för:
- Databaser och Entity Framework
- Asynkron programmering
- Web APIs och JSON-hantering
- Avancerad LINQ och Lambda expressions
- Designmönster som Repository Pattern

Lycka till! 🚀
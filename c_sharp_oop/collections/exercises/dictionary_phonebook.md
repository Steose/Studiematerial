# 📞 Telefonkatalog med Dictionary

## Beskrivning av övningen

Lär dig använda Dictionary<TKey, TValue> för att skapa en telefonkatalog. Dictionary är perfekt när du behöver snabb uppslagning baserat på en nyckel (key).

## Uppgift

Skapa en telefonkatalog som kan:
1. Lägga till nya kontakter
2. Söka upp telefonnummer via namn
3. Ta bort kontakter
4. Visa alla kontakter
5. Kontrollera om en kontakt finns

## Kodmall

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> phonebook = new Dictionary<string, string>();
        
        // Lägg till några testkontakter
        AddContact(phonebook, "Anna Andersson", "070-1234567");
        AddContact(phonebook, "Erik Eriksson", "070-2345678");
        AddContact(phonebook, "Maria Larsson", "070-3456789");
        AddContact(phonebook, "Johan Johansson", "070-4567890");
        
        Console.WriteLine("=== TELEFONKATALOG ===");
        
        ShowAllContacts(phonebook);
        
        // Testa olika funktioner
        SearchContact(phonebook, "Maria Larsson");
        SearchContact(phonebook, "Nils Nilsson");
        
        UpdateContact(phonebook, "Anna Andersson", "070-9999999");
        
        RemoveContact(phonebook, "Erik Eriksson");
        
        ShowAllContacts(phonebook);
        
        ShowStats(phonebook);
    }
    
    static void AddContact(Dictionary<string, string> phonebook, string name, string phone)
    {
        // Implementera här
    }
    
    static void SearchContact(Dictionary<string, string> phonebook, string name)
    {
        // Implementera här
    }
    
    static void UpdateContact(Dictionary<string, string> phonebook, string name, string newPhone)
    {
        // Implementera här
    }
    
    static void RemoveContact(Dictionary<string, string> phonebook, string name)
    {
        // Implementera här
    }
    
    static void ShowAllContacts(Dictionary<string, string> phonebook)
    {
        // Implementera här
    }
    
    static void ShowStats(Dictionary<string, string> phonebook)
    {
        // Implementera här - visa antal kontakter och operatörsstatistik
    }
}
```

#### Förväntad output

```
=== TELEFONKATALOG ===

Alla kontakter:
Anna Andersson: 070-1234567
Erik Eriksson: 070-2345678
Johan Johansson: 070-4567890
Maria Larsson: 070-3456789

Söker efter Maria Larsson...
Maria Larsson: 070-3456789

Söker efter Nils Nilsson...
Kontakt ej hittad.

Anna Anderssons nummer uppdaterat till 070-9999999

Erik Eriksson har tagits bort från katalogen.

Alla kontakter:
Anna Andersson: 070-9999999
Johan Johansson: 070-4567890
Maria Larsson: 070-3456789

Statistik:
Antal kontakter: 3
Alla nummer börjar med 070 (mobil)
```

#### Facit

<details><summary>Klicka här för att se facit</summary>

```csharp
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> phonebook = new Dictionary<string, string>();
        
        // Lägg till några testkontakter
        AddContact(phonebook, "Anna Andersson", "070-1234567");
        AddContact(phonebook, "Erik Eriksson", "070-2345678");
        AddContact(phonebook, "Maria Larsson", "070-3456789");
        AddContact(phonebook, "Johan Johansson", "070-4567890");
        
        Console.WriteLine("=== TELEFONKATALOG ===");
        
        ShowAllContacts(phonebook);
        
        // Testa olika funktioner
        SearchContact(phonebook, "Maria Larsson");
        SearchContact(phonebook, "Nils Nilsson");
        
        UpdateContact(phonebook, "Anna Andersson", "070-9999999");
        
        RemoveContact(phonebook, "Erik Eriksson");
        
        ShowAllContacts(phonebook);
        
        ShowStats(phonebook);
    }
    
    static void AddContact(Dictionary<string, string> phonebook, string name, string phone)
    {
        if (phonebook.ContainsKey(name))
        {
            Console.WriteLine($"{name} finns redan i katalogen. Använd UpdateContact för att ändra numret.");
        }
        else
        {
            phonebook[name] = phone;
            Console.WriteLine($"Lade till {name}: {phone}");
        }
    }
    
    static void SearchContact(Dictionary<string, string> phonebook, string name)
    {
        Console.WriteLine($"Söker efter {name}...");
        if (phonebook.ContainsKey(name))
        {
            Console.WriteLine($"{name}: {phonebook[name]}");
        }
        else
        {
            Console.WriteLine("Kontakt ej hittad.");
        }
        Console.WriteLine();
    }
    
    static void UpdateContact(Dictionary<string, string> phonebook, string name, string newPhone)
    {
        if (phonebook.ContainsKey(name))
        {
            string oldPhone = phonebook[name];
            phonebook[name] = newPhone;
            Console.WriteLine($"{name}s nummer uppdaterat från {oldPhone} till {newPhone}");
        }
        else
        {
            Console.WriteLine($"{name} finns inte i katalogen.");
        }
        Console.WriteLine();
    }
    
    static void RemoveContact(Dictionary<string, string> phonebook, string name)
    {
        if (phonebook.Remove(name))
        {
            Console.WriteLine($"{name} har tagits bort från katalogen.");
        }
        else
        {
            Console.WriteLine($"{name} finns inte i katalogen.");
        }
        Console.WriteLine();
    }
    
    static void ShowAllContacts(Dictionary<string, string> phonebook)
    {
        Console.WriteLine("\nAlla kontakter:");
        if (phonebook.Count == 0)
        {
            Console.WriteLine("Inga kontakter i katalogen.");
        }
        else
        {
            // Sortera efter namn för snyggare utskrift
            foreach (var contact in phonebook.OrderBy(kvp => kvp.Key))
            {
                Console.WriteLine($"{contact.Key}: {contact.Value}");
            }
        }
        Console.WriteLine();
    }
    
    static void ShowStats(Dictionary<string, string> phonebook)
    {
        Console.WriteLine("Statistik:");
        Console.WriteLine($"Antal kontakter: {phonebook.Count}");
        
        if (phonebook.Count > 0)
        {
            // Analysera telefonnummer
            int mobilNumbers = phonebook.Values.Count(phone => phone.StartsWith("070") || phone.StartsWith("076"));
            int fastNumbers = phonebook.Values.Count(phone => phone.StartsWith("08") || phone.StartsWith("031"));
            
            Console.WriteLine($"Mobilnummer (070/076): {mobilNumbers}");
            Console.WriteLine($"Fastnät (08/031): {fastNumbers}");
            Console.WriteLine($"Andra nummer: {phonebook.Count - mobilNumbers - fastNumbers}");
        }
        Console.WriteLine();
    }
}
```

</details>
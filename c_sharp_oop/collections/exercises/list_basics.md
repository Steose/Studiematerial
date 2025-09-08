# 📋 Grundläggande List-operationer

## Beskrivning av övningen

Lär dig använda List<T> för att hantera dynamiska samlingar av data. Lists är en av de mest användbara kollektionstyperna i C# eftersom de kan växa och krympa under programmets körning.

## Uppgift

Skapa ett program som hanterar en lista med studentnamn och deras betyg. Programmet ska kunna:

1. Lägga till nya studenter
2. Ta bort studenter
3. Söka efter en specifik student
4. Räkna antalet studenter
5. Visa alla studenter

## Kodmall

```csharp
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<string> students = new List<string>();
        List<int> grades = new List<int>();
        
        // Lägg till några test-studenter
        AddStudent(students, grades, "Anna", 85);
        AddStudent(students, grades, "Erik", 92);
        AddStudent(students, grades, "Maria", 78);
        AddStudent(students, grades, "Johan", 88);
        
        Console.WriteLine("=== STUDENTHANTERINGSSYSTEM ===");
        
        ShowAllStudents(students, grades);
        
        // Testa olika funktioner
        SearchStudent(students, grades, "Maria");
        RemoveStudent(students, grades, "Erik");
        
        ShowAllStudents(students, grades);
        
        CalculateStats(grades);
    }
    
    static void AddStudent(List<string> students, List<int> grades, string name, int grade)
    {
        // Implementera här
    }
    
    static void RemoveStudent(List<string> students, List<int> grades, string name)
    {
        // Implementera här
    }
    
    static void SearchStudent(List<string> students, List<int> grades, string name)
    {
        // Implementera här
    }
    
    static void ShowAllStudents(List<string> students, List<int> grades)
    {
        // Implementera här
    }
    
    static void CalculateStats(List<int> grades)
    {
        // Implementera här - räkna ut genomsnitt, högsta och lägsta betyg
    }
}
```

#### Förväntad output

```
=== STUDENTHANTERINGSSYSTEM ===

Alla studenter:
1. Anna - Betyg: 85
2. Erik - Betyg: 92
3. Maria - Betyg: 78
4. Johan - Betyg: 88

Söker efter Maria...
Hittade Maria med betyg: 78

Ta bort Erik från listan...
Erik har tagits bort.

Alla studenter:
1. Anna - Betyg: 85
2. Maria - Betyg: 78
3. Johan - Betyg: 88

Statistik:
Antal studenter: 3
Genomsnittligt betyg: 83.7
Högsta betyg: 88
Lägsta betyg: 78
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
        List<string> students = new List<string>();
        List<int> grades = new List<int>();
        
        // Lägg till några test-studenter
        AddStudent(students, grades, "Anna", 85);
        AddStudent(students, grades, "Erik", 92);
        AddStudent(students, grades, "Maria", 78);
        AddStudent(students, grades, "Johan", 88);
        
        Console.WriteLine("=== STUDENTHANTERINGSSYSTEM ===");
        
        ShowAllStudents(students, grades);
        
        // Testa olika funktioner
        SearchStudent(students, grades, "Maria");
        RemoveStudent(students, grades, "Erik");
        
        ShowAllStudents(students, grades);
        
        CalculateStats(grades);
    }
    
    static void AddStudent(List<string> students, List<int> grades, string name, int grade)
    {
        students.Add(name);
        grades.Add(grade);
        Console.WriteLine($"Lade till {name} med betyg {grade}");
    }
    
    static void RemoveStudent(List<string> students, List<int> grades, string name)
    {
        int index = students.IndexOf(name);
        if (index >= 0)
        {
            students.RemoveAt(index);
            grades.RemoveAt(index);
            Console.WriteLine($"{name} har tagits bort.");
        }
        else
        {
            Console.WriteLine($"{name} hittades inte i listan.");
        }
    }
    
    static void SearchStudent(List<string> students, List<int> grades, string name)
    {
        Console.WriteLine($"Söker efter {name}...");
        int index = students.IndexOf(name);
        if (index >= 0)
        {
            Console.WriteLine($"Hittade {name} med betyg: {grades[index]}");
        }
        else
        {
            Console.WriteLine($"{name} hittades inte.");
        }
    }
    
    static void ShowAllStudents(List<string> students, List<int> grades)
    {
        Console.WriteLine("\nAlla studenter:");
        if (students.Count == 0)
        {
            Console.WriteLine("Inga studenter registrerade.");
        }
        else
        {
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {students[i]} - Betyg: {grades[i]}");
            }
        }
        Console.WriteLine();
    }
    
    static void CalculateStats(List<int> grades)
    {
        if (grades.Count == 0)
        {
            Console.WriteLine("Inga betyg att räkna statistik för.");
            return;
        }
        
        Console.WriteLine("Statistik:");
        Console.WriteLine($"Antal studenter: {grades.Count}");
        Console.WriteLine($"Genomsnittligt betyg: {grades.Average():F1}");
        Console.WriteLine($"Högsta betyg: {grades.Max()}");
        Console.WriteLine($"Lägsta betyg: {grades.Min()}");
        Console.WriteLine();
    }
}
```

</details>
# 📊 Betygsanalysator med Arrays

## Beskrivning av övningen

Skapa ett program som analyserar studentbetyg med hjälp av arrays. Detta är en praktisk tillämpning av arrays med matematiska beräkningar och statistik.

## Uppgift

Skapa en betygsanalysator som kan:
1. Läsa in betyg för en klass studenter
2. Beräkna genomsnitt, högsta och lägsta betyg
3. Räkna hur många som fick varje betygsnivå
4. Visa betygsdistribution
5. Hitta studenter över/under genomsnittet

## Kodmall

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        // Testbetyg för en klass på 15 studenter
        int[] grades = { 85, 92, 78, 88, 76, 95, 82, 90, 87, 79, 91, 83, 86, 94, 89 };
        string[] students = { "Anna", "Erik", "Maria", "Johan", "Lisa", "Peter", "Sara", "Magnus", "Emma", "David", "Sofia", "Carl", "Nina", "Oscar", "Lina" };
        
        Console.WriteLine("=== BETYGSANALYS KLASS 7A ===");
        Console.WriteLine($"Antal studenter: {grades.Length}");
        Console.WriteLine();
        
        ShowAllGrades(students, grades);
        
        CalculateStatistics(grades);
        
        ShowGradeDistribution(grades);
        
        FindTopAndBottomStudents(students, grades);
        
        ShowAboveAverageStudents(students, grades);
    }
    
    static void ShowAllGrades(string[] students, int[] grades)
    {
        // Implementera här - visa alla studenter och deras betyg
        Console.WriteLine("ALLA BETYG:");
    }
    
    static void CalculateStatistics(int[] grades)
    {
        // Implementera här - beräkna och visa statistik
        Console.WriteLine("STATISTIK:");
    }
    
    static void ShowGradeDistribution(int[] grades)
    {
        // Implementera här - visa fördelning av betyg i intervaller
        Console.WriteLine("BETYGSDISTRIBUTION:");
    }
    
    static void FindTopAndBottomStudents(string[] students, int[] grades)
    {
        // Implementera här - hitta bästa och sämsta studenten
        Console.WriteLine("TOPP OCH BOTTEN:");
    }
    
    static void ShowAboveAverageStudents(string[] students, int[] grades)
    {
        // Implementera här - visa studenter över genomsnittet
        Console.WriteLine("STUDENTER ÖVER GENOMSNITTET:");
    }
    
    // Hjälpmetod för att få betygsbokstav
    static char GetLetterGrade(int score)
    {
        // Implementera här
        // A: 90-100, B: 80-89, C: 70-79, D: 60-69, F: 0-59
    }
}
```

#### Förväntad output

```
=== BETYGSANALYS KLASS 7A ===
Antal studenter: 15

ALLA BETYG:
1. Anna: 85 (B)
2. Erik: 92 (A)
3. Maria: 78 (C)
...
15. Lina: 89 (B)

STATISTIK:
Genomsnitt: 86.3
Högsta betyg: 95 
Lägsta betyg: 76
Spridning: 19 poäng
Median: 87

BETYGSDISTRIBUTION:
A (90-100): ████████ 5 studenter (33.3%)
B (80-89):  ████████████ 8 studenter (53.3%)
C (70-79):  ██ 2 studenter (13.3%)
D (60-69):  0 studenter (0.0%)
F (0-59):   0 studenter (0.0%)

TOPP OCH BOTTEN:
Högst: Peter med 95 poäng (A)
Lägst: Lisa med 76 poäng (C)

STUDENTER ÖVER GENOMSNITTET (86.3):
Erik: 92 (A)
Peter: 95 (A)
Sara: 90 (A)
David: 91 (A)
Oscar: 94 (A)
Lina: 89 (B)
Magnus: 87 (B)
```

#### Facit

<details><summary>Klicka här för att se facit</summary>

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        // Testbetyg för en klass på 15 studenter
        int[] grades = { 85, 92, 78, 88, 76, 95, 82, 90, 87, 79, 91, 83, 86, 94, 89 };
        string[] students = { "Anna", "Erik", "Maria", "Johan", "Lisa", "Peter", "Sara", "Magnus", "Emma", "David", "Sofia", "Carl", "Nina", "Oscar", "Lina" };
        
        Console.WriteLine("=== BETYGSANALYS KLASS 7A ===");
        Console.WriteLine($"Antal studenter: {grades.Length}");
        Console.WriteLine();
        
        ShowAllGrades(students, grades);
        
        CalculateStatistics(grades);
        
        ShowGradeDistribution(grades);
        
        FindTopAndBottomStudents(students, grades);
        
        ShowAboveAverageStudents(students, grades);
    }
    
    static void ShowAllGrades(string[] students, int[] grades)
    {
        Console.WriteLine("ALLA BETYG:");
        for (int i = 0; i < students.Length; i++)
        {
            char letterGrade = GetLetterGrade(grades[i]);
            Console.WriteLine($"{i + 1,2}. {students[i],-8}: {grades[i]} ({letterGrade})");
        }
        Console.WriteLine();
    }
    
    static void CalculateStatistics(int[] grades)
    {
        Console.WriteLine("STATISTIK:");
        
        // Beräkna genomsnitt
        int sum = 0;
        for (int i = 0; i < grades.Length; i++)
        {
            sum += grades[i];
        }
        double average = (double)sum / grades.Length;
        
        // Hitta högsta och lägsta
        int highest = grades[0];
        int lowest = grades[0];
        for (int i = 1; i < grades.Length; i++)
        {
            if (grades[i] > highest) highest = grades[i];
            if (grades[i] < lowest) lowest = grades[i];
        }
        
        // Beräkna median (sortera först)
        int[] sortedGrades = new int[grades.Length];
        Array.Copy(grades, sortedGrades, grades.Length);
        Array.Sort(sortedGrades);
        
        double median;
        if (grades.Length % 2 == 0)
        {
            // Jämnt antal - ta medelvärdet av två mittersta
            median = (sortedGrades[grades.Length / 2 - 1] + sortedGrades[grades.Length / 2]) / 2.0;
        }
        else
        {
            // Udda antal - ta mittersta värdet
            median = sortedGrades[grades.Length / 2];
        }
        
        Console.WriteLine($"Genomsnitt: {average:F1}");
        Console.WriteLine($"Högsta betyg: {highest}");
        Console.WriteLine($"Lägsta betyg: {lowest}");
        Console.WriteLine($"Spridning: {highest - lowest} poäng");
        Console.WriteLine($"Median: {median:F0}");
        Console.WriteLine();
    }
    
    static void ShowGradeDistribution(int[] grades)
    {
        Console.WriteLine("BETYGSDISTRIBUTION:");
        
        // Räkna betyg i varje kategori
        int[] gradeCounts = new int[5]; // A, B, C, D, F
        string[] gradeLabels = { "A (90-100)", "B (80-89)", "C (70-79)", "D (60-69)", "F (0-59)" };
        
        for (int i = 0; i < grades.Length; i++)
        {
            if (grades[i] >= 90) gradeCounts[0]++;
            else if (grades[i] >= 80) gradeCounts[1]++;
            else if (grades[i] >= 70) gradeCounts[2]++;
            else if (grades[i] >= 60) gradeCounts[3]++;
            else gradeCounts[4]++;
        }
        
        // Visa distribution med staplar
        for (int i = 0; i < gradeCounts.Length; i++)
        {
            double percentage = (double)gradeCounts[i] / grades.Length * 100;
            string bar = new string('█', gradeCounts[i]);
            Console.WriteLine($"{gradeLabels[i]}: {bar,-12} {gradeCounts[i]} studenter ({percentage:F1}%)");
        }
        Console.WriteLine();
    }
    
    static void FindTopAndBottomStudents(string[] students, int[] grades)
    {
        Console.WriteLine("TOPP OCH BOTTEN:");
        
        int highestIndex = 0;
        int lowestIndex = 0;
        
        for (int i = 1; i < grades.Length; i++)
        {
            if (grades[i] > grades[highestIndex]) highestIndex = i;
            if (grades[i] < grades[lowestIndex]) lowestIndex = i;
        }
        
        Console.WriteLine($"Högst: {students[highestIndex]} med {grades[highestIndex]} poäng ({GetLetterGrade(grades[highestIndex])})");
        Console.WriteLine($"Lägst: {students[lowestIndex]} med {grades[lowestIndex]} poäng ({GetLetterGrade(grades[lowestIndex])})");
        Console.WriteLine();
    }
    
    static void ShowAboveAverageStudents(string[] students, int[] grades)
    {
        // Beräkna genomsnitt
        int sum = 0;
        for (int i = 0; i < grades.Length; i++)
        {
            sum += grades[i];
        }
        double average = (double)sum / grades.Length;
        
        Console.WriteLine($"STUDENTER ÖVER GENOMSNITTET ({average:F1}):");
        
        for (int i = 0; i < students.Length; i++)
        {
            if (grades[i] > average)
            {
                Console.WriteLine($"{students[i]}: {grades[i]} ({GetLetterGrade(grades[i])})");
            }
        }
        Console.WriteLine();
    }
    
    static char GetLetterGrade(int score)
    {
        if (score >= 90) return 'A';
        else if (score >= 80) return 'B';
        else if (score >= 70) return 'C';
        else if (score >= 60) return 'D';
        else return 'F';
    }
}
```

</details>
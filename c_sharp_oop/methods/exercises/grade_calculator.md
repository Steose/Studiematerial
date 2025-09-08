# 📊 Betygsräknare

## Beskrivning av övningen

Skapa en betygsräknare som kan konvertera mellan olika betygsystem och beräkna genomsnitt. Detta är en praktisk tillämpning av metoder som arbetar med villkor och beräkningar.

## Uppgift

Skapa metoder som utför följande operationer:
1. Konvertera poäng (0-100) till bokstavsbetyg (A, B, C, D, F)
2. Konvertera bokstavsbetyg till numeriskt värde (A=4, B=3, C=2, D=1, F=0)
3. Beräkna genomsnittligt betyg från en lista av poäng
4. Avgör om en student har klarat kursen (genomsnitt >= 60%)

**Betygssystem:**
- A: 90-100 poäng (4.0)
- B: 80-89 poäng (3.0)  
- C: 70-79 poäng (2.0)
- D: 60-69 poäng (1.0)
- F: 0-59 poäng (0.0)

## Kodmall

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] scores = { 85, 92, 78, 67, 94, 58, 73 };
        
        Console.WriteLine("Studentens poäng och betyg:");
        foreach (int score in scores)
        {
            char grade = ScoreToGrade(score);
            Console.WriteLine($"{score} poäng = {grade} betyg ({GradeToGPA(grade)} GPA)");
        }
        
        double average = CalculateAverage(scores);
        Console.WriteLine($"\nGenomsnittlig poäng: {average:F1}");
        Console.WriteLine($"Genomsnittligt betyg: {ScoreToGrade((int)average)}");
        Console.WriteLine($"Har klarat kursen: {HasPassed(average)}");
    }
    
    public static char ScoreToGrade(int score)
    {
        // Implementera konvertering från poäng till betyg
    }
    
    public static double GradeToGPA(char grade)
    {
        // Implementera konvertering från betyg till GPA
    }
    
    public static double CalculateAverage(int[] scores)
    {
        // Implementera genomsnittsberäkning
    }
    
    public static bool HasPassed(double average)
    {
        // Implementera kontroll om studenten klarat kursen
    }
}
```

#### Förväntad output

```
Studentens poäng och betyg:
85 poäng = B betyg (3 GPA)
92 poäng = A betyg (4 GPA)
78 poäng = C betyg (2 GPA)
67 poäng = D betyg (1 GPA)
94 poäng = A betyg (4 GPA)
58 poäng = F betyg (0 GPA)
73 poäng = C betyg (2 GPA)

Genomsnittlig poäng: 78.1
Genomsnittligt betyg: C
Har klarat kursen: True
```

#### Facit

<details><summary>Klicka här för att se facit</summary>

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] scores = { 85, 92, 78, 67, 94, 58, 73 };
        
        Console.WriteLine("Studentens poäng och betyg:");
        foreach (int score in scores)
        {
            char grade = ScoreToGrade(score);
            Console.WriteLine($"{score} poäng = {grade} betyg ({GradeToGPA(grade)} GPA)");
        }
        
        double average = CalculateAverage(scores);
        Console.WriteLine($"\nGenomsnittlig poäng: {average:F1}");
        Console.WriteLine($"Genomsnittligt betyg: {ScoreToGrade((int)average)}");
        Console.WriteLine($"Har klarat kursen: {HasPassed(average)}");
    }
    
    public static char ScoreToGrade(int score)
    {
        if (score >= 90)
            return 'A';
        else if (score >= 80)
            return 'B';
        else if (score >= 70)
            return 'C';
        else if (score >= 60)
            return 'D';
        else
            return 'F';
    }
    
    public static double GradeToGPA(char grade)
    {
        switch (grade)
        {
            case 'A':
                return 4.0;
            case 'B':
                return 3.0;
            case 'C':
                return 2.0;
            case 'D':
                return 1.0;
            case 'F':
                return 0.0;
            default:
                throw new ArgumentException("Ogiltigt betyg");
        }
    }
    
    public static double CalculateAverage(int[] scores)
    {
        if (scores == null || scores.Length == 0)
            return 0;
        
        int sum = 0;
        foreach (int score in scores)
        {
            sum += score;
        }
        return (double)sum / scores.Length;
    }
    
    public static bool HasPassed(double average)
    {
        return average >= 60.0;
    }
}
```

</details>
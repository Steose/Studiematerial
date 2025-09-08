# Frodo och Metoderna i Det Stora Äventyret

## 🎯 Mål med övningen

Lär dig grunderna i metoder, hur man definierar parametrar och returnerar värden med hjälp av C#.

## 🧩 Äventyrsbeskrivning

Det är en mörk och stormig kväll i det lugna Shire. Frodo Baggins har fått i uppdrag att hjälpa sina vänner att förbereda sig inför en stor fest som firar deras senaste äventyr. Men ett problem uppstår! De har glömt att förbereda en speciell maträtt som måste tillagas innan gästerna anländer. Frodo måste använda sina programmeringskunskaper för att räkna ut ingredienserna som behövs. Kan han lösa detta mysterium med metoder?

## 🚀 Kom igång: Förberedelse av Festmåltiden

```csharp
using System;

namespace MiddleEarth
{
    class FestMaltid
    {
        // Huvudmetoden som körs
        static void Main(string[] args)
        {
            // Ingredienser för varje person
            int antalPersoner = 5;

            // Räkna ut mängden potatisar som behövs
            // Vi kommer att anropa vår metod här
            CalculatePotatoes(antalPersoner);
        }

        // Denna metod tar in antal personer som parameter
        static void CalculatePotatoes(int numberOfPeople)
        {
            // Skapa en variabel för Potatisar per person
            // Beräkna totalt antal potatisar för alla personer
            // Visa resultatet
            Console.WriteLine($"För {numberOfPeople} personer behövs {totalPotatoes} potatisar.");
        }
    }
}
```

<details>
<summary>💡 Tips för CalculatePotatoes-metoden</summary>

```csharp
        // Denna metod tar in antal personer som parameter
        static void CalculatePotatoes(int numberOfPeople)
        {
            int potatoesPerPerson = 3; // Fast mängd för potatisar
            int totalPotatoes = numberOfPeople * potatoesPerPerson;

            Console.WriteLine($"För {numberOfPeople} personer behövs {totalPotatoes} potatisar.");
        }
```

</details>

## ✅ Förväntat resultat

För 5 personer behövs 15 potatisar.

## 💡 Lärdomar

I den här övningen lärde du dig hur man definierar och använder metoder med parametrar i C#. Du har också sett hur man kan räkna ut något praktiskt med hjälp av programmering, vilket kan tillämpas i verkliga situationer, såsom matlagning inför olika evenemang. Genom att använda metoder kan vi strukturera vår kod och göra den mer förståelig och återanvändbar.

Genom att följa Frodo på hans äventyr i Shire lärde vi oss att metoder är våra vänner i kodning! Hängde du med? Nu är det dags att testa dina kunskaper!

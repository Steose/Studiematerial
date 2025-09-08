# Restaurang-menyn: Vad kan jag äta?

## Bakgrund

Du jobbar som servitör på en fin restaurang. En gäst kommer in och säger: *"Jag är allergisk mot gluten och fisk - vad kan jag äta från er meny?"*

Du måste snabbt kontrollera **alla rätter** med **loopar** och **if-satser** för att hitta säkra alternativ!

## Dagens meny (5 rätter)

1. **Lasagne** - Innehåller: gluten, laktos
2. **Caesar Sallad** - Innehåller: laktos
3. **Sushi** - Innehåller: fisk
4. **Grillad Kyckling** - Innehåller: inget speciellt
5. **Pasta Carbonara** - Innehåller: gluten, laktos

## Vanliga allergier

- **Gluten** (i bröd, pasta)
- **Laktos** (i mjölkprodukter)
- **Fisk** (i sushi, fiskretten)

## Uppgift

Skriv ett program som:

1. Spara rätterna och deras allergener i **parallella arrayer**
2. Låt användaren välja sin allergi
3. Använd en **for-loop** för att hitta säkra rätter
4. Skriv ut **alla rätter som går att äta**

## Startkod

```csharp
using System;

class Program
{
    static void Main()
    {
        // --- Dagens meny (parallella arrayer) ---
        string[] dishes    = { "Lasagne"        , "Caesar Sallad" , "Sushi" , "Grillad Kyckling", "Pasta Carbonara" };
        bool[]   hasGluten = { true             , false           , false   , false             , true              };
        bool[]   hasLactose= { true             , true            , false   , false             , true              };
        bool[]   hasFish   = { false            , false           , true    , false             , false             };


        Console.WriteLine("🍽️  RESTAURANG ALLERGI-KONTROLL");
        Console.WriteLine("=================================");
        Console.WriteLine("Dagens meny:");

        // Visa alla rätter först
        for (int i = 0; i < dishes.Length; i++)
        {
            Console.WriteLine($"{i+1}. {dishes[i]}");
        }

        // Välj allergi (för enkelhetens skull hårdkodat)
        string allergy = "gluten"; // Du kan ändra till "lactose" eller "fish"

        Console.WriteLine($"\n🚫 Gästen är allergisk mot: {allergy}");
        Console.WriteLine("\nSäkra alternativ:");

        // Din kod här - använd en for-loop!

    }
}
```

**Vad ska din loop göra?**
1. För varje rätt: kontrollera om den innehåller allergen
2. Om den är säker: skriv ut rätten
3. Räkna hur många alternativ som finns

## Exempel på utskrift

```
🍽️  RESTAURANG ALLERGI-KONTROLL
=================================
Dagens meny:
1. Lasagne
2. Caesar Sallad
3. Sushi
4. Grillad Kyckling
5. Pasta Carbonara

🚫 Gästen är allergisk mot: gluten

Säkra alternativ:
✅ Caesar Sallad
✅ Sushi
✅ Grillad Kyckling

Resultat: 3 rätter att välja mellan!
```

## Experiment att testa

* **Andra allergier**: Ändra `allergy` till "lactose" eller "fish"
* **Flera allergier**: Vad händer om gästen har både gluten- och laktosallergi?
* **Inga alternativ**: Lägg till fler allergener så att inga rätter blir säkra

<details>
<summary>💡 Lösning</summary>

```csharp
using System;

class Program
{
    static void Main()
    {
        // --- Dagens meny (parallella arrayer) ---
        string[] dishes     = { "Lasagne"        , "Caesar Sallad" , "Sushi" , "Grillad Kyckling", "Pasta Carbonara" };
        bool[]   hasGluten  = { true             , false           , false   , false             , true              };
        bool[]   hasLactose = { true             , true            , false   , false             , true              };
        bool[]   hasFish    = { false            , false           , true    , false             , false             };


        Console.WriteLine("🍽️  RESTAURANG ALLERGI-KONTROLL");
        Console.WriteLine("=================================");
        Console.WriteLine("Dagens meny:");

        // Visa alla rätter först
        for (int i = 0; i < dishes.Length; i++)
        {
            Console.WriteLine($"{i+1}. {dishes[i]}");
        }

        // Välj allergi
        string allergy = "gluten";

        Console.WriteLine($"\n🚫 Gästen är allergisk mot: {allergy}");
        Console.WriteLine("\nSäkra alternativ:");

        int safeCount = 0;

        for (int i = 0; i < dishes.Length; i++)
        {
            bool isSafe = true;

            // Kontrollera allergier
            if (allergy == "gluten" && hasGluten[i])
                isSafe = false;
            else if (allergy == "lactose" && hasLactose[i])
                isSafe = false;
            else if (allergy == "fish" && hasFish[i])
                isSafe = false;

            if (isSafe)
            {
                Console.WriteLine($"✅ {dishes[i]}");
                safeCount++;
            }
        }

        Console.WriteLine($"\nResultat: {safeCount} rätter att välja mellan!");

        if (safeCount == 0)
            Console.WriteLine("😞 Tyvärr inga säkra alternativ idag...");
    }
}
```

**Vad händer när du kör?** Med glutenallergi får du 3 alternativ!

</details>

## Bonusuppgifter

<details>
<summary>🚀 Utökad version med flera allergier</summary>

```csharp
// Lägg till efter allergy:
bool hasGlutenAllergy = true;
bool hasLactoseAllergy = false;
bool hasFishAllergy = true;

// I loopen:
bool isSafe = true;
if (hasGlutenAllergy && hasGluten[i]) isSafe = false;
if (hasLactoseAllergy && hasLactose[i]) isSafe = false;
if (hasFishAllergy && hasFish[i]) isSafe = false;
```

</details>

<details>
<summary>🔍 Detaljerad version med ingredienslista</summary>

```csharp
// Visa exakt vad som finns i varje rätt:
string[] ingredients = { "pasta,kött,ost", "sallad,dressing,parmesan", "ris,fisk,nori", "kyckling,kryddor", "pasta,ägg,bacon,ost" };

// I loopen när du visar säkra rätter:
Console.WriteLine($"✅ {dishes[i]} (innehåller: {ingredients[i]})");
```

</details>

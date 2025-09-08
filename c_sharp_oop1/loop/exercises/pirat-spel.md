# Piratspelet: Hitta Captain Hooks skatt!

## Bakgrund

Ahoy! Du har hittat Captain Hooks hemliga ö-karta! På ön finns **6 platser** där skatten kan vara gömd. Men var försiktig - Captain Hook har placerat **farliga fällor** på några platser för att skydda sitt guld!

Detta är ett **interaktivt spel** där DU får välja vilka platser du vill undersöka. Använd **loopar**, **if-satser** och **input** för att hitta skatten!

## Piratön

```
    🏝️ CAPTAIN HOOKS Ö 🏝️
    
    [1] Palmträd    [2] Klippa
    
    [3] Strand      [4] Grotta  
    
    [5] Vattenfal   [6] Ruiner
```

**Vad kan finnas på platserna:**
- 💰 **Skatt** (Captain Hooks guld!)
- 💀 **Fälla** (giftpilar, fallgropar, spöken...)
- 🔍 **Tom plats** (inget här, fortsätt leta!)

## Uppgift

Skriv ett program som:

1. Spara vad som finns på varje plats i **parallella arrayer**
2. Låt användaren **välja** vilken plats att undersöka (1-6)
3. Använd **if-satser** för att kolla vad som händer
4. **Loopa** tills användaren hittar skatten ELLER råkar ut för en fälla
5. Räkna hur många platser de undersökte

## Startkod

```csharp
using System;

class Program
{
    static void Main()
    {
        // --- Piratöns innehåll ---
        string[] placeNames = { "Palmträd", "Klippa", "Strand", "Grotta", "Vattenfal", "Ruiner" };
        string[] contents = { "empty", "trap", "empty", "treasure", "trap", "empty" };
        string[] trapTypes = { "", "Giftpilar", "", "", "Fallgrop", "" };
        bool[] hasBeenSearched = { false, false, false, false, false, false };
        
        Console.WriteLine("🏴‍☠️ PIRATSPELET: Captain Hooks Skatt 🏴‍☠️");
        Console.WriteLine("===========================================");
        Console.WriteLine("Du har landat på Captain Hooks hemliga ö!");
        Console.WriteLine("Skatten är gömd någonstans... men var?\n");
        
        Console.WriteLine("🏝️ Platser att undersöka:");
        Console.WriteLine("[1] Palmträd    [2] Klippa");
        Console.WriteLine("[3] Strand      [4] Grotta");  
        Console.WriteLine("[5] Vattenfal   [6] Ruiner\n");
        
        // Din kod här - använd while-loop och input!
        
    }
}
```

**Vad ska ditt spel göra?**
1. Fråga användaren: "Vilken plats vill du undersöka? (1-6): "
2. Kontrollera vad som finns på den platsen
3. Om **treasure**: "Du hittade skatten! 💰" → spelet slut
4. Om **trap**: "Du föll i en fälla! 💀" → spelet slut  
5. Om **empty**: "Inget här, fortsätt leta! 🔍" → fortsätt spela
6. Markera platsen som undersökt

## Exempel på spelomgång

```
🏴‍☠️ PIRATSPELET: Captain Hooks Skatt 🏴‍☠️
===========================================
Du har landat på Captain Hooks hemliga ö!
Skatten är gömd någonstans... men var?

🏝️ Platser att undersöka:
[1] Palmträd    [2] Klippa
[3] Strand      [4] Grotta
[5] Vattenfal   [6] Ruiner

Vilken plats vill du undersöka? (1-6): 1
🔍 Du undersöker Palmträdet... Inget här! Fortsätt leta!

Vilken plats vill du undersöka? (1-6): 3  
🔍 Du gräver i Stranden... Tom! Prova en annan plats!

Vilken plats vill du undersöka? (1-6): 4
💰 JACKPOT! Du hittade Captain Hooks skatt i Grottan!

🎉 GRATTIS! Du vann spelet!
📊 Du undersökte 3 platser innan du hittade skatten.
⚠️ Du undvek 2 farliga fällor!
```

<details>
<summary>💡 Lösning</summary>

```csharp
using System;

class Program
{
    static void Main()
    {
        // --- Piratöns innehåll ---
        string[] placeNames = { "Palmträd", "Klippa", "Strand", "Grotta", "Vattenfal", "Ruiner" };
        string[] contents = { "empty", "trap", "empty", "treasure", "trap", "empty" };
        string[] trapTypes = { "", "Giftpilar", "", "", "Fallgrop", "" };
        bool[] hasBeenSearched = { false, false, false, false, false, false };
        
        Console.WriteLine("🏴‍☠️ PIRATSPELET: Captain Hooks Skatt 🏴‍☠️");
        Console.WriteLine("===========================================");
        Console.WriteLine("Du har landat på Captain Hooks hemliga ö!");
        Console.WriteLine("Skatten är gömd någonstans... men var?\n");
        
        Console.WriteLine("🏝️ Platser att undersöka:");
        Console.WriteLine("[1] Palmträd    [2] Klippa");
        Console.WriteLine("[3] Strand      [4] Grotta");  
        Console.WriteLine("[5] Vattenfal   [6] Ruiner\n");
        
        int searchCount = 0;
        bool gameOver = false;
        bool foundTreasure = false;
        
        while (!gameOver)
        {
            Console.Write("Vilken plats vill du undersöka? (1-6): ");
            string input = Console.ReadLine();
            
            // Konvertera input till array-index (1-6 blir 0-5)
            if (int.TryParse(input, out int choice) && choice >= 1 && choice <= 6)
            {
                int index = choice - 1;
                
                // Kontrollera om platsen redan undersökts
                if (hasBeenSearched[index])
                {
                    Console.WriteLine($"❌ Du har redan undersökt {placeNames[index]}! Prova en annan plats.\n");
                    continue;
                }
                
                // Markera som undersökt och räkna
                hasBeenSearched[index] = true;
                searchCount++;
                
                Console.WriteLine($"🔍 Du undersöker {placeNames[index]}...");
                
                // Kolla vad som finns där
                if (contents[index] == "treasure")
                {
                    Console.WriteLine("💰 JACKPOT! Du hittade Captain Hooks skatt!");
                    foundTreasure = true;
                    gameOver = true;
                }
                else if (contents[index] == "trap")
                {
                    Console.WriteLine($"💀 AJAJ! Du föll i en fälla: {trapTypes[index]}!");
                    Console.WriteLine("💀 Spelet över - du blev piratmat!");
                    gameOver = true;
                }
                else
                {
                    Console.WriteLine("🔍 Inget här! Fortsätt leta!\n");
                }
            }
            else
            {
                Console.WriteLine("❌ Ogiltigt val! Skriv en siffra mellan 1-6.\n");
            }
        }
        
        // Visa resultat
        Console.WriteLine("\n" + new string('=', 40));
        if (foundTreasure)
        {
            Console.WriteLine("🎉 GRATTIS! Du vann spelet!");
            Console.WriteLine($"📊 Du undersökte {searchCount} platser innan du hittade skatten.");
            
            // Räkna hur många fällor de undvek
            int trapsAvoided = 0;
            for (int i = 0; i < contents.Length; i++)
            {
                if (contents[i] == "trap" && !hasBeenSearched[i])
                    trapsAvoided++;
            }
            Console.WriteLine($"⚠️ Du undvek {trapsAvoided} farliga fällor!");
        }
        else
        {
            Console.WriteLine("💀 Spelet över! Bättre lycka nästa gång!");
            Console.WriteLine($"📊 Du undersökte {searchCount} platser.");
        }
    }
}
```

**Spelet blir annorlunda varje gång du spelar!** Prova olika strategier.

</details>

## Experiment att testa

* **Flytta skatten**: Ändra "treasure" till en annan plats
* **Fler fällor**: Lägg till fler "trap" platser  
* **Fler platser**: Utöka till 8 eller 10 platser
* **Poäng-system**: Ge poäng baserat på hur snabbt man hittar skatten

## Bonusuppgifter

<details>
<summary>🎲 Random skatt-placering</summary>

```csharp
// Lägg till längst upp:
Random random = new Random();
int treasureLocation = random.Next(0, placeNames.Length);

// Sätt skatten på slumpmässig plats:
for (int i = 0; i < contents.Length; i++)
{
    if (i == treasureLocation)
        contents[i] = "treasure";
    else if (contents[i] == "treasure") 
        contents[i] = "empty";
}

Console.WriteLine($"🎲 Skatten har blandats om! Nu är den på en ny plats...\n");
```

</details>

<details>
<summary>🗺️ Visa karta med undersökta platser</summary>

```csharp
// Lägg till efter varje val:
Console.WriteLine("\n📋 Status:");
for (int i = 0; i < placeNames.Length; i++)
{
    if (hasBeenSearched[i])
        Console.WriteLine($"✅ {i+1}. {placeNames[i]} - Undersökt");
    else  
        Console.WriteLine($"❓ {i+1}. {placeNames[i]} - Ej undersökt");
}
Console.WriteLine();
```

</details>

<details>
<summary>⏱️ Tidsbegränsning</summary>

```csharp
// Lägg till efter searchCount:
int maxSearches = 4; // Max 4 försök

if (searchCount >= maxSearches && !foundTreasure)
{
    Console.WriteLine("⏰ Tiden är ute! Captain Hook kom tillbaka!");
    gameOver = true;
}
```

</details>
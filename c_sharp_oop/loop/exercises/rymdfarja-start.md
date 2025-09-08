# Rymdfärja-start: Kan vi lyfta?

## Bakgrund

Du är kontrollingenjör på NASA och ansvarar för att kontrollera rymdfärjan innan start. Rymdfärjan har **5 kontrollpaneler** som alla måste visa **grön lampa** för att starten ska vara säker.

Men vissa lampor blinkar rött ibland...

Din uppgift: Kontrollera **alla paneler** med en **loop** och **if-satser** för att se om vi kan starta!

## Kontrollpanelerna

1. **Motor Panel**
2. **Bränsle Panel**
3. **Navigation Panel**
4. **Kommunikation Panel**
5. **Livssupport Panel**

## Uppgift

Skriv ett program som:

1. Spara panelernas status i en array: `string[] panels`
2. Använd en **for-loop** för att kontrollera alla paneler
3. Om **alla** är "green" → skriv "✅ KLAR FÖR START!"
4. Om **någon** är "red" → skriv "❌ STOPP! Panel X visar rött"

## Startkod

```csharp
using System;

class Program
{
    static void Main()
    {
        // --- Kontrollpaneler ---
        string[] panelNames  = { "Motor"       , "Bränsle" , "Navigation" , "Kommunikation" , "Livssupport" };
        string[] panelStatus = { "green"       , "green"   , "red"        , "green"         , "green"       };


        Console.WriteLine("🚀 RYMDFÄRJA STARTKONTROLL");
        Console.WriteLine("===========================");

        // Din kod här - använd en for-loop!

    }
}
```

**Vad ska din loop göra?**
1. För varje panel: kontrollera om `panelStatus[i] == "green"`
2. Om någon är "red": skriv vilken panel som är fel
3. Räkna hur många som är OK

## Exempel på utskrift

```
🚀 RYMDFÄRJA STARTKONTROLL
===========================
✅ Motor: OK
✅ Bränsle: OK
❌ Navigation: PROBLEM UPPTÄCKT!
✅ Kommunikation: OK
✅ Livssupport: OK

RESULTAT: 4/5 paneler OK
❌ STOPP! Kan inte starta - åtgärda Navigation först!
```

## Experiment att testa

* **Alla gröna**: Ändra "red" till "green" och se vad som händer
* **Flera fel**: Ändra fler paneler till "red"
* **Okänt status**: Vad händer om en panel säger "yellow"?

<details>
<summary>💡 Lösning</summary>

```csharp
using System;

class Program
{
    static void Main()
    {
        // --- Kontrollpaneler ---
        string[] panelNames  = { "Motor"        , "Bränsle" , "Navigation" , "Kommunikation" , "Livssupport" };
        string[] panelStatus = { "green"        , "green"   , "red"        , "green"         , "green"       };


        Console.WriteLine("🚀 RYMDFÄRJA STARTKONTROLL");
        Console.WriteLine("===========================");

        int okCount = 0;
        bool canLaunch = true;

        for (int i = 0; i < panelNames.Length; i++)
        {
            if (panelStatus[i] == "green")
            {
                Console.WriteLine($"✅ {panelNames[i]}: OK");
                okCount++;
            }
            else
            {
                Console.WriteLine($"❌ {panelNames[i]}: PROBLEM UPPTÄCKT!");
                canLaunch = false;
            }
        }

        Console.WriteLine($"\nRESULTAT: {okCount}/{panelNames.Length} paneler OK");

        if (canLaunch)
            Console.WriteLine("🚀 KLAR FÖR START!");
        else
            Console.WriteLine("❌ STOPP! Åtgärda problem innan start!");
    }
}
```

**Vad händer när du kör?** Navigation visar rött så du får stoppsignal!

</details>

## Bonusuppgifter

<details>
<summary>🚀 Utökad version med prioriteter</summary>

```csharp
// Lägg till efter panelStatus:
int[] priority = { 1, 1, 2, 3, 1 }; // 1=kritisk, 2=viktig, 3=mindre viktig

// I loopen:
if (panelStatus[i] != "green")
{
    if (priority[i] == 1)
        Console.WriteLine($"🔥 KRITISKT: {panelNames[i]} måste fixas!");
    else
        Console.WriteLine($"⚠️ {panelNames[i]}: Problem detekterat");
}
```

</details>

<details>
<summary>🔧 Interactive version</summary>

```csharp
// Lägg till efter huvudloopen:
if (!canLaunch)
{
    Console.WriteLine("\nVill du försöka åtgärda problemen? (j/n)");
    // Här kan man lägga till input och ändra panel-status
}
```

</details>

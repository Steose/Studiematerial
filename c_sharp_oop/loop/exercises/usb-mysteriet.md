# Mini-mysteriet: Vem tog USB-minnet?

## Bakgrund

Ett USB-minne med viktiga kursnycklar har försvunnit från Campus Mölndal. Polisen har gripit **tre personer** som sågs i närheten vid tidpunkten för stölden. Vittnen har gett **enkla ledtrådar** som kan hjälpa till att identifiera den skyldige.

Din uppgift: använd **loopar** och **if-satser** för att filtrera fram den/de som matchar **alla** ledtrådar.

## Misstänkta personer

* **Anna** — kvinna, rött hår, blå väst, glasögon
* **Ben** — man, brunt hår, grön väst, inga glasögon
* **Carla** — kvinna, svart hår, grön väst, glasögon

## Vittnesmål (ledtrådar)

* Förövaren hade **rött hår**
* En **kvinna** sågs springa ut från byggnaden
* Förövaren bar **inte** grön väst
* Vittne såg att personen hade **glasögon**

## Uppgift

Din kod ska:

1. Spara de misstänkta i **parallella arrayer** (name[], isFemale[], hair[], vest[], glasses[])
```csharp
// extremt förenklad och övertydlig version av parallella arrayer
int suspectsCount = 3;
string[] names    = new string[suspectsCount];
bool[]   isFemale = new bool[suspectsCount];
string[] hair     = new string[suspectsCount];
string[] vest     = new string[suspectsCount];
bool[]   glasses  = new bool[suspectsCount];
```


2. Spara ledtrådarna i **enkla variabler**: `requiredHair`, `requireFemale`, `forbidGreenVest`, `requireGlasses`
```csharp
// Fortfarande extremt överdriven övertydlighet (du kan göra det mer kompakt)
int annaIndex = 0;
names[annaIndex]      = "Anna";
isFemale[annaIndex]   = true;
hair[annaIndex]       = "red";
vest[annaIndex]       = "blue";
glasses[annaIndex]    = true;

int benIndex = 1;
//osv
```
3. Använd en **for-loop** som går igenom alla personer och kollar **alla** villkor med `if`-satser
```csharp
for (int i = 0; i < names.Length; i++)
{
    // Kolla alla villkor här med if-satser
}
```

4. Skriv ut namnen på de som matchar **alla** villkor

5. Om ingen matchar: skriv "Inga misstänkta matchar alla ledtrådar"

### Regler
- Använd **endast** arrayer + loopar + if/else
- Inga LINQ, inga listor, inga avancerade funktioner
- Håll koden enkel och lättläst

## Startkod

```csharp
using System;

class Program
{
    static void Main()
    {
        // --- Misstänkta (parallella arrayer) ---
        string[] names    = { "Anna" , "Ben"   , "Carla" };
        bool[]   isFemale = {  true  , false   ,  true   };
        string[] hair     = { "red"  , "brown" , "black" };
        string[] vest     = { "blue" , "green" , "green" };
        bool[]   glasses  = {  true  , false   ,  true   };


        // --- Ledtrådar ---
        string requiredHair   = "red";
        bool   requireFemale  = true;
        bool   forbidGreenVest = true;
        bool   requireGlasses = true;

        // Din kod här!

    }
}
```

## Experiment för dig att testa

När du är klar med grunduppgiften, testa följande:

* **Ändra ledtrådar**: Sätt `forbidGreenVest` till `false`. Vem matchar nu? Varför?
* **Bytt hårfärg**: Ändra `requiredHair` till `"black"`. Hur många kandidater får du?
* **Lägg till ny ledtråd**: Skapa `forbidBlueVest` och lägg till logik för "inte blå väst"
* **Räknare per person**: Skapa en `int hits = 0;` per person och räkna träffar. Visa "X/4 ledtrådar" för varje
* **Meny-system**: Använd en while-loop för att låta användaren slå av/på olika ledtrådar

<details>
<summary>💡 Förslag till Lösning</summary>

```csharp
using System;

class Program
{
    static void Main()
    {
        // --- Misstänkta (parallella arrayer) ---
        string[] names    = { "Anna" , "Ben"   , "Carla" };
        bool[]   isFemale = {  true  , false   ,  true   };
        string[] hair     = { "red"  , "brown" , "black" };
        string[] vest     = { "blue" , "green" , "green" };
        bool[]   glasses  = {  true  , false   ,  true   };


        // --- Ledtrådar ---
        string requiredHair   = "red";
        bool   requireFemale  = true;
        bool   forbidGreenVest = true;
        bool   requireGlasses = true;

        bool foundAny = false;

        Console.WriteLine("Misstänkta som matchar alla ledtrådar:");

        for (int i = 0; i < names.Length; i++)
        {
            bool matches = true;

            // Kontrollera hårfärg
            if (hair[i] != requiredHair)
                matches = false;

            // Kontrollera om det måste vara kvinna
            if (requireFemale && !isFemale[i])
                matches = false;

            // Kontrollera om grön väst är förbjuden
            if (forbidGreenVest && vest[i] == "green")
                matches = false;

            // Kontrollera glasögon
            if (requireGlasses && !glasses[i])
                matches = false;

            // Om alla villkor stämmer, skriv ut namnet
            if (matches)
            {
                foundAny = true;
                Console.WriteLine($"- {names[i]}");
            }
        }

        if (!foundAny)
            Console.WriteLine("Inga misstänkta matchar alla ledtrådar");
    }
}
```

**Förväntad utdata:**
```
Misstänkta som matchar alla ledtrådar:
- Anna
```

**Förklaring:** Anna är den enda som har rött hår, är kvinna, har inte grön väst (hon har blå), och bär glasögon.

</details>

## Bonusuppgifter

<details>
<summary>🚀 Avancerad version med kompakt if-sats</summary>

```csharp
// Byt ut de fyra if-satserna mot en kompakt if:
bool matches =
    hair[i] == requiredHair &&
    (!requireFemale || isFemale[i]) &&
    (!forbidGreenVest || vest[i] != "green") &&
    (!requireGlasses || glasses[i]);
```

</details>

<details>
<summary>🔍 Utökad version med träff-räknare</summary>

```csharp
// Lägg till efter for-loopen:
Console.WriteLine("\nDetaljerad analys:");
for (int i = 0; i < names.Length; i++)
{
    int hits = 0;

    if (hair[i] == requiredHair) hits++;
    if (!requireFemale || isFemale[i]) hits++;
    if (!forbidGreenVest || vest[i] != "green") hits++;
    if (!requireGlasses || glasses[i]) hits++;

    Console.WriteLine($"{names[i]}: {hits}/4 ledtrådar");
}
```

</details>

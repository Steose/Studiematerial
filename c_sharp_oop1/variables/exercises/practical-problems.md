# Praktiska Problem med Variabler 🧮

Välkommen till den riktiga världen av programmering! Här löser vi vardagsproblem med kod. Från pizza-budgetar till Star Wars-äventyr! 🍕⭐

## 🎯 Vad kommer du att lära dig?

- Använda variabler för att lösa verkliga problem
- Göra beräkningar med olika datatyper
- Kombinera matematik med logik
- Ha kul medan du lär dig! 🎉

## 🚌 Övning 2: Kollektivtrafik-kalkylen (Praktisk matematik)

**Problem:** Ska du köpa månadskort eller betala per resa? Låt matematiken bestämma!

**Tips** Kolla på [Västtragik](https://www.vasttrafik.se/biljetter/)s hemsida för att få fram riktiga prisuppgifter.
```csharp
// Transport-ekonomi
double tripPrice = 87.0;        // Pris per resa (tur och retur)
int monthlyCard = 1230;         // Månadskort kostnad
int schoolDaysPerWeek = 2;      // Dagar på campus
int weeksPerMonth = 4;          // Veckor per månad

// Beräkna total reskostnad utan kort
int totalTripsPerMonth = schoolDaysPerWeek * weeksPerMonth;
double monthlyTripCost = totalTripsPerMonth * tripPrice;

// Spara pengar?
double savings = monthlyTripCost - monthlyCard;

Console.WriteLine("=== KOLLEKTIVTRAFIK-KALKYLEN ===");
Console.WriteLine($"Resor per månad: {totalTripsPerMonth}");
Console.WriteLine($"Kostnad utan kort: {monthlyTripCost} kr");
Console.WriteLine($"Kostnad med månadskort: {monthlyCard} kr");

if (savings > 0)
{
    Console.WriteLine($"✅ Spara {savings} kr med månadskort!");
}
else
{
    Console.WriteLine($"❌ Betala per resa, spara {Math.Abs(savings)} kr");
}
```

**Din uppgift:**
1. Testa med 3 dagar per vecka istället
2. Lägg till helgresa (50% av vanligt pris)
3. Jämför med årskort (9800 kr)

## 🎮 Övning 4: Spelkaraktär-statistik (RPG-matematik)

**Problem:** Du skapar en RPG-karaktär. Fördela poäng mellan olika egenskaper!

```csharp
// RPG Karaktär-skapare
string characterName = "Gandalf den Grå";
int totalStatPoints = 100;    // Totala poäng att fördela

// Fördelning av egenskaper
int strength = 20;      // Styrka
int intelligence = 35;  // Intelligens
int agility = 25;      // Smidighet
int vitality = 20;     // Vitalitet

// Beräkna totalt använda poäng
int usedPoints = strength + intelligence + agility + vitality;
int remainingPoints = totalStatPoints - usedPoints;

// Beräkna sekundära stats
double healthPoints = vitality * 10 + strength * 2;
double manaPoints = intelligence * 15;
double attackDamage = strength * 1.5 + agility * 0.8;
double criticalChance = agility * 0.3;

Console.WriteLine($"=== KARAKTÄR: {characterName.ToUpper()} ===");
Console.WriteLine($"💪 Styrka: {strength}");
Console.WriteLine($"🧠 Intelligens: {intelligence}");
Console.WriteLine($"🏃 Smidighet: {agility}");
Console.WriteLine($"❤️  Vitalitet: {vitality}");
Console.WriteLine($"📊 Använda poäng: {usedPoints}/{totalStatPoints}");
Console.WriteLine($"⭐ Kvarvarande poäng: {remainingPoints}");
Console.WriteLine();
Console.WriteLine("=== BERÄKNADE VÄRDEN ===");
Console.WriteLine($"🩸 Hälsopoäng: {healthPoints}");
Console.WriteLine($"🔵 Manapoäng: {manaPoints}");
Console.WriteLine($"⚔️  Attackskada: {attackDamage:F1}");
Console.WriteLine($"💥 Kritisk chans: {criticalChance:F1}%");
```

**Din uppgift:**
1. Skapa en "Rogue"-karaktär med hög smidighet
2. Lägg till "luck"-stat som påverkar kritisk chans
3. Validera att totala poängen inte överstiger 100

## 🎲 Övning 6: Tärningsspel-sannolikhet (Matematik & logik)

**Problem:** Du spelar ett brädspel. Vilken är sannolikheten att få olika resultat med två tärningar?

```csharp
// Tärningsspel-matematik
int diceSides = 6;                    // Sexsidig tärning
int numberOfDice = 2;                 // Två tärningar
int minSum = numberOfDice;            // Minsta möjliga summa (1+1)
int maxSum = diceSides * numberOfDice; // Största möjliga summa (6+6)

// Beräkna totala möjliga kombinationer
int totalCombinations = diceSides * diceSides; // 6*6 = 36

Console.WriteLine("=== TÄRNINGSSPEL-SANNOLIKHETER ===");
Console.WriteLine($"🎲 Antal tärningar: {numberOfDice}");
Console.WriteLine($"🔢 Möjliga summor: {minSum} till {maxSum}");
Console.WriteLine($"🎯 Totala kombinationer: {totalCombinations}");
Console.WriteLine();

// Räkna sannolikheter för viktiga summor
int sevenWays = 6;      // (1,6), (2,5), (3,4), (4,3), (5,2), (6,1)
int doublesSix = 1;     // (6,6)
int snakeEyes = 1;      // (1,1)

double sevenProbability = (double)sevenWays / totalCombinations * 100;
double doublesSixProbability = (double)doublesSix / totalCombinations * 100;
double snakeEyesProbability = (double)snakeEyes / totalCombinations * 100;

Console.WriteLine("📊 VIKTIGA SANNOLIKHETER:");
Console.WriteLine($"🎯 Summa 7 (vanligaste): {sevenProbability:F1}%");
Console.WriteLine($"🔥 Dubbla sexor: {doublesSixProbability:F1}%");
Console.WriteLine($"🐍 Ormögon (1,1): {snakeEyesProbability:F1}%");

// Bonus: Beräkna genomsnittlig summa
double averageSum = (minSum + maxSum) / 2.0;
Console.WriteLine($"📈 Genomsnittlig summa: {averageSum}");
```

**Din uppgift:**
1. Beräkna sannolikheten för alla summor (2-12)
2. Simulera 1000 kast och jämför med teorin
3. Lägg till tredje tärning och se hur sannolikheterna förändras

---

## 🏆 Bonus-utmaning: Multi-problem kombination

Kombinera flera problem i en större uppgift:

```csharp
// MEGA-KALKYLATOR: Studentens månadsbudget
Console.WriteLine("=== MÅNADSBUDGET-ANALYS ===");

// Grunddata
double monthlyIncome = 12000.0;
double fixedExpenses = 6500.0;    // Hyra, försäkringar etc.
double variableExpenses = 3200.0; // Mat, transport, nöje

// Pizza-budget från övning 1
double weeklyPizzaCost = 149.50 * 2;
double monthlyPizzaCost = weeklyPizzaCost * 4;

// Transport från övning 2
double monthlyTransport = 1230.0; // Månadskort vann!

// Lägg ihop allt
double totalExpenses = fixedExpenses + variableExpenses + monthlyPizzaCost + monthlyTransport;
double remainingMoney = monthlyIncome - totalExpenses;
double savingsRate = (remainingMoney / monthlyIncome) * 100;

Console.WriteLine($"💰 Inkomst: {monthlyIncome:C}");
Console.WriteLine($"🏠 Fasta kostnader: {fixedExpenses:C}");
Console.WriteLine($"🛒 Rörliga kostnader: {variableExpenses:C}");
Console.WriteLine($"🍕 Pizza-budget: {monthlyPizzaCost:C}");
Console.WriteLine($"🚌 Transport: {monthlyTransport:C}");
Console.WriteLine($"💸 Totala utgifter: {totalExpenses:C}");
Console.WriteLine($"💾 Kvar att spara: {remainingMoney:C}");
Console.WriteLine($"📊 Sparkvot: {savingsRate:F1}%");

// Finansiell hälsokontroll
if (savingsRate >= 20)
{
    Console.WriteLine("🌟 Utmärkt sparkvot! Du har ekonomisk kontroll.");
}
else if (savingsRate >= 10)
{
    Console.WriteLine("👍 Bra sparkvot, men kan förbättras.");
}
else if (savingsRate > 0)
{
    Console.WriteLine("⚠️ Låg sparkvot. Överväg att minska utgifter.");
}
else
{
    Console.WriteLine("🚨 VARNING: Du spenderar mer än du tjänar!");
}
```

## 🎯 Sammanfattning

Du har nu löst verkliga problem med kod! Du har lärt dig att:
- ✅ Använda variabler för praktiska beräkningar
- ✅ Kombinera olika datatyper logiskt
- ✅ Göra ekonomiska kalkyler
- ✅ Lösa kreativa problem (som Star Wars-matematik!)
- ✅ Tänka som en programmerare

**Nästa steg:** Prova att modifiera övningarna med dina egna värden och scenarion!

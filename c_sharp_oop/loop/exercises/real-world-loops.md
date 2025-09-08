# Verkliga Problem med Loopar 🔄

Nu tar vi loopar till nästa nivå! Från enkla räknare till komplexa simuleringar av vardagsscenarier. Här lär du dig lösa riktiga problem med kod! 🚀

## 🎯 Vad kommer du att bemästra?

- For-loopar för exakta beräkningar
- While-loopar för okända mängder
- Nested loops för komplexa problem
- Praktisk problemlösning med kod

---

## 🎵 Övning 1: Spotify Premium - Är det värt det? (For-loop)

**Problem:** Du lyssnar på musik 2 timmar per dag. Spotify har annonser var 3:e låt utan Premium. Är Premium värt sina pengar?

```csharp
// Spotify-ekonomi
double songLength = 3.5;           // Genomsnittlig låtlängd (minuter)
double listeningHoursPerDay = 2.0; // Timmar musik per dag
int daysPerMonth = 30;             // Dagar per månad
double spotifyPremium = 109.0;     // Premium kostnad per månad
double adLength = 0.5;             // Reklamlängd (minuter)
int adFrequency = 3;               // Reklam var 3:e låt

Console.WriteLine("=== SPOTIFY PREMIUM-KALKYLEN ===");

// Beräkna totalt antal låtar per månad
double totalListeningMinutes = listeningHoursPerDay * 60 * daysPerMonth;
int totalSongs = (int)(totalListeningMinutes / songLength);

// Räkna annonser och förlorad tid
int totalAds = totalSongs / adFrequency;
double timeWastedOnAds = totalAds * adLength;

Console.WriteLine($"🎵 Totala låtar per månad: {totalSongs}");
Console.WriteLine($"📺 Antal annonser: {totalAds}");
Console.WriteLine($"⏰ Förlorad tid på annonser: {timeWastedOnAds:F1} minuter");

// Simulera månaderna
for (int month = 1; month <= 12; month++)
{
    double yearlyAdTime = timeWastedOnAds * month;
    double yearlyCostPremium = spotifyPremium * month;
    double timeValuePerHour = 150; // Vad din tid är värd (kr/timme)
    double timeWastedValue = (yearlyAdTime / 60) * timeValuePerHour;

    Console.WriteLine($"Månad {month}: Annonser = {yearlyAdTime:F0} min, Premium = {yearlyCostPremium:F0} kr");

    if (timeWastedValue > yearlyCostPremium)
    {
        Console.WriteLine($"  💡 Premium lönar sig! Sparar {timeWastedValue - yearlyCostPremium:F0} kr värde");
        break;
    }
}
```

**Din uppgift:**
1. Ändra dina lyssnarvanor (4 timmar/dag)
2. Testa olika värden på din tid (50, 100, 200 kr/timme)
3. Lägg till YouTube Premium som alternativ

---

## 🏃‍♂️ Övning 2: Tränings-motivation (While-loop)

**Problem:** Du har satt mål att springa 100km i månaden. Hur många dagar tar det med olika intensitet?

```csharp
// Löpar-simulation
double monthlyGoal = 100.0;        // Målet: 100km per månad
double currentDistance = 0.0;      // Nuvarande distans
int currentDay = 1;                // Dag i månaden
double baseSpeed = 3.0;            // Grundhastighet (km per session)
int consecutiveDays = 0;           // Dagar i rad

Console.WriteLine("=== LÖPAR-UTMANINGEN: 100KM PER MÅNAD ===");

// Random för att simulera verkliga variationer
Random random = new Random();

while (currentDistance < monthlyGoal && currentDay <= 31)
{
    // Simulera om du springer idag (80% chans)
    bool runToday = random.Next(1, 101) <= 80;

    if (runToday)
    {
        consecutiveDays++;

        // Bättre form ju fler dagar i rad
        double motivationBonus = 1.0 + (consecutiveDays * 0.1);

        // Slumpmässig variation (-20% till +50%)
        double variation = random.NextDouble() * 0.7 + 0.8; // 0.8 till 1.5

        double todayDistance = baseSpeed * motivationBonus * variation;
        currentDistance += todayDistance;

        Console.WriteLine($"Dag {currentDay}: Sprang {todayDistance:F1}km (Totalt: {currentDistance:F1}km)");

        // Extra motivation vid milstolpar
        if (currentDistance >= 25 && currentDistance < 30)
        {
            Console.WriteLine("  🎯 25km passerat! Bra jobbat!");
        }
        else if (currentDistance >= 50 && currentDistance < 55)
        {
            Console.WriteLine("  🔥 Halvvägs! Keep going!");
        }
        else if (currentDistance >= 75 && currentDistance < 80)
        {
            Console.WriteLine("  💪 75km! Målet känns nära!");
        }
    }
    else
    {
        consecutiveDays = 0; // Nollställ streak
        Console.WriteLine($"Dag {currentDay}: Vilodag (Totalt: {currentDistance:F1}km)");
    }

    currentDay++;

    // Kontrollera om målet är uppnått
    if (currentDistance >= monthlyGoal)
    {
        Console.WriteLine($"🏆 GRATTIS! Du nådde målet på dag {currentDay - 1}!");
        break;
    }
}

// Sammanfattning
if (currentDistance >= monthlyGoal)
{
    double average = currentDistance / (currentDay - 1);
    Console.WriteLine($"📊 Genomsnitt: {average:F1}km per dag");
}
else
{
    double remaining = monthlyGoal - currentDistance;
    Console.WriteLine($"😞 Målet inte uppnått. {remaining:F1}km kvar...");
}
```

**Din uppgift:**
1. Lägg till olika träningstyper (cykling, simning)
2. Simulera skador som pausar träningen
3. Beräkna kaloriförbränning baserat på distans

---

## 🏦 Övning 3: Ränta-på-ränta simulering (Nested loops)

**Problem:** Du har 10,000kr att spara. Testa olika sparstrategier över 10 år!

```csharp
// Långsiktig sparplanering
double initialAmount = 10000.0;     // Startkapital
double monthlyDeposit = 500.0;      // Månatlig insättning
int yearsToSimulate = 10;           // Simuleringsperiod

// Olika sparalternativ
double[] interestRates = { 0.5, 1.5, 3.0, 5.0, 7.0 }; // Olika räntor
string[] accountTypes = { "Sparkonto", "Blandat", "Fonder", "Aktier", "Riskfonder" };

Console.WriteLine("=== JÄMFÖRELSE AV SPARSTRATEGIER ===");
Console.WriteLine($"Startkapital: {initialAmount:C} SEK");
Console.WriteLine($"Månatlig sparande: {monthlyDeposit:C} SEK");
Console.WriteLine($"Tidsperiod: {yearsToSimulate} år\n");

// Simulera varje sparstrategi
for (int strategy = 0; strategy < interestRates.Length; strategy++)
{
    double currentAmount = initialAmount;
    double annualRate = interestRates[strategy] / 100.0;
    double monthlyRate = annualRate / 12.0;

    Console.WriteLine($"📊 {accountTypes[strategy]} ({interestRates[strategy]}% årlig ränta):");

    // Simulera år för år
    for (int year = 1; year <= yearsToSimulate; year++)
    {
        double yearStartAmount = currentAmount;

        // Simulera månad för månad
        for (int month = 1; month <= 12; month++)
        {
            // Lägg till månadsinsättning
            currentAmount += monthlyDeposit;

            // Räkna ränta på nuvarande belopp
            currentAmount += currentAmount * monthlyRate;
        }

        double yearGrowth = currentAmount - yearStartAmount - (monthlyDeposit * 12);

        // Visa resultat vart femte år + sista året
        if (year % 5 == 0 || year == yearsToSimulate)
        {
            Console.WriteLine($"  År {year}: {currentAmount:C} SEK (Räntevinst i år: {yearGrowth:C})");
        }
    }

    // Beräkna totala insättningar
    double totalDeposits = initialAmount + (monthlyDeposit * 12 * yearsToSimulate);
    double totalInterest = currentAmount - totalDeposits;
    double returnRate = (totalInterest / totalDeposits) * 100;

    Console.WriteLine($"  💰 Slutsumma: {currentAmount:C} SEK");
    Console.WriteLine($"  📈 Total räntevinst: {totalInterest:C} SEK");
    Console.WriteLine($"  📊 Avkastning: {returnRate:F1}%\n");
}
```

**Din uppgift:**
1. Lägg till inflation (2% per år)
2. Simulera oregelbundna insättningar
3. Jämför med att köpa en lägenhet istället

---

## 🎮 Övning 4: Gaming-statistik (Do-while loop)

**Problem:** Du spelar League of Legends och vill nå Gold-rank. Simulera din progress!

```csharp
// LoL Ranked Simulator
int currentLP = 1200;        // Nuvarande League Points
int goldThreshold = 1500;    // LP för Gold rank
int maxGames = 100;          // Max antal spel att simulera
int gamesPlayed = 0;
int wins = 0;
int losses = 0;
int winStreak = 0;
int longestWinStreak = 0;

Console.WriteLine("=== LEAGUE OF LEGENDS RANKED GRIND ===");
Console.WriteLine($"🎯 Mål: Nå {goldThreshold} LP (Gold rank)");
Console.WriteLine($"📊 Nuvarande LP: {currentLP}");
Console.WriteLine();

Random random = new Random();

// Simulera spel tills vi når målet eller max antal spel
do
{
    gamesPlayed++;

    // Beräkna vinst-sannolikhet baserat på form
    double baseWinRate = 0.55; // 55% grundchans att vinna
    double streakBonus = Math.Min(winStreak * 0.02, 0.15); // Max 15% bonus
    double totalWinChance = baseWinRate + streakBonus;

    bool wonGame = random.NextDouble() < totalWinChance;

    if (wonGame)
    {
        wins++;
        winStreak++;

        // LP-vinst varierar beroende på streak
        int lpGain = 15 + (winStreak > 3 ? 5 : 0); // Bonus för streak
        currentLP += lpGain;

        Console.WriteLine($"Spel {gamesPlayed}: VINST! +{lpGain} LP (Totalt: {currentLP} LP) [Streak: {winStreak}]");

        // Uppdatera längsta streak
        if (winStreak > longestWinStreak)
        {
            longestWinStreak = winStreak;
        }
    }
    else
    {
        losses++;
        winStreak = 0; // Nollställ streak

        int lpLoss = random.Next(12, 19); // Förlust mellan 12-18 LP
        currentLP -= lpLoss;

        Console.WriteLine($"Spel {gamesPlayed}: Förlust... -{lpLoss} LP (Totalt: {currentLP} LP) [Streak bruten]");
    }

    // Specialmeddelanden vid milstolpar
    if (currentLP >= 1400 && currentLP < 1410)
    {
        Console.WriteLine("  🔥 Nästan Gold! Keep pushing!");
    }
    else if (currentLP < 1100)
    {
        Console.WriteLine("  😰 Tuff period... Ta en paus?");
    }

    // Tvingad paus efter 5 förluster i rad för mental health
    if (winStreak == 0 && losses > wins + 5)
    {
        Console.WriteLine("  🛑 Mental health break... *tar paus*");
        System.Threading.Thread.Sleep(100); // Kort paus i simuleringen
    }

} while (currentLP < goldThreshold && gamesPlayed < maxGames && currentLP > 0);

// Resultat-analys
Console.WriteLine("\n=== SLUTRESULTAT ===");
if (currentLP >= goldThreshold)
{
    Console.WriteLine("🏆 GRATTIS! Du nådde Gold!");
    Console.WriteLine($"🎮 Spel för att nå målet: {gamesPlayed}");
}
else if (gamesPlayed >= maxGames)
{
    Console.WriteLine("⏰ Max antal spel nått. Fortsätt imorgon!");
}
else
{
    Console.WriteLine("😢 LP nådde 0. Season är över!");
}

// Statistik
double winRate = (double)wins / gamesPlayed * 100;
Console.WriteLine($"📊 Vinster: {wins}");
Console.WriteLine($"📊 Förluster: {losses}");
Console.WriteLine($"📊 Vinst-procent: {winRate:F1}%");
Console.WriteLine($"🔥 Längsta win-streak: {longestWinStreak}");
Console.WriteLine($"📈 LP-förändring: {currentLP - 1200}");
```

**Din uppgift:**
1. Lägg till olika spel-modi (Solo/Duo, Flex)
2. Simulera degradering vid för många förluster
3. Lägg till säsongs-reset funktionalitet

---

## 🚗 Övning 5: Bil vs Kollektivtrafik - Livstidskalkylen (Complex loops)

**Problem:** Ska du köpa bil eller fortsätta åka kollektivt? En 20-års jämförelse!

```csharp
// 20-års transport-jämförelse
Console.WriteLine("=== TRANSPORT-EKONOMI: 20-ÅRS JÄMFÖRELSE ===");

// Bil-kostnader
double carPrice = 150000.0;        // Bilpris
double carInsurance = 8000.0;      // Försäkring per år
double carService = 12000.0;       // Service per år
double fuelPerMonth = 1500.0;      // Bensin per månad
double carDepreciation = 0.15;     // 15% värdeminskning per år

// Kollektivtrafik
double yearlyTransitPass = 12000.0; // Årskort kollektivtrafik
double transitIncrease = 0.03;      // 3% ökning per år

double totalCarCost = carPrice; // Startinvestering
double totalTransitCost = 0.0;
double currentCarValue = carPrice;

for (int year = 1; year <= 20; year++)
{
    // Bil-kostnader detta år
    double yearlyCarCosts = carInsurance + carService + (fuelPerMonth * 12);

    // Värdeminskning av bil
    currentCarValue *= (1 - carDepreciation);

    // Kollektivtrafik med inflation
    double currentYearTransit = yearlyTransitPass * Math.Pow(1 + transitIncrease, year - 1);

    // Ackumulera kostnader
    totalCarCost += yearlyCarCosts;
    totalTransitCost += currentYearTransit;

    // Visa resultat vart femte år
    if (year % 5 == 0 || year == 1)
    {
        Console.WriteLine($"\nÅr {year}:");
        Console.WriteLine($"  🚗 Bil - Årskostnad: {yearlyCarCosts:C}, Bilens värde: {currentCarValue:C}");
        Console.WriteLine($"  🚌 Kollektivt - Årskostnad: {currentYearTransit:C}");
        Console.WriteLine($"  💰 Total bil-kostnad: {totalCarCost:C}");
        Console.WriteLine($"  💳 Total kollektiv-kostnad: {totalTransitCost:C}");

        double difference = totalCarCost - totalTransitCost;
        if (difference > 0)
        {
            Console.WriteLine($"  📊 Kollektivt sparar: {difference:C}");
        }
        else
        {
            Console.WriteLine($"  📊 Bil sparar: {Math.Abs(difference):C}");
        }
    }

    // Simulera bilbyte vart 8:e år
    if (year % 8 == 0 && year < 20)
    {
        double newCarCost = 180000.0; // Nya bilar blir dyrare
        totalCarCost += newCarCost - currentCarValue; // Inbyte
        currentCarValue = newCarCost;
        Console.WriteLine($"  🔄 Byte till ny bil! Nettokostnad: {newCarCost - currentCarValue:C}");
    }
}

// Slutanalys med bilens kvarvarande värde
double netCarCost = totalCarCost - currentCarValue;

Console.WriteLine("\n=== 20-ÅRS SLUTSAMMANFATTNING ===");
Console.WriteLine($"🚗 Total bil-kostnad: {totalCarCost:C}");
Console.WriteLine($"💎 Bilens slutvärde: {currentCarValue:C}");
Console.WriteLine($"💸 Netto bil-kostnad: {netCarCost:C}");
Console.WriteLine($"🚌 Total kollektiv-kostnad: {totalTransitCost:C}");

double finalDifference = netCarCost - totalTransitCost;
if (finalDifference > 0)
{
    Console.WriteLine($"🏆 KOLLEKTIVT VINNER med {finalDifference:C}!");
}
else
{
    Console.WriteLine($"🚗 BIL VINNER med {Math.Abs(finalDifference):C}!");
}

// Bonus: Beräkna miljöpåverkan
double carCO2PerYear = 2.3; // Ton CO2 per år
double transitCO2PerYear = 0.8; // Ton CO2 per år för kollektivtrafik
double totalCarCO2 = carCO2PerYear * 20;
double totalTransitCO2 = transitCO2PerYear * 20;

Console.WriteLine($"🌱 Miljöpåverkan - Bil: {totalCarCO2} ton CO2");
Console.WriteLine($"🌱 Miljöpåverkan - Kollektivt: {totalTransitCO2} ton CO2");
Console.WriteLine($"🌍 Kollektivt sparar: {totalCarCO2 - totalTransitCO2:F1} ton CO2");
```

**Din uppgift:**
1. Lägg till olika biltyper (elbil, hybrid)
2. Simulera oväntade reparationer
3. Inkludera parkeringskostnader i storstäder

---

## 🎯 Övning 6: Fantasy Football-liga (Ultimate loops)

**Problem:** Du driver en Fantasy Football-liga. Simulera en hel säsong!

```csharp
// Fantasy Football Season Simulator
Console.WriteLine("=== FANTASY FOOTBALL SÄSONG 2024 ===");

string[] teamNames = { "Marcus Legends", "Code Crushers", "Loop Warriors", "Array Avengers",
                      "Boolean Bombers", "String Slashers", "Method Monsters", "Class Champions" };
int numberOfTeams = teamNames.Length;
int regularSeasonWeeks = 14;
int playoffWeeks = 3;

// Skapa team-statistik
int[] teamWins = new int[numberOfTeams];
int[] teamLosses = new int[numberOfTeams];
double[] teamScores = new double[numberOfTeams];

Random random = new Random();

// GRUNDSERIE (14 veckor)
for (int week = 1; week <= regularSeasonWeeks; week++)
{
    Console.WriteLine($"\n🏈 VECKA {week} RESULTAT:");

    // Slumpmässiga matchups (alla möter alla under säsongen)
    for (int match = 0; match < numberOfTeams / 2; match++)
    {
        int team1 = match * 2;
        int team2 = match * 2 + 1;

        // Generera realistiska Fantasy-poäng (80-150 poäng)
        double team1Score = 80 + (random.NextDouble() * 70);
        double team2Score = 80 + (random.NextDouble() * 70);

        // Lägg till i total-poäng
        teamScores[team1] += team1Score;
        teamScores[team2] += team2Score;

        // Bestäm vinnare
        if (team1Score > team2Score)
        {
            teamWins[team1]++;
            teamLosses[team2]++;
            Console.WriteLine($"  {teamNames[team1]} {team1Score:F1} - {team2Score:F1} {teamNames[team2]} ✅");
        }
        else
        {
            teamWins[team2]++;
            teamLosses[team1]++;
            Console.WriteLine($"  {teamNames[team1]} {team1Score:F1} - {team2Score:F1} {teamNames[team2]} ✅");
        }
    }

    // Visa tabelltopp efter varje vecka
    if (week % 5 == 0 || week == regularSeasonWeeks)
    {
        Console.WriteLine($"\n📊 TABELLSTÄLLNING EFTER VECKA {week}:");

        // Sortera teams efter vinster, sedan efter total poäng
        var teamStats = new List<(int index, string name, int wins, double avgScore)>();
        for (int i = 0; i < numberOfTeams; i++)
        {
            teamStats.Add((i, teamNames[i], teamWins[i], teamScores[i] / week));
        }

        var sortedStats = teamStats.OrderByDescending(t => t.wins)
                                  .ThenByDescending(t => t.avgScore)
                                  .ToList();

        for (int i = 0; i < sortedStats.Count; i++)
        {
            var team = sortedStats[i];
            string playoff = i < 4 ? "🟢 PLAYOFF" : "🔴";
            Console.WriteLine($"{i + 1}. {team.name} ({team.wins}-{teamLosses[team.index]}) - {team.avgScore:F1} avg {playoff}");
        }
    }
}

// SLUTSPEL (Top 4 teams)
Console.WriteLine("\n🏆 SLUTSPEL BÖRJAR!");

// Hitta top 4 teams
var finalStandings = new List<(int index, string name, int wins, double totalScore)>();
for (int i = 0; i < numberOfTeams; i++)
{
    finalStandings.Add((i, teamNames[i], teamWins[i], teamScores[i]));
}

var playoffTeams = finalStandings.OrderByDescending(t => t.wins)
                                .ThenByDescending(t => t.totalScore)
                                .Take(4)
                                .ToList();

Console.WriteLine("\n🎯 PLAYOFF-TEAMS:");
for (int i = 0; i < playoffTeams.Count; i++)
{
    var team = playoffTeams[i];
    Console.WriteLine($"{i + 1}. {team.name} ({team.wins}-{teamLosses[team.index]})");
}

// Semifinaler
Console.WriteLine("\n🥊 SEMIFINALER:");
var finalists = new List<(int index, string name)>();

for (int semifinal = 0; semifinal < 2; semifinal++)
{
    int team1Idx = playoffTeams[semifinal * 2].index;
    int team2Idx = playoffTeams[semifinal * 2 + 1].index;

    double team1Score = 90 + (random.NextDouble() * 60); // Playoff-spänning!
    double team2Score = 90 + (random.NextDouble() * 60);

    if (team1Score > team2Score)
    {
        finalists.Add((team1Idx, teamNames[team1Idx]));
        Console.WriteLine($"  {teamNames[team1Idx]} {team1Score:F1} - {team2Score:F1} {teamNames[team2Idx]} ✅");
    }
    else
    {
        finalists.Add((team2Idx, teamNames[team2Idx]));
        Console.WriteLine($"  {teamNames[team1Idx]} {team1Score:F1} - {team2Score:F1} {teamNames[team2Idx]} ✅");
    }
}

// FINAL
Console.WriteLine("\n🏆 STOR FINAL!");
double finalist1Score = 95 + (random.NextDouble() * 50);
double finalist2Score = 95 + (random.NextDouble() * 50);

if (finalist1Score > finalist2Score)
{
    Console.WriteLine($"🎉 {finalists[0].name} VINNER LIGAN!");
    Console.WriteLine($"   Final: {finalists[0].name} {finalist1Score:F1} - {finalist2Score:F1} {finalists[1].name}");
}
else
{
    Console.WriteLine($"🎉 {finalists[1].name} VINNER LIGAN!");
    Console.WriteLine($"   Final: {finalists[0].name} {finalist1Score:F1} - {finalist2Score:F1} {finalists[1].name}");
}

// Säsongs-statistik
Console.WriteLine("\n📈 SÄSONGSSTATISTIK:");
double highestAverage = teamScores.Max() / regularSeasonWeeks;
int mvpTeam = Array.IndexOf(teamScores, teamScores.Max());
Console.WriteLine($"🏅 Högsta genomsnitt: {teamNames[mvpTeam]} ({highestAverage:F1} poäng/vecka)");

int mostWins = teamWins.Max();
int bestTeam = Array.IndexOf(teamWins, mostWins);
Console.WriteLine($"👑 Flest vinster: {teamNames[bestTeam]} ({mostWins} vinster)");
```

**Din uppgift:**
1. Lägg till spelar-trades under säsongen
2. Simulera skador som påverkar lag-prestanda
3. Skapa en "waiver wire" för free agents

## 🎯 Sammanfattning

Du behärskar nu loopar för verkliga problem! Du kan:

- ✅ Använda for-loopar för exakta beräkningar
- ✅ Använda while-loopar för okända mängder
- ✅ Bygga komplexa simuleringar med nested loops
- ✅ Lösa praktiska ekonomiska och livsstilsproblem
- ✅ Skapa interaktiva program som simulerar verkligheten

**Nästa steg:** Kombinera loopar med if-satser för ännu mer avancerad logik!

## 🤣 Obligatorisk Dad Joke

Varför älskar programmerare loopar?

För att de aldrig tröttnar på att göra samma sak om och om igen! 🔄😄

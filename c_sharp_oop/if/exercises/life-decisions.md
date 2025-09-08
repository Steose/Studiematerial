# Livsbeslut med If-satser 🤔

Livet är fullt av beslut! Från enkla vardagsval till komplexa livssituationer. Här lär du dig att programmera smart beslutslogik som hjälper dig navigera genom vardagen! 🧠✨

## 🎯 Vad kommer du att lära dig?

- If-else för binära beslut
- Else-if för multipla alternativ
- Nested if för komplexa scenarier
- Boolean logik för smarta villkor
- Ternary operators för snabba val

---

## ☕ Övning 1: Morgon-rutinen (Grundläggande if-else)

**Problem:** Ska du ta kaffe hemma eller köpa på vägen? Låt koden bestämma baserat på tid och budget!

```csharp
// Smart morgon-assistent
DateTime currentTime = DateTime.Now;
int hour = currentTime.Hour;
int minute = currentTime.Minute;
double walletMoney = 45.50;        // Pengar i plånboken
double coffeeAtHome = 3.50;        // Kostnad för hemkaffe
double coffeeShop = 38.0;          // Kostnad för café-kaffe
bool hasTimePressure = hour >= 8 && minute > 15; // Sen till jobbet?
bool rainToday = true;             // Regnar det?

Console.WriteLine("☀️ GOD MORGON! Kaffebeslut-assistenten är här!");
Console.WriteLine($"⏰ Tid: {hour:D2}:{minute:D2}");
Console.WriteLine($"💰 I plånboken: {walletMoney} kr");
Console.WriteLine($"🌧️ Regn idag: {(rainToday ? "Ja" : "Nej")}");
Console.WriteLine();

// Beslutslogik
if (hasTimePressure)
{
    Console.WriteLine("🏃‍♂️ DU ÄR SEN!");

    if (walletMoney >= coffeeShop && !rainToday)
    {
        Console.WriteLine("☕ Köp kaffe på vägen - du hinner inte göra hemma!");
        Console.WriteLine($"💸 Kostnad: {coffeeShop} kr");
    }
    else if (rainToday)
    {
        Console.WriteLine("🏠 Snabbkaffe hemma - regn + bråttom = hemmalösning!");
        Console.WriteLine($"💸 Kostnad: {coffeeAtHome} kr");
        Console.WriteLine("💡 Tips: Ställ klockan 10 min tidigare imorgon!");
    }
    else
    {
        Console.WriteLine("😰 Inget kaffe idag - för sent och för lite pengar!");
        Console.WriteLine("💡 Överväg energidryck från automaten (12 kr)");
    }
}
else
{
    Console.WriteLine("😌 Du har god tid!");

    if (walletMoney < coffeeShop)
    {
        Console.WriteLine("☕ Hemkaffe - spara pengar för lunch istället!");
        Console.WriteLine($"💸 Kostnad: {coffeeAtHome} kr");
        Console.WriteLine($"💰 Sparar: {coffeeShop - coffeeAtHome} kr");
    }
    else
    {
        Console.WriteLine("🤔 Du kan välja fritt:");
        Console.WriteLine($"🏠 Hemkaffe: {coffeeAtHome} kr - mysigt och billigt");
        Console.WriteLine($"☕ Café: {coffeeShop} kr - gott och socialt");

        // Extra beslutshjälp
        if (currentTime.DayOfWeek == DayOfWeek.Monday)
        {
            Console.WriteLine("💡 Måndag = unna dig café-kaffe för veckostart!");
        }
        else if (currentTime.DayOfWeek == DayOfWeek.Friday)
        {
            Console.WriteLine("🎉 Fredag = fira med fancy kaffe!");
        }
        else
        {
            Console.WriteLine("💭 Vardagsval - kanske hemkaffe för att spara?");
        }
    }
}

// Bonus: Hälso-check
if (hour < 6)
{
    Console.WriteLine("⚠️ Kanske för tidigt för kaffe? Överväg vatten först!");
}
else if (hour > 14)
{
    Console.WriteLine("🌙 Sent på dagen - koffein kan påverka sömnen!");
}
```

**Din uppgift:**
1. Lägg till väderkoll som påverkar beslutet
2. Inkludera helger vs vardagar
3. Lägg till "koffein-tolerans" som variabel

---

## 🍕 Övning 2: Middag-dilemmat (Else-if kedjor)

**Problem:** Vad ska du äta till middag? Flera faktorer påverkar beslutet!

```csharp
// Middag-beslutssystem
double budget = 150.0;             // Dagsbudget för mat
int energyLevel = 3;               // 1-5 skala (1=utmattad, 5=energisk)
int cookingSkill = 2;              // 1-5 skala (1=nybörjare, 5=mästerkock)
bool hasIngredients = false;       // Mat hemma?
bool friendsAvailable = true;      // Vänner tillgängliga?
int timeAvailable = 45;            // Minuter till mat
string mood = "comfort";           // "comfort", "healthy", "adventure", "lazy"

Console.WriteLine("🍽️ MIDDAGSBESLUT-ASSISTENTEN");
Console.WriteLine($"💰 Budget: {budget} kr");
Console.WriteLine($"⚡ Energinivå: {energyLevel}/5");
Console.WriteLine($"👨‍🍳 Matlagningsskill: {cookingSkill}/5");
Console.WriteLine($"🥘 Mat hemma: {(hasIngredients ? "Ja" : "Nej")}");
Console.WriteLine($"👥 Vänner tillgängliga: {(friendsAvailable ? "Ja" : "Nej")}");
Console.WriteLine($"⏰ Tid tillgänglig: {timeAvailable} min");
Console.WriteLine($"😊 Humör: {mood}");
Console.WriteLine();

// Komplex beslutslogik
if (energyLevel <= 2 && timeAvailable < 30)
{
    Console.WriteLine("😴 LÅGENERGIALARM!");

    if (budget >= 120)
    {
        Console.WriteLine("🚚 Beställ mat hem - du behöver vila!");
        Console.WriteLine("📱 Rekommendation: Pizza eller sushi (bekvämt)");
        Console.WriteLine($"💸 Kostnad: ~120 kr + dricks");
    }
    else if (budget >= 50)
    {
        Console.WriteLine("🍜 Snabbmat eller färdigmat från butik");
        Console.WriteLine("🏪 ICA Basic, mikromac eller cup noodles");
        Console.WriteLine($"💸 Kostnad: ~50 kr");
    }
    else
    {
        Console.WriteLine("🍞 Toast eller smörgås - enkelt och billigt");
        Console.WriteLine("💡 Kanske dags att handla mat imorgon?");
    }
}
else if (friendsAvailable && budget >= 200)
{
    Console.WriteLine("👥 SOCIAL MATLAGNING!");

    if (mood == "adventure")
    {
        Console.WriteLine("🌮 Prova ny restaurang tillsammans!");
        Console.WriteLine("🗺️ Sök på Google Maps efter något ni aldrig provat");
    }
    else if (mood == "comfort")
    {
        Console.WriteLine("🏠 Laga mat tillsammans hemma!");
        Console.WriteLine("🛒 Handla ingredienser och gör det till en aktivitet");
    }
    else
    {
        Console.WriteLine("🍺 Casual pub-mat eller pizzeria");
        Console.WriteLine("💬 Fokus på umgänge, maten är sekundär");
    }
}
else if (hasIngredients && cookingSkill >= 3)
{
    Console.WriteLine("👨‍🍳 HEMLAGAD MAT-CHAMPION!");

    if (mood == "healthy")
    {
        Console.WriteLine("🥗 Gör en näringsrik måltid!");
        Console.WriteLine("💡 Protein + grönsaker + fullkorn = perfekt");
        Console.WriteLine("⏰ Beräknad tid: 30-45 min");
    }
    else if (mood == "comfort")
    {
        Console.WriteLine("🍝 Comfort food hemma!");
        Console.WriteLine("💡 Pasta, risotto eller något som mättar och tröstar");
    }
    else if (timeAvailable >= 60)
    {
        Console.WriteLine("⭐ Experimentera med nytt recept!");
        Console.WriteLine("📱 Kolla YouTube för inspiration");
    }
    else
    {
        Console.WriteLine("⚡ Snabb hemlagad mat!");
        Console.WriteLine("🍳 Äggröra, pasta eller stir-fry");
    }
}
else if (budget >= 80 && timeAvailable >= 20)
{
    Console.WriteLine("🛒 SHOPPINGSCENARIOT!");

    if (cookingSkill <= 2)
    {
        Console.WriteLine("📦 Köp färdiga lösningar från butik");
        Console.WriteLine("💡 Färdigrätter som bara behöver värmas");
        Console.WriteLine("🥘 ICA, Coop eller Hemköp har bra utbud");
    }
    else
    {
        Console.WriteLine("🥘 Snabbhandla och laga något enkelt");
        Console.WriteLine("💡 Pasta + färdigsås, fläskfilé + potatis etc.");
    }
}
else
{
    Console.WriteLine("🤷‍♂️ TOUGH SITUATION!");

    if (budget < 50)
    {
        Console.WriteLine("💸 Budget är tight:");
        Console.WriteLine("🍜 Nudlar, ägg, bröd eller vad som finns hemma");
        Console.WriteLine("💡 Kanske fråga familj/vänner om middag?");
    }
    else
    {
        Console.WriteLine("⏰ Tid är problemet:");
        Console.WriteLine("🏃‍♂️ Snabbmat på vägen eller färdigmat från närbutik");
    }
}

// Bonus rekommendationer
Console.WriteLine("\n💡 EXTRA TIPS:");

if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
{
    Console.WriteLine("📅 Söndag = Meal prep för veckan?");
}

if (energyLevel >= 4 && cookingSkill >= 3)
{
    Console.WriteLine("⭐ Du har energi och kunskap - perfect combo för matlagning!");
}

if (budget > 200)
{
    Console.WriteLine("💰 God budget - unna dig något extra gott!");
}
```

**Din uppgift:**
1. Lägg till dietrestriktioner (vegetarian, glutenfri)
2. Inkludera säsong (sommarsallader vs vintersoppor)
3. Lägg till "leftover"-logik från förra dagen

---

## 🎯 Övning 3: Jedi vs Sith - The Ultimate Choice (Complex nested if)

**Problem:** Du är på Korriban och måste välja din väg. Många faktorer påverkar ditt öde!

```csharp
// Star Wars: Path to Destiny
int lightSidePoints = 35;         // 0-100 ljussida poäng
int darkSidePoints = 25;          // 0-100 mörka sida poäng
int forceLevel = 7;               // 1-10 Force-känslighet
string masterTraining = "Yoda";   // "Yoda", "Palpatine", "Qui-Gon", "None"
bool hasEmotionalAttachments = true; // Kärlek, vänskap etc
int age = 23;                     // Ålder när training börjar
bool witnessedTrauma = true;      // Sett Jedi-order falla?
string homeplanet = "Tatooine";   // Bakgrund påverkar worldview

Console.WriteLine("⭐ STAR WARS: DIN FORCE-DESTINÉ ⭐");
Console.WriteLine($"☀️ Ljussida poäng: {lightSidePoints}/100");
Console.WriteLine($"🌑 Mörka sida poäng: {darkSidePoints}/100");
Console.WriteLine($"⚡ Force-nivå: {forceLevel}/10");
Console.WriteLine($"👨‍🏫 Mästare: {masterTraining}");
Console.WriteLine($"💝 Emotionella band: {(hasEmotionalAttachments ? "Ja" : "Nej")}");
Console.WriteLine($"🎂 Ålder vid träning: {age}");
Console.WriteLine($"💥 Bevittnat trauma: {(witnessedTrauma ? "Ja" : "Nej")}");
Console.WriteLine($"🌍 Hemplanet: {homeplanet}");
Console.WriteLine();

// Beräkna Force-balans
int forceBalance = lightSidePoints - darkSidePoints;
bool isForceProdigy = forceLevel >= 8;
bool hadProperTraining = masterTraining == "Yoda" || masterTraining == "Qui-Gon";

Console.WriteLine("🔮 ANALYS AV DIN FORCE-VÄGAR:");

// Huvudbeslut: Jedi, Sith eller Gray Jedi
if (forceBalance >= 20 && hadProperTraining)
{
    Console.WriteLine("✨ DU BLIR EN SANN JEDI! ✨");

    if (isForceProdigy && age < 25)
    {
        Console.WriteLine("🌟 JEDI PRODIGY PATH!");
        Console.WriteLine("🏛️ Du kommer bli en av de starka Jedi Council members");
        Console.WriteLine("⚔️ Specialitet: Lightsaber combat och Force meditation");

        if (!hasEmotionalAttachments)
        {
            Console.WriteLine("🧘‍♂️ Perfect Jedi - helt odistraherad av känslor");
        }
        else
        {
            Console.WriteLine("💔 Risk: Dina känslor kan bli en svaghet");
            Console.WriteLine("⚠️ Anakin Skywalker vibes - var försiktig!");
        }
    }
    else if (witnessedTrauma)
    {
        Console.WriteLine("🛡️ GUARDIAN JEDI PATH!");
        Console.WriteLine("⚔️ Du blir en protector som aldrig låter tragedy repeat");
        Console.WriteLine("🏰 Specialitet: Defending the innocent och temple security");
    }
    else
    {
        Console.WriteLine("📚 CONSULAR JEDI PATH!");
        Console.WriteLine("🕊️ Diplomati och healing blir din styrka");
        Console.WriteLine("🌌 Du löser konflikter med ord, inte lightsaber");
    }
}
else if (forceBalance <= -15 || masterTraining == "Palpatine")
{
    Console.WriteLine("🌑 DU FALLER TILL MÖRKA SIDAN! 🌑");

    if (witnessedTrauma && hasEmotionalAttachments)
    {
        Console.WriteLine("💀 REVENGE-DRIVEN SITH!");
        Console.WriteLine("⚡ Din smärta blir din kraft");
        Console.WriteLine("🗡️ Sith name: Darth Vengeance");
        Console.WriteLine("🎯 Mål: Krossa alla som sårade dig");
    }
    else if (forceLevel >= 8)
    {
        Console.WriteLine("👑 POWERFUL SITH LORD!");
        Console.WriteLine("⚡ Ren ambition och makt driver dig");
        Console.WriteLine("🗡️ Sith name: Darth Dominus");
        Console.WriteLine("🌌 Mål: Anta control över galaxen");
    }
    else
    {
        Console.WriteLine("😈 SITH ASSASSIN!");
        Console.WriteLine("🗡️ Du jobbar i skuggorna för Sith Lords");
        Console.WriteLine("💀 Specialitet: Stealth kills och infiltration");
    }

    // Varning för Sith-path
    Console.WriteLine("\n⚠️ VARNING: Mörka sidan korrupt!");
    Console.WriteLine("💔 Du kommer förlora allt du älskar");
    Console.WriteLine("⚡ Makt får ett högt pris...");
}
else
{
    Console.WriteLine("⚖️ DU BLIR EN GRAY JEDI! ⚖️");

    if (homeplanet == "Tatooine" || homeplanet == "Jakku")
    {
        Console.WriteLine("🏜️ DESERT WANDERER PATH!");
        Console.WriteLine("🧭 Du lever utanför både Jedi och Sith orders");
        Console.WriteLine("⚖️ Använder both light and dark when needed");
        Console.WriteLine("🦎 Liknar Qui-Gon Jinn - följer din egen moral");
    }
    else if (hasEmotionalAttachments)
    {
        Console.WriteLine("💝 EMOTIONAL BALANCE PATH!");
        Console.WriteLine("🌅 Du accepterar känslor men låter inte dem kontrollera dig");
        Console.WriteLine("👨‍👩‍👧‍👦 Kan ha family och ändå använda Force");
    }
    else
    {
        Console.WriteLine("🌊 NEUTRAL FORCE USER!");
        Console.WriteLine("⚖️ Du ser Force som verktyg, inte religion");
        Console.WriteLine("🔧 Praktisk approach - hjälper när du kan");
    }
}

// Specialförmågor baserat på stats
Console.WriteLine("\n🎭 DINA FORCE-FÖRMÅGOR:");

if (forceLevel >= 9)
{
    Console.WriteLine("⚡ Force Lightning mastery");
    Console.WriteLine("🧠 Advanced Mind Tricks");
}

if (lightSidePoints >= 70)
{
    Console.WriteLine("✨ Force Heal");
    Console.WriteLine("🛡️ Force Protection");
}

if (darkSidePoints >= 60)
{
    Console.WriteLine("🌪️ Force Choke");
    Console.WriteLine("😡 Rage-enhanced combat");
}

if (age < 20 && forceLevel >= 7)
{
    Console.WriteLine("🔮 Precognition (se framtiden)");
}

if (masterTraining == "Yoda")
{
    Console.WriteLine("🤸‍♂️ Incredible agility och wisdom");
}

// Final destiny
Console.WriteLine("\n🔮 DIN SLUTLIGA DESTINY:");

if (forceBalance > 30)
{
    Console.WriteLine("🌟 Du blir remembered som en legend som saved the galaxy!");
}
else if (forceBalance < -20)
{
    Console.WriteLine("💀 History kommer remember dig som en powerful men tragic figure");
}
else
{
    Console.WriteLine("⚖️ Du lever ett balanced liv - neither hero nor villain");
    Console.WriteLine("🌅 Kanske det är the wisest path of all...");
}
```

**Din uppgift:**
1. Lägg till fler homeplanets med olika effekter
2. Skapa en "redemption arc" för fallen Sith
3. Lägg till lightsaber color baserat på personality

---

## 💰 Övning 4: Investment Advisor (Financial if-logic)

**Problem:** Du har fått 50,000 kr i arv. Vad är den smartaste investeringen baserat på din situation?

```csharp
// Smart Investment Advisor
double inheritanceMoney = 50000.0;  // Arv att investera
int age = 28;                       // Din ålder
double monthlyIncome = 32000.0;     // Månadslön efter skatt
double monthlyExpenses = 28000.0;   // Månatliga utgifter
double currentDebt = 15000.0;       // Skulder (CSN, lån etc)
double emergencyFund = 8000.0;      // Nödfond
bool hasStableJob = true;           // Trygg anställning?
int riskTolerance = 3;              // 1-5 (1=no risk, 5=high risk)
string lifeGoal = "house";          // "house", "retirement", "travel", "business"
bool hasKnowledge = false;          // Finansiell kunskap?

Console.WriteLine("💰 SMART INVESTMENT ADVISOR 💰");
Console.WriteLine($"💵 Arv att investera: {inheritanceMoney:C} SEK");
Console.WriteLine($"👤 Ålder: {age}");
Console.WriteLine($"💸 Månadsbudget: {monthlyIncome:C} in, {monthlyExpenses:C} ut");
Console.WriteLine($"📊 Skulder: {currentDebt:C} SEK");
Console.WriteLine($"🚨 Nödfond: {emergencyFund:C} SEK");
Console.WriteLine($"💼 Stabil jobb: {(hasStableJob ? "Ja" : "Nej")}");
Console.WriteLine($"🎲 Risktolerans: {riskTolerance}/5");
Console.WriteLine($"🎯 Livsmål: {lifeGoal}");
Console.WriteLine($"📚 Finanskunskap: {(hasKnowledge ? "Bra" : "Begränsad")}");
Console.WriteLine();

// Beräkna finansiell hälsa
double monthlySurplus = monthlyIncome - monthlyExpenses;
double recommendedEmergencyFund = monthlyExpenses * 6; // 6 månaders utgifter
bool hasAdequateEmergency = emergencyFund >= recommendedEmergencyFund;
double debtToIncomeRatio = (currentDebt / (monthlyIncome * 12)) * 100;

Console.WriteLine("🔍 FINANSIELL HÄLSOKONTROLL:");
Console.WriteLine($"💰 Månatligt överskott: {monthlySurplus:C} SEK");
Console.WriteLine($"🚨 Rekommenderad nödfond: {recommendedEmergencyFund:C} SEK");
Console.WriteLine($"📊 Skuld/inkomst-ratio: {debtToIncomeRatio:F1}%");
Console.WriteLine();

// HUVUDBESLUT: Vad ska prioriteras?
if (currentDebt > 0 && debtToIncomeRatio > 20)
{
    Console.WriteLine("🚨 SKULDPRIORITERING!");
    Console.WriteLine("💡 Betala av skulder FÖRST - guaranteed avkastning!");

    if (currentDebt >= inheritanceMoney)
    {
        Console.WriteLine($"✅ Använd HELA arvet ({inheritanceMoney:C}) för skuld");
        Console.WriteLine($"💸 Kvarvarande skuld: {currentDebt - inheritanceMoney:C}");
        Console.WriteLine("🎯 Fokusera på att betala resten snabbt");
    }
    else
    {
        double afterDebtMoney = inheritanceMoney - currentDebt;
        Console.WriteLine($"✅ Betala av all skuld: {currentDebt:C}");
        Console.WriteLine($"💰 Kvar att investera: {afterDebtMoney:C}");

        // Vad göra med resten?
        if (afterDebtMoney >= 10000)
        {
            Console.WriteLine("🎉 Grattis! Nu kan du investera utan skulder!");
            // Fortsätt med investeringslogik nedan
        }
        else
        {
            Console.WriteLine("💡 Spara resten som extra nödfond");
        }
    }
}
else if (!hasAdequateEmergency)
{
    Console.WriteLine("🚨 NÖDFONDSPRIORITET!");

    double emergencyShortfall = recommendedEmergencyFund - emergencyFund;
    Console.WriteLine($"💡 Du behöver {emergencyShortfall:C} mer i nödfond");

    if (emergencyShortfall >= inheritanceMoney)
    {
        Console.WriteLine("✅ Använd hela arvet för nödfond!");
        Console.WriteLine("🏦 Sätt pengarna på sparkonto (låg risk, tillgängligt)");
    }
    else
    {
        double afterEmergencyMoney = inheritanceMoney - emergencyShortfall;
        Console.WriteLine($"✅ Fyll på nödfonden: {emergencyShortfall:C}");
        Console.WriteLine($"💰 Kvar att investera: {afterEmergencyMoney:C}");
    }
}
else
{
    Console.WriteLine("🎉 BRA FINANSIELL GRUND - DAGS ATT INVESTERA!");

    // Investeringsstrategi baserat på mål och risk
    if (lifeGoal == "house")
    {
        Console.WriteLine("🏠 BOSTADSKÖP-STRATEGI:");

        if (riskTolerance <= 2)
        {
            Console.WriteLine("💡 Konservativ approach för bostadsköp:");
            Console.WriteLine("🏦 70% sparkonto/obligationer (säkerhet)");
            Console.WriteLine("📈 30% aktiefonder (tillväxt)");
            Console.WriteLine($"⏰ Tidshorisont: 3-5 år");
        }
        else
        {
            Console.WriteLine("💡 Balanserad approach för bostadsköp:");
            Console.WriteLine("🏦 40% sparkonto/obligationer");
            Console.WriteLine("📈 60% aktiefonder/indexfonder");
            Console.WriteLine("⏰ Tidshorisont: 5-7 år");
        }
    }
    else if (lifeGoal == "retirement" && age < 35)
    {
        Console.WriteLine("🌅 PENSION-STRATEGI (Långsiktig):");

        if (riskTolerance >= 4)
        {
            Console.WriteLine("💡 Aggressiv pensionsstrategi:");
            Console.WriteLine("📈 80% aktier/aktiefonder");
            Console.WriteLine("🏦 20% obligationer");
            Console.WriteLine("⏰ Tidshorisont: 30+ år");
        }
        else
        {
            Console.WriteLine("💡 Balanserad pensionsstrategi:");
            Console.WriteLine("📈 60% aktier/indexfonder");
            Console.WriteLine("🏦 40% obligationer/räntefonder");
        }
    }
    else if (lifeGoal == "business")
    {
        Console.WriteLine("🚀 FÖRETAGS-STRATEGI:");

        if (hasKnowledge && riskTolerance >= 4)
        {
            Console.WriteLine("💡 Entreprenör-portfolio:");
            Console.WriteLine("🚀 40% för egen business");
            Console.WriteLine("📈 40% aktiefonder (diversifiering)");
            Console.WriteLine("🏦 20% säkerhet (nödfond++)");
        }
        else
        {
            Console.WriteLine("⚠️ Bygg kunskap först!");
            Console.WriteLine("📚 50% utbildning/kurser i business");
            Console.WriteLine("📈 50% konservativ investering meanwhile");
        }
    }
    else if (lifeGoal == "travel")
    {
        Console.WriteLine("✈️ RESE-STRATEGI:");
        Console.WriteLine("🏦 60% sparkonto (tillgängligt inom 1-2 år)");
        Console.WriteLine("📈 40% måttlig risk-fonder");
        Console.WriteLine("💡 Fokus på likviditet för reseplaner");
    }
}

// Riskvarnningar och tips
Console.WriteLine("\n⚠️ VIKTIGA PÅMINNELSER:");

if (!hasKnowledge)
{
    Console.WriteLine("📚 INVESTERA I KUNSKAP FÖRST!");
    Console.WriteLine("💡 Läs böcker, ta kurser, förstå vad du investerar i");
    Console.WriteLine("🎓 'Rich Dad Poor Dad', 'The Intelligent Investor'");
}

if (riskTolerance >= 4 && !hasStableJob)
{
    Console.WriteLine("⚠️ Hög risk + ostabil jobb = farlig kombination!");
    Console.WriteLine("💡 Sänk risknivån tills jobbet är säkrare");
}

if (age < 30)
{
    Console.WriteLine("⏰ Ung ålder = tid för compound interest att jobba!");
    Console.WriteLine("💰 Även små belopp nu blir stora summor senare");
}

// Konkreta rekommendationer
Console.WriteLine("\n🎯 KONKRETA STEG:");
Console.WriteLine("1. 🏦 Öppna konto hos Avanza eller Nordnet");
Console.WriteLine("2. 📊 Börja med indexfonder (OMXS30, global)");
Console.WriteLine("3. 💰 Sätt upp auto-investering månadsvis");
Console.WriteLine("4. 📚 Lär dig mer efterhand");
Console.WriteLine("5. 🔄 Review och justera årligen");

Console.WriteLine($"\n🌟 Med rätt strategi kan dina {inheritanceMoney:C} bli much more över tiden!");
```

**Din uppgift:**
1. Lägg till olika tax-advantaged accounts (ISK, AF)
2. Inkludera inflation i beräkningarna
3. Skapa en "risk-capacity" vs "risk-tolerance" check

---

## 🎮 Övning 5: RPG Character Creator (Ultimate decision tree)

**Problem:** Skapa den perfekta RPG-karaktären baserat på din spelstil och preferenser!

```csharp
// Ultimate RPG Character Creator
Console.WriteLine("⚔️ ULTIMATE RPG CHARACTER CREATOR ⚔️");
Console.WriteLine("Svara på frågorna för att skapa din perfekta karaktär!\n");

// Samla spelarpreferenser
string playstyle = "";
string difficulty = "";
string social = "";
string magic = "";
string combat = "";

// Fråga 1: Spelstil
Console.WriteLine("🎮 Hur spelar du RPG:er?");
Console.WriteLine("1. Rusher - jag vill ha action nu!");
Console.WriteLine("2. Explorer - jag utforskar varje vrå");
Console.WriteLine("3. Storyteller - plot och karaktär är viktigt");
Console.WriteLine("4. Minmaxer - optimala builds och stats");

int playstyleChoice = int.Parse(Console.ReadLine());

if (playstyleChoice == 1)
{
    playstyle = "rusher";
    Console.WriteLine("⚡ Rusher detected! Du kommer älska combat-focused builds.\n");
}
else if (playstyleChoice == 2)
{
    playstyle = "explorer";
    Console.WriteLine("🗺️ Explorer spotted! Utility och mobility blir viktigt.\n");
}
else if (playstyleChoice == 3)
{
    playstyle = "storyteller";
    Console.WriteLine("📚 Storyteller identified! Charisma och dialog-options.\n");
}
else
{
    playstyle = "minmaxer";
    Console.WriteLine("🧮 Minmaxer confirmed! Optimal stat distribution!\n");
}

// Fråga 2: Svårighetsgrad
Console.WriteLine("💀 Vilken svårighetsgrad föredrar du?");
Console.WriteLine("1. Easy - jag vill bara ha roligt");
Console.WriteLine("2. Normal - lagom utmaning");
Console.WriteLine("3. Hard - jag gillar att lida");
Console.WriteLine("4. Nightmare - pain is gain");

int diffChoice = int.Parse(Console.ReadLine());

if (diffChoice <= 2)
{
    difficulty = "casual";
    Console.WriteLine("😊 Casual gaming - fokus på fun over optimization!\n");
}
else
{
    difficulty = "hardcore";
    Console.WriteLine("💀 Hardcore detected - survival är priority #1!\n");
}

// Fråga 3: Social interaction
Console.WriteLine("👥 Hur är du med social interaction?");
Console.WriteLine("1. Talar mig ur allt - diplomati först");
Console.WriteLine("2. Blandar dialog och action");
Console.WriteLine("3. Låter svärdet tala - action först");

int socialChoice = int.Parse(Console.ReadLine());

social = socialChoice == 1 ? "diplomat" : socialChoice == 2 ? "balanced" : "aggressive";

// SKAPA KARAKTÄR baserat på svar
Console.WriteLine("\n🔮 ANALYSERAR DINA PREFERENSER...\n");
Console.WriteLine("✨ DIN PERFEKTA KARAKTÄR ÄR: ✨\n");

// Komplex if-logik för karaktärsskapande
if (playstyle == "rusher" && difficulty == "casual")
{
    if (social == "aggressive")
    {
        Console.WriteLine("⚔️ BERSERKER WARRIOR");
        Console.WriteLine("💪 Stats: STR 18, CON 16, DEX 14");
        Console.WriteLine("🏹 Weapons: Two-handed weapons, heavy armor");
        Console.WriteLine("🎯 Playstyle: Charge in, smash everything");
        Console.WriteLine("💡 Tips: High HP, devastating attacks, simple tactics");
    }
    else
    {
        Console.WriteLine("🗡️ PALADIN CHAMPION");
        Console.WriteLine("💪 Stats: STR 16, CHA 16, CON 14");
        Console.WriteLine("⚔️ Weapons: Sword & shield, plate armor");
        Console.WriteLine("🎯 Playstyle: Tank damage, help party, righteous fury");
        Console.WriteLine("✨ Special: Healing spells, turn undead");
    }
}
else if (playstyle == "explorer" && social == "diplomat")
{
    Console.WriteLine("🎭 CHARISMATIC BARD");
    Console.WriteLine("💪 Stats: CHA 18, DEX 16, INT 14");
    Console.WriteLine("🎵 Weapons: Rapier, light armor, musical instruments");
    Console.WriteLine("🎯 Playstyle: Talk first, inspire party, versatile magic");
    Console.WriteLine("💡 Tips: Jack-of-all-trades, great for story-driven games");
}
else if (playstyle == "storyteller")
{
    if (social == "diplomat")
    {
        Console.WriteLine("📜 WISE CLERIC");
        Console.WriteLine("💪 Stats: WIS 18, CHA 16, CON 14");
        Console.WriteLine("⚕️ Role: Healer, support, spiritual guide");
        Console.WriteLine("🎯 Playstyle: Keep party alive, provide wisdom");
        Console.WriteLine("✨ Special: Powerful healing, divine magic");
    }
    else
    {
        Console.WriteLine("🧙‍♂️ SCHOLARLY WIZARD");
        Console.WriteLine("💪 Stats: INT 18, WIS 16, DEX 14");
        Console.WriteLine("📚 Focus: Knowledge, arcane magic, problem-solving");
        Console.WriteLine("🎯 Playstyle: Analyze, plan, devastating spells");
        Console.WriteLine("💡 Tips: Squishy but incredibly powerful");
    }
}
else if (playstyle == "minmaxer")
{
    if (difficulty == "hardcore")
    {
        Console.WriteLine("🏹 OPTIMIZED RANGER");
        Console.WriteLine("💪 Stats: DEX 18, WIS 16, CON 14");
        Console.WriteLine("🎯 Weapons: Bow, dual weapons, medium armor");
        Console.WriteLine("🎯 Playstyle: Damage from distance, survivability");
        Console.WriteLine("🦌 Special: Animal companion, tracking, nature magic");
        Console.WriteLine("💡 Perfect balance of offense and defense");
    }
    else
    {
        Console.WriteLine("⚡ MULTICLASS POWERHOUSE");
        Console.WriteLine("💪 Stats: Depends on specific build");
        Console.WriteLine("🔄 Classes: Fighter/Wizard or Rogue/Sorcerer");
        Console.WriteLine("🎯 Playstyle: Maximum versatility and power");
        Console.WriteLine("💡 Advanced: Requires game knowledge but incredibly strong");
    }
}
else if (playstyle == "explorer" && difficulty == "hardcore")
{
    Console.WriteLine("🗡️ SURVIVALIST ROGUE");
    Console.WriteLine("💪 Stats: DEX 18, INT 16, CON 14");
    Console.WriteLine("🔧 Skills: Stealth, traps, lockpicking, scouting");
    Console.WriteLine("🎯 Playstyle: Avoid fights, strike from shadows");
    Console.WriteLine("💡 Perfect for exploring dangerous areas safely");
}
else
{
    Console.WriteLine("🌟 BALANCED FIGHTER");
    Console.WriteLine("💪 Stats: STR 16, DEX 14, CON 16");
    Console.WriteLine("⚔️ Weapons: Versatile - sword, bow, armor");
    Console.WriteLine("🎯 Playstyle: Adapt to any situation");
    Console.WriteLine("💡 Great starter choice, works in any party");
}

// Bonus rekommendationer
Console.WriteLine("\n🎮 GAMEPLAY TIPS:");

if (difficulty == "hardcore")
{
    Console.WriteLine("⚠️ Hardcore survival tips:");
    Console.WriteLine("- Always carry healing potions");
    Console.WriteLine("- Save often!");
    Console.WriteLine("- Learn enemy patterns");
    Console.WriteLine("- Have escape plans");
}

if (playstyle == "storyteller")
{
    Console.WriteLine("📚 Story enhancement tips:");
    Console.WriteLine("- Read all dialog options");
    Console.WriteLine("- Explore character backstories");
    Console.WriteLine("- Make choices that fit your character");
    Console.WriteLine("- Don't rush the main quest");
}

if (playstyle == "minmaxer")
{
    Console.WriteLine("📊 Optimization tips:");
    Console.WriteLine("- Plan your level progression");
    Console.WriteLine("- Research best equipment");
    Console.WriteLine("- Understand game mechanics");
    Console.WriteLine("- Test different builds");
}

Console.WriteLine("\n🏆 Lycka till med ditt äventyr, chosen one!");
```

**Din uppgift:**
1. Lägg till fler karaktärsklasser (Warlock, Monk, Druid)
2. Inkludera race-selection som påverkar stats
3. Skapa equipment recommendations baserat på build

## 🎯 Sammanfattning

Du behärskar nu if-satser för komplexa beslut! Du kan:

- ✅ Använda if-else för binära val
- ✅ Bygga else-if kedjor för multipla alternativ
- ✅ Skapa nested if för komplexa scenarier
- ✅ Kombinera boolean logik för smarta villkor
- ✅ Lösa verkliga beslutsproblem med kod
- ✅ Skapa interaktiva system som hjälper med livsval

**Nästa steg:** Kombinera if-satser med loopar för ännu mer kraftfull logik!

## 🤣 Obligatorisk Dad Joke

Varför är if-satser så bra på att ge råd?

För att de alltid tänker på alla alternativ innan de fattar beslut! 🤔💭

# 🔄 Loop Mayhem - Endless Coding Fun! 🔄

**Marcus visar loops i 10 min → NI KODAR LOSS!** 🚀

Här är 25+ loop challenges som får dig att loopa tills du blir galen! Välj, koda, testa, repeat! 🔥

---

## 🎯 GAME SIMULATION LOOPS

### 1. Slot Machine Simulator
**8 min:** Simulera 1000 spins på en enarmad bandit
```csharp
Random rand = new Random();
int money = 100;
int spins = 0;

while (money > 0 && spins < 1000)
{
    // Spin logic: 🍎🍌🍒
    // Win conditions, money tracking
    // Biggest win streak?
}
```

### 2. Pokémon Catch Simulator
**10 min:** Fånga alla 150 original Pokémon!
```csharp
string[] pokemon = {"Pikachu", "Charizard", "Blastoise", /*... add more*/};
List<string> caught = new List<string>();

for (int day = 1; day <= 365; day++)
{
    // Random encounter each day
    // Catch success based on rarity
    // När har du fångat alla?
}
```

### 3. FIFA Pack Opening Madness
**12 min:** Öppna packs tills du får Messi!
```csharp
double[] rarities = {0.001, 0.01, 0.1, 0.89}; // Legend, Rare, Common
string[] players = {"Messi", "Ronaldo", "Mbappé", "Random Player"};
int packsOpened = 0;
double totalCost = 0;

// Loop until legendary!
```

### 4. Wordle Score Tracker
**6 min:** Simulera en månads Wordle-spel
```csharp
int[] guessDistribution = new int[7]; // 1-6 guesses + failed
Random rand = new Random();

for (int day = 1; day <= 30; day++)
{
    int guessesNeeded = rand.Next(1, 8); // 7 means failed
    // Track statistics, calculate average
}
```

---

## 💰 MONEY & INVESTMENT LOOPS

### 5. Compound Interest Beast Mode
**15 min:** Simulera olika investeringsstrategier över 40 år
```csharp
double[] strategies = {0.02, 0.05, 0.08, 0.12}; // Different returns
double monthlyInvestment = 1000;

for (int strategy = 0; strategy < strategies.Length; strategy++)
{
    double total = 0;
    for (int month = 1; month <= 480; month++) // 40 years
    {
        // Compound magic happens here!
    }
    // Compare final amounts
}
```

### 6. Salary Negotiation Simulator
**10 min:** Vad händer med olika löneökningar över career?
```csharp
double startingSalary = 35000;
double[] yearlyIncreases = {0.02, 0.03, 0.05, 0.07}; // 2%, 3%, 5%, 7%

foreach (double increase in yearlyIncreases)
{
    double salary = startingSalary;
    for (int year = 1; year <= 35; year++)
    {
        salary *= (1 + increase);
        // Calculate lifetime earnings
    }
}
```

### 7. Crypto HODL Simulator
**12 min:** Vad om du köpt Bitcoin varje månad sedan 2015?
```csharp
double[] bitcoinPrices = {200, 250, 400, 600, /*...historical data...*/};
double monthlyBuy = 500;
double totalBitcoins = 0;

for (int month = 0; month < bitcoinPrices.Length; month++)
{
    double bitcoinsBought = monthlyBuy / bitcoinPrices[month];
    totalBitcoins += bitcoinsBought;
    // Current value vs total invested
}
```

### 8. Subscription Hell Calculator
**8 min:** Alla dina subscriptions över 10 år
```csharp
string[] services = {"Netflix", "Spotify", "gym", "phone", "insurance"};
double[] costs = {179, 109, 399, 599, 450};

for (int year = 1; year <= 10; year++)
{
    double yearlyTotal = 0;
    for (int i = 0; i < services.Length; i++)
    {
        yearlyTotal += costs[i] * 12;
        costs[i] *= 1.03; // 3% yearly increase
    }
    // Total cost accumulation
}
```

---

## 🏃‍♂️ FITNESS & HEALTH LOOPS

### 9. Marathon Training Program
**15 min:** 16-veckors träningsprogram simulation
```csharp
double currentDistance = 5; // Start at 5km
double targetDistance = 42.2; // Marathon distance
int weeks = 16;

for (int week = 1; week <= weeks; week++)
{
    for (int day = 1; day <= 7; day++)
    {
        if (day % 2 == 1) // Run every other day
        {
            // Progressive distance increase
            // Injury risk calculation
            // Rest day logic
        }
    }
}
```

### 10. Weight Loss Journey
**10 min:** Simulera viktminskning med olika metoder
```csharp
double currentWeight = 85;
double targetWeight = 75;
double[] methods = {0.2, 0.5, 0.8, 1.2}; // kg per week loss rates

foreach (double lossRate in methods)
{
    double weight = currentWeight;
    int weeks = 0;

    while (weight > targetWeight)
    {
        weight -= lossRate;
        weeks++;
        // Plateau effects, cheat days, motivation drops
    }
}
```

### 11. 10,000 Steps Challenge
**8 min:** Tracka steg över en månad
```csharp
int target = 10000;
int totalSteps = 0;
int successfulDays = 0;

for (int day = 1; day <= 30; day++)
{
    int dailySteps = GenerateRandomSteps(); // Weekend vs weekday logic
    totalSteps += dailySteps;

    if (dailySteps >= target)
    {
        successfulDays++;
    }
    // Streak tracking, motivation system
}
```

---

## 🍔 FOOD & COOKING LOOPS

### 12. Restaurant Queue Simulator
**12 min:** Simulera kö-system på Max Burgers
```csharp
int customersInQueue = 0;
int totalCustomersServed = 0;
int maxQueueLength = 0;

for (int minute = 1; minute <= 480; minute++) // 8-hour shift
{
    // Rush hour logic (12:00-13:00)
    // Customer arrival rate
    // Service time per customer
    // Queue management
}
```

### 13. Pizza Delivery Optimization
**15 min:** Optimera delivery routes för en kväll
```csharp
string[] addresses = {"Vasagatan 12", "Storgatan 45", /*... add more*/};
int[] distances = {5, 12, 8, 15, 3}; // km from pizzeria
int deliveryCapacity = 3; // pizzas per trip

for (int trip = 1; customersWaiting > 0; trip++)
{
    // Select optimal route
    // Calculate delivery time
    // Customer satisfaction tracking
}
```

### 14. Calorie Burn Calculator
**8 min:** Hur länge för att bränna en Big Mac?
```csharp
int bigMacCalories = 550;
int[] activities = {300, 400, 600, 800}; // calories per hour
string[] activityNames = {"walking", "cycling", "running", "swimming"};

for (int i = 0; i < activities.Length; i++)
{
    double hoursNeeded = (double)bigMacCalories / activities[i];
    // Convert to minutes, add motivational messages
}
```

---

## 🎓 SCHOOL & STUDY LOOPS

### 15. Grade Point Average Evolution
**10 min:** Track betyg över hela utbildningen
```csharp
string[] courses = {"Prog1", "Webbutveckling", "Databaser", /*...*/};
double[] currentGrades = {3.5, 4.2, 2.8, /*...*/};

for (int semester = 1; semester <= 6; semester++)
{
    double semesterGPA = CalculateSemesterGPA();
    // Improvement tracking, graduation requirements
}
```

### 16. Study Session Optimizer
**8 min:** Pomodoro technique effectiveness
```csharp
int totalMinutesToStudy = 240; // 4 hours
int pomodoroLength = 25;
int breakLength = 5;
int longBreakAfter = 4;

for (int session = 1; totalMinutesToStudy > 0; session++)
{
    // Study session logic
    // Attention span degradation
    // Productivity tracking
}
```

### 17. Exam Cramming Simulator
**12 min:** Last-minute exam prep strategy
```csharp
int daysUntilExam = 3;
int totalTopics = 20;
int knownTopics = 5;

for (int day = daysUntilExam; day > 0; day--)
{
    int studyHours = day == 1 ? 12 : 8; // Panic mode on last day

    for (int hour = 1; hour <= studyHours; hour++)
    {
        // Learning efficiency decreases with fatigue
        // Panic bonus vs exhaustion penalty
    }
}
```

---

## 🌍 SIMULATION & MODELING

### 18. Population Growth Simulator
**15 min:** Simulera världens befolkning över 100 år
```csharp
long worldPopulation = 8000000000; // 8 billion start
double growthRate = 0.0105; // 1.05% annually

for (int year = 2024; year <= 2124; year++)
{
    worldPopulation = (long)(worldPopulation * (1 + growthRate));

    // Environmental impact calculations
    // Resource scarcity effects
    // Growth rate changes over time
}
```

### 19. Climate Change Impact
**18 min:** Temperature rise effects över 50 år
```csharp
double currentTemp = 15.2; // Global average
double yearlyIncrease = 0.018; // Degrees per year

for (int year = 1; year <= 50; year++)
{
    currentTemp += yearlyIncrease;

    // Ice cap melting calculations
    // Sea level rise
    // Agricultural impact
}
```

### 20. Zombie Apocalypse Spread
**20 min:** Epidemiological model för zombie outbreak
```csharp
int totalPopulation = 10000000; // Stockholm area
int zombies = 1; // Patient zero
int immune = 0;
int dead = 0;

for (int day = 1; zombies > 0 && zombies < totalPopulation; day++)
{
    // Infection rate calculations
    // Human resistance efforts
    // Cure development progress
}
```

---

## 🎨 CREATIVE & ART LOOPS

### 21. ASCII Art Generator
**12 min:** Skapa patterns med nested loops
```csharp
// Triangle patterns
for (int row = 1; row <= 10; row++)
{
    for (int col = 1; col <= row; col++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}

// Expand to: diamonds, spirals, fractals!
```

### 22. Color Pattern Creator
**10 min:** Skapa rainbow patterns
```csharp
string[] colors = {"🔴", "🟠", "🟡", "🟢", "🔵", "🟣"};

for (int row = 1; row <= 20; row++)
{
    for (int col = 1; col <= 40; col++)
    {
        // Wave patterns, gradients, animations
        int colorIndex = (row + col) % colors.Length;
        Console.Write(colors[colorIndex]);
    }
    Console.WriteLine();
}
```

### 23. Music Practice Tracker
**8 min:** Track daily practice sessions
```csharp
string[] instruments = {"Piano", "Guitar", "Violin"};
int[] dailyGoals = {60, 45, 30}; // minutes
int totalDays = 100;

for (int day = 1; day <= totalDays; day++)
{
    for (int i = 0; i < instruments.Length; i++)
    {
        int practiceTime = GenerateRandomPractice();
        // Skill improvement tracking
        // Streak rewards
    }
}
```

---

## 🚀 ADVANCED CHALLENGES

### 24. Social Media Influence Simulator
**25 min:** Bygg upp ett Instagram-följare empire
```csharp
int followers = 50;
int posts = 0;
double engagementRate = 0.05;

for (int day = 1; day <= 365; day++)
{
    // Post frequency strategy
    // Algorithm changes
    // Viral post probability
    // Follower churn rate

    if (day % 7 == 0) // Weekly analysis
    {
        // Calculate growth metrics
    }
}
```

### 25. Dating App Success Rate
**15 min:** Swipe your way to love... mathematically
```csharp
int totalSwipes = 0;
int matches = 0;
int dates = 0;
int relationships = 0;

while (relationships == 0 && totalSwipes < 10000)
{
    // Swipe right/left logic
    // Match probability
    // Date conversion rate
    // Relationship success factors
}
```

### 26. Space Colonization Plan
**30 min:** Plan Mars colony över 50 år
```csharp
int earthPopulation = 8000000000;
int marsPopulation = 0;
double transportCostPerPerson = 500000; // USD

for (int year = 1; year <= 50; year++)
{
    // Technology improvements
    // Cost reductions over time
    // Life support calculations
    // Resource availability
}
```

---

## 🎮 **GAME MODES:**

### 🟢 **Speed Mode (5-10 min):**
- Basic loop structure
- Simple math and counters
- Console output med results

### 🟡 **Feature Mode (10-15 min):**
- Add user input and choices
- Multiple scenarios
- Statistical analysis

### 🔴 **Beast Mode (15-25 min):**
- Complex nested loops
- Data structures integration
- Advanced algorithms

### 💀 **God Mode (25+ min):**
- Multi-threaded simulations
- File I/O for data persistence
- Real-time visualization
- Interactive controls

---

## 🔥 **LOOP MASTERY BONUSES:**

- **Break & Continue Master:** Use strategic loop control
- **Nested Loop Ninja:** Three levels deep minimum
- **Performance Pro:** Optimize for speed and memory
- **Data Wizard:** Export results to files
- **Visual Artist:** ASCII art and progress bars
- **Statistical Genius:** Calculate means, medians, trends

---

## 💡 **PRO LOOP TIPS:**

1. **Start with simple counters** - få basic logic att fungera
2. **Add random variation** - gör simuleringen realistisk
3. **Track multiple metrics** - mer data = mer insights
4. **Use meaningful variable names** - `day`, `customer`, `score`
5. **Add progress indicators** - show completion percentage
6. **Break infinite loops** - lägg till safety exits!
7. **Visualize with characters** - █▓▒░ för progress bars

**LOOP TILL DU TRILLAR! 🔄🚀**

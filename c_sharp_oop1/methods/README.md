# 🔧 Metoder - Organisera och återanvänd kod

Lär dig skapa metoder (funktioner) för att organisera din kod, göra den återanvändbar och lättare att underhålla. Metoder är nyckeln till att skriva professionell kod!

## 🎯 Vad du kommer att lära dig

- Vad metoder är och varför de är viktiga
- Method signatures (namn, parametrar, returvärden)
- Static vs instance methods
- Method overloading
- Scope och lokala variabler
- Best practices för metoddesign

## 📚 Innehåll

### 🏋️ Praktiska övningar
Se **[exercises/](exercises/)** för alla övningar:

- **[🧮 Kalkylator med metoder](exercises/calculator_methods.md)** - Grundläggande matematiska metoder
- **[📝 Texthantering med metoder](exercises/string_methods.md)** - Arbeta med strängar
- **[🌡️ Temperaturkonverterare](exercises/temperature_converter.md)** - Konvertera mellan temperaturskalor
- **[🔢 Talhantering med metoder](exercises/number_methods.md)** - Primtal, fakultet och mer
- **[📊 Betygsräknare](exercises/grade_calculator.md)** - Komplext system med många metoder

Se även **[exercises/index.md](exercises/index.md)** för fullständig översikt!

## 🚀 Grundläggande metodsyntax

### Enkel metod utan parametrar
```csharp
public static void SayHello()
{
    Console.WriteLine("Hej från min metod!");
}

// Anropa metoden
SayHello();
```

### Metod med parametrar
```csharp
public static void Greet(string name, int age)
{
    Console.WriteLine($"Hej {name}! Du är {age} år gammal.");
}

// Anropa metoden
Greet("Anna", 25);
```

### Metod som returnerar värde
```csharp
public static int Add(int a, int b)
{
    return a + b;
}

// Använd returvärdet
int result = Add(5, 3);
Console.WriteLine($"5 + 3 = {result}");
```

### Metod med både parametrar och returvärde
```csharp
public static double CalculateCircleArea(double radius)
{
    double area = Math.PI * radius * radius;
    return area;
}

// Använd metoden
double area = CalculateCircleArea(5.0);
Console.WriteLine($"Cirkelns area: {area:F2}");
```

## 🧩 Method Signatures förklarat

```csharp
public static int AddNumbers(int a, int b)
//  ↑      ↑    ↑      ↑           ↑
//  |      |    |      |           |
//  |      |    |      |           └─ Parametrar
//  |      |    |      └─ Metodnamn
//  |      |    └─ Returtyp
//  |      └─ static (tillhör klassen, inte en instans)
//  └─ Access modifier (public = alla kan använda)
```

### Olika returtyper
```csharp
public static void DoSomething()        // Returnerar inget (void)
public static int GetNumber()           // Returnerar int
public static string GetName()          // Returnerar string
public static bool IsValid()            // Returnerar boolean
public static double[] GetPrices()      // Returnerar array av doubles
```

## 📋 Praktiska exempel

### Validering av input
```csharp
public static bool IsValidAge(int age)
{
    return age >= 0 && age <= 120;
}

// Använd i main program
Console.WriteLine("Ange din ålder:");
if (int.TryParse(Console.ReadLine(), out int age))
{
    if (IsValidAge(age))
    {
        Console.WriteLine($"Din ålder {age} är giltig.");
    }
    else
    {
        Console.WriteLine("Ogiltig ålder!");
    }
}
```

### Formatering av utdata
```csharp
public static string FormatCurrency(double amount)
{
    return $"{amount:C}";
}

public static void PrintReceipt(string item, double price, int quantity)
{
    double total = price * quantity;
    Console.WriteLine($"{item}: {quantity}x {FormatCurrency(price)} = {FormatCurrency(total)}");
}

// Använd metoderna
PrintReceipt("Kaffe", 25.50, 2);
// Output: Kaffe: 2x 25,50 kr = 51,00 kr
```

### Meny-system med metoder
```csharp
public static void ShowMenu()
{
    Console.WriteLine("=== HUVUDMENY ===");
    Console.WriteLine("1. Visa info");
    Console.WriteLine("2. Beräkna");
    Console.WriteLine("3. Avsluta");
    Console.WriteLine("Välj alternativ (1-3):");
}

public static int GetMenuChoice()
{
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int choice) && 
            choice >= 1 && choice <= 3)
        {
            return choice;
        }
        Console.WriteLine("Ogiltigt val, försök igen (1-3):");
    }
}

public static void HandleMenuChoice(int choice)
{
    switch (choice)
    {
        case 1:
            ShowInfo();
            break;
        case 2:
            DoCalculation();
            break;
        case 3:
            Console.WriteLine("Hej då!");
            break;
    }
}
```

## 🔄 Method Overloading

Du kan ha flera metoder med samma namn men olika parametrar:

```csharp
// Olika antal parametrar
public static int Add(int a, int b)
{
    return a + b;
}

public static int Add(int a, int b, int c)
{
    return a + b + c;
}

// Olika parametertyper
public static double Add(double a, double b)
{
    return a + b;
}

// Användning
int result1 = Add(2, 3);        // Använder int-versionen
int result2 = Add(2, 3, 4);     // Använder trie-parameter versionen
double result3 = Add(2.5, 3.7); // Använder double-versionen
```

## 🔍 Scope (räckvidd)

### Lokala variabler
```csharp
public static void TestScope()
{
    int localVariable = 10; // Finns bara i denna metod
    
    if (localVariable > 5)
    {
        int blockVariable = 20; // Finns bara i detta block
        Console.WriteLine(blockVariable);
    }
    
    // blockVariable finns inte här!
    Console.WriteLine(localVariable); // Men localVariable finns här
}
```

### Parameterscope
```csharp
public static void ProcessData(int input) // 'input' är lokal till denna metod
{
    int result = input * 2; // 'result' är också lokal
    Console.WriteLine(result);
} // Både 'input' och 'result' försvinner här
```

## 💡 Best Practices

### 1. En metod, en uppgift
```csharp
// Bra - gör en sak
public static double CalculateCircleArea(double radius)
{
    return Math.PI * radius * radius;
}

// Mindre bra - gör flera saker
public static void CalculateAndPrintAndSaveArea(double radius)
{
    double area = Math.PI * radius * radius;
    Console.WriteLine($"Area: {area}");
    // Spara till fil...
    // Skicka email...
}
```

### 2. Beskrivande metodnamn
```csharp
// Bra namn
public static bool IsValidEmail(string email)
public static double ConvertCelsiusToFahrenheit(double celsius)
public static void PrintWelcomeMessage()

// Mindre bra namn
public static bool Check(string email)
public static double Convert(double temp)
public static void Print()
```

### 3. Begränsa antal parametrar
```csharp
// Bra - få parametrar
public static string FormatName(string firstName, string lastName)

// Mindre bra - många parametrar
public static string FormatPerson(string firstName, string lastName, 
    int age, string email, string phone, string address, string city)
    
// Bättre - använd en klass eller struct för många relaterade värden
```

### 4. Hantera edge cases
```csharp
public static double Divide(double a, double b)
{
    if (b == 0)
    {
        Console.WriteLine("Kan inte dividera med noll!");
        return 0; // Eller throw exception
    }
    return a / b;
}
```

## ⚠️ Vanliga misstag

### Glöm att returnera värde
```csharp
// FEL - lovar returnera int men gör det inte
public static int GetAge()
{
    int age = 25;
    // Glömt: return age;
} // Kompileringsfel!

// RÄTT
public static int GetAge()
{
    int age = 25;
    return age;
}
```

### Försöka använda lokala variabler utanför scope
```csharp
public static void BadExample()
{
    if (true)
    {
        int x = 10;
    }
    Console.WriteLine(x); // Kompileringsfel - x finns inte här
}
```

### Static vs instance förvirring
```csharp
// Static metod - kan anropas utan att skapa objekt
public static void StaticMethod()
{
    Console.WriteLine("Jag är static!");
}

// Anropa static metod
StaticMethod(); // Fungerar

// Instance metod - kräver objekt (kommer senare i kursen)
public void InstanceMethod()
{
    Console.WriteLine("Jag behöver ett objekt!");
}
```

## 🎯 När du behärskar metoder

Du kommer kunna:
- ✅ Bryta ner stora problem i mindre, hanterbara delar
- ✅ Skriva återanvändbar kod som inte upprepas
- ✅ Skapa välorganiserade program med tydlig struktur
- ✅ Debugga enklare genom att isolera funktionalitet
- ✅ Vara redo för objektorienterad programmering

## 🚀 Studieordning

1. **Börja med enkla metoder** - void metoder utan parametrar
2. **Lägg till parametrar** - Skicka data till metoder
3. **Lägg till returvärden** - Få data tillbaka från metoder
4. **Kombinera allt** - Metoder med både parametrar och returvärden
5. **Gör övningarna** - Praktisera med riktiga problem
6. **Experimentera** - Skapa egna metoder för dina program

---

**Lycka till med metoderna! 🎉**

*Nästa steg: Objektorienterad programmering med klasser och objekt*
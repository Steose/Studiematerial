---
title: "Enums i C#"
nav_order: 50
parent: "Grundläggande C#"
permalink: /docs/enums
updated: '2025-01-02 14:30:00'
---

# Enums

## 💡 Vad är enums?

Tänk dig att du är Neo i Matrix och måste välja mellan olika piller. Röd pill, blå pill, kanske grön pill för att återvända till verkligheten. Du vill inte bara ha `int pilChoice = 1` där du måste komma ihåg att 1 betyder röd och 2 betyder blå. Det blir snabbt rörigt!

📘 Enums är precis som Neo's pillarsenal - en tydlig, namngiven uppsättning val som gör din kod läsbar och säker. Istället för magiska nummer får du `PillColor.Red` eller `PillColor.Blue`. Mycket tydligare, eller hur?

I min erfarenhet är enums en av de mest underskattade funktionerna i C#. De gör din kod så mycket mer läsbar och mindre felbenägen. Hängde du med?

## 🔧 Grundprinciper

### Princip 1: Namngivna konstanter
Enums är i grunden namngivna konstanter som representerar en grupp relaterade värden. Tänk på dem som en lista över alla tillgängliga val i ett specifikt sammanhang.

Som när Gandalf säger "Du kan inte passera!" - han har begränsade alternativ: `WizardAction.Block`, `WizardAction.Fight` eller `WizardAction.Retreat`. Inte bara siffror som 1, 2, 3.

### Princip 2: Typsäkerhet
Enums ger dig compile-time säkerhet. Du kan inte av misstag tilldela ett felaktigt värde. Tänk på det som att ha en bouncer på en exklusiv klubb - bara medlemmarna släpps in.

## 💭 Tänk så här (Pseudokod)
```plaintext
SKAPA enum med alla möjliga val
  Alternativ1 = värde1
  Alternativ2 = värde2
  Alternativ3 = värde3

ANVÄND enum i kod
  OM valet är Alternativ1
    GÖR specifik action för alternativ1
  ANNARS OM valet är Alternativ2  
    GÖR specifik action för alternativ2
```

## 🚀 Minimal implementation
```csharp
// Enklaste möjliga enum - superhjälte-status
public enum HeroStatus
{
    Active,      // 0
    Injured,     // 1  
    Retired,     // 2
    Missing      // 3
}

// Användning - enkelt och tydligt
HeroStatus tonyStark = HeroStatus.Active;
Console.WriteLine($"Iron Man status: {tonyStark}"); // Iron Man status: Active
```

### 🟢 Grundläggande användning
```csharp
// Avengers missionstyper - tydliga och läsbara
public enum MissionType
{
    Reconnaissance,  // Spaning
    Rescue,         // Räddning  
    Combat,         // Strid
    Stealth,        // Smyg
    Diplomatic      // Diplomati
}

// Tilldela mission till en Avenger
public class AvengersHQ
{
    public void AssignMission(string heroName, MissionType mission)
    {
        // Switch statement blir super läsbart med enum
        switch (mission)
        {
            case MissionType.Stealth:
                Console.WriteLine($"{heroName} gets the stealth mission - perfect for Black Widow!");
                break;
            case MissionType.Combat:
                Console.WriteLine($"{heroName} assigned to combat - Hulk smash time!");
                break;
            case MissionType.Diplomatic:
                Console.WriteLine($"{heroName} handling diplomacy - Captain America's specialty!");
                break;
            default:
                Console.WriteLine($"{heroName} gets standard mission assignment");
                break;
        }
    }
}
```

### 🟡 Avancerad användning
```csharp
// E-commerce orderstatus med explicita värden och attribut
[Flags] // Tillåter kombinationer av värden
public enum OrderStatus
{
    Pending = 1,        // 0001
    Confirmed = 2,      // 0010  
    Shipped = 4,        // 0100
    Delivered = 8,      // 1000
    Cancelled = 16      // 10000
}

// Business logic för orderhantering
public class OrderManager
{
    public void ProcessOrder(int orderId, OrderStatus status)
    {
        // Kan kombinera flera statusar med [Flags]
        if (status.HasFlag(OrderStatus.Shipped | OrderStatus.Confirmed))
        {
            Console.WriteLine($"Order {orderId} is shipped and confirmed - send tracking info");
            SendTrackingEmail(orderId);
        }
        
        // Enum till string conversion för logging
        LogOrderStatus(orderId, status.ToString());
    }
    
    private void SendTrackingEmail(int orderId) => Console.WriteLine($"📧 Tracking email sent for order {orderId}");
    private void LogOrderStatus(int orderId, string status) => Console.WriteLine($"📝 Order {orderId}: {status}");
}
```

### 🔴 Proffstips
```csharp
// Enum med metoder - extension methods för extra funktionalitet
public enum Priority
{
    Low = 1,
    Medium = 2, 
    High = 3,
    Critical = 4
}

// Extension methods för enums - proffsnivå!
public static class PriorityExtensions
{
    public static string GetDescription(this Priority priority)
    {
        return priority switch
        {
            Priority.Low => "Can wait until next sprint",
            Priority.Medium => "Should be completed this week", 
            Priority.High => "Needs attention today",
            Priority.Critical => "DROP EVERYTHING AND FIX THIS!",
            _ => "Unknown priority level"
        };
    }
    
    public static ConsoleColor GetColor(this Priority priority)
    {
        return priority switch
        {
            Priority.Low => ConsoleColor.Green,
            Priority.Medium => ConsoleColor.Yellow,
            Priority.High => ConsoleColor.Red,
            Priority.Critical => ConsoleColor.Magenta,
            _ => ConsoleColor.White
        };
    }
}

// Användning av extension methods
var bugPriority = Priority.Critical;
Console.WriteLine($"Bug priority: {bugPriority.GetDescription()}");
```

## ⚠️ Vanliga misstag
* **Misstag 1**: Använda `int` istället för enum för val som har begränsade alternativ. Det är som att använda "1, 2, 3" istället för "Small, Medium, Large" för t-shirt storlekar - går att förstå men inte tydligt.

* **Misstag 2**: Glömma att hantera nya enum-värden i switch statements. När du lägger till `MissionType.Undercover` men glömmer uppdatera din switch, får du en tyst bug som är svår att hitta.

## 📚 Sammanfattning
* 💡 **Named Constants** - Enums ger tydliga namn åt magiska nummer och gör kod läsbar
* 💡 **Type Safety** - Compile-time kontroll hindrar felaktiga värdetilldelningar  
* 💡 **Switch Friendly** - Perfekt för switch statements och conditional logic
* 💡 **Extensible** - Kan utökas med extension methods för extra funktionalitet

## 🔍 Kodexempel i fullversion
👉 [Exempel: Avengers Mission Management System](./examples/enums-example.md)

## 🧪 Övningar
1. [🟢 Grundläggande enums](./exercises/enums-basic.md)
2. [🟡 Praktisk tillämpning](./exercises/enums-intermediate.md)  
3. [🔴 Avancerade tekniker](./exercises/enums-advanced.md)

## 😄 Obligatoriskt pappaskämt
Varför gillar programmerare enums så mycket? För att de är *enum-ormously* användbara! 🥁

---
**Marcus berättar:** Jag minns första gången jag såg kod med `int status = 1` överallt och ingen visste vad siffrorna betydde. Det var som att läsa hemliga koder utan nyckel. När jag upptäckte enums blev allt så mycket klarare - som att få glasögon för första gången. Plötsligt kunde jag läsa `OrderStatus.Shipped` istället för att gissa vad "3" betydde. Game changer!
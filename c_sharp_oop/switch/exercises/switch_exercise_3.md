# Övning 3: Starship Enterprise Security System

## 🎯 Mål med övningen

Efter den här övningen kommer du att kunna:

- Använda avancerad pattern matching med tuples
- Implementera switch expressions med when-clauses
- Hantera komplexa boolean logic i switch patterns
- Skapa säkra access control system

## 🧩 Uppgiften

Nu ska ni bygga säkerhetssystemet för USS Enterprise! Som säkerhetsansvarig på skeppet måste ni kontrollera vem som får access till vilka områden baserat på deras rang, clearance level och aktuell duty status.

Captain Kirk kan gå överallt, men en ensign kanske inte ska ha tillgång till warp core under red alert!

## 🚀 Kom igång: Startkod

```csharp
using System;

// Enums för clean code
public enum Rank
{
    Ensign,
    Lieutenant,
    Commander,
    Captain,
    Admiral
}

public enum ClearanceLevel
{
    Public,
    Restricted,
    Classified,
    TopSecret
}

public enum AlertStatus
{
    Green,    // All clear
    Yellow,   // Caution
    Red       // Battle stations!
}

public enum ShipArea
{
    Bridge,
    Engineering,
    Sickbay,
    Transporter,
    Armory,
    WarpCore,
    TacticalRoom
}

class Program
{
    static void Main()
    {
        Console.WriteLine("🚀 USS ENTERPRISE SECURITY SYSTEM 🚀");
        Console.WriteLine();

        // Test olika access scenarios
        TestSecuritySystem();
    }

    static void TestSecuritySystem()
    {
        Console.WriteLine("=== TESTING ACCESS CONTROL ===");

        // TODO: Testa dessa scenarios
        TestAccess("Captain Kirk", Rank.Captain, ClearanceLevel.TopSecret, AlertStatus.Green, ShipArea.Bridge);
        TestAccess("Ensign Ricky", Rank.Ensign, ClearanceLevel.Public, AlertStatus.Red, ShipArea.WarpCore);
        TestAccess("Dr. McCoy", Rank.Commander, ClearanceLevel.Classified, AlertStatus.Yellow, ShipArea.Sickbay);
        TestAccess("Mr. Spock", Rank.Commander, ClearanceLevel.TopSecret, AlertStatus.Red, ShipArea.TacticalRoom);
    }

    static void TestAccess(string name, Rank rank, ClearanceLevel clearance,
                          AlertStatus alert, ShipArea requestedArea)
    {
        bool hasAccess = CheckAccess(rank, clearance, alert, requestedArea);
        string reason = GetAccessReason(rank, clearance, alert, requestedArea);

        Console.WriteLine($"\n--- {name} ---");
        Console.WriteLine($"Rang: {rank}");
        Console.WriteLine($"Clearance: {clearance}");
        Console.WriteLine($"Ship Alert: {alert}");
        Console.WriteLine($"Begär access till: {requestedArea}");
        Console.WriteLine($"RESULTAT: {(hasAccess ? "✅ ACCESS GRANTED" : "❌ ACCESS DENIED")}");
        Console.WriteLine($"Anledning: {reason}");
    }

    // TODO: Implementera med tuple pattern matching
    static bool CheckAccess(Rank rank, ClearanceLevel clearance, AlertStatus alert, ShipArea area)
    {
        // DIN KOD HÄR - använd tuple patterns och when-clauses!
        return false; // Placeholder
    }

    // TODO: Implementera för att ge användbar feedback
    static string GetAccessReason(Rank rank, ClearanceLevel clearance, AlertStatus alert, ShipArea area)
    {
        // DIN KOD HÄR - förklara varför access gavs eller nekades
        return "Not implemented"; // Placeholder
    }
}
```

## ✅ Förväntat resultat

```
🚀 USS ENTERPRISE SECURITY SYSTEM 🚀

=== TESTING ACCESS CONTROL ===

--- Captain Kirk ---
Rang: Captain
Clearance: TopSecret
Ship Alert: Green
Begär access till: Bridge
RESULTAT: ✅ ACCESS GRANTED
Anledning: Captain har alltid access till Bridge

--- Ensign Ricky ---
Rang: Ensign
Clearance: Public
Ship Alert: Red
Begär access till: WarpCore
RESULTAT: ❌ ACCESS DENIED
Anledning: WarpCore kräver minst Commander-rang under Red Alert

--- Dr. McCoy ---
Rang: Commander
Clearance: Classified
Ship Alert: Yellow
Begär access till: Sickbay
RESULTAT: ✅ ACCESS GRANTED
Anledning: Medical personal har alltid access till Sickbay
```

## 🕵️‍♂️ Hur testar vi att det funkar?

1. **Som Captain vill jag ha access överallt oavsett alert status**
2. **Som Ensign vill jag bara ha access till icke-kritiska områden**
3. **Som Medical Officer vill jag alltid ha access till Sickbay**
4. **Under Red Alert vill jag att endast senior officers får access till känsliga områden**

## 🤔 Diskussion i paret

Snacka ihop er!

1. Vilka fördelar har tuple patterns jämfört med nested if-statements?
2. Hur skulle ni utöka systemet för att hantera temporary permissions?
3. När är switch expressions INTE det bästa valet för complex logic?

## 🔥 BONUS: Kodbyte och Felsökning

Byt kod med ett annat par och granska:

- **Security**: Finns det säkerhetshål i access logic?
- **Edge cases**: Vad händer med null values eller okända enums?
- **Maintainability**: Hur lätt är det att lägga till nya areas eller ranks?
- **Performance**: Är logic effektiv för många samtidiga requests?

<details>
<summary>💡 Klicka här för ett </summary>

```csharp
using System;

public enum Rank
{
    Ensign,
    Lieutenant,
    Commander,
    Captain,
    Admiral
}

public enum ClearanceLevel
{
    Public,
    Restricted,
    Classified,
    TopSecret
}

public enum AlertStatus
{
    Green,
    Yellow,
    Red
}

public enum ShipArea
{
    Bridge,
    Engineering,
    Sickbay,
    Transporter,
    Armory,
    WarpCore,
    TacticalRoom
}

class Program
{
    static void Main()
    {
        Console.WriteLine("🚀 USS ENTERPRISE SECURITY SYSTEM 🚀");
        Console.WriteLine();

        TestSecuritySystem();
    }

    static void TestSecuritySystem()
    {
        Console.WriteLine("=== TESTING ACCESS CONTROL ===");

        TestAccess("Captain Kirk", Rank.Captain, ClearanceLevel.TopSecret, AlertStatus.Green, ShipArea.Bridge);
        TestAccess("Ensign Ricky", Rank.Ensign, ClearanceLevel.Public, AlertStatus.Red, ShipArea.WarpCore);
        TestAccess("Dr. McCoy", Rank.Commander, ClearanceLevel.Classified, AlertStatus.Yellow, ShipArea.Sickbay);
        TestAccess("Mr. Spock", Rank.Commander, ClearanceLevel.TopSecret, AlertStatus.Red, ShipArea.TacticalRoom);
        TestAccess("Lt. Uhura", Rank.Lieutenant, ClearanceLevel.Restricted, AlertStatus.Green, ShipArea.Bridge);
    }

    static void TestAccess(string name, Rank rank, ClearanceLevel clearance,
                          AlertStatus alert, ShipArea requestedArea)
    {
        bool hasAccess = CheckAccess(rank, clearance, alert, requestedArea);
        string reason = GetAccessReason(rank, clearance, alert, requestedArea);

        Console.WriteLine($"\n--- {name} ---");
        Console.WriteLine($"Rang: {rank}");
        Console.WriteLine($"Clearance: {clearance}");
        Console.WriteLine($"Ship Alert: {alert}");
        Console.WriteLine($"Begär access till: {requestedArea}");
        Console.WriteLine($"RESULTAT: {(hasAccess ? "✅ ACCESS GRANTED" : "❌ ACCESS DENIED")}");
        Console.WriteLine($"Anledning: {reason}");
    }

    static bool CheckAccess(Rank rank, ClearanceLevel clearance, AlertStatus alert, ShipArea area)
    {
        return (rank, clearance, alert, area) switch
        {
            // Captain och Admiral har access överallt
            (Rank.Captain or Rank.Admiral, _, _, _) => true,

            // Special cases för specific areas
            (_, _, _, ShipArea.Sickbay) => rank >= Rank.Lieutenant, // Medical access

            // WarpCore access - super restrictive under Red Alert
            (_, _, AlertStatus.Red, ShipArea.WarpCore) => rank >= Rank.Commander && clearance >= ClearanceLevel.TopSecret,
            (_, _, _, ShipArea.WarpCore) => rank >= Rank.Lieutenant && clearance >= ClearanceLevel.Classified,

            // TacticalRoom - classified operations
            (_, _, AlertStatus.Red, ShipArea.TacticalRoom) => rank >= Rank.Commander && clearance >= ClearanceLevel.Classified,
            (_, _, _, ShipArea.TacticalRoom) => rank >= Rank.Lieutenant && clearance >= ClearanceLevel.Restricted,

            // Bridge access baserat på alert level
            (_, _, AlertStatus.Red, ShipArea.Bridge) => rank >= Rank.Lieutenant,
            (_, _, _, ShipArea.Bridge) => rank >= Rank.Ensign && clearance >= ClearanceLevel.Restricted,

            // Armory - weapons access
            (_, _, AlertStatus.Red, ShipArea.Armory) => rank >= Rank.Lieutenant && clearance >= ClearanceLevel.Restricted,
            (_, _, _, ShipArea.Armory) => rank >= Rank.Commander,

            // Engineering - technical areas
            (_, _, AlertStatus.Red, ShipArea.Engineering) => rank >= Rank.Lieutenant && clearance >= ClearanceLevel.Restricted,
            (_, _, _, ShipArea.Engineering) => rank >= Rank.Ensign,

            // Transporter - generally accessible
            (_, _, _, ShipArea.Transporter) => rank >= Rank.Ensign,

            // Default deny för säkerhet
            _ => false
        };
    }

    static string GetAccessReason(Rank rank, ClearanceLevel clearance, AlertStatus alert, ShipArea area)
    {
        bool hasAccess = CheckAccess(rank, clearance, alert, area);

        return (hasAccess, rank, area, alert) switch
        {
            // Success messages
            (true, Rank.Captain or Rank.Admiral, _, _) => "Senior officer har universal access",
            (true, _, ShipArea.Sickbay, _) => "Medical access granted för patient care",
            (true, _, ShipArea.Bridge, AlertStatus.Green) => "Standard bridge access under normal operations",
            (true, _, ShipArea.WarpCore, _) => "Engineering clearance verified för warp core access",
            (true, _, _, _) => "Access granted baserat på rang och clearance level",

            // Denial messages
            (false, _, ShipArea.WarpCore, AlertStatus.Red) => "WarpCore låst under Red Alert - endast senior staff",
            (false, _, ShipArea.Bridge, AlertStatus.Red) => "Bridge restricted under Red Alert",
            (false, _, ShipArea.TacticalRoom, _) => "Tactical operations kräver högre clearance",
            (false, _, ShipArea.Armory, _) => "Weapons access nekad - för låg rang eller clearance",
            (false, _, _, AlertStatus.Red) => $"{area} är låst under Red Alert för din rangnivå",

            // Default denial
            (false, _, _, _) => $"Otillräcklig rang ({rank}) eller clearance ({clearance}) för {area}"
        };
    }
}
```

</details>

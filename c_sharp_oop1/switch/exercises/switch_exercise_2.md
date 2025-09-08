# Övning 2: Avengers Shopping Cart med Switch Expressions

## 🎯 Mål med övningen

Efter den här övningen kommer du att kunna:

- Använda moderna switch expressions i C#
- Implementera pattern matching med when-clauses
- Kombinera switch expressions med methods
- Hantera komplexa business logic på ett clean sätt

## 🧩 Uppgiften

Nu ska ni bygga en shopping cart för Avengers merchandise! Tänk er att ni arbetar för Marvel och ska skapa ett system som automatiskt beräknar priser och rabatter baserat på produkttyp, quantity och membership level.

Tony Stark vill ha premium pricing, medan Peter Parker behöver student-rabatt!

## 🚀 Kom igång: Startkod

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("🛒 AVENGERS MERCHANDISE STORE 🛒");
        Console.WriteLine();

        // Test olika scenarios
        TestShoppingCart();
    }

    static void TestShoppingCart()
    {
        // TODO: Testa ditt system med dessa scenarios
        Console.WriteLine("=== CUSTOMER: TONY STARK (VIP) ===");
        // Calculate price för: "action_figure", quantity: 5, membership: "vip"

        Console.WriteLine("\n=== CUSTOMER: PETER PARKER (STUDENT) ===");
        // Calculate price för: "t_shirt", quantity: 2, membership: "student"

        Console.WriteLine("\n=== CUSTOMER: PEPPER POTTS (REGULAR) ===");
        // Calculate price för: "poster", quantity: 10, membership: "regular"
    }

    // TODO: Implementera denna method med switch expression
    static decimal CalculatePrice(string productType, int quantity, string membership)
    {
        // DIN KOD HÄR - använd switch expression!
        // Base price först, sedan membership discount
        return 0; // Placeholder
    }

    // TODO: Implementera denna method med switch expression
    static decimal GetMembershipDiscount(string membership, decimal basePrice) =>
        // DIN KOD HÄR
        0; // Placeholder
}
```

## ✅ Förväntat resultat

```
🛒 AVENGERS MERCHANDISE STORE 🛒

=== CUSTOMER: TONY STARK (VIP) ===
Produkt: Action Figure
Antal: 5 st
Grundpris: $199.95 (5 x $39.99)
VIP Rabatt: -$39.99 (20%)
TOTALPRIS: $159.96
Status: "Money is no object!" - Tony Stark

=== CUSTOMER: PETER PARKER (STUDENT) ===
Produkt: T-Shirt
Antal: 2 st
Grundpris: $49.98 (2 x $24.99)
Student Rabatt: -$12.50 (25%)
TOTALPRIS: $37.48
Status: "Thanks Mr. Stark for the discount!" - Peter Parker
```

## 🕵️‍♂️ Hur testar vi att det funkar?

1. **Som Tony Stark (VIP) vill jag få 20% rabatt på allt**
2. **Som Peter Parker (Student) vill jag få 25% rabatt för student discount**
3. **Som vanlig kund vill jag få standard pricing**
4. **Som köpare av stora kvantiteter (>5) vill jag få bulk discount**

## 🤔 Diskussion i paret

Snacka ihop er!

1. Varför är switch expressions bättre än if-else för pricing logic?
2. Hur skulle ni hantera nya produkttyper eller membership levels?
3. Vilka fördelar ser ni med pattern matching när ni har komplexa business rules?

## 🔥 BONUS: Kodbyte och Felsökning

Byt kod med ett annat par. Er uppgift är nu att agera kvalitetsgranskare och buggjägare. Leta efter:

- **Hårdkodade priser**: Borde vara konstanter eller i en config
- **Magiska siffror**: Vad betyder 20, 25, etc.?
- **Felhantering**: Vad händer med ogiltiga produkttyper?
- **Clean Code**: Är method-namnen beskrivande?

Ge varandra konstruktiv feedback. Målet är att hjälpa varandra!

<details>
<summary>💡 Klicka här för ett </summary>

```csharp
using System;

class Program
{
    // Konstanter för clean code
    const decimal ACTION_FIGURE_PRICE = 39.99m;
    const decimal T_SHIRT_PRICE = 24.99m;
    const decimal POSTER_PRICE = 15.99m;
    const decimal HOODIE_PRICE = 49.99m;

    static void Main()
    {
        Console.WriteLine("🛒 AVENGERS MERCHANDISE STORE 🛒");
        Console.WriteLine();

        TestShoppingCart();
    }

    static void TestShoppingCart()
    {
        // Tony Stark - VIP Customer
        Console.WriteLine("=== CUSTOMER: TONY STARK (VIP) ===");
        decimal tonyPrice = CalculatePrice("action_figure", 5, "vip");
        PrintReceipt("Action Figure", 5, ACTION_FIGURE_PRICE, tonyPrice, "vip");
        Console.WriteLine("Status: \"Money is no object!\" - Tony Stark");

        Console.WriteLine("\n=== CUSTOMER: PETER PARKER (STUDENT) ===");
        decimal peterPrice = CalculatePrice("t_shirt", 2, "student");
        PrintReceipt("T-Shirt", 2, T_SHIRT_PRICE, peterPrice, "student");
        Console.WriteLine("Status: \"Thanks Mr. Stark for the discount!\" - Peter Parker");

        Console.WriteLine("\n=== CUSTOMER: PEPPER POTTS (REGULAR) ===");
        decimal pepperPrice = CalculatePrice("poster", 10, "regular");
        PrintReceipt("Poster", 10, POSTER_PRICE, pepperPrice, "regular");
        Console.WriteLine("Status: \"Organizing Tony's merch collection\" - Pepper Potts");
    }

    static decimal CalculatePrice(string productType, int quantity, string membership)
    {
        // Först får vi base price per produkt
        decimal unitPrice = productType.ToLower() switch
        {
            "action_figure" => ACTION_FIGURE_PRICE,
            "t_shirt" => T_SHIRT_PRICE,
            "poster" => POSTER_PRICE,
            "hoodie" => HOODIE_PRICE,
            _ => throw new ArgumentException($"Okänd produkttyp: {productType}")
        };

        decimal basePrice = unitPrice * quantity;

        // Bulk discount för stora beställningar
        decimal bulkPrice = quantity switch
        {
            > 10 => basePrice * 0.85m, // 15% bulk discount
            > 5 => basePrice * 0.90m,  // 10% bulk discount
            _ => basePrice
        };

        // Membership discount
        return ApplyMembershipDiscount(membership, bulkPrice);
    }

    static decimal ApplyMembershipDiscount(string membership, decimal price) =>
        membership.ToLower() switch
        {
            "vip" => price * 0.80m,      // 20% rabatt för Tony Stark niveau
            "student" => price * 0.75m,  // 25% rabatt för broke college kids
            "employee" => price * 0.50m, // 50% staff discount
            "regular" => price,          // Inga rabatter för vanliga människor
            _ => price // Okänd membership = regular price
        };

    static void PrintReceipt(string productName, int quantity, decimal unitPrice,
                           decimal finalPrice, string membership)
    {
        decimal basePrice = unitPrice * quantity;
        decimal discount = basePrice - finalPrice;
        decimal discountPercent = discount / basePrice * 100;

        Console.WriteLine($"Produkt: {productName}");
        Console.WriteLine($"Antal: {quantity} st");
        Console.WriteLine($"Grundpris: ${basePrice:F2} ({quantity} x ${unitPrice:F2})");

        if (discount > 0)
        {
            string discountType = membership.ToLower() switch
            {
                "vip" => "VIP",
                "student" => "Student",
                "employee" => "Employee",
                _ => "Bulk"
            };
            Console.WriteLine($"{discountType} Rabatt: -${discount:F2} ({discountPercent:F0}%)");
        }

        Console.WriteLine($"TOTALPRIS: ${finalPrice:F2}");
    }
}
```

</details>

# Övning 1: RPG Karaktärsväljare

## 🎯 Mål med övningen

Efter den här övningen kommer du att kunna:

- Använda grundläggande switch-statements i C#
- Hantera flera cases med samma resultat
- Implementera default-fall för okända inputs
- Skriva clean code med tydlig struktur

## 🧩 Uppgiften

Nu ska ni bygga en RPG-karaktärsväljare inspirerad av Lord of the Rings! Tänk er att ni utvecklar nästa stora fantasy-spel och spelarna ska kunna välja mellan olika karaktärsklasser.

Varje klass har sina egna starting stats, utrustning och specialförmågor.

## 🚀 Kom igång: Startkod

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== MIDDLE-EARTH CHARACTER CREATOR ===");
        Console.WriteLine("Välj din karaktärsklass:");
        Console.WriteLine("1. Warrior (Aragorn-style)");
        Console.WriteLine("2. Wizard (Gandalf-style)");
        Console.WriteLine("3. Rogue (Legolas-style)");
        Console.WriteLine("4. Dwarf (Gimli-style)");
        Console.WriteLine("5. Hobbit (Frodo-style)");

        Console.Write("\nAnge ditt val (1-5): ");
        string input = Console.ReadLine();

        // TODO: Implementera switch-statement här
        SelectCharacterClass(input);
    }

    static void SelectCharacterClass(string choice)
    {
        // DIN KOD HÄR - använd switch statement!
    }
}
```

## ✅ Förväntat resultat

När ni kör er färdiga kod och väljer "1", borde terminalen visa något i stil med detta:

```
=== KARAKTÄR SKAPAD ===
Klass: Warrior
Inspiration: Aragorn, King of Gondor
Hälsa: 100 HP
Styrka: 8/10
Intelligens: 6/10
Smidighet: 7/10

Startautrustning:
- Andúril (Legendary Sword)
- Chain Mail Armor
- Healing Potions x3

Specialförmåga: "Kingsfoil Healing" - Kan läka sig själv och andra
```

## 🕵️‍♂️ Hur testar vi att det funkar?

Hur vet du att din kod gör det den ska? Jo, testa att:

1. **Som användare vill jag kunna välja Warrior och få Aragorn-stats**
2. **Som användare vill jag kunna välja Wizard och få Gandalf-inspirerade krafter**
3. **Som användare vill jag få ett tydligt felmeddelande om jag skriver "99"**
4. **Som användare vill jag se snygg formatering som gör det lätt att läsa**

## 🤔 Diskussion i paret

Snacka ihop er!

1. Vilken var den svåraste delen att implementera? Varför?
2. Finns det andra sätt att lösa samma problem på? (if-else?)
3. Vad händer om användaren skriver "warrior" istället för "1"? Hur skulle du hantera det?

## 💡 Tips

- Använd `\n` för radbrytningar i dina Console.WriteLine
- Tänk på att ha en bra default-case för ogiltiga inputs
- Kanske skapa separata metoder för varje karaktärsklass för att hålla koden clean?

<details>
<summary>💡 Klicka här för ett </summary>

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== MIDDLE-EARTH CHARACTER CREATOR ===");
        Console.WriteLine("Välj din karaktärsklass:");
        Console.WriteLine("1. Warrior (Aragorn-style)");
        Console.WriteLine("2. Wizard (Gandalf-style)");
        Console.WriteLine("3. Rogue (Legolas-style)");
        Console.WriteLine("4. Dwarf (Gimli-style)");
        Console.WriteLine("5. Hobbit (Frodo-style)");

        Console.Write("\nAnge ditt val (1-5): ");
        string input = Console.ReadLine();

        SelectCharacterClass(input);
    }

    static void SelectCharacterClass(string choice)
    {
        Console.WriteLine("\n=== KARAKTÄR SKAPAD ===");

        switch (choice)
        {
            case "1":
                Console.WriteLine("Klass: Warrior");
                Console.WriteLine("Inspiration: Aragorn, King of Gondor");
                Console.WriteLine("Hälsa: 100 HP");
                Console.WriteLine("Styrka: 8/10");
                Console.WriteLine("Intelligens: 6/10");
                Console.WriteLine("Smidighet: 7/10");
                Console.WriteLine("\nStartautrustning:");
                Console.WriteLine("- Andúril (Legendary Sword)");
                Console.WriteLine("- Chain Mail Armor");
                Console.WriteLine("- Healing Potions x3");
                Console.WriteLine("\nSpecialförmåga: \"Kingsfoil Healing\" - Kan läka sig själv och andra");
                break;

            case "2":
                Console.WriteLine("Klass: Wizard");
                Console.WriteLine("Inspiration: Gandalf the Grey");
                Console.WriteLine("Hälsa: 70 HP");
                Console.WriteLine("Styrka: 4/10");
                Console.WriteLine("Intelligens: 10/10");
                Console.WriteLine("Smidighet: 5/10");
                Console.WriteLine("\nStartautrustning:");
                Console.WriteLine("- Staff of Power");
                Console.WriteLine("- Spell Book");
                Console.WriteLine("- Magic Ring");
                Console.WriteLine("\nSpecialförmåga: \"You shall not pass!\" - Kan blockera fiender");
                break;

            case "3":
                Console.WriteLine("Klass: Rogue");
                Console.WriteLine("Inspiration: Legolas Greenleaf");
                Console.WriteLine("Hälsa: 80 HP");
                Console.WriteLine("Styrka: 7/10");
                Console.WriteLine("Intelligens: 7/10");
                Console.WriteLine("Smidighet: 10/10");
                Console.WriteLine("\nStartautrustning:");
                Console.WriteLine("- Elven Bow");
                Console.WriteLine("- Quiver with 50 arrows");
                Console.WriteLine("- Elven cloak");
                Console.WriteLine("\nSpecialförmåga: \"Perfect Shot\" - Missar aldrig sitt mål");
                break;

            case "4":
                Console.WriteLine("Klass: Dwarf");
                Console.WriteLine("Inspiration: Gimli, son of Glóin");
                Console.WriteLine("Hälsa: 120 HP");
                Console.WriteLine("Styrka: 9/10");
                Console.WriteLine("Intelligens: 5/10");
                Console.WriteLine("Smidighet: 4/10");
                Console.WriteLine("\nStartautrustning:");
                Console.WriteLine("- Battle Axe");
                Console.WriteLine("- Dwarven Armor");
                Console.WriteLine("- Ale Horn (never empty)");
                Console.WriteLine("\nSpecialförmåga: \"Axe Mastery\" - Extra skada med yxor");
                break;

            case "5":
                Console.WriteLine("Klass: Hobbit");
                Console.WriteLine("Inspiration: Frodo Baggins");
                Console.WriteLine("Hälsa: 60 HP");
                Console.WriteLine("Styrka: 3/10");
                Console.WriteLine("Intelligens: 8/10");
                Console.WriteLine("Smidighet: 9/10");
                Console.WriteLine("\nStartautrustning:");
                Console.WriteLine("- Sting (Glowing sword)");
                Console.WriteLine("- Mithril shirt");
                Console.WriteLine("- Lembas bread x10");
                Console.WriteLine("\nSpecialförmåga: \"Second Breakfast\" - Kan äta för att återställa HP");
                break;

            default:
                Console.WriteLine("Okänt val! Välj mellan 1-5.");
                Console.WriteLine("Du får vara en vanlig NPC istället... 😢");
                Console.WriteLine("\nTips: Starta om programmet och välj en riktig karaktärsklass!");
                break;
        }
    }
}
```

</details>

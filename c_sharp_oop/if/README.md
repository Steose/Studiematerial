# ❓ If-satser och villkorsstyrd logik

Lär dig styra dina programs flöde med if-satser! Detta är där din kod börjar ta beslut och bli smart.

## 🎯 Vad du kommer att lära dig

- if, else if och else-satser
- Boolean-operatorer (&&, ||, !)  
- Jämförelseoperatorer (==, !=, <, >, <=, >=)
- Nested if-statements
- Ternary operator (?:)
- Switch-statements

## 📚 Innehåll

### 📖 Lectures och teori
- **[if_statements.md](lecture/if_statements.md)** - Grundläggande if-satser
- **[if_and_variables.md](lecture/if_and_variables.md)** - Kombinera if-satser med variabler

### 🏋️ Praktiska övningar
- **[if-exempel.md](exercises/if-exempel.md)** - Grundläggande if-exempel
- **[decision-chaos.md](exercises/decision-chaos.md)** - Komplexa beslutsscenarion
- **[life-decisions.md](exercises/life-decisions.md)** - Verkliga beslutssituationer

## 🚀 Grundläggande if-syntax

### Enkel if
```csharp
int age = 20;

if (age >= 18)
{
    Console.WriteLine("Du är myndig!");
}
```

### if-else
```csharp
int score = 85;

if (score >= 70)
{
    Console.WriteLine("Du är godkänd!");
}
else
{
    Console.WriteLine("Du behöver studera mer.");
}
```

### if-else if-else
```csharp
int grade = 92;

if (grade >= 90)
{
    Console.WriteLine("Betyg: A");
}
else if (grade >= 80)
{
    Console.WriteLine("Betyg: B");
}
else if (grade >= 70)
{
    Console.WriteLine("Betyg: C");
}
else
{
    Console.WriteLine("Betyg: F");
}
```

## 🔧 Jämförelseoperatorer

```csharp
int x = 10;
int y = 20;

// Likhet
if (x == y) { /* false */ }
if (x != y) { /* true */ }

// Storlek
if (x < y)  { /* true */ }
if (x > y)  { /* false */ }
if (x <= y) { /* true */ }
if (x >= y) { /* false */ }
```

## 🧠 Logiska operatorer

### AND (&&) - Båda villkor måste vara sanna
```csharp
int age = 25;
bool hasLicense = true;

if (age >= 18 && hasLicense)
{
    Console.WriteLine("Du får köra bil!");
}
```

### OR (||) - Minst ett villkor måste vara sant
```csharp
string day = "Saturday";

if (day == "Saturday" || day == "Sunday")
{
    Console.WriteLine("Det är helg!");
}
```

### NOT (!) - Vänder på sanningsvärdet
```csharp
bool isRaining = false;

if (!isRaining)
{
    Console.WriteLine("Bra väder för promenad!");
}
```

## 🎲 Switch-statements

För många val är switch ofta tydligare:

```csharp
int dayNumber = 3;
string dayName;

switch (dayNumber)
{
    case 1:
        dayName = "Måndag";
        break;
    case 2:
        dayName = "Tisdag";
        break;
    case 3:
        dayName = "Onsdag";
        break;
    default:
        dayName = "Okänd dag";
        break;
}

Console.WriteLine(dayName);
```

## ⚡ Ternary operator (kort if)

```csharp
int age = 20;
string status = (age >= 18) ? "Myndig" : "Omyndig";
Console.WriteLine(status);
```

## 💡 Best Practices

### Tydliga villkor
```csharp
// Bra - lätt att förstå
if (temperature > 30)
{
    Console.WriteLine("Det är varmt!");
}

// Mindre bra - svårare att förstå
if (t > 30) Console.WriteLine("Det är varmt!");
```

### Använd paranteser
```csharp
// Bra - tydligt vad som grupperas
if ((age >= 18 && hasLicense) || isEmergency)
{
    // ...
}

// Mindre bra - oklart vad som grupperas först
if (age >= 18 && hasLicense || isEmergency)
{
    // ...
}
```

### Undvik djupt nästade if-satser
```csharp
// Bra - early return pattern
if (user == null)
{
    Console.WriteLine("Ingen användare hittad");
    return;
}

if (user.Age < 18)
{
    Console.WriteLine("För ung");
    return;
}

// Huvudlogiken här

// Mindre bra - djup nästning
if (user != null)
{
    if (user.Age >= 18)
    {
        // Huvudlogiken här
    }
    else
    {
        Console.WriteLine("För ung");
    }
}
else
{
    Console.WriteLine("Ingen användare hittad");
}
```

## ⚠️ Vanliga misstag

### Glöm inte dubbla likhetstecken
```csharp
// FEL - tilldelning istället för jämförelse
if (x = 5) // Kompileringsfel i C#

// RÄTT - jämförelse
if (x == 5)
```

### Boolean-jämförelser
```csharp
bool isActive = true;

// Onödigt - redan en boolean
if (isActive == true)

// Bättre
if (isActive)

// För false
if (!isActive)
```

## 🎯 När du behärskar if-satser

Du kommer kunna:
- ✅ Skapa program som tar beslut baserat på data
- ✅ Validera användarinput
- ✅ Skapa interaktiva program med olika flöden
- ✅ Kombinera flera villkor för komplexa logik
- ✅ Vara redo för nästa steg: [loop](../loop/)

## 🚀 Studieordning

1. **Börja med grunderna** - Enkel if och else
2. **Öva jämförelseoperatorer** - ==, !=, <, >, etc.
3. **Lär dig logiska operatorer** - &&, ||, !
4. **Testa nested if-statements** - If inuti if
5. **Prova switch-statements** - För många alternativ
6. **Gör övningarna** - Praktisk tillämpning av allt du lärt dig

---

**Lycka till med if-satserna! 🎉**

*Nästa steg: [loop](../loop/) för att upprepa kod*
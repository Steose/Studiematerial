# Variabler & Casting + If-satser (Nybörjare)

## 1) `Console.ReadLine` → `int`

**Mål:** läsa text, spara i variabel, konvertera till heltal säkert.

**Uppgift:**
Skriv ett program som frågar efter användarens ålder.

- Läs in som `string`
- Försök konvertera till `int`
- Skriv ut: `Du är X år.`
- Om inmatningen inte är ett tal: skriv `Ogiltig ålder.`

**Tips:**

- Använd `int.TryParse(...)`

<details>
<summary></summary>

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ange din ålder: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int age))
        {
            Console.WriteLine($"Du är {age} år.");
        }
        else
        {
            Console.WriteLine("Kompis! Du skemta mig Aprillo!");
            Console.WriteLine("Ogiltig ålder.");
        }
    }
}
```

</details>

---

## 2) `Console.ReadLine` → `double`

**Mål:** läsa flyttal, förstå decimalpunkt/komma.

**Uppgift:**
Fråga efter priset på en produkt.

- Läs in och konvertera till `double`
- Skriv ut `Priset är X.xx` med två decimaler
- Vid felinmatning: `Ogiltigt pris.`

**Tips:**

- Använd `double.TryParse(...)`
- Bonus: testa med både `,` och `.` på din dator (kulturinställningar)

<details>
<summary></summary>

```csharp
using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Ange pris: ");
        string input = Console.ReadLine();

        // Försök med aktuell kultur först
        if (!double.TryParse(input, NumberStyles.Float, CultureInfo.CurrentCulture, out double price))
        {
            // Fallback: prova invariant kultur (decimalpunkt)
            double.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out price);
        }

        if (price > 0)
        {
            Console.WriteLine($"Priset är {price:F2}");
        }
        else
        {
            Console.WriteLine("Ogiltigt pris.");
        }
    }
}
```

</details>

---

## 3) `double` → `int` (trunkeringens “katastrof”)

**Mål:** se skillnaden mellan **trunkering** och **avrundning**.

**Uppgift:**
Be användaren ange ett mått i centimeter som `double` (t.ex. 179.9).

- Konvertera till `int` på två sätt:

  1. `(int)cm` (trunker)
  2. `Convert.ToInt32(cm)` (avrundar)

- Visa båda resultaten.

**Förväntad insikt:** `(int)179.9` blir `179` (tappar decimal), `Convert.ToInt32(179.9)` blir `180`.

<details>
<summary></summary>

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ange längd i cm (ex 179.9): ");
        if (double.TryParse(Console.ReadLine(), out double cm))
        {
            int trunkerat = (int)cm;                 // 179.9 -> 179
            int avrundat = Convert.ToInt32(cm);      // 179.9 -> 180

            Console.WriteLine($"Trunkerat: {trunkerat}");
            Console.WriteLine($"Avrundat: {avrundat}");
        }
        else
        {
            Console.WriteLine("Ogiltigt tal.");
        }
    }
}
```

</details>

---

## 4) `int` → `double` (undvik heltalsdivision)

**Mål:** förstå att `int / int` ger heltal; hur man får riktig decimaldivision.

**Uppgift:**
Läs in två heltal: `summa` och `antal`.

- Räkna ut medelvärdet.
- Visa först vad som händer med **heltalsdivision**, sedan korrekt **double-division**.

**Förväntad insikt:** `5 / 2` blir `2` som int, men `5 / 2.0` blir `2.5`.

<details>
<summary></summary>

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ange summa (heltal): ");
        int.TryParse(Console.ReadLine(), out int sum);

        Console.Write("Ange antal (heltal): ");
        int.TryParse(Console.ReadLine(), out int count);

        int heltalsMedel = sum / count;               // heltalsdivision
        double korrektMedel = (double)sum / count;    // typlyft till double

        Console.WriteLine($"Heltalsmedel: {heltalsMedel}");
        Console.WriteLine($"Korrekt medel: {korrektMedel:F2}");
    }
}
```

</details>

---

## 5) `float` vs `double` (precision)

**Mål:** se att `float` har lägre precision än `double`.

**Uppgift:**
Summera `0.1` tio gånger med `float` och med `double`.

- Jämför resultatet med 1.0
- Skriv ut skillnaden.

**Förväntad insikt:** små fel uppstår, och `double` är oftast mer exakt.

<details>
<summary></summary>

```csharp
using System;

class Program
{
    static void Main()
    {
        float f = 0f;
        for (int i = 0; i < 10; i++) f += 0.1f;

        double d = 0.0;
        for (int i = 0; i < 10; i++) d += 0.1;

        Console.WriteLine($"float-summa:  {f}  (skillnad från 1.0: {Math.Abs(1.0f - f)})");
        Console.WriteLine($"double-summa: {d}  (skillnad från 1.0: {Math.Abs(1.0 - d)})");
    }
}
```

</details>

---

## 6) `if` (enkel)

**Mål:** enkel villkorskontroll.

**Uppgift:**
Fråga efter ålder. Skriv **“Vuxen”** om `age >= 18`. Annars skriv ingenting (eller “Minderårig” i en extra version).

<details>
<summary></summary>

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ålder: ");
        if (int.TryParse(Console.ReadLine(), out int age) && age >= 18)
        {
            Console.WriteLine("Vuxen");
        }
    }
}
```

</details>

---

## 7) `if`–`else`

**Mål:** tvåvägsbeslut.

**Uppgift:**
Läs in hastighet i km/h.

- Om `speed > 110`: skriv `För fort`.
- Annars: `OK`.

<details>
<summary></summary>

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Hastighet (km/h): ");
        if (int.TryParse(Console.ReadLine(), out int speed))
        {
            if (speed > 110) Console.WriteLine("För fort");
            else Console.WriteLine("OK");
        }
        else
        {
            Console.WriteLine("Ogiltigt tal.");
        }
    }
}
```

</details>

---

## 8) `if`–`else if`–`else` (flera gränser)

**Mål:** prioritetsordning och intervall.

**Uppgift:**
Läs in provpoäng `0–100` och skriv betyg:

- `>= 90`: A
- `>= 75`: B
- `>= 60`: C
- Annars: F

**Krav:** Visa fel om talet är utanför `0–100`.

<details>
<summary></summary>

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Poäng (0-100): ");
        if (!int.TryParse(Console.ReadLine(), out int p))
        {
            Console.WriteLine("Ogiltigt tal.");
            return;
        }

        if (p < 0 || p > 100)
        {
            Console.WriteLine("Poäng utanför intervallet 0-100.");
        }
        else if (p >= 90) Console.WriteLine("A");
        else if (p >= 75) Console.WriteLine("B");
        else if (p >= 60) Console.WriteLine("C");
        else Console.WriteLine("F");
    }
}
```

</details>

---

## 9) Edge case–tänkande (utan att prata tester)

**Mål:** förstå att varje `if` skapar nya vägar och att gränsfall måste hanteras.

**Uppgift (rabattberäkning):**
Läs in: `ålder (int)`, `student (true/false)`, `helg (true/false)`.
Pris = 100 kr.

- Om `ålder < 5`: gratis (0 kr)
- Annars om `ålder >= 65`: 20% rabatt
- Annars om `student == true`: 15% rabatt
- Extra: `helg == true` ger ytterligare 5% rabatt **efter** ovan rabatt.

**Krav:**

- Skriv ut slutpris med två decimaler.
- Lista exempel på **gränsfall** att prova (t.ex. 4 år, 5 år, 64/65, student + helg, 0, negativa värden).

**Reflektionsfrågor:**

- Vad händer om både `student` och `65+` är sant?
- I vilken ordning ska rabatterna appliceras?
- Hur många vägar uppstår när du kombinerar tre boolska villkor?

<details>
<summary></summary>

```csharp
using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        const double basePrice = 100.0;

        Console.Write("Ålder: ");
        if (!int.TryParse(Console.ReadLine(), out int age) || age < 0)
        {
            Console.WriteLine("Ogiltig ålder.");
            return;
        }

        Console.Write("Student? (true/false): ");
        bool.TryParse(Console.ReadLine(), out bool isStudent);

        Console.Write("Helg? (true/false): ");
        bool.TryParse(Console.ReadLine(), out bool isWeekend);

        double price;

        if (age < 5)
        {
            price = 0.0;
        }
        else if (age >= 65)
        {
            price = basePrice * 0.80; // 20% rabatt
        }
        else if (isStudent)
        {
            price = basePrice * 0.85; // 15% rabatt
        }
        else
        {
            price = basePrice;
        }

        if (isWeekend && price > 0.0)
        {
            price *= 0.95; // +5% extra rabatt
        }

        Console.WriteLine($"Slutpris: {price.ToString("F2", CultureInfo.InvariantCulture)} kr");

        // Förslag på edge cases att prova manuellt:
        // age = 4 (gratis), age = 5 (ej gratis), age = 65 (20%),
        // isStudent=true + isWeekend=true, age=0, age=-1 (ogiltigt)
    }
}
```

</details>

---

## Snabb repetition (pseudokod)

- **Parsing:** `input -> TryParse -> variabel`
- **Casting:** `(int)x` = trunkera, `Convert.ToInt32(x)` = avrunda
- **Division:** `int/int` = heltal → kasta en operand till `double`
- **Precision:** `float` < `double`
- **Villkor:** ordning spelar roll; gränser (`<`, `<=`) måste vara tydliga
- **Edge case–tänk:** tänk “gränser, kombinationer, orimliga indata”

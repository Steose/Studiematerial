# Övning 1: Det första C#-demot

I dag kikade vi på ett litet C#-program. Kort, enkelt – men fullt av viktiga byggstenar.
Vi tar det rad för rad. Häng med!

## Koden

```csharp
namespace basic_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej på dig!");
            Console.Write("Vad heter du? ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hej {name}!");
        }
    }
}
```

## Rad för rad

### 1. `namespace basic_demo`

Ett **namespace** (namnområde) fungerar ungefär som en mapp eller etikett för din kod.
Det håller ordning och ser till att namn inte krockar.

### 2. `{ ... }`

Klammerparenteserna öppnar och stänger block. Allt som hör till `namespace basic_demo` ligger här inne.

### 3. `internal class Program`

En **klass** är en behållare för kod.
I C# måste allt ligga i en klass.
`internal` betyder att klassen bara används inom samma projekt.

### 4. `static void Main(string[] args)`

Det här är **hjärtat** i ditt program. Datorn letar alltid efter en metod som heter `Main`.

- `static` = vi kan köra den utan att skapa ett objekt.
- `void` = den ger inget värde tillbaka.
- `string[] args` = gör det möjligt att skicka in data utifrån (men vi hoppar det just nu).

### 5. `Console.WriteLine("Hej på dig!");`

Det här skriver ut en rad text och hoppar sedan ner till nästa rad.
Resultat:

```
Hej på dig!
```

### 6. `Console.Write("Vad heter du? ");`

Skillnaden är att här används `Write` – utan `Line`.
Texten visas, men markören stannar kvar på samma rad.
Perfekt för frågor där du väntar på svar.

### 7. `string name = Console.ReadLine();`

Här händer magi:

- `string` = vi lagrar text.
- `name` = variabelns namn.
- `Console.ReadLine()` = väntar på att du skriver något och trycker Enter.

Det du skrev sparas i `name`.

### 8. `Console.WriteLine($"Hej {name}!");`

Nu blir programmet personligt.
Vi använder en **interpolerad sträng** (`$"..."`) som blandar text och variabler.

Om du skrev _"Anna"_ blir resultatet:

```
Hej Anna!
```

### 9–13. Stängande `}`

Alla block stängs i tur och ordning. Tänk på det som att sätta tillbaka lock på lådorna du öppnade.

## Sammanfattning

- **Namespace** = ordning och reda.
- **Klass** = behållare för kod.
- **Main** = startpunkten.
- **WriteLine** = text + radbyte.
- **Write** = text utan radbyte.
- **ReadLine** = vänta på inmatning.
- **Variabel** = lagra information.
- **Interpolering** = blanda text och data enkelt.

## ✨ Reflektion

Det här lilla programmet är ofta första mötet med C#.
Kanske känns det som mycket nytt – `namespace`, `class`, `Main`, `Console`… men allt följer en logik.

Kom ihåg: _varje rad i koden har en uppgift_. När du förstår syftet är det inte längre mystiskt – det är bara verktyg.

Så nästa gång du kör det här programmet och ser datorn hälsa på dig med ditt eget namn:

> Tänk: “Jag fick datorn att prata med mig.”

Snyggt jobbat. Du har just skrivit ditt första interaktiva program i C#! 🎉


# Kvitto-mysteriet: Stämmer handlarkvittot?

## Bakgrund

Du har precis handlat på ICA och fått ett kvitto på **239 kr**. Känns det rätt? Vi ska kontrollera steg för steg med **loopar** och **if-satser**.

## Inköpslistan (6 enkla varor)

1. **Mjölk** - Du köpte: 2 st
2. **Bröd** - Du köpte: 1 st
3. **Äpplen** - Du köpte: 3 st
4. **Pasta** - Du köpte: 2 st
5. **Yoghurt** - Du köpte: 4 st
6. **Chips** - Du köpte: 1 st

---

# Del 1: Grundpriser (enklast)

Först kollar vi bara **normalpriser** utan rabatter.

**Normalpriser:**
- Mjölk: 18 kr/st
- Bröd: 25 kr/st
- Äpplen: 8 kr/st
- Pasta: 12 kr/st
- Yoghurt: 9 kr/st
- Chips: 32 kr/st

## Uppgift Del 1

Räkna ut vad handlingen **ska** kosta med normalpriser.

```csharp
using System;

class Program
{
    static void Main()
    {
        // --- Varor (parallella arrayer) ---
        string[] names      = { "Mjölk" , "Bröd" , "Äpplen" , "Pasta"   , "Yoghurt" , "Chips" };
        int[]    prices     = {      18 ,     25 ,        8 ,        12 ,         9 ,     32  };
        int[]    quantities = {       2 ,      1 ,        3 ,         2 ,         4 ,      1  };

        int totalCost = 0;

        Console.WriteLine("=== KVITTOKONTROLL DEL 1 ===");
        Console.WriteLine("Räknar med normalpriser...\n");

        // Din kod här - använd en for-loop!

        Console.WriteLine($"\nBeräknad totalsumma: {totalCost} kr");
        Console.WriteLine("Kvittot säger: 239 kr");

        if (totalCost == 239)
            Console.WriteLine("✓ Stämmer!");
        else
            Console.WriteLine("✗ Stämmer INTE - något är konstigt...");
    }
}
```

**Vad ska din loop göra?**
1. För varje vara: räkna `pris × antal`
2. Lägg till i `totalCost`
3. Skriv ut: `"Mjölk: 2 × 18 = 36 kr"`

---

# Del 2: Oj, några varor var på rea!

Efter Del 1 märker du att summan blir **130 kr**, men kvittot säger **239 kr**. Hmm...

**Nyhet:** Du kommer ihåg att några varor var **dyrare** än vanligt (specialerbjudanden):

- **Bröd**: Inte 25 kr utan **35 kr** (specialbröd)
- **Chips**: Inte 32 kr utan **45 kr** (importchips)

## Uppgift Del 2

Uppdatera din kod med de **riktiga** priserna.

```csharp
// Ändra bara dessa rader:
int[] prices = { 18, 35, 8, 12, 9, 45 };  // Uppdaterade priser!
```

**Förväntat resultat:** Nu ska totalen bli **239 kr** och stämma med kvittot!

---

# Del 3: Bonus - kontroll av fel

**Utmaning:** Vad händer om kassapersonalen råkade slå fel på **en** vara?

Testa att ändra en quantity och se vad som händer:

```csharp
int[] quantities = { 2, 1, 4, 2, 4, 1 };  // Äpplen: 4 st istället för 3!
```

Kommer din kod att hitta felet?

<details>
<summary>💡 Lösning Del 1</summary>

```csharp
using System;

class Program
{
    static void Main()
    {
        // --- Varor (parallella arrayer) ---
        string[] names      = { "Mjölk"  , "Bröd" , "Äpplen" , "Pasta"   , "Yoghurt" , "Chips"  };
        int[]    prices     = {      18  ,     25 ,        8 ,       12  ,        9  ,     32  };
        int[]    quantities = {       2  ,      1 ,        3 ,        2  ,        4  ,      1  };


        int totalCost = 0;

        Console.WriteLine("=== KVITTOKONTROLL DEL 1 ===");
        Console.WriteLine("Räknar med normalpriser...\n");

        for (int i = 0; i < names.Length; i++)
        {
            int itemCost = prices[i] * quantities[i];
            totalCost += itemCost;
            Console.WriteLine($"{names[i]}: {quantities[i]} × {prices[i]} = {itemCost} kr");
        }

        Console.WriteLine($"\nBeräknad totalsumma: {totalCost} kr");
        Console.WriteLine("Kvittot säger: 239 kr");

        if (totalCost == 239)
            Console.WriteLine("✓ Stämmer!");
        else
            Console.WriteLine("✗ Stämmer INTE - något är konstigt...");
    }
}
```

**Vad händer när du kör?** Får du 130 kr som vi sa? Då vet du att några priser måste vara fel!

</details>

<details>
<summary>💡 Lösning Del 2</summary>

```csharp
using System;

class Program
{
    static void Main()
    {
        // --- Varor med KORRIGERADE priser ---
        string[] names      = { "Mjölk"  , "Bröd" , "Äpplen" , "Pasta"   , "Yoghurt" , "Chips"  };
        int[]    prices     = {      18  ,     35 ,        8 ,       12  ,        9  ,     45  };
        int[]    quantities = {       2  ,      1 ,        3 ,        2  ,        4  ,      1  };


        int totalCost = 0;

        Console.WriteLine("=== KVITTOKONTROLL DEL 2 ===");
        Console.WriteLine("Nu med korrigerade priser...\n");

        for (int i = 0; i < names.Length; i++)
        {
            int itemCost = prices[i] * quantities[i];
            totalCost += itemCost;
            Console.WriteLine($"{names[i]}: {quantities[i]} × {prices[i]} = {itemCost} kr");
        }

        Console.WriteLine($"\nBeräknad totalsumma: {totalCost} kr");
        Console.WriteLine("Kvittot säger: 239 kr");

        if (totalCost == 239)
            Console.WriteLine("✓ Nu stämmer det!");
        else
            Console.WriteLine("✗ Något är fortfarande fel...");
    }
}
```

**Nu ska det stämma!** Får du 239 kr? Då har du löst mysteriet!

</details>

## Experiment för dig att testa

* **Fel antal**: Vad händer om du ändrar quantities till `{ 2, 1, 4, 2, 4, 1 }`?
* **Fel pris**: Vad händer om mjölken kostar 20 kr istället för 18 kr?
* **Egen lista**: Skapa din egen handlelista med andra varor och priser!

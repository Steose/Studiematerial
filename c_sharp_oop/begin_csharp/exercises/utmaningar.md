# Kodutmaningar - Luriga uppgifter med bakgrundshistorier

Här hittar du mer utmanande uppgifter som kombinerar flera koncept. Varje uppgift har en rolig bakgrundshistoria som gör kodningen mer intressant!

---

## Uppgift 1: Mattehjälpens kalkylator

### Bakgrundshistoria
Du hjälper din lillasyster med matte-läxan. Hon ska räkna ut hur många äpplen familjen äter på en vecka, men hon har bara fått reda på hur många varje person äter per dag. Nu behöver du hjälpa henne räkna ut totalen och se om de behöver köpa fler äpplen.

### Din uppgift

```csharp
using System;

namespace MatteHjälpen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skapa variabler för hur många äpplen varje familjemedlem äter per dag
            // Pappa äter 2 äpplen per dag
            // Mamma äter 1 äpple per dag
            // Lillasyster äter 3 äpplen per dag
            // Du äter 2 äpplen per dag

            // Hur många dagar i en vecka? (7 dagar)

            // Räkna ut totalt per person för hela veckan (person * dagar)

            // Räkna ut totalt för hela familjen

            // Familjen har redan 25 äpplen hemma

            // Skriv ut rapport om konsumtion
            Console.WriteLine("FAMILJEN ÄPPELSSONS VECKORAPPORT");
            // Skriv ut varje persons veckokonsumtion

            // Skriv ut totalt för familjen

            // Kontrollera om de har tillräckligt med äpplen hemma
            // Om ja: skriv "Vi har tillräckligt med äpplen!"
            // Om nej: skriv "Vi behöver köpa fler äpplen!"
        }
    }
}
```

### Förväntad output
```
FAMILJEN ÄPPELSSONS VECKORAPPORT
Pappa äter 14 äpplen per vecka
Mamma äter 7 äpplen per vecka
Lillasyster äter 21 äpplen per vecka
Du äter 14 äpplen per vecka
---
Familjen äter totalt 56 äpplen per vecka
Vi har 25 äpplen hemma
Vi behöver köpa fler äpplen!
```

<details>
<summary><strong>💡 Tips 1: Kom igång</strong></summary>

För denna uppgift behöver du skapa `int` variabler för att lagra heltal. Börja med att skapa en variabel för varje familjemedlem som äter äpplen per dag.

```csharp
int pappaPerDag = 2;
// Fortsätt med resten...
```

</details>

<details>
<summary><strong>💡 Tips 2: Beräkningar</strong></summary>

För att beräkna veckokonsumtion, multiplicera antal äpplen per dag med antal dagar i veckan (7).

```csharp
int pappaVecka = pappaPerDag * 7;
```

Använd sedan addition (`+`) för att lägga ihop alla familjemedlemmars veckokonsumtion.

</details>

<details>
<summary><strong>💡 Tips 3: If-sats för jämförelse</strong></summary>

Använd en if-sats för att jämföra om familjen har tillräckligt med äpplen:

```csharp
if (äpplenHemma >= totaltVecka)
{
    // Tillräckligt med äpplen
}
else
{
    // Behöver köpa fler
}
```

</details>

<details>
<summary><strong>💡 </strong></summary>

```csharp
using System;

namespace MatteHjälpen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Äpplen per dag för varje person
            int pappaPerDag = 2;
            int mammaPerDag = 1;
            int lillasysterPerDag = 3;
            int digPerDag = 2;

            // Dagar i veckan
            int dagarIVeckan = 7;

            // Beräkna veckokonsumtion per person
            int pappaVecka = pappaPerDag * dagarIVeckan;
            int mammaVecka = mammaPerDag * dagarIVeckan;
            int lillasysterVecka = lillasysterPerDag * dagarIVeckan;
            int digVecka = digPerDag * dagarIVeckan;

            // Total veckokonsumtion
            int totaltVecka = pappaVecka + mammaVecka + lillasysterVecka + digVecka;

            // Äpplen hemma
            int äpplenHemma = 25;

            // Skriv ut rapport
            Console.WriteLine("FAMILJEN ÄPPELSSONS VECKORAPPORT");
            Console.WriteLine("Pappa äter " + pappaVecka + " äpplen per vecka");
            Console.WriteLine("Mamma äter " + mammaVecka + " äpplen per vecka");
            Console.WriteLine("Lillasyster äter " + lillasysterVecka + " äpplen per vecka");
            Console.WriteLine("Du äter " + digVecka + " äpplen per vecka");
            Console.WriteLine("---");
            Console.WriteLine("Familjen äter totalt " + totaltVecka + " äpplen per vecka");
            Console.WriteLine("Vi har " + äpplenHemma + " äpplen hemma");

            // Kontrollera om de har tillräckligt
            if (äpplenHemma >= totaltVecka)
            {
                Console.WriteLine("Vi har tillräckligt med äpplen!");
            }
            else
            {
                Console.WriteLine("Vi behöver köpa fler äpplen!");
            }
        }
    }
}
```

</details>

---

## Uppgift 2: Poängräknaren på skolan

### Bakgrundshistoria
Du arbetar som poängräknare på gymnasiets idrottsdagar. Det är dags för trestegshoppstävlingen och du behöver räkna ihop deltagarnas resultat. Varje deltagare hoppar tre gånger och du ska ta fram deras bästa resultat och se vem som vinner.

### Din uppgift

```csharp
using System;

namespace Idrottsdag
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deltagare 1: Anna
            // Annas tre hopp: 4 meter, 7 meter, 5 meter

            // Deltagare 2: Erik
            // Eriks tre hopp: 6 meter, 5 meter, 8 meter

            // Deltagare 3: Sara
            // Saras tre hopp: 9 meter, 4 meter, 6 meter

            // Hitta varje persons bästa hopp (använd if-satser)

            // Skriv ut rapport för varje deltagare
            Console.WriteLine("TRESTEGSHOPPSTÄVLING - RESULTAT");
            // Visa alla hopp och bästa för varje person

            // Avgör vem som vann (hitta högsta av de bästa hoppen)
            // Skriv ut vinnaren
        }
    }
}
```

### Förväntad output
```
TRESTEGSHOPPSTÄVLING - RESULTAT
Anna hoppade: 4m, 7m, 5m - Bästa: 7m
Erik hoppade: 6m, 5m, 8m - Bästa: 8m
Sara hoppade: 9m, 4m, 6m - Bästa: 9m
---
VINNARE: Sara med 9 meter!
```

<details>
<summary><strong>💡 Tips 1: Lagra hoppdata</strong></summary>

Skapa `int` variabler för varje persons tre hopp:

```csharp
int anna1 = 4;
int anna2 = 7;
int anna3 = 5;
// Fortsätt för Erik och Sara...
```

</details>

<details>
<summary><strong>💡 Tips 2: Hitta bästa hopp</strong></summary>

För att hitta det bästa hoppet, använd if-satser för att jämföra:

```csharp
int annaBäst = anna1;  // Börja med första hoppet
if (anna2 > annaBäst)
{
    annaBäst = anna2;  // Anna2 är bättre
}
if (anna3 > annaBäst)
{
    annaBäst = anna3;  // Anna3 är bättre
}
```

</details>

<details>
<summary><strong>💡 Tips 3: Jämför vinnare</strong></summary>

Använd if-else if för att avgöra vem som vann:

```csharp
if (annaBäst > erikBäst && annaBäst > saraBäst)
{
    Console.WriteLine("VINNARE: Anna...");
}
else if (erikBäst > annaBäst && erikBäst > saraBäst)
{
    Console.WriteLine("VINNARE: Erik...");
}
// osv...
```

</details>

<details>
<summary><strong>💡 </strong></summary>

```csharp
using System;

namespace Idrottsdag
{
    class Program
    {
        static void Main(string[] args)
        {
            // Annas hopp
            int anna1 = 4;
            int anna2 = 7;
            int anna3 = 5;

            // Eriks hopp
            int erik1 = 6;
            int erik2 = 5;
            int erik3 = 8;

            // Saras hopp
            int sara1 = 9;
            int sara2 = 4;
            int sara3 = 6;

            // Hitta Annas bästa hopp
            int annaBäst = anna1;
            if (anna2 > annaBäst)
            {
                annaBäst = anna2;
            }
            if (anna3 > annaBäst)
            {
                annaBäst = anna3;
            }

            // Hitta Eriks bästa hopp
            int erikBäst = erik1;
            if (erik2 > erikBäst)
            {
                erikBäst = erik2;
            }
            if (erik3 > erikBäst)
            {
                erikBäst = erik3;
            }

            // Hitta Saras bästa hopp
            int saraBäst = sara1;
            if (sara2 > saraBäst)
            {
                saraBäst = sara2;
            }
            if (sara3 > saraBäst)
            {
                saraBäst = sara3;
            }

            // Skriv ut resultat
            Console.WriteLine("TRESTEGSHOPPSTÄVLING - RESULTAT");
            Console.WriteLine("Anna hoppade: " + anna1 + "m, " + anna2 + "m, " + anna3 + "m - Bästa: " + annaBäst + "m");
            Console.WriteLine("Erik hoppade: " + erik1 + "m, " + erik2 + "m, " + erik3 + "m - Bästa: " + erikBäst + "m");
            Console.WriteLine("Sara hoppade: " + sara1 + "m, " + sara2 + "m, " + sara3 + "m - Bästa: " + saraBäst + "m");
            Console.WriteLine("---");

            // Avgör vinnare
            if (annaBäst > erikBäst && annaBäst > saraBäst)
            {
                Console.WriteLine("VINNARE: Anna med " + annaBäst + " meter!");
            }
            else if (erikBäst > annaBäst && erikBäst > saraBäst)
            {
                Console.WriteLine("VINNARE: Erik med " + erikBäst + " meter!");
            }
            else if (saraBäst > annaBäst && saraBäst > erikBäst)
            {
                Console.WriteLine("VINNARE: Sara med " + saraBäst + " meter!");
            }
            else
            {
                Console.WriteLine("Det blev oavgjort!");
            }
        }
    }
}
```

</details>

---

## Uppgift 3: Musikquizet

### Bakgrundshistoria
Du är quizmaster på skolans musikquiz. Tre lag tävlar och du behöver räkna poäng. Varje lag får poäng för rätta svar och förlorar poäng för fel svar. Du ska räkna ut slutresultatet och se vilket lag som vinner.

### Din uppgift

```csharp
using System;

namespace Musikquiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MUSIKQUIZ - POÄNGRÄKNING");

            // Lag 1: Rockstjärnorna
            // De fick 3 rätt (10 poäng per rätt svar)
            // De fick 1 fel (-5 poäng per fel svar)

            // Lag 2: Popfansen
            // De fick 2 rätt (10 poäng per rätt svar)
            // De fick 2 fel (-5 poäng per fel svar)

            // Lag 3: Jazzmästarna
            // De fick 4 rätt (10 poäng per rätt svar)
            // De fick 0 fel (-5 poäng per fel svar)

            // Räkna ut totalpoäng för varje lag

            // Skriv ut resultat för varje lag

            // Avgör vilket lag som vann med if-satser
            Console.WriteLine("Vinnare: [skriv vilket lag som vann]");
        }
    }
}
```

### Förväntad output
```
MUSIKQUIZ - POÄNGRÄKNING
Lag 1 Rockstjärnorna: 3 rätt, 1 fel = 25 poäng
Lag 2 Popfansen: 2 rätt, 2 fel = 10 poäng
Lag 3 Jazzmästarna: 4 rätt, 0 fel = 40 poäng
---
Vinnare: Jazzmästarna med 40 poäng!
```

<details>
<summary><strong>💡 Tips 1: Poängsystem</strong></summary>

Skapa variabler för poängsystemet först:

```csharp
int poängPerRätt = 10;
int poängPerFel = -5;  // Negativt tal för minuspoäng
```

Sedan skapa variabler för varje lags rätta och felaktiga svar.

</details>

<details>
<summary><strong>💡 Tips 2: Beräkna totalpoäng</strong></summary>

För varje lag, multiplicera antal rätt med poäng per rätt, och antal fel med poäng per fel, och addera ihop:

```csharp
int lag1Poäng = (lag1Rätt * poängPerRätt) + (lag1Fel * poängPerFel);
```

Kom ihåg att fel ger minuspoäng!

</details>

<details>
<summary><strong>💡 Tips 3: Hitta vinnare</strong></summary>

Använd if-else if för att jämföra vilket lag som har högst poäng:

```csharp
if (lag1Poäng > lag2Poäng && lag1Poäng > lag3Poäng)
{
    Console.WriteLine("Vinnare: Rockstjärnorna...");
}
// fortsätt för andra lagen...
```

</details>

<details>
<summary><strong>💡 </strong></summary>

```csharp
using System;

namespace Musikquiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MUSIKQUIZ - POÄNGRÄKNING");

            // Poäng per rätt och fel svar
            int poängPerRätt = 10;
            int poängPerFel = -5;

            // Lag 1: Rockstjärnorna
            int lag1Rätt = 3;
            int lag1Fel = 1;
            int lag1Poäng = (lag1Rätt * poängPerRätt) + (lag1Fel * poängPerFel);

            // Lag 2: Popfansen
            int lag2Rätt = 2;
            int lag2Fel = 2;
            int lag2Poäng = (lag2Rätt * poängPerRätt) + (lag2Fel * poängPerFel);

            // Lag 3: Jazzmästarna
            int lag3Rätt = 4;
            int lag3Fel = 0;
            int lag3Poäng = (lag3Rätt * poängPerRätt) + (lag3Fel * poängPerFel);

            // Skriv ut resultat
            Console.WriteLine("Lag 1 Rockstjärnorna: " + lag1Rätt + " rätt, " + lag1Fel + " fel = " + lag1Poäng + " poäng");
            Console.WriteLine("Lag 2 Popfansen: " + lag2Rätt + " rätt, " + lag2Fel + " fel = " + lag2Poäng + " poäng");
            Console.WriteLine("Lag 3 Jazzmästarna: " + lag3Rätt + " rätt, " + lag3Fel + " fel = " + lag3Poäng + " poäng");
            Console.WriteLine("---");

            // Avgör vinnare
            if (lag1Poäng > lag2Poäng && lag1Poäng > lag3Poäng)
            {
                Console.WriteLine("Vinnare: Rockstjärnorna med " + lag1Poäng + " poäng!");
            }
            else if (lag2Poäng > lag1Poäng && lag2Poäng > lag3Poäng)
            {
                Console.WriteLine("Vinnare: Popfansen med " + lag2Poäng + " poäng!");
            }
            else if (lag3Poäng > lag1Poäng && lag3Poäng > lag2Poäng)
            {
                Console.WriteLine("Vinnare: Jazzmästarna med " + lag3Poäng + " poäng!");
            }
            else
            {
                Console.WriteLine("Det blev oavgjort!");
            }
        }
    }
}
```

</details>

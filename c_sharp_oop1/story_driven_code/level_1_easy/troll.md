# Trollets styrka

## 🎯 Mål med övningen

Efter den här övningen kommer du att kunna:

- Skapa variabler av olika datatyper (`string`, `int`)
- Använda operatorer (`*`, `+`, `-`, `+=`, `-=`)
- Skriva ut resultat i konsolen med string concatenation

---

## 🧩 Lär känna hjälten

Detta är sagan om trollet Grlub som bor i en mörk skog. Grlub är stor och stark men människorna i byn intill är många och de vill jaga bort honom.

En människa har styrkan **15**. Grlub är **dubbelt så stark som fem människor**.

## 🚀 Kom igång: Första rundan (tänk själv!)

```csharp
using System;

namespace TrollensStyrka
{
    class Program
    {
        static void Main(string[] args)
        {
            // Trollets namn (text)
            //
            // Skapa en string variabel som heter "trollName" och sätt värdet till "Grlub"
            // Eller vad du vill att trollet ska heta
```

<details>
<summary>💡 Tips</summary>

```csharp
            string trollName = "Grlub";
```

</details>

```csharp
            // Människans styrka (heltal)
            // Skapa en int variabel som heter "humanStrength" och sätt värdet till 15
```

<details>
<summary>💡 Tips</summary>

```csharp
            int humanStrength = 15;
```

</details>

```csharp
            // Grlubs styrka (dubbelt så stark som fem människor)
            // Skapa en int variabel som heter "grlubStrength" och beräkna mot humanStrength
            // Antal gånger som Grlub är starkare än en människa.
```

<details>
<summary>💡 Tips</summary>

```csharp
            int grlubStrength = humanStrength * 5 * 2;
```

</details>

```csharp
            Console.WriteLine("Hej! Jag heter " + trollName + ".");
            Console.WriteLine(trollName + " är " + grlubStrength + " stark!");

            // Antal människor
            // Skapa en int variabel som heter "humanCount" och sätt värdet till 17
            // Då det är 17 människor som anfaller
```

<details>
<summary>💡 Tips</summary>

```csharp
            int humanCount = 17;
```

</details>

```csharp
            Console.WriteLine("Människorna anfaller, de är " + humanCount + " stycken");

            // Nu räknar vi slagen
            // 3 människor mot kroppen, 1 mot huvudet
            // Skapa två int variabler: "hitsToBody" (3 tre slag mot 3 människor)
            // och "hitsToHead" (ett slag mot 1 människa)
            // för att räkna ut antal slag som Grlub använder i en runda
```

<details>
<summary>💡 Tips</summary>

```csharp
            int hitsToBody = 3 * 3; // 3 människor, 3 slag var
            int hitsToHead = 1 * 1; // 1 människa, 1 slag var
```

</details>

```csharp
            // Hur många slag totalt per runda?
            // Skapa en int variabel som heter "totalHits" och lägg ihop hitsToBody och hitsToHead
```

<details>
<summary>💡 Tips</summary>

```csharp
            int totalHits = hitsToBody + hitsToHead;
```

</details>

```csharp
            // Räkna ut antal besegrade människor
            // Skapa en int variabel som heter "defeatedHumans" och sätt värdet till 4
            // då han slår 3 människor mot kroppen och 1 mot huvudet
```

<details>
<summary>💡 Tips</summary>

```csharp
            int defeatedHumans = 4;
```

</details>

```csharp
            // Minska antal människor med antal besegrade
            // Uppdatera humanCount genom attminska med defeatedHumans
```

<details>
<summary>💡 Tips</summary>

```csharp
            humanCount = humanCount - defeatedHumans;
```

</details>

```csharp
            Console.WriteLine(humanCount + " människor kvar.");
            Console.WriteLine(trollName + " kämpar vidare...");

            // Skriv ut antal slag som använts
            Console.WriteLine(trollName + " har använt " + totalHits + " slag.");
        }
    }
}
```

## ✅ Förväntat resultat efter första rundan

```
Hej! Jag heter Grlub.
Grlub är 150 stark!
Människorna anfaller, de är 17 stycken
13 människor kvar.
Grlub kämpar vidare...
Grlub har använt 10 slag.
```

---

## ⚔️ Andra rundan och framåt (nu vet du hur det funkar!)

Nu när du förstår grunderna fortsätter striden. **17 människor** anfaller totalt och Grlub slår strategiskt:

- **3 människor mot kroppen** (3 slag per människa = 9 slag totalt)
- **1 människa mot huvudet** (1 slag = 1 slag totalt)
- **Totalt per runda**: 10 slag som besegrar 4 människor

Fortsätt med resten av koden:

```csharp
            // Andra runda
            // Nu behöver vi inte skapa nya variabler, utan återanvänder de vi redan har
            // Uppdatera totalHits och humanCount med samma logik som ovan
            totalHits += hitsToBody + hitsToHead;
            humanCount = humanCount - defeatedHumans;

            Console.WriteLine(humanCount + " människor kvar.");
            Console.WriteLine(trollName + " har använt " + totalHits + " slag.");
            Console.WriteLine(trollName + " kämpar vidare...");

            // Tredje runda
            totalHits += hitsToBody + hitsToHead;
            humanCount -= defeatedHumans; // Kort version av samma sak

            Console.WriteLine(humanCount + " människor kvar.");
            Console.WriteLine(trollName + " har använt " + totalHits + " slag.");
            Console.WriteLine(trollName + " kämpar vidare...");

            // Fjärde runda
            totalHits += hitsToBody + hitsToHead;
            humanCount -= defeatedHumans;

            Console.WriteLine(humanCount + " människor kvar.");
            Console.WriteLine(trollName + " har använt " + totalHits + " slag.");
            Console.WriteLine(trollName + " har besegrat alla människor!");

            // Femte runda
            totalHits += hitsToBody + hitsToHead;
            humanCount -= defeatedHumans;

            Console.WriteLine(humanCount + " människor kvar.");
            Console.WriteLine(trollName + " har använt " + totalHits + " slag.");
            Console.WriteLine(trollName + " har besegrat alla människor!");
        }
    }
}
```

## ✅ Fullständigt förväntat resultat

```
Hej! Jag heter Grlub.
Grlub är 150 stark!
Människorna anfaller, de är 17 stycken
13 människor kvar.
Grlub kämpar vidare...
Grlub har använt 10 slag.
9 människor kvar.
Grlub har använt 20 slag.
Grlub kämpar vidare...
5 människor kvar.
Grlub har använt 30 slag.
Grlub kämpar vidare...
1 människor kvar.
Grlub har använt 40 slag.
Grlub har besegrat alla människor!
-3 människor kvar.
Grlub har använt 50 slag.
Grlub har besegrat alla människor!
```

## 💡 Lärdomar

**Första rundan lärde dig:**

- **String concatenation**: Sammanslagning av text med `+` operatorn
- **Datatyper**: `string` för text, `int` för heltal
- **Matematiska operationer**: Multiplikation (`*`), addition (`+`), subtraktion (`-`)

**Andra rundan och framåt lärde dig:**

- **Compound assignment**: `+=` och `-=` för att förändra variabelns värde
- **Variabelanvändning**: Återanvända beräknade värden i flera rundor
- **Kodrepetition**: Samma logik upprepas för att simulera flera rundor

Grlub visar att programmering handlar om att först förstå grunderna, sedan återanvända dem!

** En sista tanke **

Som du såg så upprepades koden för varje runda. I framtida lektioner kommer du att lära dig hur du kan undvika detta
med hjälp av loopar. En loop som till exempel kan köra samma kodblock flera gånger utan att du behöver skriva om koden.
Loopen kan köra så länge det finns människor kvar att slåss mot!

Det är det som är magin med Loopar, istället för att skriva samma kod flera gånger, så skriver du den en gång och
låter loopen göra jobbet åt dig! _Har jag nämnt att programmerare är lata?_

**'\*Intressant fakta**: Ideen med Loopar kommer från

## Slutet gott allting gott

Vår hjältetroll fick leva lycklig i alla sina dagar. Människorna lärde sig att respektera
skogen och Grlub fick vara ifred.

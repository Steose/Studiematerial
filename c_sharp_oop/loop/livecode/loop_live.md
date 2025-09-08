# Loopar och sånt

Första övningen var att skriva 7an tabell

Här är en enkel loop som går igenom talen 0–9 och skriver ut multiplikationstabellen för 7.

```csharp
// Loop som itererar från 0 till 9 och skriver ut 7ans tabell.
for (int i = 0; i < 10; i++)
{
    // Skriv ut en formaterad rad: "i * 7 = resultat"
    Console.WriteLine($"{i} * 7 = {i * 7}");
}
```

Självklart kan vi skriva alla tabeller.

Här använder vi två nästlade loopar: den yttre loopen väljer vilken tabell (j) vi är på, den inre loopen går igenom multiplikatorerna (i).

```csharp
// Yttre loop: välj tabellnummer 1–10
for (int j = 1; j <= 10; j++)
{
    // Inre loop: multiplicera med 1–10 för den aktuella tabellen
    for (int i = 1; i <= 10; i++)
    {
        // Skriv ut t.ex. "3 * 7 = 21"
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
}
```

men det är lite att ta i, så vi fortsätter med övningarna

Jämna tal, där hamnade vi i MVP träsket. Vad innebär MVP?

**MVP** står för Minimum Viable Product, och betyder att man gör **enbart det mest grundläggande för att få en produkt att fungera.**

Det handlar om att snabbt få ut en version av produkten med tillräckligt med funktionalitet för att kunna testa och få feedback, utan att lägga tid på onödiga detaljer eller funktioner. Detta ska vara er guide för att inte fastna i detaljer, speciellt vid inlämningar.

Men nu skulle vi i alla fall skriva ut jämna tal mellan 1 och 10.

Den enkla versionen är självklart en for-loop med +=2

Denna loop börjar på 2 och ökar med 2 varje varv — perfekt för att skriva ut jämna tal.

```csharp
// Starta på 2, öka med 2 varje gång, skriv ut värdet
for (int i = 2; i <= 10; i += 2)
{
    Console.WriteLine(i);
}
```

Vilket löser problemet faktiskt, fullt fungerande MVP. Vi kan ändra startvärde och slutvärde för att få andra intervaller.

Den algoritmiska lösningen (aka den krångliga och tekniska) är modulus-lösningen.

Här går vi igenom alla tal och använder modulusoperatorn (%) för att kolla om talet är jämnt.

```csharp
// Gå igenom 1–10
for (int i = 1; i <= 10; i++)
{
    // i % 2 == 0 betyder: resten vid division med 2 är 0 → talet är jämnt
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}

```

Denna lösning är mer flexibel, eftersom vi kan ändra villkoret för att skriva ut andra typer av tal (t.ex. udda tal eller tal delbara med 3) utan att ändra steget i loopen.

Slutligen kom den hemska utmaningen, att skriva ut en triangel med \*

```
*
**
***
****
*****
```

Denna utmaning kräver en **nested loop** (en loop inuti en annan loop).

I exemplet nedan ökar antalet stjärnor med 1 varje rad. Yttre loopen bestämmer vilken rad vi är på, inre loopen skriver ut antal stjärnor som krävs för den raden.

```csharp
// Yttre loop: radnummer 1–5
for (int rad = 1; rad <= 5; rad++)
{
    // Inre loop: skriv ut lika många '*' som radens nummer
    for (int kolumn = 1; kolumn <= rad; kolumn++)
    {
        Console.Write("*"); // Skriv en stjärna utan ny rad
    }
    Console.WriteLine(); // Byt till ny rad när inre loopen är klar
}
```

men man kan göra det med en loop, genom att använda en sträng som byggs på varje iteration.

Här bygger vi successivt en sträng genom att lägga till en '\*' varje varv och skriva ut den.

```csharp
// Starta med en tom sträng
string rad = "";
for (int i = 1; i <= 5; i++)
{
    // Lägg till en stjärna i slutet av strängen
    rad += "*";
    // Skriv ut den aktuella raden (1 stjärna första varvet, 2 andra, osv.)
    Console.WriteLine(rad);
}
```

eller Marcus krångliga lösning med new String()

Den här varianten skapar direkt en sträng med rätt antal '\*' utan att bygga den manuellt.

```csharp
for (int i = 1; i <= 5; i++)
{
    // new String(char, count) skapar en sträng bestående av count upprepningar av char
    string stars=new String('*', i); // Skapar en sträng med i stjärnor
    Console.WriteLine(stars); // Skriver ut stjärnor
}
```

Som sagt det finns alltid flera sätt att lösa ett problem i programmering, och valet av metod kan bero på faktorer som läsbarhet, prestanda och personlig preferens.

> [!NOTE]
> Så om ni löser på ett annat sätt än läraren (alltså jag) så är det helt okej, så länge det funkar och är läsbart.

# Harry Potter och Tramsigheternas Kammare

## 🎯 Mål med övningen

Efter den här övningen kommer du att kunna:

- Använda `switch`-satser för att hantera flera olika fall
- Förstå `while (true)` loops för kontinuerlig bearbetning
- Kombinera användarinput med villkorssatser
- Implementera program som körs tills användaren väljer att avsluta

---

## 🧩 Äventyret

Harry Potter och Ron Weasley har smugit sig ner i Zonkos hemliga källare - **Tramsigheternas Kammare** - där alla de mest experimentella bus-artiklarna testas innan de släpps i butiken. Hermione har följt med (motvilligt) för att hålla koll på dem.

I källaren finns en mystisk **Trams-O-Matic 3000**, en maskin som skapar olika busartiklar baserat på magiska siffror. Harry och Ron kan inte låta bli att experimentera med alla möjliga värden, medan Hermione bedömer varje resultat med sin karakteristiska skarpsinne.

Maskinen fortsätter att köra tills någon säger **"avsluta"** - precis som ett `while (true)` loop!

## 🚀 Kom igång: Experimenterandet börjar (tänk själv!)

```csharp
using System;

namespace ZonkosBasement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Trollkarlens namn (text)
            // Vi lagrar namn för personlig upplevelse genom hela experimenterandet
            // Detta gör koden mer engagerande och lättare att följa
            // Skapa en string variabel som heter "wizardName" och sätt värdet till "Harry Potter"
```

<details>
<summary>💡 Tips</summary>

```csharp
            string wizardName = "Harry Potter";
```

</details>

```csharp
            // Kompanjonen som hjälper till
            // Sidekicks och team members: vanligt i verkliga applikationer
            // Skapa en string variabel som heter "companion" och sätt värdet till "Ron Weasley"
```

<details>
<summary>💡 Tips</summary>

```csharp
            string companion = "Ron Weasley";
```

</details>

```csharp
            // Den skeptiska övervakaren
            // Error checking och quality control: alltid bra att ha någon som ifrågasätter
            // Skapa en string variabel som heter "supervisor" och sätt värdet till "Hermione Granger"
```

<details>
<summary>💡 Tips</summary>

```csharp
            string supervisor = "Hermione Granger";
```

</details>

```csharp
            Console.WriteLine("🪄 Välkommen till Zonkos hemliga källare!");
            Console.WriteLine("✨ " + wizardName + " och " + companion + " har hittat Trams-O-Matic 3000!");
            Console.WriteLine("📚 " + supervisor + " följer med för att hålla koll...");
            Console.WriteLine();
            Console.WriteLine("🎰 Mata in siffror (1-8) för att skapa tramsigheter!");
            Console.WriteLine("💬 Skriv 'avsluta' för att lämna källaren");
            Console.WriteLine("════════════════════════════════════════════════════");
            Console.WriteLine();

            // Experimenträknare
            // Accumulator pattern: räkna totala antal operationer
            // I verkliga system: antal API-anrop, processed records, user interactions
            // Skapa en int variabel som heter "experimentCount" och sätt värdet till 0
```

<details>
<summary>💡 Tips</summary>

```csharp
            int experimentCount = 0;
```

</details>

```csharp
            // EVIG EXPERIMENTERING med while (true)
            // Infinite loop: fortsätter tills break statement
            // Event loop pattern: vanligt i spel, servrar, UI-applikationer
            // while (true) betyder "kör för evigt tills vi säger stopp"
```

<details>
<summary>💡 Tips</summary>

```csharp
            while (true)
            {
```

</details>

```csharp
                Console.Write("🎯 Mata in din magiska siffra (1-8) eller 'avsluta': ");
                string userInput = Console.ReadLine();

                // Kontrollera om användaren vill avsluta
                // Exit condition: hur vi bryter ur infinite loop
                // Input validation: alltid kontrollera användarinput
                if (userInput.ToLower() == "avsluta")
                {
                    Console.WriteLine();
                    Console.WriteLine("👋 " + supervisor + ": 'Äntligen! Vi går tillbaka till slottet.'");
                    Console.WriteLine("🎒 " + wizardName + " och " + companion + " lämnar källaren...");
                    Console.WriteLine("📊 Totalt antal experiment: " + experimentCount);
                    Console.WriteLine("🏰 Tack för att du experimenterade med Trams-O-Matic 3000!");
                    break; // Avsluta while-loopen
                }

                // Försök konvertera input till int
                // Error handling: hantera ogiltiga inputs gracefully
                int magicNumber;
                if (!int.TryParse(userInput, out magicNumber))
                {
                    Console.WriteLine("❌ " + supervisor + ": 'Det där är inte en giltig siffra!'");
                    Console.WriteLine();
                    continue; // Hoppa tillbaka till början av loopen
                }

                // Räkna upp experimenten
                experimentCount++;
                Console.WriteLine();
                Console.WriteLine("⚡ Experiment #" + experimentCount + " - Magisk siffra: " + magicNumber);

                // SWITCH-SATS: Olika tramsigheter baserat på siffra
                // Multi-way branching: elegantare än långa if-else kedjor
                // Pattern matching: koppla input till specifika outputs
                // switch (magicNumber) med olika cases
```

<details>
<summary>💡 Tips</summary>

```csharp
                switch (magicNumber)
                {
                    case 1:
                        Console.WriteLine("🎪 Trams-O-Matic skapar: Självhoppande Chokladgrodor!");
                        Console.WriteLine("😒 " + supervisor + ": 'Meh... rätt så basic.'");
                        break;
                    case 2:
                        Console.WriteLine("💥 Trams-O-Matic skapar: Exploderande Snap-Kort!");
                        Console.WriteLine("🙄 " + supervisor + ": 'Åh men... så tramsigt!'");
                        break;
                    case 3:
                        Console.WriteLine("🌈 Trams-O-Matic skapar: Färgskiftande Bläckfiskar!");
                        Console.WriteLine("😤 " + supervisor + ": 'Verkligen? Så fjantigt!'");
                        break;
                    case 4:
                        Console.WriteLine("🎭 Trams-O-Matic skapar: Falska Trollstavar som Gapar!");
                        Console.WriteLine("😠 " + supervisor + ": 'Det där är rent av dumt!'");
                        break;
                    case 5:
                        Console.WriteLine("🕷️ Trams-O-Matic skapar: Gummi-Spindlar som Skriker!");
                        Console.WriteLine("😨 " + supervisor + ": 'Usch! Så äckligt och korkat!'");
                        break;
                    case 6:
                        Console.WriteLine("💨 Trams-O-Matic skapar: Stinkbomber med Trolllukt!");
                        Console.WriteLine("🤢 " + supervisor + ": 'Herregud! Så vidrigt och infantilt!'");
                        break;
                    case 7:
                        Console.WriteLine("🎪 Trams-O-Matic skapar: Självlekande Praktjoke-Pianon!");
                        Console.WriteLine("😵 " + supervisor + ": 'Helt sjukt! Bara idioti!'");
                        break;
                    case 8:
                        Console.WriteLine("🌟 Trams-O-Matic skapar: ULTRA-Portabel Träskmark!");
                        Console.WriteLine("🤯 " + supervisor + ": 'BOYS! Det där är bara HELT galet!'");
                        break;
                    default:
                        Console.WriteLine("❓ Trams-O-Matic fnittar och gör ingenting...");
                        Console.WriteLine("🤔 " + supervisor + ": 'Smart val - den siffran är utanför räckvidden.'");
                        break;
                }
```

</details>

```csharp
                // Kompanjoners reaktioner
                // Character development: olika personligheter reagerar olika
                if (magicNumber >= 1 && magicNumber <= 3)
                {
                    Console.WriteLine("😄 " + companion + ": 'Häftigt! Låt oss prova en till!'");
                    Console.WriteLine("⚡ " + wizardName + ": 'Brilliant! Zonko är ett geni!'");
                }
                else if (magicNumber >= 4 && magicNumber <= 6)
                {
                    Console.WriteLine("🤣 " + companion + ": 'HAHAHA! Det här blir episkt!'");
                    Console.WriteLine("😎 " + wizardName + ": 'Wicked! Tänk vad vi kan göra med detta!'");
                }
                else if (magicNumber >= 7 && magicNumber <= 8)
                {
                    Console.WriteLine("🔥 " + companion + ": 'MERLINS SKÄGG! Det här är OTROLIGT!'");
                    Console.WriteLine("🤩 " + wizardName + ": 'BLOODY HELL! Vi måste få tag på fler!'");
                }

                Console.WriteLine();
                Console.WriteLine("🔄 Trams-O-Matic återställer sig för nästa experiment...");
                Console.WriteLine("───────────────────────────────────────────────────");
                Console.WriteLine();
```

<details>
<summary>💡 Tips för att avsluta while-loopen</summary>

```csharp
            }
```

</details>

```csharp
        }
    }
}
```

## ✅ Exempel på körning

```
🪄 Välkommen till Zonkos hemliga källare!
✨ Harry Potter och Ron Weasley har hittat Trams-O-Matic 3000!
📚 Hermione Granger följer med för att hålla koll...

🎰 Mata in siffror (1-8) för att skapa tramsigheter!
💬 Skriv 'avsluta' för att lämna källaren
════════════════════════════════════════════════════

🎯 Mata in din magiska siffra (1-8) eller 'avsluta': 3

⚡ Experiment #1 - Magisk siffra: 3
🌈 Trams-O-Matic skapar: Färgskiftande Bläckfiskar!
😤 Hermione Granger: 'Verkligen? Så fjantigt!'
😄 Ron Weasley: 'Häftigt! Låt oss prova en till!'
⚡ Harry Potter: 'Brilliant! Zonko är ett geni!'

🔄 Trams-O-Matic återställer sig för nästa experiment...
───────────────────────────────────────────────────

🎯 Mata in din magiska siffra (1-8) eller 'avsluta': 7

⚡ Experiment #2 - Magisk siffra: 7
🎪 Trams-O-Matic skapar: Självlekande Praktjoke-Pianon!
😵 Hermione Granger: 'Helt sjukt! Bara idioti!'
🔥 Ron Weasley: 'MERLINS SKÄGG! Det här är OTROLIGT!'
🤩 Harry Potter: 'BLOODY HELL! Vi måste få tag på fler!'

🔄 Trams-O-Matic återställer sig för nästa experiment...
───────────────────────────────────────────────────

🎯 Mata in din magiska siffra (1-8) eller 'avsluta': banana

❌ Hermione Granger: 'Det där är inte en giltig siffra!'

🎯 Mata in din magiska siffra (1-8) eller 'avsluta': avsluta

👋 Hermione Granger: 'Äntligen! Vi går tillbaka till slottet.'
🎒 Harry Potter och Ron Weasley lämnar källaren...
📊 Totalt antal experiment: 2
🏰 Tack för att du experimenterade med Trams-O-Matic 3000!
```

## 💡 Lärdomar

**Switch-satser lärde dig:**
- **Multi-way branching**: Elegantare än långa if-else kedjor
- **Case statements**: Koppla specifika värden till specifika actions
- **Default case**: Hantera oväntat input gracefully
- **Break statements**: Förhindra "fall-through" mellan cases

**While (true) loops lärde dig:**
- **Infinite loops**: Program som kör tills explicit stopp
- **Break statements**: Hur man avsluter infinite loops
- **Continue statements**: Hoppa till nästa iteration
- **Event loop pattern**: Vanligt i interaktiva applikationer

**Input handling lärde dig:**
- **Console.ReadLine()**: Läsa användarinput som string
- **int.TryParse()**: Säker konvertering från string till int
- **Input validation**: Kontrollera att input är giltig
- **Error recovery**: Hantera fel input utan att krascha

**Programmeringsmönster du lärde dig:**
- **Event-driven programming**: Reagera på användaractions
- **State management**: Hålla reda på experimentCount
- **Character-based responses**: Olika reaktioner baserat på input
- **Graceful exit**: Professionell avslutning av program

**Verkliga tillämpningar:**
- **Menu systems**: Restaurang-beställningssystem, ATM-menyer
- **Game loops**: Spel som kör tills spelaren avslutar
- **Server applications**: Web servers som lyssnar på requests
- **Interactive tools**: Kalkylatorer, chat-bots, command-line tools
- **Data processing**: Läsa filer rad för rad tills slut

Harry Potter visar att switch-satser och while-loops tillsammans skapar kraftfulla interaktiva program som kan hantera användarval elegant! 🪄✨
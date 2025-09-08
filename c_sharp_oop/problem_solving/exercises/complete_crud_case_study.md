
# Komplett CRUD-projekt: Från Planering till Implementation

## Inledning

Detta är en omfattande fallstudie som visar hur en erfaren programmerare planerar och implementerar ett komplett CRUD-projekt (Create, Read, Update, Delete) för hantering av en personlista. Vi följer samma systematiska approach som i tidigare exempel, men denna gång för ett mer komplext system.

**Projekt**: Personhanteringssystem med fullständig CRUD-funktionalitet

## Fas 1: Målsättning och Scope

### 🎯 Målet

> "Jag börjar alltid med att sätta målet. Det är kritiskt att veta vad programmet ska och inte ska göra."

**Vad programmet SKA göra:**
- Lagra information om personer (namn, ålder, telefon, email)
- Lägga till nya personer (Create)
- Visa alla personer (Read)
- Uppdatera befintliga personer (Update)
- Ta bort personer (Delete)
- Söka bland personer
- Enkel menybaserad användargränssnitt

**Vad programmet INTE ska göra:**
- Permanent datalagring (ingen databas/fil)
- Avancerad användarautentisering
- Grafiskt användargränssnitt
- Datavalidering utöver grundläggande input-hantering

### Varför Är Tydliga Gränser Viktiga?

- **Förhindrar scope creep**: Projektet växer inte okontrollerat
- **Gör planering enklare**: Vet exakt vad som ska byggas
- **Hjälper vid prioritering**: Fokusera på kärnfunktionalitet först
- **Underlättar testning**: Tydliga acceptanskriterier

## Fas 2: Krav och Komponenter

### 🛠 Verktyg och Metoder

**Identifierade komponenter:**
1. **Person** - Datamodell för personinformation
2. **PersonHandler** - Business logic för CRUD-operationer
3. **MenuHandler** - Användargränssnitt och menyhantering
4. **Program** - Applikationsstartpunkt och huvudloop

**Nödvändiga funktioner:**
- CRUD-operationer för person-objekt
- Menybaserat gränssnitt
- Sökmekanism
- Input-validering och felhantering

### Systemarkitektur

```plaintext
Program.cs (Main)
    ↓ skapar och använder
MenuHandler.cs (UI Layer)
    ↓ använder
PersonHandler.cs (Business Logic)
    ↓ hanterar
Person.cs (Data Model)
```

## Fas 3: Strukturell Design

### 🧩 Struktur och Separation of Concerns

**Principen "En klass, ett ansvar":**

- **`Person.cs`**: Datamodell - innehåller bara persondata
- **`PersonHandler.cs`**: Business logic - hanterar alla operationer på persondata
- **`MenuHandler.cs`**: UI-logic - hanterar användarinteraktion
- **`Program.cs`**: Startpunkt - minimal kod som startar applikationen

### 📜 Namnstandard

**Konsekventa namn för förbättrad läsbarhet:**
- Alla klasser använder PascalCase: `PersonHandler`, `MenuHandler`
- Metoder beskriver action: `AddPerson`, `RemovePerson`, `PrintPersons`
- Engelska namn för kod, svenska för kommentarer och UI
- Enums följer samma namnmönster som relaterade metoder

## Fas 4: Detaljplanering

### Pseudokod för Varje Komponent

#### Person.cs
```plaintext
class Person
    properties:
        string Namn
        int Ålder
        string Telefonnummer
        string Epost

    // Enkel datacontainer utan business logic
```

#### PersonHandler.cs
```plaintext
class PersonHandler
    private List<Person> personer

    methods:
        void AddPerson(Person person)
        void RemovePerson(Person person)
        void UpdatePerson(Person person)
        void PrintPersons()
        List<Person> SearchPersons(string searchTerm)
```

#### MenuHandler.cs
```plaintext
class MenuHandler
    methods:
        void ShowMenu()
        MenuOption ReadMenuChoice()
        void HandleMenuOption(MenuOption option)

    private helper methods:
        void AddPersonUI()
        void RemovePersonUI()
        void UpdatePersonUI()
        // etc.
```

#### Program.cs
```plaintext
class Program
    static void Main()
        create MenuHandler
        while (true)
            show menu
            read choice
            handle choice
```

## Fas 5: Implementation

### Person.cs - Datamodellen

```csharp
/// <summary>
/// Representerar en person med grundläggande kontaktinformation.
/// Denna klass fungerar som en datacontainer utan business logic.
/// </summary>
public class Person
{
    /// <summary>
    /// Personens fullständiga namn.
    /// </summary>
    public string Namn { get; set; }

    /// <summary>
    /// Personens ålder i år.
    /// </summary>
    public int Ålder { get; set; }

    /// <summary>
    /// Personens telefonnummer.
    /// </summary>
    public string Telefonnummer { get; set; }

    /// <summary>
    /// Personens e-postadress.
    /// </summary>
    public string Epost { get; set; }

    /// <summary>
    /// Skapar en tom person-instans.
    /// </summary>
    public Person() { }

    /// <summary>
    /// Skapar en person med all nödvändig information.
    /// </summary>
    public Person(string namn, int ålder, string telefonnummer, string epost)
    {
        Namn = namn;
        Ålder = ålder;
        Telefonnummer = telefonnummer;
        Epost = epost;
    }

    /// <summary>
    /// Returnerar en sträng representation av personen.
    /// </summary>
    public override string ToString()
    {
        return $"{Namn}, {Ålder} år, Tel: {Telefonnummer}, Email: {Epost}";
    }
}
```

### PersonHandler.cs - Business Logic

```csharp
/// <summary>
/// Hanterar alla operationer relaterade till person-objekt.
/// Denna klass innehåller business logic för CRUD-operationer.
/// </summary>
public class PersonHandler
{
    /// <summary>
    /// Intern lista som lagrar alla personer.
    /// </summary>
    private List<Person> persons = new List<Person>();

    /// <summary>
    /// Lägger till en ny person i listan.
    /// </summary>
    /// <param name="person">Personen som ska läggas till</param>
    public void AddPerson(Person person)
    {
        if (person == null)
        {
            Console.WriteLine("Fel: Person kan inte vara null.");
            return;
        }

        if (string.IsNullOrWhiteSpace(person.Namn))
        {
            Console.WriteLine("Fel: Person måste ha ett namn.");
            return;
        }

        persons.Add(person);
        Console.WriteLine($"✓ {person.Namn} har lagts till i systemet.");
    }

    /// <summary>
    /// Tar bort en person från listan baserat på namn.
    /// </summary>
    /// <param name="namn">Namnet på personen som ska tas bort</param>
    public bool RemovePerson(string namn)
    {
        Person personToRemove = persons.Find(p => p.Namn.Equals(namn, StringComparison.OrdinalIgnoreCase));

        if (personToRemove != null)
        {
            persons.Remove(personToRemove);
            Console.WriteLine($"✓ {namn} har tagits bort från systemet.");
            return true;
        }
        else
        {
            Console.WriteLine($"✗ Ingen person med namnet '{namn}' hittades.");
            return false;
        }
    }

    /// <summary>
    /// Uppdaterar en befintlig person baserat på namn.
    /// </summary>
    /// <param name="updatedPerson">Person med uppdaterad information</param>
    public bool UpdatePerson(Person updatedPerson)
    {
        if (updatedPerson == null || string.IsNullOrWhiteSpace(updatedPerson.Namn))
        {
            Console.WriteLine("Fel: Ogiltig personinformation.");
            return false;
        }

        int index = persons.FindIndex(p => p.Namn.Equals(updatedPerson.Namn, StringComparison.OrdinalIgnoreCase));

        if (index != -1)
        {
            persons[index] = updatedPerson;
            Console.WriteLine($"✓ Information för {updatedPerson.Namn} har uppdaterats.");
            return true;
        }
        else
        {
            Console.WriteLine($"✗ Ingen person med namnet '{updatedPerson.Namn}' hittades för uppdatering.");
            return false;
        }
    }

    /// <summary>
    /// Skriver ut alla personer i en formaterad lista.
    /// </summary>
    public void PrintPersons()
    {
        if (persons.Count == 0)
        {
            Console.WriteLine("📝 Inga personer registrerade än.");
            return;
        }

        Console.WriteLine("\n📋 Alla registrerade personer:");
        Console.WriteLine("".PadRight(60, '─'));

        for (int i = 0; i < persons.Count; i++)
        {
            Console.WriteLine($"{i + 1:D2}. {persons[i]}");
        }

        Console.WriteLine("".PadRight(60, '─'));
        Console.WriteLine($"Totalt: {persons.Count} personer");
    }

    /// <summary>
    /// Söker efter personer baserat på en sökterm.
    /// </summary>
    /// <param name="searchTerm">Sökterm att matcha mot namn</param>
    /// <returns>Lista med matchande personer</returns>
    public List<Person> SearchPersons(string searchTerm)
    {
        if (string.IsNullOrWhiteSpace(searchTerm))
        {
            return new List<Person>();
        }

        return persons.FindAll(p => p.Namn.Contains(searchTerm, StringComparison.OrdinalIgnoreCase));
    }

    /// <summary>
    /// Returnerar antalet personer i systemet.
    /// </summary>
    public int GetPersonCount()
    {
        return persons.Count;
    }

    /// <summary>
    /// Kontrollerar om en person med givet namn redan finns.
    /// </summary>
    public bool PersonExists(string namn)
    {
        return persons.Any(p => p.Namn.Equals(namn, StringComparison.OrdinalIgnoreCase));
    }
}
```

### MenuHandler.cs - Användargränssnitt

```csharp
/// <summary>
/// Hanterar all användarinteraktion och menyvisning.
/// Denna klass fungerar som bryggan mellan användaren och business logic.
/// </summary>
public class MenuHandler
{
    private PersonHandler personHandler;

    /// <summary>
    /// Skapar en ny MenuHandler med tillhörande PersonHandler.
    /// </summary>
    public MenuHandler()
    {
        personHandler = new PersonHandler();
    }

    /// <summary>
    /// Enum som definierar alla tillgängliga menyalternativ.
    /// </summary>
    public enum MenuOption
    {
        AddPerson = 1,
        RemovePerson = 2,
        UpdatePerson = 3,
        PrintPersons = 4,
        SearchPersons = 5,
        Exit = 6
    }

    /// <summary>
    /// Visar huvudmenyn med alla tillgängliga alternativ.
    /// </summary>
    public void ShowMenu()
    {
        Console.Clear();
        Console.WriteLine("╔════════════════════════════════════╗");
        Console.WriteLine("║        PERSONHANTERINGSSYSTEM      ║");
        Console.WriteLine("╠════════════════════════════════════╣");
        Console.WriteLine("║ 1. Lägg till person               ║");
        Console.WriteLine("║ 2. Ta bort person                 ║");
        Console.WriteLine("║ 3. Uppdatera person               ║");
        Console.WriteLine("║ 4. Visa alla personer             ║");
        Console.WriteLine("║ 5. Sök personer                   ║");
        Console.WriteLine("║ 6. Avsluta                        ║");
        Console.WriteLine("╚════════════════════════════════════╝");
        Console.WriteLine($"Antal registrerade personer: {personHandler.GetPersonCount()}");
    }

    /// <summary>
    /// Läser in och validerar användarens menyval.
    /// </summary>
    /// <returns>Giltigt menyval</returns>
    public MenuOption ReadMenuChoice()
    {
        while (true)
        {
            Console.Write("\n➤ Välj alternativ (1-6): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int choice) && choice >= 1 && choice <= 6)
            {
                return (MenuOption)choice;
            }
            else
            {
                Console.WriteLine("❌ Ogiltigt val. Ange en siffra mellan 1 och 6.");
            }
        }
    }

    /// <summary>
    /// Hanterar det valda menyalternativet genom att anropa rätt metod.
    /// </summary>
    /// <param name="menuOption">Det valda menyalternativet</param>
    public void HandleMenuOption(MenuOption menuOption)
    {
        switch (menuOption)
        {
            case MenuOption.AddPerson:
                AddPersonUI();
                break;
            case MenuOption.RemovePerson:
                RemovePersonUI();
                break;
            case MenuOption.UpdatePerson:
                UpdatePersonUI();
                break;
            case MenuOption.PrintPersons:
                PrintPersonsUI();
                break;
            case MenuOption.SearchPersons:
                SearchPersonsUI();
                break;
            case MenuOption.Exit:
                ExitApplication();
                break;
            default:
                Console.WriteLine("❌ Ogiltigt menyval.");
                break;
        }

        if (menuOption != MenuOption.Exit)
        {
            Console.WriteLine("\nTryck Enter för att fortsätta...");
            Console.ReadLine();
        }
    }

    /// <summary>
    /// UI för att lägga till en ny person.
    /// </summary>
    private void AddPersonUI()
    {
        Console.WriteLine("\n➕ LÄGG TILL NY PERSON");
        Console.WriteLine("".PadRight(30, '─'));

        Person person = new Person();

        Console.Write("Namn: ");
        person.Namn = Console.ReadLine();

        if (personHandler.PersonExists(person.Namn))
        {
            Console.WriteLine($"⚠️  En person med namnet '{person.Namn}' finns redan.");
            return;
        }

        Console.Write("Ålder: ");
        while (!int.TryParse(Console.ReadLine(), out int ålder) || ålder < 0 || ålder > 150)
        {
            Console.Write("Ange en giltig ålder (0-150): ");
        }
        person.Ålder = ålder;

        Console.Write("Telefonnummer: ");
        person.Telefonnummer = Console.ReadLine();

        Console.Write("E-post: ");
        person.Epost = Console.ReadLine();

        personHandler.AddPerson(person);
    }

    /// <summary>
    /// UI för att ta bort en person.
    /// </summary>
    private void RemovePersonUI()
    {
        Console.WriteLine("\n➖ TA BORT PERSON");
        Console.WriteLine("".PadRight(30, '─'));

        if (personHandler.GetPersonCount() == 0)
        {
            Console.WriteLine("📝 Inga personer att ta bort.");
            return;
        }

        Console.Write("Ange namn på person att ta bort: ");
        string namn = Console.ReadLine();

        personHandler.RemovePerson(namn);
    }

    /// <summary>
    /// UI för att uppdatera en befintlig person.
    /// </summary>
    private void UpdatePersonUI()
    {
        Console.WriteLine("\n✏️  UPPDATERA PERSON");
        Console.WriteLine("".PadRight(30, '─'));

        if (personHandler.GetPersonCount() == 0)
        {
            Console.WriteLine("📝 Inga personer att uppdatera.");
            return;
        }

        Console.Write("Ange namn på person att uppdatera: ");
        string namn = Console.ReadLine();

        if (!personHandler.PersonExists(namn))
        {
            Console.WriteLine($"✗ Ingen person med namnet '{namn}' hittades.");
            return;
        }

        Console.WriteLine("Ange ny information:");
        Person updatedPerson = new Person { Namn = namn };

        Console.Write("Ny ålder: ");
        while (!int.TryParse(Console.ReadLine(), out int ålder) || ålder < 0 || ålder > 150)
        {
            Console.Write("Ange en giltig ålder (0-150): ");
        }
        updatedPerson.Ålder = ålder;

        Console.Write("Nytt telefonnummer: ");
        updatedPerson.Telefonnummer = Console.ReadLine();

        Console.Write("Ny e-post: ");
        updatedPerson.Epost = Console.ReadLine();

        personHandler.UpdatePerson(updatedPerson);
    }

    /// <summary>
    /// UI för att visa alla personer.
    /// </summary>
    private void PrintPersonsUI()
    {
        Console.WriteLine("\n👥 ALLA PERSONER");
        personHandler.PrintPersons();
    }

    /// <summary>
    /// UI för att söka efter personer.
    /// </summary>
    private void SearchPersonsUI()
    {
        Console.WriteLine("\n🔍 SÖK PERSONER");
        Console.WriteLine("".PadRight(30, '─'));

        Console.Write("Ange sökterm: ");
        string searchTerm = Console.ReadLine();

        List<Person> searchResults = personHandler.SearchPersons(searchTerm);

        if (searchResults.Count == 0)
        {
            Console.WriteLine($"🔍 Inga personer hittades som matchar '{searchTerm}'.");
        }
        else
        {
            Console.WriteLine($"\n🔍 Hittade {searchResults.Count} person(er):");
            Console.WriteLine("".PadRight(50, '─'));
            for (int i = 0; i < searchResults.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {searchResults[i]}");
            }
        }
    }

    /// <summary>
    /// Avslutar applikationen på ett kontrollerat sätt.
    /// </summary>
    private void ExitApplication()
    {
        Console.WriteLine("\n👋 Tack för att du använde personhanteringssystemet!");
        Console.WriteLine("Programmet avslutas...");
        Environment.Exit(0);
    }
}
```

### Program.cs - Startpunkt

```csharp
/// <summary>
/// Huvudklass som startar applikationen.
/// Håller minimal kod enligt best practice.
/// </summary>
class Program
{
    /// <summary>
    /// Applikationens startpunkt.
    /// </summary>
    /// <param name="args">Kommandoradsargument (används ej)</param>
    static void Main(string[] args)
    {
        // Skapa MenuHandler-instans utanför loopen för att undvika onödig recreation
        MenuHandler menuHandler = new MenuHandler();

        // Huvudloop som håller applikationen igång
        while (true)
        {
            // Visa meny
            menuHandler.ShowMenu();

            // Läs användarens val
            MenuHandler.MenuOption choice = menuHandler.ReadMenuChoice();

            // Hantera valet
            menuHandler.HandleMenuOption(choice);
        }
    }
}
```

## Fas 6: Designprincieper och Best Practices

### Separation of Concerns

**Varje klass har ett tydligt ansvar:**

1. **Person**: Datamodell utan business logic
2. **PersonHandler**: All business logic för person-operationer
3. **MenuHandler**: UI-logic och användarinteraktion
4. **Program**: Minimal startpunkt

### Konsistent Namngivning

**Observera mönstret:**
- MenuHandler.MenuOption enum-värden: `AddPerson`, `RemovePerson`, etc.
- PersonHandler metoder: `AddPerson()`, `RemovePerson()`, etc.
- MenuHandler UI-metoder: `AddPersonUI()`, `RemovePersonUI()`, etc.

**Detta gör att:**
- Koden är lätt att följa och förstå
- Relationerna mellan komponenter är tydliga
- Nya utvecklare snabbt förstår strukturen

### Felhantering och Validering

**Olika nivåer av validering:**
- **Input-validering**: MenuHandler kontrollerar användarinput
- **Business logic-validering**: PersonHandler kontrollerar affärsregler
- **Data-validering**: Grundläggande null-checks och värdeområden

## Fas 7: Möjliga Förbättringar

### Immediate Enhancements

1. **Databeständighet**
```csharp
public class FilePersonHandler : PersonHandler
{
    public void SaveToFile(string filename) { /* Implementation */ }
    public void LoadFromFile(string filename) { /* Implementation */ }
}
```

2. **Avancerad sökning**
```csharp
public List<Person> SearchByAge(int minAge, int maxAge) { /* Implementation */ }
public List<Person> SearchByEmail(string emailDomain) { /* Implementation */ }
```

3. **Import/Export funktionalitet**
```csharp
public void ExportToCsv(string filename) { /* Implementation */ }
public void ImportFromCsv(string filename) { /* Implementation */ }
```

### Arkitektuell Förbättringar

1. **Interface-baserad design**
```csharp
public interface IPersonHandler
{
    void AddPerson(Person person);
    bool RemovePerson(string namn);
    // etc.
}
```

2. **Dependency Injection**
```csharp
public MenuHandler(IPersonHandler personHandler)
{
    this.personHandler = personHandler;
}
```

3. **Event-driven arkitektur**
```csharp
public event EventHandler<PersonEventArgs> PersonAdded;
public event EventHandler<PersonEventArgs> PersonRemoved;
```

## Övningar och Tillämpningar

### Övning 1: Utvidga Funktionalitet

Lägg till följande funktioner till systemet:
1. Sortera personer efter namn eller ålder
2. Exportera personlista till textfil
3. Visa statistik (medelålder, yngst, äldst)
4. Ångra senaste operation

### Övning 2: Förbättra Användargränssnittet

1. Lägg till färgkodning för olika typer av meddelanden
2. Implementera paginering för långa listor
3. Lägg till shortcuts för vanliga operationer
4. Förbättra input-validering med mer detaljerade felmeddelanden

### Övning 3: Refaktorering

1. Extrahera gemensamma UI-mönster till basklasser
2. Implementera Repository-mönstret för datahantering
3. Lägg till enhetstester för alla business logic-metoder
4. Implementera logging för alla operationer

### Övning 4: Ny Feature - Grupper

Utvidga systemet med gruppfunktionalitet:
1. Skapa Group-klass
2. Låt personer tillhöra grupper
3. Lägg till CRUD-operationer för grupper
4. Implementera gruppbaserad sökning och filtrering

## Reflektion och Lärdomar

### Vad Gjorde Denna Approach Framgångsrik?

1. **Tydlig separation**: Varje klass hade ett specifikt ansvar
2. **Konsistent design**: Mönster upprepades genom hela systemet
3. **Gradvis komplexitet**: Byggde från enkla till mer komplexa funktioner
4. **Användbarhet första**: UI designades för faktisk användning

### Viktiga Designbeslut

1. **Objekt-kommunikation**: PersonHandler kommunicerar endast via Person-objekt
2. **Enum för menyval**: Gör koden mer läsbar än magiska nummer
3. **Single instance**: MenuHandler skapas en gång, inte i varje loop-iteration
4. **Defensive programming**: Validering på flera nivåer

### Lessons Learned

- **Planering sparar tid**: Noggrann planering från början förhindrade stora omskrivningar
- **Konsistens är kung**: Enhetliga mönster gör koden förutsägbar
- **Start enkelt**: Grundfunktionalitet först, sedan förbättringar
- **Testa tidigt**: Varje komponent testades isolerat före integration

## Sammanfattning

Detta projekt visar hur systematisk planering och god arkitektur leder till underhållbar, utvidgbar kod. Nyckelprincieperna som tillämpades:

1. **Tydliga ansvarsområden** för varje klass
2. **Konsistent namngivning** genom hela systemet
3. **Separation av concerns** mellan UI, business logic och data
4. **Defensive programming** med validering på flera nivåer
5. **Användarvänligt gränssnitt** med tydlig feedback

Som Marcus sammanfattar: "För att hålla koden organiserad och lättläst används 'Handlers' för olika uppgifter. Detta skapar fokus på en del av projektet i taget."

Denna approach resulterar i kod som är:
- **Lätt att förstå**: Tydlig struktur och ansvar
- **Lätt att underhålla**: Ändringar påverkar endast relevanta delar
- **Lätt att utvidga**: Nya funktioner kan läggas till utan att förstöra befintlig kod
- **Lätt att testa**: Varje komponent kan testas isolerat

🌟 Detta är grunden för professionell mjukvaruutveckling! 🌟


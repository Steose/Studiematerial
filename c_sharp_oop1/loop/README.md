# 🔄 Loopar - Upprepa kod effektivt

Lär dig använda loopar för att upprepa kod utan att skriva samma sak om och om igen. Loopar är kraften bakom all automatisering!

## 🎯 Vad du kommer att lära dig

- for-loopar för kända antal upprepningar
- while-loopar för villkorsstyrda upprepningar  
- do-while loopar (kör minst en gång)
- foreach-loopar för collections
- Loop-kontroll (break, continue)
- Nested loops (loopar inuti loopar)

## 📚 Innehåll

### 🏋️ Praktiska övningar
- **[loop-exempel.md](exercises/loop-exempel.md)** - Grundläggande loop-exempel
- **[loop-mayhem.md](exercises/loop-mayhem.md)** - Utmanande loop-scenarion
- **[real-world-loops.md](exercises/real-world-loops.md)** - Praktiska tillämpningar

## 🚀 Grundläggande loop-typer

### For-loop (när du vet antalet upprepningar)
```csharp
// Räkna från 1 till 10
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Nummer: {i}");
}

// Räkna bakåt
for (int i = 10; i >= 1; i--)
{
    Console.WriteLine($"Countdown: {i}");
}

// Hoppa i steg
for (int i = 0; i <= 20; i += 2)
{
    Console.WriteLine($"Jämnt tal: {i}");
}
```

### While-loop (kör medan villkor är sant)
```csharp
int count = 1;
while (count <= 5)
{
    Console.WriteLine($"Count: {count}");
    count++; // VIKTIGT: Öka count för att undvika oändlig loop
}

// Läs input tills användaren skriver "quit"
string input = "";
while (input != "quit")
{
    Console.WriteLine("Skriv 'quit' för att avsluta:");
    input = Console.ReadLine();
    Console.WriteLine($"Du skrev: {input}");
}
```

### Do-while loop (kör minst en gång)
```csharp
string password;
do
{
    Console.WriteLine("Ange lösenord:");
    password = Console.ReadLine();
    
    if (password != "secret")
    {
        Console.WriteLine("Fel lösenord, försök igen!");
    }
    
} while (password != "secret");

Console.WriteLine("Korrekt lösenord!");
```

### Foreach-loop (för arrays och collections)
```csharp
string[] names = {"Anna", "Erik", "Maria", "Johan"};

foreach (string name in names)
{
    Console.WriteLine($"Hej {name}!");
}

// Med index (när du behöver det)
for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine($"{i + 1}. {names[i]}");
}
```

## 🎮 Loop-kontroll

### Break - Avsluta loopen omedelbart
```csharp
for (int i = 1; i <= 100; i++)
{
    if (i == 50)
    {
        Console.WriteLine("Hittade 50, avslutar loop!");
        break; // Hoppar ut ur loopen
    }
    Console.WriteLine(i);
}
```

### Continue - Hoppa till nästa iteration
```csharp
for (int i = 1; i <= 10; i++)
{
    if (i % 2 == 0) // Om jämnt tal
    {
        continue; // Hoppa över resten av denna iteration
    }
    Console.WriteLine($"Udda tal: {i}");
}
// Skriver ut: 1, 3, 5, 7, 9
```

## 🌀 Nested loops (loopar inuti loopar)

### Multiplikationstabell
```csharp
for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= 5; j++)
    {
        int result = i * j;
        Console.Write($"{result,3} "); // Formaterat med 3 tecken
    }
    Console.WriteLine(); // Ny rad efter varje rad
}
```

### Pattern med stjärnor
```csharp
for (int row = 1; row <= 5; row++)
{
    for (int col = 1; col <= row; col++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}
// Output:
// * 
// * * 
// * * * 
// * * * * 
// * * * * * 
```

## 🎯 Praktiska exempel

### Summera tal
```csharp
int sum = 0;
for (int i = 1; i <= 100; i++)
{
    sum += i;
}
Console.WriteLine($"Summan av 1-100 är: {sum}");
```

### Hitta största talet i array
```csharp
int[] numbers = {45, 23, 78, 12, 94, 67};
int largest = numbers[0];

foreach (int number in numbers)
{
    if (number > largest)
    {
        largest = number;
    }
}
Console.WriteLine($"Största talet är: {largest}");
```

### Validera input
```csharp
int age;
while (true)
{
    Console.WriteLine("Ange din ålder (0-120):");
    string input = Console.ReadLine();
    
    if (int.TryParse(input, out age) && age >= 0 && age <= 120)
    {
        break; // Giltig ålder, avsluta loop
    }
    
    Console.WriteLine("Ogiltig ålder, försök igen!");
}
Console.WriteLine($"Din ålder är: {age}");
```

## ⚠️ Vanliga misstag och fallgropar

### Oändliga loopar
```csharp
// FEL - i ökar aldrig
int i = 0;
while (i < 10)
{
    Console.WriteLine(i);
    // Glömt: i++;
}

// RÄTT
int i = 0;
while (i < 10)
{
    Console.WriteLine(i);
    i++; // Öka i för att eventuellt avsluta loopen
}
```

### Off-by-one errors
```csharp
int[] array = {1, 2, 3, 4, 5};

// FEL - IndexOutOfRangeException
for (int i = 0; i <= array.Length; i++) // <= är fel
{
    Console.WriteLine(array[i]);
}

// RÄTT
for (int i = 0; i < array.Length; i++) // < är rätt
{
    Console.WriteLine(array[i]);
}
```

## 💡 Best Practices

### Använd rätt loop för rätt situation
- **for**: När du vet antalet iterationer
- **foreach**: För arrays/collections när du inte behöver index
- **while**: När du inte vet antalet iterationer
- **do-while**: När koden ska köras minst en gång

### Tydliga variabelnamn
```csharp
// Bra
for (int studentIndex = 0; studentIndex < students.Length; studentIndex++)
{
    // ...
}

// Mindre bra
for (int i = 0; i < students.Length; i++)
{
    // ...
}
```

### Begränsa loop-variabelns scope
```csharp
// Bra - i finns bara i loopen
for (int i = 0; i < 10; i++)
{
    // Använd i här
}
// i finns inte här

// Mindre bra - i finns kvar efter loopen
int i;
for (i = 0; i < 10; i++)
{
    // ...
}
// i finns fortfarande här
```

## 🎯 När du behärskar loopar

Du kommer kunna:
- ✅ Automatisera upprepande uppgifter
- ✅ Bearbeta arrays och collections effektivt
- ✅ Skapa interaktiva menysystem
- ✅ Implementera enkla algoritmer (sökning, sortering)
- ✅ Vara redo för nästa steg: [arrays](../arrays/)

## 🚀 Studieordning

1. **Börja med for-loops** - Enklast att förstå
2. **Prova while-loops** - För mer flexibel kontroll
3. **Testa loop-kontroll** - break och continue
4. **Kombinera med arrays** - Gå igenom listor av data
5. **Experimentera med nested loops** - Loopar inuti loopar
6. **Gör övningarna** - Praktisk tillämpning av alla loop-typer

---

**Lycka till med looparna! 🎉**

*Nästa steg: [arrays](../arrays/) för att lagra flera värden*
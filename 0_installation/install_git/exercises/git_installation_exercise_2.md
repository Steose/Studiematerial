---
nav_order: 70
parent: Githubstudent
permalink: Lectures/Git/git_installation_exercise_2
title: 'Övning 2: Första Git repository och workflow'
updated: '2025-08-20 14:30:48'
---
# Övning 2: Första Git repository och workflow

## 🎯 Mål med övningen

Efter den här övningen kommer du att:
- Ha skapat ditt första lokala Git repository 📁
- Förstå Git workflow: add → commit → push 🔄
- Ha synkat lokalt projekt med GitHub ☁️
- Kunna hantera grundläggande Git operationer 🛠️

## 🧩 Uppgiften

Nu ska ni skapa ert första riktiga projekt med Git och GitHub! Tänk er att ni gör er första "professionella" kod-commit som utvecklare.

## 🚀 Kom igång: Första Git Repository (35 min)

### **Steg 1: Skapa lokalt C# projekt (10 min)**

```bash
# 1. Skapa mapp för projekt
mkdir git-test-project
cd git-test-project

# 2. Skapa C# console application
dotnet new console -n GitTestApp
cd GitTestApp

# 3. Öppna i er IDE
code .        # VS Code
rider .       # JetBrains Rider
# eller öppna manuellt i Visual Studio
```

### **Steg 2: Editera Program.cs (5 min)**

Ersätt innehållet i `Program.cs` med:

```csharp
using System;

namespace GitTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("🎉 Mitt första Git-hanterade C# projekt!");
            Console.WriteLine($"📅 Skapat: {DateTime.Now:yyyy-MM-dd HH:mm}");
            Console.WriteLine("👨‍💻 Student: [Ditt Namn]");
            Console.WriteLine("🏫 Skola: Campus Mölndal");
            Console.WriteLine();
            
            DisplayGitWorkflow();
            
            Console.WriteLine("\nTryck på valfri tangent för att avsluta...");
            Console.ReadKey();
        }
        
        static void DisplayGitWorkflow()
        {
            Console.WriteLine("🔄 Git Workflow som jag lärde mig:");
            Console.WriteLine("1. 📝 Editera filer (Working Directory)");
            Console.WriteLine("2. ➕ git add . (Staging Area)");
            Console.WriteLine("3. 💾 git commit -m 'message' (Local Repository)");
            Console.WriteLine("4. ☁️ git push (Remote Repository - GitHub)");
        }
    }
}
```

### **Steg 3: Testa att projektet fungerar (2 min)**

```bash
# Bygg och kör projektet
dotnet build
dotnet run
```

**Förväntat resultat:** Program körs och visar meddelanden

### **Steg 4: Initiera Git repository (3 min)**

```bash
# Initiera Git i projekt-mappen
git init

# Kontrollera status
git status
```

**Output ska visa:**
```
Initialized empty Git repository in /path/to/GitTestApp/.git/
On branch main

No commits yet

Untracked files:
  (use "git add <file>..." to include in what will be committed)
        GitTestApp.csproj
        Program.cs
        bin/
        obj/
```

### **Steg 5: Skapa .gitignore (5 min)**

**Viktigt:** Skapa `.gitignore` INNAN första commit!

```bash
# Skapa .gitignore fil
touch .gitignore    # Linux/macOS
# eller skapa manuellt i Windows

# Lägg till följande innehåll:
```

**`.gitignore` innehåll:**
```
# Build results
bin/
obj/

# Visual Studio
.vs/
*.user
*.suo

# JetBrains Rider
.idea/

# VS Code
.vscode/

# User-specific files
*.rsuser
*.userprefs

# OS generated
.DS_Store
Thumbs.db

# Logs
*.log

# Environment variables
.env
appsettings.Development.json
```

### **Steg 6: Första commit (5 min)**

```bash
# Lägg till alla filer till staging area
git add .

# Kontrollera vad som är stagat
git status

# Skapa första commit
git commit -m "Initial commit: Add C# console app with Git workflow demo"

# Kontrollera commit historik
git log --oneline
```

### **Steg 7: Koppla till GitHub repository (5 min)**

**Först:** Skapa nytt repository på GitHub.com
- Repository name: `git-test-project`
- Description: `My first C# project with Git workflow`
- **Public** (för portfolio)
- **INTE** "Add README" (vi har redan filer)

**Sedan i terminal:**
```bash
# Lägg till GitHub som remote origin
git remote add origin git@github.com:ditt-användarnamn/git-test-project.git

# Kontrollera remote
git remote -v

# Skicka till GitHub (första gången)
git push -u origin main
```

## ✅ Förväntat resultat

Efter alla steg ska ni ha:

**✅ Lokalt Git Repository:**
- `.git` mapp (dold) med Git data
- `.gitignore` som exkluderar build-filer
- Minst 1 commit med meningsfullt meddelande
- Fungerande C# console application

**✅ GitHub Synkning:**
- Repository existerar på GitHub.com
- Lokala filer synkade till GitHub
- Commit history synlig på GitHub
- Green square på er GitHub activity graph! 🟢

## 🕵️‍♂️ Hur testar vi att det funkar?

### **Lokal Git Test:**

```bash
# 1. Kontrollera Git status
git status

# 2. Se commit historik
git log --oneline --decorate

# 3. Kontrollera remote connection
git remote -v

# 4. Se vilka filer Git spårar
git ls-files
```

### **GitHub Web Test:**

1. **Gå till:** `https://github.com/ditt-användarnamn/git-test-project`
2. **Kontrollera:** Att alla filer är där (Program.cs, .gitignore, etc.)
3. **Klicka:** På commit history och se ert meddelande
4. **Verifiera:** Att INTE bin/ och obj/ mappar finns

## 🤔 Test och experiment

Nu när grunderna fungerar - experimentera!

### **Ändra kod och committa igen:**

```csharp
// Lägg till i Main() metoden efter första Console.WriteLine:
Console.WriteLine("🔄 Version 2 av projektet - nu kan jag Git!");
Console.WriteLine($"📊 Totalt antal commits: [räkna manuellt från git log]");
```

**Sedan:**
```bash
# Se vad som ändrats
git diff

# Lägg till ändring
git add Program.cs

# Committa med beskrivande meddelande
git commit -m "Add version info and commit count display"

# Skicka till GitHub
git push
```

### **Kontrollera på GitHub:**
- Refresh GitHub sidan
- Se nya commit i history
- Klicka på commit för att se diff

## 🔥 BONUS: Git Workflow Experiment

### **Scenario: Simulera "riktig" utveckling**

1. **Lägg till en ny metod:**

```csharp
static void ShowStudentInfo()
{
    Console.WriteLine("\n📚 Student Information:");
    Console.WriteLine($"Namn: [Ditt Namn]");
    Console.WriteLine($"Kurs: C# .NET Utvecklare");
    Console.WriteLine($"Skola: Campus Mölndal");
    Console.WriteLine($"GitHub: https://github.com/ditt-användarnamn");
}
```

2. **Anropa metoden från Main():**

```csharp
// Lägg till innan Console.ReadKey():
ShowStudentInfo();
```

3. **Testa, committa, och pusha:**

```bash
# Testa att allt funkar
dotnet run

# Committa ändring
git add .
git commit -m "Add ShowStudentInfo method with student details"
git push
```

4. **Experimentera med Git history:**

```bash
# Se detaljerad log
git log --oneline --graph --decorate --all

# Se skillnader mellan commits
git diff HEAD~1 HEAD

# Se vad som var i första commit
git show HEAD~2
```

## 💡 Marcus tips om första Git workflow

<details>
<summary>⚡ Marcus säger om Git workflow mastery</summary>

**Marcus säger:**

"Era första commits är som era första ord som baby - ni kommer komma ihåg dem för alltid! 👶

**Git Workflow är som att laga mat:**

1. **Working Directory** = ingredienser på bänken
   - Era filer som ni editerar
   - Kan vara 'smutsiga' eller halvfärdiga
   - Git vet om dem men spårar inte ändringar ännu

2. **Staging Area** = ingredienser förberedda för matlagning
   - `git add` lägger filer här
   - Som att säga 'dessa ändringar vill jag spara'
   - Kan lägga till selektivt - bara vissa filer

3. **Local Repository** = färdig måltid i kylen
   - `git commit` sparar permanent
   - Kan aldrig förloras (nästan)
   - Finns på er dator även offline

4. **Remote Repository** = dela måltiden med vänner
   - `git push` skickar till GitHub
   - Backup + samarbete
   - Andra kan se och bidra

**Pro-tips för bättre commits:**

```bash
# Bra commit meddelanden följer mönstret:
# [Typ]: [Kort beskrivning]
# 
# Typer:
git commit -m "feat: Add user authentication system"
git commit -m "fix: Resolve null reference in UserService"  
git commit -m "docs: Update README with installation guide"
git commit -m "refactor: Simplify database connection logic"
git commit -m "test: Add unit tests for calculator functions"

# Använd imperativ form (som att ge en order):
# ✅ "Add feature" inte "Added feature"
# ✅ "Fix bug" inte "Fixed bug"
# ✅ "Update docs" inte "Updated docs"
```

**Vanliga nybörjar-misstag att undvika:**

1. **Committa generated filer**
   ```bash
   # ❌ ALDRIG committa:
   bin/Debug/       # Build output
   obj/             # Temp build files  
   .vs/             # Visual Studio settings
   *.user           # User-specific settings
   
   # ✅ Använd .gitignore!
   ```

2. **Dåliga commit meddelanden**
   ```bash
   # ❌ Undvik:
   git commit -m "fix"
   git commit -m "stuff"
   git commit -m "changes"
   git commit -m "asdf"
   
   # ✅ Skriv så här:
   git commit -m "Fix null reference exception in user login"
   ```

3. **För stora commits**
   ```bash
   # ❌ Inte så här:
   git commit -m "Add entire user management system"
   
   # ✅ Utan så här:
   git commit -m "Add User model class"
   git commit -m "Add UserService for database operations" 
   git commit -m "Add user login validation logic"
   ```

**Git är som en tidsmaskin - använd den!**

```bash
# Se vad som hände:
git log --oneline                    # Alla commits
git show HEAD                        # Senaste commit i detalj  
git diff HEAD~1 HEAD                 # Vad ändrades i senaste commit

# Gå tillbaka i tiden:
git checkout [commit-hash]           # Titta på gammal version
git checkout main                    # Tillbaka till nuvarande

# Ångra ändringar (var försiktig!):
git reset --soft HEAD~1              # Ångra commit, behåll ändringar
git reset --hard HEAD~1              # VARNING: Tar bort allt!
```

**Bottom line:** Git är som ett superkraftsverktyg - lär er grunderna ordentligt nu så blir resten av kursen mycket enklare! 🚀"

</details>
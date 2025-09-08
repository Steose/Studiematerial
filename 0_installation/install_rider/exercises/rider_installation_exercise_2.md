
# Övning 2: IDE-jämförelse och Linux C# setup

## 🎯 Mål med övningen

Efter den här övningen kommer du att:
- Ha testat flera C# utvecklingsmiljöer 🔄
- Förstå styrkor och svagheter med olika IDEs ⚖️
- Ha optimerat din setup för C# på Linux 🐧
- Kunnat välja rätt verktyg för olika situationer 🎯

## 🧩 Uppgiften

Nu ska ni experimentera med olika utvecklingsmiljöer och hitta er favorit! Tänk er som att ni testar olika "verkstäder" för att se vilken som passar er arbetsstil bäst.

## 🚀 Kom igång: IDE Battle Royale

### **Challenge: Samma projekt, olika IDEs**

Skapa samma enkla projekt i olika miljöer för att jämföra:

```csharp
// IDE Comparison Project
using System;
using System.Collections.Generic;
using System.Linq;

namespace IDEComparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("🥊 IDE BATTLE ROYALE 🥊");
            Console.WriteLine();

            var tasks = GetDevelopmentTasks();

            foreach (var task in tasks)
            {
                Console.WriteLine($"📋 {task}");
            }

            Console.WriteLine();
            TestIDEFeatures();
            Console.ReadLine();
        }

        static List<string> GetDevelopmentTasks()
        {
            return new List<string>
            {
                "Syntax highlighting (färgkodning)",
                "IntelliSense (auto-complete)",
                "Debugging (sätta breakpoints)",
                "Refactoring (byta namn på variabler)",
                "Git integration",
                "Plugin/Extension support"
            };
        }

        static void TestIDEFeatures()
        {
            // Test IntelliSense - när ni skriver DateTime.
            // ska IDEn visa tillgängliga metoder
            var now = DateTime.Now;

            // Test debugging - sätt breakpoint här
            var formatted = now.ToString("yyyy-MM-dd");

            // Test refactoring - högerklick på 'testVariable'
            // och välj "Rename" - namnet ska ändras överallt
            string testVariable = "IDE Test Complete!";
            Console.WriteLine(testVariable);
        }
    }
}
```

## ✅ Förväntat resultat

Ni ska kunna skapa och köra samma projekt i minst 2 olika miljöer och jämföra:

**Hastighet:**
- Hur snabbt startar IDE:n?
- Hur responsiv är IntelliSense?
- Hur snabbt bygger och kör projektet?

**Användbarhet:**
- Hur lätt hittar ni funktioner?
- Är gränssnittet intuitivt?
- Fungerar kortkommandon som förväntat?

## 🕵️‍♂️ Linux C# Setup (Special Focus)

### **För Linux-användare - Full C# stack:**

**1. Installera .NET SDK:**
```bash
# Ubuntu/Debian
wget https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
sudo apt update
sudo apt install -y dotnet-sdk-6.0

# Arch Linux
sudo pacman -S dotnet-sdk

# Fedora
sudo dnf install dotnet-sdk-6.0
```

**2. Verifiera installation:**
```bash
dotnet --version
dotnet --list-sdks
```

**3. IDE/Editor alternativ för Linux:**

**Option A: Rider**
```bash
sudo snap install rider --classic
# eller ladda ner .tar.gz från JetBrains
```

**Option B: VS Code**
```bash
sudo snap install code --classic
# Installera C# extension
```

**Option C: Terminal + Vim/Nano (hardcore! 😎)**
```bash
dotnet new console -n MyProject
cd MyProject
nano Program.cs  # eller vim/code
dotnet run
```

## 🤔 Diskussion i paret

Fyll i denna jämförelse-tabell medan ni testar:

| Feature | Rider | VS Code | Visual Studio | Terminal |
|---------|-------|---------|---------------|----------|
| Startup tid | ⏱️ | ⏱️ | ⏱️ | ⏱️ |
| RAM användning | 🐏 | 🐏 | 🐏 | 🐏 |
| IntelliSense kvalitet | ⭐ | ⭐ | ⭐ | ⭐ |
| Debugging tools | 🐛 | 🐛 | 🐛 | 🐛 |
| Git integration | 📊 | 📊 | 📊 | 📊 |
| Linux support | 🐧 | 🐧 | 🐧 | 🐧 |

**Använd skala 1-5 för varje kategori!**

Diskutera också:
- Vilken IDE känns mest "naturlig" för er?
- Vilka features är absolut nödvändiga vs "nice to have"?
- Hur viktigt är det med samma IDE som teamet använder?

## 🔥 BONUS: Advanced Linux C# Development

### **Setup för avancerad Linux C# utveckling:**

**1. OmniSharp Language Server (förbättrar VS Code C#-stöd):**
```bash
# Installeras automatiskt med C# extension, men kan konfigureras
```

**2. Användbara Linux C# verktyg:**
```bash
# dotnet CLI verktyg
dotnet tool install -g dotnet-ef          # Entity Framework
dotnet tool install -g dotnet-aspnet-codegenerator  # ASP.NET scaffolding
dotnet tool install -g dotnet-dump        # Memory dumps
dotnet tool install -g dotnet-trace       # Performance tracing
```

**3. Databas-verktyg för Linux:**
```bash
# SQLite browser
sudo apt install sqlitebrowser

# PostgreSQL client
sudo apt install postgresql-client

# MongoDB Compass (GUI)
# Ladda ner från mongodb.com
```

**4. Git GUI för Linux:**
```bash
sudo apt install gitk git-gui     # Enkla Git GUIs
sudo snap install gitkraken       # Professionell Git client
```

<details>
<summary>💡 Marcus Linux C# survival guide</summary>

**Marcus säger:**

"Linux + C# = Awesome combo! 🐧❤️ Microsoft har gjort fantastiskt jobb med cross-platform .NET.

**Pro-tips för Linux C# utveckling:**

1. **Terminal är din vän:** Lär er dotnet CLI - det är kraftfullt!
   ```bash
   dotnet new                 # Se alla project templates
   dotnet add package         # Installera NuGet packages
   dotnet publish            # Bygg för distribution
   ```

2. **Environment variables:** Sätt upp för olika miljöer
   ```bash
   export ASPNETCORE_ENVIRONMENT=Development
   export DOTNET_ENVIRONMENT=Development
   ```

3. **Performance:** Linux + .NET = ofta snabbare än Windows!

4. **Docker:** Perfekt för att containerisera .NET apps
   ```bash
   dotnet publish -c Release
   docker build -t myapp .
   ```

5. **Package managers:** Använd er distributions PM för system-tools, NuGet för .NET-bibliotek

**Vanliga Linux C# gotchas:**
- File paths: `/` inte `\`
- Case sensitivity: `MyFile.cs` ≠ `myfile.cs`
- Line endings: LF inte CRLF
- Permissions: `chmod +x` för executable files

**Bottom line:** Linux är en fantastisk platform för C# utveckling - ni kommer älska flexibiliteten! 🚀"

</details>

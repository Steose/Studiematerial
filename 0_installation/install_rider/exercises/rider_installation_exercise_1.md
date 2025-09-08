
# Övning 1: Rider installation och VS Code alternativ

## 🎯 Mål med övningen

Efter den här övningen kommer du att:
- Ha installerat Rider (eller VS Code som alternativ) 💻
- Fått student-licens för JetBrains-verktyg 🎓
- Förstå skillnaderna mellan olika C# IDEs ⚖️
- Ha konfigurerat din utvecklingsmiljö optimalt ⚙️

## 🧩 Uppgiften

Nu ska ni välja och installera er professionella utvecklingsmiljö. Tänk er som att ni ska välja verktyg för er "professionella verkstad" - olika verktyg för olika behov!

## 🚀 Kom igång: Välj din väg

### **Alternativ A: Rider (Kraftfull, alla OS) 💪**

**Steg 1: Student-licens (15 min)**
1. Gå till [education.github.com](https://education.github.com)
2. Klicka "Get benefits"
3. Logga in med GitHub (skapa konto om ni inte har)
4. Verifiera student-status med skol-email
5. Hitta JetBrains i benefits och aktivera

**Steg 2: Ladda ner Rider (5 min)**
- Windows: [jetbrains.com/rider](https://jetbrains.com/rider) → Download
- Mac: Samma, eller `brew install --cask rider`
- Linux: `sudo snap install rider --classic`

### **Alternativ B: VS Code (Snabbt, lätt, alla OS) ⚡**

**För Linux-användare eller lättare alternativ:**

1. **Installera VS Code:**
   - Ubuntu/Debian: `sudo snap install code --classic`
   - Arch: `sudo pacman -S code`
   - Mac: `brew install --cask visual-studio-code`
   - Windows: [code.visualstudio.com](https://code.visualstudio.com)

2. **Installera C# Extension:**
   - Öppna VS Code
   - Ctrl+Shift+X (Extensions)
   - Sök "C#" → installera Microsoft C# extension
   - Installera ".NET Install Tool for Extension Authors"

## ✅ Förväntat resultat

**Rider-användare:**
- Rider startar utan fel
- Student-licens aktiverad (inga "trial"-varningar)
- Kan skapa nytt C# Console projekt
- IntelliSense fungerar

**VS Code-användare:**
- VS Code startar med C# support
- Kan skapa och köra C# projekt via terminal
- Syntax highlighting fungerar
- Debugging är tillgängligt

## 🕵️‍♂️ Hur testar vi att det funkar?

### **Test: Skapa "Development Environment Test"**

**Rider:**
1. File → New Solution
2. Console Application (.NET 6.0)
3. Name: "RiderTest", Location: `~/Code/CSharp_CMYH/00_Setup/`

**VS Code:**
```bash
mkdir -p ~/Code/CSharp_CMYH/00_Setup/VSCodeTest
cd ~/Code/CSharp_CMYH/00_Setup/VSCodeTest
dotnet new console
code .
```

### **Test-kod för båda:**
```csharp
using System;

namespace DevelopmentTest
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== DEVELOPMENT ENVIRONMENT TEST ===");
            Console.WriteLine();

            // Test basic functionality
            string ide = GetIDEName();
            string os = Environment.OSVersion.Platform.ToString();

            Console.WriteLine($"🖥️  Operating System: {os}");
            Console.WriteLine($"💻 IDE/Editor: {ide}");
            Console.WriteLine($"⚡ .NET Version: {Environment.Version}");
            Console.WriteLine();

            // Test student benefits
            ShowStudentBenefits();

            Console.WriteLine("✅ Development environment ready!");
            Console.ReadLine();
        }

        static string GetIDEName()
        {
            // Just for fun - vi kan inte detektera detta riktigt
            Console.Write("Vilken IDE använder du? (Rider/VSCode/VS): ");
            return Console.ReadLine() ?? "Unknown";
        }

        static void ShowStudentBenefits()
        {
            Console.WriteLine("🎓 Student Benefits ni borde ha:");
            Console.WriteLine("• JetBrains All Products Pack");
            Console.WriteLine("• GitHub Pro (unlimited private repos)");
            Console.WriteLine("• Azure for Students");
            Console.WriteLine("• Figma Pro");
            Console.WriteLine("• Canva Pro");
            Console.WriteLine("• Plus 100+ andra verktyg!");
            Console.WriteLine();
        }
    }
}
```

## 🤔 Diskussion i paret

Medan installationen pågår, diskutera:

- Vilken typ av utveckling tror ni passar er bäst? (Desktop, Web, Mobile)
- Vad är viktigast för er: prestanda, funktioner, eller enkelhet?
- Hur viktigt är det med cross-platform support?
- Har ni använt andra IDEs tidigare? (Eclipse, IntelliJ, Atom)

## 🔥 BONUS: Konfigurera för optimal C#-utveckling

### **Rider-konfiguration:**
1. **File → Settings → Editor → General:**
   - ✅ Change font size with mouse wheel
   - ✅ Show line numbers

2. **Build, Execution, Deployment → Toolset:**
   - Kontrollera att rätt .NET SDK är valt

3. **Plugins:**
   - Installera "String Manipulation" (användbart!)
   - "Rainbow Brackets" (färgkodade paranteser)

### **VS Code-konfiguration:**
1. **Settings (Ctrl+,):**
   - Font: "Fira Code" eller "JetBrains Mono"
   - Theme: "Dark+ (default dark)" eller installera tema

2. **Användbara extensions:**
   - "C# Extensions" (boilerplate code)
   - "Bracket Pair Colorizer"
   - "GitLens" (för Git senare)
   - "Path Intellisense"

<details>
<summary>💡 Klicka här för Marcus IDE-tips</summary>

**Marcus 25 års erfarenhet av IDEs:**

**"Den bästa IDE:n är den ni faktiskt använder dagligen!"**

**Rider är bäst för:**
- Stora, komplexa projekt
- Professionell utveckling
- När ni vill ha "allt i en box"
- Refactoring av befintlig kod

**VS Code är bäst för:**
- Snabb redigering och prototyping
- Mindre projekt och script
- När ni hoppar mellan många språk
- Äldre datorer med begränsad RAM

**Visual Studio är bäst för:**
- Ren Windows/.NET utveckling
- Enterprise applikationer
- När ni jobbar mest med Microsoft-stack

**Pro-tip:** Många utvecklare använder flera IDEs beroende på projekt. Börja med en, lär er den väl, sedan experimentera med andra!

**Viktigast:** Lär er kortkommandon! En utvecklare som kan navigera snabbt i sin IDE är typ 3x mer produktiv än en som klickar på allt. 🚀

</details>

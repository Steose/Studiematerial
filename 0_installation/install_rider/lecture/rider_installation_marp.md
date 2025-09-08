# ![bg left:40%](https://images.pexels.com/photos/1181346/pexels-photo-1181346.jpeg)

# **JetBrains Rider Installation** 🚀
### Det professionella alternativet för C#

---

## **Varför Rider?** 🤔

Rider är som **Tesla Model S för C#-utveckling**! 🏎️⚡

- **Cross-platform** = Windows, Mac, Linux 🌍
- **ReSharper inbyggt** = AI-powered kod-analys 🧠
- **Git-integration** = versionshantering på steroider 🔄
- **Databas-verktyg** = allt i en IDE 🗄️

**Men:** Kostar pengar (utom för studenter!) 💰

---

## **Rider vs Visual Studio** ⚖️

```mermaid
graph TD;
    A[IDE Val] --> B[Visual Studio];
    A --> C[Rider];
    B --> D[✅ Gratis alltid];
    B --> E[✅ Microsoft-optimerat];
    C --> F[✅ Cross-platform];
    C --> G[✅ Kraftfulla verktyg];
    C --> H[💰 Betald (student-rabatt)];
```

**Mitt råd:** VS för nybörjare, Rider för avancerade! 🎯

---

## **Få Rider gratis som student** 🎓

### **GitHub Student Pack:**
1. **Gå till:** [education.github.com](https://education.github.com)
2. **Verifiera:** Er student-status
3. **Få:** JetBrains-licens gratis!
4. **Bonus:** Massa andra dev-verktyg

**Alternativ:** Direkt på [jetbrains.com/student](https://jetbrains.com/student)

**Krav:** Giltig student-email (@-adress från skolan)

---

## **System-krav** 📋

### **Alla plattformar:**
- **RAM:** 8GB minimum (16GB rekommenderat)
- **Disk:** 2.5GB för IDE + 1GB för projekt
- **CPU:** Multicore rekommenderat
- **Internet:** För licens-aktivering

### **Specifikt:**
- **Windows:** 10/11
- **Mac:** macOS 10.14+
- **Linux:** Ubuntu 18.04+, RHEL 8+

---

## **Installation Windows** 🪟

### **Steg 1-3: Nedladdning**
1. **Gå till:** [jetbrains.com/rider](https://jetbrains.com/rider)
2. **Klicka:** "Download Rider"
3. **Välj:** Windows (.exe)

### **Steg 4-5: Installation**
4. **Kör:** `JetBrains.Rider-[version].exe`
5. **Nästa, nästa...** (standard-inställningar är bra)

### **Steg 6: Första start**
- Välj UI Theme (Dark är populärt! 🌙)
- Importera settings (skippa första gången)

---

## **Installation Mac** 🍎

### **Alternativ 1: Direct Download**
1. **Ladda ner:** .dmg från JetBrains
2. **Dra:** till Applications
3. **Första start:** Högerklick → Open (Gatekeeper)

### **Alternativ 2: Homebrew** ☕
```bash
brew install --cask rider
```

**Tips:** Homebrew är awesome för Mac-utveckling! 💪

---

## **Installation Linux** 🐧

### **Snap (Ubuntu/Debian):**
```bash
sudo snap install rider --classic
```

### **Tarball (alla distributioner):**
```bash
# Ladda ner från jetbrains.com
tar -xzf rider-*.tar.gz
cd rider-*/bin
./rider.sh
```

**Pro-tip:** Skapa desktop-genväg för enkel åtkomst! 🖥️

---

## **Första konfiguration** ⚙️

### **Licens-aktivering:**
1. **Student-licens:** Logga in med JetBrains-konto
2. **Trial:** 30 dagar gratis
3. **Företag:** Mata in licens-nyckel

### **Viktiga inställningar:**
- **Theme:** Darcula (dark) eller Light
- **Keymap:** Visual Studio (för VS-användare)
- **Font:** JetBrains Mono (inbyggd, awesome!)
- **Plugins:** Kolla "Featured" för C#-goodies

---

## **Rider vs VS Code** 🆚

### **Rider fördelar:**
✅ Full IDE-upplevelse
✅ Inbyggd debugger
✅ ReSharper code analysis
✅ Database tools
✅ Git integration

### **VS Code fördelar:**
✅ Mycket snabbare start
✅ Lättare på systemresurser
✅ Större community
✅ Helt gratis

**Val:** Beror på era behov och dator-specs! 💻

---

## **Test: Er första Rider-app** 🧪

```csharp
using System;

namespace RiderTest
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Rider fungerar perfekt! 🚀");
            Console.WriteLine("IntelliJ + C# = ❤️");

            // Testa Rider's AI-suggestions
            var nu = DateTime.Now;
            Console.WriteLine($"Aktuell tid: {nu:yyyy-MM-dd HH:mm}");

            Console.ReadLine();
        }
    }
}
```

**Run: Ctrl+F5** ⚡

---

## **Rider Pro-tips** 💡

### **Kortkommandon att lära:**
- `Ctrl+Shift+F` = Search everywhere
- `Alt+Enter` = Quick fixes
- `Ctrl+T` = Go to type
- `F12` = Go to declaration
- `Shift+F6` = Rename everywhere

### **Kraftfulla funktioner:**
- **Live Templates** = kod-snippets
- **Code Analysis** = upptäcker buggar innan compilation
- **Refactoring** = omorganisera kod säkert

---

## **När välja Rider?** 🎯

### **✅ Välj Rider om:**
- Ni har kraftfull dator (8GB+ RAM)
- Vill ha professionella dev-verktyg
- Jobbar cross-platform
- Gillar JetBrains-produkter (IntelliJ, PyCharm)

### **❌ Håll er till VS om:**
- Nybörjare till programmering
- Begränsade systemresurser
- Mest Windows-utveckling
- Vill ha gratis alternativ

---

## **Nästa steg** ⏭️

Nu när Rider är installerat:

1. **Utforska** interface och verktyg 👀
2. **Aktivera** student-licens 🎓
3. **Prova** några templates 📝
4. **Förbered** för Git-integration 🔧

**Målet:** Bli produktiva i er nya kraftfulla IDE! ⚡

---

## **Källor & Resurser** 📚

**Bild på titelsidan:** Foto av Startup Stock Photos via Pexels - [Länk](https://images.pexels.com/photos/1181346/pexels-photo-1181346.jpeg)

**JetBrains Student:** [jetbrains.com/student](https://jetbrains.com/student)

**Rider Documentation:** [jetbrains.com/help/rider](https://jetbrains.com/help/rider)

**GitHub Student Pack:** [education.github.com](https://education.github.com)

---
nav_order: 50
parent: Development Tools
permalink: Lectures/vs_and_rider/visual_studio_installation_exercise_1
title: 'Övning 1: Installera Visual Studio Community'
updated: '2025-08-20 14:30:48'
---
# Övning 1: Installera Visual Studio Community

## 🎯 Mål med övningen

Efter den här övningen kommer du att:
- Ha installerat Visual Studio Community på din dator 💻
- Känna till de viktigaste komponenterna för C#-utveckling 🛠️
- Ha skapat ditt första C#-projekt 📁
- Förstå grundläggande navigation i Visual Studio 🧭

## 🧩 Uppgiften

Nu ska ni installera Visual Studio och sätta upp er utvecklingsmiljö. Tänk er att ni bygger er egna "verkstad" för kod-skapande!

## 🚀 Kom igång: Installation steg för steg

### **Steg 1: Nedladdning (5 min)**

**Windows-användare:**
1. Gå till [visualstudio.microsoft.com/vs/community/](https://visualstudio.microsoft.com/vs/community/)
2. Klicka "Download Visual Studio Community 2022"
3. Spara filen på Desktop eller Downloads

**Mac-användare:**
1. Gå till [visualstudio.microsoft.com/vs/mac/](https://visualstudio.microsoft.com/vs/mac/)
2. Ladda ner Visual Studio for Mac
3. Alternativt: VS Code + C# Extension

### **Steg 2: Starta installationen (2 min)**
- **Windows:** Dubbelklicka på `VisualStudioSetup.exe`
- **Mac:** Dra till Applications och starta

### **Steg 3: Välj Workloads (VIKTIGT!) 🎯**

Kryssa i dessa:
- ✅ **.NET desktop development** (Konsol-appar)
- ✅ **ASP.NET and web development** (Webbsidor)
- ✅ **Data storage and processing** (Databaser)

**Ungefär 3-4GB nedladdning - perfekt fika-paus! ☕**

## ✅ Förväntat resultat

Efter installationen ska ni kunna:
- Starta Visual Studio utan fel
- Se "Start Page" med projekt-templates
- Skapa nytt projekt under File → New → Project

## 🕵️‍♂️ Hur testar vi att det funkar?

### **Test 1: Skapa första projektet**
1. File → New → Project
2. Välj "Console App (.NET Core)" eller "Console App"
3. Namnge projektet: "MittForstaProjekt"
4. Klicka "Create"

### **Test 2: Kör "Hello World"**
```csharp
using System;

class Program 
{
    static void Main()
    {
        Console.WriteLine("Hej från Visual Studio!");
        Console.WriteLine("Installation lyckad! 🎉");
        Console.ReadLine();
    }
}
```

**Tryck F5 - om det funkar är allt bra! 🚀**

## 🤔 Diskussion i paret

Snacka ihop er medan installationen pågår:

- Vilken version av Windows/Mac har ni?
- Hur mycket diskutrymme hade ni innan installation?
- Några funderingar kring utvecklingsmiljöer vs vanliga program?
- Vad tror ni skillnaden är mellan VS Community och Professional?

## 🔥 BONUS: Utforska Visual Studio

När installationen är klar, utforska gränssnittet:

### **Viktiga områden att hitta:**
- **Solution Explorer** (höger sida) - Era projekt och filer
- **Error List** (bottom) - Visar problem med koden
- **Output** (bottom) - Vad händer när programmet körs
- **Toolbox** (vänster) - Verktyg för UI-utveckling

### **Första anpassningar:**
- **Theme:** Tools → Options → Environment → General → Theme (Dark är populärt! 😎)
- **Font:** Tools → Options → Environment → Fonts and Colors
- **Extensions:** Extensions → Manage Extensions (installera senare)

<details>
<summary>💡 Klicka här om installationen fastnar</summary>

**Vanliga problem och lösningar:**

**Windows Defender blockerar:**
- Lägg till undantag för Visual Studio Installer
- Kör som Administrator

**Inte nog diskutrymme:**
- Rensa Downloads och Temp-filer
- Avinstallera program ni inte använder
- Välj bara nödvändiga Workloads

**Långsam nedladdning:**
- Installera under kvällstid (mindre belastning)
- Stäng andra program som använder internet
- Överväg mobildata om WiFi är långsamt

**Mac-specifika problem:**
- Kontrollera macOS-version (kräver 10.15+)
- Ge tillstånd för "App Store and identified developers"
- Testa VS Code som alternativ

**Fortfarande problem?**
Fråga Marcus - ingen installation är omöjlig! 💪

</details>
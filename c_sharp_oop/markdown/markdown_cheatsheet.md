# 📝 Markdown CheatSheet för Studerande

## 🎯 Vad är Markdown?

Markdown är ett enkelt sätt att formatera text. Du skriver vanlig text med några speciella tecken för att göra den snygg!

Markdown används ofta för:

- Dokumentation
- Bloggar
- Skolarbeten
- Anteckningar
- README-filer i kodprojekt
- Chatt (Discord, Slack, etc.)

---

## 📋 Grundläggande formatering

### ✨ Text-styling

```markdown
**Fetstil text**
_Kursiv text_
~~Genomstruken text~~
`Kod eller kommando`
```

**Resultat:**

- **Fetstil text**
- _Kursiv text_
- ~~Genomstruken text~~
- `Kod eller kommando`

### 📊 Rubriker

```markdown
# Huvudrubrik (H1)

## Underrubrik (H2)

### Mindre rubrik (H3)

#### Liten rubrik (H4)
```

---

## 📝 Listor

### • Punktlista

```markdown
- Första punkten
- Andra punkten
  - Underpunkt
  - Ännu en underpunkt
- Tredje punkten
```

### 1️⃣ Numrerad lista

```markdown
1. Första steget
2. Andra steget
3. Tredje steget
```

### ☑️ Checklista

```markdown
- [x] Klar uppgift
- [ ] Ej klar uppgift
- [ ] Kommande uppgift
```

---

## 🔗 Länkar och bilder

### Länkar

```markdown
[Google](https://google.com)
[Min projektmapp](./projekt/)
```

### Bilder

```markdown
![Alt text](bild.jpg)
![Logo](https://example.com/logo.png)
```

---

## 📊 Tabeller

```markdown
| Namn | Ålder | Stad      |
| ---- | ----- | --------- |
| Anna | 25    | Stockholm |
| Erik | 30    | Göteborg  |
| Lisa | 28    | Malmö     |
```

**Resultat:**
| Namn | Ålder | Stad |
|------|-------|------|
| Anna | 25 | Stockholm |
| Erik | 30 | Göteborg |
| Lisa | 28 | Malmö |

---

## 💻 Kodblock

### En rad kod

```markdown
`console.log("Hello World")`
```

### Större kodblock

````markdown
```javascript
function greet(name) {
  console.log("Hej " + name + "!");
}
greet("Anna");
```
````

### Kodblock utan språk

````markdown
```
Detta är bara text
i ett kodblock
```
````

---

## 📢 Specialblock

### 💡 Citat

```markdown
> Detta är ett citat
> som kan sträcka sig
> över flera rader
```

### 📏 Horisontell linje

```markdown
---
```

---

## 🎨 Praktiska tips för skolarbeten

### 📝 Rapport-struktur

````markdown
# Projektrapport

## Sammanfattning

_Kort beskrivning av projektet_

## Mål

- [x] Huvudmål 1
- [x] Huvudmål 2
- [ ] Framtida förbättring

## Metod

1. Planering
2. Implementation
3. Testning

## Resultat

**Viktigt:** Projektet blev framgångsrikt!

### Statistik

| Vecka | Timmar | Status      |
| ----- | ------ | ----------- |
| 1     | 20     | ✅ Klar     |
| 2     | 25     | ✅ Klar     |
| 3     | 15     | 🔄 Pågående |

## Kod

```javascript
// Min lösning
function calculate(x, y) {
  return x + y;
}
```
````

## Källor

- [MDN Web Docs](https://developer.mozilla.org)
- [W3Schools](https://w3schools.com)

````

### 📚 Anteckningsformat
```markdown
# OOP - Lektion 3

## ⏰ Datum: 2025-08-27

### 📝 Viktiga begrepp
- **Klass:** Mall för objekt
- **Objekt:** Instance av en klass
- **Arv:** Klasser kan ärva från andra klasser

### 💡 Exempel
```java
public class Bil {
    private String märke;
    private int år;

    public Bil(String märke, int år) {
        this.märke = märke;
        this.år = år;
    }
}
````

### ❓ Frågor att komma ihåg

- [ ] Vad är skillnaden mellan klass och objekt?
- [ ] Hur fungerar konstruktorer?
- [ ] När använder man private vs public?

### 🏠 Hemuppgift

> Skapa en klass för **Student** med attributen:
>
> - namn
> - studentID
> - kurser (lista)

````

---

## ⚡ Snabbtips

### Emojis gör text roligare!
```markdown
✅ Klart    ❌ Fel     ⚠️ Varning
🔥 Coolt    💡 Idé     📝 Anteckning
🚀 Start    🎯 Mål     📊 Statistik
````

### Kombinera formatting

```markdown
**🎯 VIKTIGT:** _Glöm inte_ att `spara` ditt arbete!
```

### Tomma rader = nya stycken

```markdown
Detta är första stycket.

Detta är andra stycket efter en tom rad.
```

---

## 🆘 Hjälp och verktyg

### Online-editors för att testa

- [Dillinger.io](https://dillinger.io) - Live preview
- [StackEdit](https://stackedit.io) - Avancerad editor

## I Visual Studio Community

- Skapa en ny fil med `.md`-ändelse
- Högerklicka i editorn och välj "Open Preview" för förhandsvisning
- Du kan behöva installera "Markdown Editor" från Extensions

## I Jetbrains Rider

- Skapa en ny fil med `.md`-ändelse
- Högerklicka i editorn och välj "Show Preview" för förhandsvisning

### I VS Code

- Installera "Markdown Preview Enhanced"
- Tryck `Ctrl+Shift+V` för förhandsvisning

### Kom ihåg

- Markdown är **förlåtande** - det går inte att "krasha"
- **Testa dig fram** - experimentera!
- **Spara ofta** när du arbetar

---

_Lycka till med era projekt! 🎓_

---
marp: true
theme: default
paginate: true
---

# Git - Versionskontroll som förändrar allt

**Marcus Medina**
*Campus Mölndal*

---

# Vad är Git? 🤔

Git är som en **magisk "undo"-knapp** för din kod

- Kommer ihåg **allt** du någonsin gjort
- Låter dig hoppa tillbaka till **vilken punkt som helst**
- Gör att flera personer kan jobba **tillsammans utan kaos**

*Tänk: "uppsats_v1.docx" → "uppsats_FINAL_FINAL.docx" men smart*

---

# Innan Git vs Med Git

## Utan Git 😵
```
projekt_v1/
projekt_v2/
projekt_FINAL/
projekt_FINAL_FINAL/
projekt_verkligen_sista_versionen/
```

## Med Git ✨
```
projekt/
└── .git/ (all historia här)
```

En mapp. Hela historiken gömd.

---

# Git håller reda på TRE områden

## 🏠 Working Directory
*Här jobbar du*

## 📦 Staging Area  
*"Packar" ändringar*

## 🏛️ Repository
*Permanent historia*

---

# Basic Git Workflow

```bash
# 1. Kolla läget
git status

# 2. "Packa" filer för commit
git add filnamn.txt
git add .               # alla filer

# 3. "Spara ögonblicksbild"
git commit -m "Vad jag gjorde"

# 4. Kolla historiken
git log
```

---

# Varför är Git KRITISKT? 💪

## 🛡️ **Säkerhet**
Förlorar aldrig kod igen

## 👥 **Samarbete** 
Flera utvecklare, inga konflikter

## 🧪 **Experimentering**
Testa idéer utan risk

## 📊 **Spårbarhet**
Vem ändrade vad och varför?

---

# Repository = Projektmapp + Historia

```bash
# Skapa nytt repository
git init

# Klona befintligt repository
git clone https://github.com/user/projekt.git
```

Ett repository innehåller:
- Dina filer
- **Hela projektets historia**
- Information om branches, remotes, etc.

---

# Commits = Ögonblicksbilder

Varje commit innehåller:
- **Snapshot** av alla filer
- **Meddelande** som beskriver ändringen
- **Tidsstämpel** och **författare**
- **Unikt ID** (hash)

```bash
git commit -m "Lagt till inloggningsfunktion"
```

---

# Git Status = Din kompass 🧭

```bash
git status
```

Visar dig:
- Vilka filer som **ändrats** men inte committats
- Vilka filer som är **redo att committas**
- Vilka filer som är **helt nya**

**Pro-tip**: Kör `git status` hela tiden!

---

# Git Log = Tidsmaskin ⏰

```bash
git log                    # Full historik
git log --oneline         # Kompakt vy
git log --graph          # Visuell vy
```

Se:
- Alla commits i kronologisk ordning
- Vem som gjorde vad
- När ändringar gjordes
- Commit-meddelanden

---

# Lokalt vs Remote

## 💻 Lokalt (din dator)
```bash
git init
git add .
git commit -m "Lokal ändring"
```

## ☁️ Remote (GitHub, GitLab)
```bash
git push origin main      # Skicka upp
git pull origin main      # Hämta ner
```

---

# Branching = Parallella universum 🌌

```bash
# Skapa ny branch
git checkout -b ny-feature

# Jobba på branchen
git add .
git commit -m "Implementerat ny feature"

# Byt tillbaka till main
git checkout main

# Slå ihop branches
git merge ny-feature
```

---

# Vanliga misstag att undvika ⚠️

## ❌ Dåligt:
```bash
git commit -m "fix"
git commit -m "update"
```

## ✅ Bra:
```bash
git commit -m "Fixade bug i login-validering"
git commit -m "Uppdaterat användarmanual med nya screenshots"
```

---

# Grundregler för Git-framgång 🎯

1. **Commit tidigt och ofta** - små ändringar är bäst
2. **Skriv bra meddelanden** - framtida du kommer tacka dig
3. **Kör `git status` konstant** - vet alltid var du står
4. **Experimentera utan rädsla** - Git är säkert
5. **Backup med remotes** - push till GitHub/GitLab

---

# Git räddar dig när... 🚨

- **Datorn kraschar** (remote backup)
- **Kod slutar fungera** (återgå till working version)
- **Konflikter uppstår** (merge tools)
- **Du glömmer vad du gjorde** (git log)
- **Flera jobbar samtidigt** (branches + merge)

---

# Sammanfattning - Git är...

✨ **Ett tidsresande filsystem**
🛡️ **Försäkring för din kod**  
👥 **Samarbetsverktyg för team**
🧪 **Säkert experimentlabb**
📚 **Automatisk projektdokumentation**

**Git är inte bara ett verktyg - det är superkraft för utvecklare!**

---

# Nästa: Hands-on!

Nu ska vi **praktisera** Git tillsammans:
- Skapa repository
- Göra commits  
- Navigera i historik
- Hantera branches
- Jobba med remotes

**Är ni redo?** 🚀

---

# Frågor? 🤔

*"Inga dumma frågor - bara odokumenterade lösningar!"*

**Marcus Medina**
📧 marcus@campusmolndal.se
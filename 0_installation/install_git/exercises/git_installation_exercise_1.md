---
nav_order: 50
parent: Githubstudent
permalink: Lectures/Git/git_installation_exercise_1
title: 'Övning 1: Git installation och grundkonfiguration'
updated: '2025-08-20 14:30:48'
---
# Övning 1: Git installation och grundkonfiguration

## 🎯 Mål med övningen

Efter den här övningen kommer du att:
- Ha installerat Git på din dator ⚙️
- Förstå skillnaden mellan Git och GitHub 🤝
- Ha konfigurerat Git med ditt namn och email 👤
- Ha skapat och konfigurerat SSH-nycklar för säker anslutning 🔐

## 🧩 Uppgiften

Nu ska ni installera och konfigurera Git - era "tidsmaskin för kod"! Tänk er att ni får era första professionella utvecklarverktyg.

## 🚀 Kom igång: Git Installation (30 min)

### **Steg 1: Installera Git enligt er plattform (15 min)**

**Windows:**
1. **Gå till:** [git-scm.com/download/win](https://git-scm.com/download/win)
2. **Ladda ner** och **kör** Git installer
3. **Viktiga inställningar:**
   - ✅ "Git Bash Here" (högerklick i mappar)
   - ✅ "Use Visual Studio Code as Git's default editor" 
   - ✅ "Override the default branch name for new repositories" → **main**
   - ✅ "Git from the command line and also from 3rd-party software"
   - ✅ "Use the OpenSSL library"

**macOS:**
```bash
# Option 1: Homebrew (rekommenderat)
/bin/bash -c "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/HEAD/install.sh)"
brew install git

# Option 2: Direkt download från git-scm.com/download/mac
# Option 3: Xcode Command Line Tools
xcode-select --install
```

**Linux:**
```bash
# Ubuntu/Debian
sudo apt update && sudo apt install git

# Fedora
sudo dnf install git

# Arch Linux
sudo pacman -S git
```

### **Steg 2: Verifiera installation (5 min)**

Öppna terminal/kommandoprompt och kör:

```bash
git --version
```

**Förväntat resultat:** `git version 2.40.0` (eller nyare)

### **Steg 3: Första konfiguration (10 min)**

```bash
# Ditt riktiga namn (visas i Git historik)
git config --global user.name "Ditt Förnamn Efternamn"

# Din GitHub email (samma som ni registrerade med!)
git config --global user.email "din.email@student.campusmolndal.se"

# Bättre default branch namn
git config --global init.defaultBranch main

# Färger i terminal
git config --global color.ui auto

# Standard editor (om ni har VS Code)
git config --global core.editor "code --wait"
```

## ✅ Förväntat resultat

Efter steg 1-3 ska ni ha:

**✅ Git Installation:**
- Git version 2.40+ installerat
- Terminal/kommandoprompt känner igen `git` kommando
- Git Bash tillgängligt (Windows användare)

**✅ Grundkonfiguration:**
- Användarnamn och email konfigurerat
- Default branch satt till "main"
- Färgstöd aktiverat för bättre läsbarhet

## 🕵️‍♂️ Hur testar vi att det funkar?

### **Verifieringstest:**

```bash
# 1. Kontrollera Git version
git --version

# 2. Kontrollera konfiguration
git config --list --global

# 3. Specifikt kolla användarinfo
git config user.name
git config user.email

# 4. Testa hjälp-systemet
git help
```

**Förväntat output:**
```
git version 2.40.0
user.name=Ditt Namn
user.email=din.email@student.campusmolndal.se
init.defaultbranch=main
color.ui=auto
```

## 🤔 Diskussion i paret

Medan Git installeras och konfigureras, diskutera:

**Versionshantering förvirring:**
- Vad tror ni är skillnaden mellan "save" och "commit"?
- Varför kan det vara bra att spara flera versioner av samma fil?
- Hur hanterade ni tidigare när ni samarbetade på dokument?

**Utvecklarverktyg:**
- Vilka andra verktyg tror ni professionella utvecklare använder dagligen?
- Varför tror ni alla utvecklare använder versionshantering?
- Vad är fördelen med att kunna "gå tillbaka i tiden" i kod?

## 🔥 BONUS: SSH Nycklar Setup (Avancerat)

### **Varför SSH nycklar?**
- **Säkrare** än lösenord (impossible att hacka)
- **Bekvämare** - slipper skriva lösenord varje gång
- **GitHub standard** - alla proffs använder SSH

### **Steg 1: Generera SSH nyckelpar (5 min)**

```bash
# Generera Ed25519 SSH key (modern och säker)
ssh-keygen -t ed25519 -C "din.email@student.campusmolndal.se"

# När promptad:
# - File location: Tryck ENTER (använd default ~/.ssh/id_ed25519)
# - Passphrase: Tryck ENTER två gånger (inget lösenord för nu)
```

**Vad händer:**
- Skapar två filer: `id_ed25519` (privat) och `id_ed25519.pub` (publik)
- Privat nyckel stannar på er dator (ALDRIG delad!)
- Publik nyckel läggs till GitHub

### **Steg 2: Kopiera publik nyckel (3 min)**

```bash
# Windows/Linux
cat ~/.ssh/id_ed25519.pub

# macOS (kopierar automatiskt till clipboard)
pbcopy < ~/.ssh/id_ed25519.pub

# Windows (PowerShell)
Get-Content ~/.ssh/id_ed25519.pub | clip
```

**Kopiera hela outputen** (börjar med `ssh-ed25519` och slutar med er email)

### **Steg 3: Lägg till i GitHub (7 min)**

1. **Gå till GitHub.com** och logga in
2. **Settings** (klicka er profilbild → Settings)
3. **SSH and GPG keys** (vänstra menyn)
4. **New SSH key** (grön knapp)
5. **Title:** "Campus Mölndal Laptop" (eller något beskrivande)
6. **Key type:** Authentication Key
7. **Key:** Klistra in er publik nyckel
8. **Add SSH key**

### **Steg 4: Testa SSH anslutning (2 min)**

```bash
# Testa anslutning till GitHub
ssh -T git@github.com
```

**Första gången ser ni:**
```
The authenticity of host 'github.com (140.82.121.4)' can't be established.
ED25519 key fingerprint is SHA256:+DiY3wvvV6TuJJhbpZisF/zLDA0zPMSvHdkr4UvCOqU.
Are you sure you want to continue connecting (yes/no/[fingerprint])? 
```

**Skriv:** `yes` och tryck ENTER

**Framgångfullt resultat:**
```
Hi ditt-github-användarnamn! You've successfully authenticated, 
but GitHub does not provide shell access.
```

## 💡 Marcus tips om Git setup

<details>
<summary>🔧 Marcus säger om Git konfiguration</summary>

**Marcus säger:**

"Git setup är som att sätta upp ert utvecklar-DNA! 🧬

**Varför är första konfiguration så viktig?**

1. **user.name** och **user.email** blir era 'signaturer' på all kod
   - Syns i Git historik för alltid
   - Andra utvecklare ser vem som skrev vad
   - GitHub använder email för att länka commits till er profil

2. **SSH keys** är som nycklar till er digitala lägenhet
   - Lösenord = samma nyckel för alla (dåligt!)
   - SSH = unik nyckel per dator (säkert!)
   - Professionella utvecklare använder ALLTID SSH

3. **Default branch 'main'** istället för 'master'
   - Modern standard sedan 2020
   - Inkluderande språk i tech-industrin
   - GitHub default för nya repositories

**Pro-tips för Git config:**

```bash
# Praktiska alias som sparar tid
git config --global alias.st status
git config --global alias.co checkout  
git config --global alias.br branch
git config --global alias.ci commit
git config --global alias.unstage 'reset HEAD --'

# Bättre log output
git config --global alias.lg 'log --oneline --decorate --all --graph'

# Auto-setup för push
git config --global push.default current

# Bättre merge conflict resolution
git config --global merge.tool vscode
```

**SSH Security Best Practices:**

- 🔑 **En SSH key per dator** - inte samma för laptop och desktop
- 🚫 **Aldrig dela privat nyckel** - om ni gör det, generera ny!
- 📧 **Använd samma email** som GitHub-kontot
- 🔐 **Passphrase för extra säkerhet** (valfritt för studenter)

**Troubleshooting vanliga problem:**

```bash
# Problem: Git känner inte igen användare
git config --global --list    # Kolla alla inställningar

# Problem: SSH connection fails
ssh-add ~/.ssh/id_ed25519     # Lägg till key till SSH agent
ssh -vT git@github.com        # Verbose output för debugging

# Problem: Wrong email i commits
git config user.email         # Kolla nuvarande email
git log --oneline            # Se tidigare commits
```

**Kom ihåg:** Denna setup gör ni EN gång per dator - sedan funkar allt automagiskt! ⚡"

</details>
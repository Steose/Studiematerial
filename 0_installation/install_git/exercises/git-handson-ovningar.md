---
marp: true
theme: default
paginate: true
---

# Git Hands-On Övningar

**Praktiska steg-för-steg övningar**
*Marcus Medina - Campus Mölndal*

---

# Övning 1: Första gången Git-setup 🎯

## Innan vi börjar - sätt upp din identitet

```bash
# Sätt ditt namn (används i alla commits)
git config --global user.name "Ditt Namn"

# Sätt din email (används i alla commits)
git config --global user.email "din.email@exempel.se"

# Kolla att det blev rätt
git config --global user.name
git config --global user.email
```

**Detta behöver bara göras EN gång per dator!**

---

# Övning 2: Skapa ditt första repository 📁

## Steg 1: Skapa en projektmapp
```bash
mkdir mitt-forsta-repo
cd mitt-forsta-repo
```

## Steg 2: Initiera Git
```bash
git init
```

**💡 Nu har du skapat en `.git` mapp - där bor hela historiken!**

---

# Övning 3: Första filen och commit ✍️

## Steg 1: Skapa en fil
```bash
echo "# Mitt första Git-projekt" > README.md
```

## Steg 2: Kolla status
```bash
git status
```
*Vad ser du? Filen är "untracked"*

---

# Övning 3: Första commiten (fortsättning)

## Steg 3: Lägg till filen
```bash
git add README.md
```

## Steg 4: Kolla status igen
```bash
git status
```
*Nu är filen "staged" - redo för commit*

## Steg 5: Gör din första commit
```bash
git commit -m "Lagt till README-fil"
```

---

# Övning 4: Ändra och commit igen 🔄

## Steg 1: Ändra filen
```bash
echo "Detta är mitt första Git-projekt för att lära mig versionskontroll." >> README.md
```

## Steg 2: Se vad som ändrats
```bash
git status
git diff
```

## Steg 3: Commit ändringen
```bash
git add README.md
git commit -m "Lade till beskrivning i README"
```

---

# Övning 5: Se din historik 📚

## Kolla alla dina commits
```bash
git log
git log --oneline
```

## Vad ser du?
- Dina commit-meddelanden
- Datum och tid
- Ditt namn och email
- Unika commit-ID:n (hash)

---

# Övning 6: Lägga till flera filer samtidigt 📂

## Steg 1: Skapa flera filer
```bash
echo "print('Hej från Python!')" > hello.py
echo "<h1>Min webbsida</h1>" > index.html
echo "# Todo-lista" > todo.txt
```

## Steg 2: Lägg till alla samtidigt
```bash
git add .
git status
```

## Steg 3: Commit allt
```bash
git commit -m "Lagt till Python-fil, HTML-fil och todo-lista"
```

---

# Övning 7: Hantera ändringar i flera filer 🎭

## Steg 1: Ändra i flera filer
```bash
echo "print('Hej världen!')" >> hello.py
echo "<p>Välkommen till min sida</p>" >> index.html
echo "- Lär mig Git" >> todo.txt
```

## Steg 2: Se alla ändringar
```bash
git status
git diff
```

---

# Övning 7: (fortsättning)

## Steg 3: Välj vad som ska committas
```bash
# Lägg bara till Python-filen
git add hello.py

git status  # Vad händer?

# Lägg till resten
git add index.html todo.txt
```

## Steg 4: Commit
```bash
git commit -m "Uppdaterat alla filer med mer innehåll"
```

---

# Övning 8: Återställa ändringar ↩️

## Steg 1: Gör en ändring du ångrar
```bash
echo "DENNA ÄNDRING VAR ETT MISSTAG!" >> README.md
```

## Steg 2: Återställ filen
```bash
git checkout HEAD README.md
```

## Steg 3: Kontrollera
```bash
cat README.md
```
*Misstaget är borta!*

---

# Övning 9: Gå tillbaka i tiden ⏰

## Steg 1: Se din historik
```bash
git log --oneline
```

## Steg 2: Kolla en tidigare commit
```bash
git show <första-commit-hashen>
```

## Steg 3: Jämför commits
```bash
git diff HEAD~2 HEAD
```
*Vad ändrades mellan för 2 commits sedan och nu?*

---

# Övning 10: Skapa din första branch 🌿

## Steg 1: Skapa och byt till ny branch
```bash
git checkout -b experimental-feature
```

## Steg 2: Gör ändringar på branchen
```bash
echo "# Experimentell funktion" > experiment.md
git add experiment.md
git commit -m "Lagt till experimentell fil"
```

---

# Övning 10: (fortsättning)

## Steg 3: Byt tillbaka till main
```bash
git checkout main
ls
```
*Experimentell filen finns inte här!*

## Steg 4: Byt tillbaka till din branch
```bash
git checkout experimental-feature
ls
```
*Nu finns filen igen!*

---

# Övning 11: Merge branches 🔀

## Steg 1: Gå tillbaka till main
```bash
git checkout main
```

## Steg 2: Slå ihop din branch
```bash
git merge experimental-feature
```

## Steg 3: Kontrollera
```bash
ls
git log --oneline
```
*Nu finns experimentella filen även i main!*

---

# Övning 12: Rensa upp branches 🧹

## Steg 1: Se alla branches
```bash
git branch
```

## Steg 2: Ta bort den gamla branchen
```bash
git branch -d experimental-feature
```

## Steg 3: Kontrollera
```bash
git branch
```

---

# Övning 13: Anslut till GitHub/Remote 🌐

## Steg 1: Skapa repository på GitHub
*Gör detta i GitHub-webgränssnitt*

## Steg 2: Anslut ditt lokala repo
```bash
git remote add origin https://github.com/dittnamn/mitt-forsta-repo.git
```

## Steg 3: Push till remote
```bash
git push -u origin main
```

---

# Övning 14: Pull och Push-cykeln 🔄

## Simulera teamwork

## Steg 1: Gör ändringar lokalt
```bash
echo "Lokal ändring" >> todo.txt
git add todo.txt
git commit -m "Lagt till lokal ändring"
```

## Steg 2: Hämta eventuella ändringar
```bash
git pull origin main
```

## Steg 3: Skicka upp dina ändringar
```bash
git push origin main
```

---

# Checkpunkter - Vad har du lärt dig? ✅

Efter dessa övningar kan du:

- ✅ Konfigurera Git med namn/email
- ✅ Skapa repository med `git init`
- ✅ Lägga till filer med `git add`
- ✅ Committa ändringar med `git commit`
- ✅ Se historik med `git log`
- ✅ Återställa filer med `git checkout`
- ✅ Arbeta med branches
- ✅ Merge branches
- ✅ Ansluta till remote repositories

---

# Vanliga problem och lösningar 🚨

## Problem: "Please tell me who you are"
**Lösning:** Kör git config commands från övning 1

## Problem: "Not a git repository"
**Lösning:** Kör `git init` eller `cd` till rätt mapp

## Problem: "Nothing to commit"
**Lösning:** Gör ändringar först, eller kör `git status`

---

# Vad gör vi härnäst? 🚀

## Fördjupning:
- Hantera merge-konflikter
- Advanced branching strategies
- Git hooks och automation
- Samarbetsworkflows (Git Flow, GitHub Flow)

## Praktik:
- Jobba i team på riktiga projekt
- Integrera med GitHub/GitLab
- Automatisering med CI/CD

---

# Grattis! 🎉

**Du kan nu grunderna i Git!**

## Kom ihåg:
- Övning ger färdighet
- Git är säkert - experimentera
- Community och dokumentation finns alltid
- Commit tidigt och ofta

**Nästa steg:** Börja använda Git i dina riktiga projekt!

---

# Frågor och diskussion 💬

*"Det enda sättet att lära sig Git är att använda det!"*

**Ha en bra dag och lycka till med Git! 🚀**
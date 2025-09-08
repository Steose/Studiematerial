# Git Merge: Slå ihop ändringar som en proffis

## Vad är Git Merge?

📘 Git merge är som att **blanda ihop två receptböcker** till en. När flera utvecklare jobbar på samma projekt, eller när du själv jobbar på olika features samtidigt, behöver ni "slå ihop" era ändringar så att allt fungerar tillsammans.

Merge är den process där Git kombinerar ändringar från två eller flera **branches** (grenar) till en gemensam gren. Det är så team kan jobba parallellt utan att störa varandra.

## Grundläggande koncept

### Branches (Grenar)

Tänk på branches som **parallella universum** för din kod:

- **main branch** - huvudgrenen, den "riktiga" koden
- **feature branch** - där du utvecklar nya funktioner
- **bugfix branch** - där du fixar specifika problem

### Merge vs Rebase

Git erbjuder två huvudsätt att slå ihop ändringar:

- **Merge** - skapar en ny commit som kombinerar två grenar
- **Rebase** - "flyttar" dina commits så de ser ut som om de gjordes efter andra ändringar

Vi fokuserar på **merge** här - det är säkrast för nybörjare.

## Enkel merge utan konflikter

### Scenario: Du jobbat på en feature branch

```plaintext
main:     A --- B --- C
               \
feature:        D --- E
```

Efter merge:
```plaintext
main:     A --- B --- C --- M
               \             /
feature:        D --------- E
```

### Stegvis genomgång

#### Steg 1: Förbered merge

```bash
# Gå tillbaka till main branch
git checkout main

# Hämta senaste ändringar (om du jobbar i team)
git pull origin main

# Kontrollera status
git status
```

#### Steg 2: Slå ihop din feature branch

```bash
# Merge feature branch till main
git merge feature-login

# Om allt går bra ser du:
# "Merge made by the 'recursive' strategy"
```

#### Steg 3: Kontrollera resultatet

```bash
# Se att merge-commiten skapades
git log --oneline --graph

# Kontrollera att alla filer finns
git status
```

#### Steg 4: Rensa upp

```bash
# Ta bort feature branch (valfritt)
git branch -d feature-login

# Push merged changes (om remote)
git push origin main
```

### Komplett exempel - Enkel merge

```bash
# Skapa och jobba på feature branch
git checkout -b feature-user-profile
echo "user_profile.py content" > user_profile.py
git add user_profile.py
git commit -m "Implementerat användarprofilfunktion"

# Gå tillbaka till main
git checkout main

# Merge feature
git merge feature-user-profile

# Resultat: feature är nu del av main
git log --oneline
# Visar både din commit och merge-commiten

# Rensa upp
git branch -d feature-user-profile
```

## Merge med konflikter - Steg för steg

### Vad är en konflikt?

En **merge conflict** uppstår när Git inte kan automatiskt slå ihop ändringar eftersom:
- Samma rader ändrats i båda branches
- En fil tagits bort i ena grenen men ändrats i andra
- Motstridande ändringar som Git inte kan lösa automatiskt

### Exempel på konflikt

**main branch - config.py:**
```python
DATABASE_URL = "localhost:5432/production"
DEBUG = False
```

**feature branch - config.py:**
```python
DATABASE_URL = "localhost:5432/development"  
DEBUG = True
```

### Lösa konflikter steg för steg

#### Steg 1: Försök merge (kommer att misslyckas)

```bash
git checkout main
git merge feature-config

# Git visar fel:
# CONFLICT (content): Merge conflict in config.py
# Automatic merge failed; fix conflicts and then commit the result.
```

#### Steg 2: Identifiera konflikter

```bash
# Se vilka filer som har konflikter
git status

# Visar:
# Unmerged paths:
#   (use "git add <file>..." to mark resolution)
#         both modified:   config.py
```

#### Steg 3: Öppna filen och lös konflikter

```bash
# Öppna filen i din editor
nano config.py
# eller
code config.py
```

**Filen kommer att se ut så här:**
```python
<<<<<<< HEAD
DATABASE_URL = "localhost:5432/production"
DEBUG = False
=======
DATABASE_URL = "localhost:5432/development"
DEBUG = True
>>>>>>> feature-config
```

#### Steg 4: Välj hur konflikten ska lösas

**Option 1: Välj ena versionen**
```python
# Behåll bara main version (ta bort konfliktmarkeringar)
DATABASE_URL = "localhost:5432/production"
DEBUG = False
```

**Option 2: Kombinera båda versionerna**
```python
# Skapa lösning som kombinerar båda
DATABASE_URL = "localhost:5432/production"  # Från main
DEBUG = True  # Från feature branch
```

**Option 3: Skapa helt ny lösning**
```python
# Skapa något nytt som löser problemet
DATABASE_URL = os.getenv("DB_URL", "localhost:5432/default")
DEBUG = os.getenv("DEBUG", "False").lower() == "true"
```

#### Steg 5: Markera konflikten som löst

```bash
# Lägg till den fixade filen
git add config.py

# Kontrollera att konflikten är löst
git status
# Ska visa: "All conflicts fixed but you are still merging"
```

#### Steg 6: Slutför merge

```bash
# Commit merge (Git föreslår automatiskt meddelande)
git commit

# Eller skriv eget meddelande:
git commit -m "Merge feature-config med löst databas-konflikt"
```

### Användbara verktyg för konfliktlösning

#### Git diff för att förstå konflikter

```bash
# Se vad som ändrats i båda branches
git diff HEAD~1 HEAD      # Main branch ändringar
git diff feature-config   # Feature branch ändringar
```

#### Mergetools

```bash
# Konfigurera ett visuellt merge-verktyg
git config merge.tool vimdiff
# eller för VS Code:
git config merge.tool vscode

# Använd verktyget för att lösa konflikter
git mergetool
```

## Avancerade merge-strategier

### Fast-forward merge

När din feature branch är direkt framför main branch:

```plaintext
main:     A --- B
               \
feature:        C --- D

Efter merge:
main:     A --- B --- C --- D
```

```bash
# Tvinga fram merge commit även vid fast-forward
git merge --no-ff feature-branch

# Eller tillåt fast-forward (standard)
git merge feature-branch
```

### Squash merge

Kombinerar alla commits från feature branch till en enda commit:

```bash
# Slå ihop alla commits till en
git merge --squash feature-branch
git commit -m "Implementerat användarautentisering (sammanslaget från feature-branch)"
```

### Cherry-pick istället för merge

Ta bara specifika commits från en annan branch:

```bash
# Ta bara en specifik commit
git cherry-pick abc123def

# Ta flera commits
git cherry-pick abc123^..def456
```

## Teamwork med merges

### Pull Request workflow

**Istället för direkta merges:**

1. **Skapa feature branch**
```bash
git checkout -b feature-payment-system
# ... jobba och commita
git push origin feature-payment-system
```

2. **Skapa Pull Request** via GitHub/GitLab webgränssnitt

3. **Code review** - teamet granskar din kod

4. **Merge via web interface** efter godkännande

### Merge vs Pull Request

| Direct Merge | Pull Request |
|-------------|-------------|
| Snabb | Säkrare |
| Ingen kodgranskning | Obligatorisk review |
| Risk för fel | Team-validerad kod |
| Solo projekt | Team-projekt |

## Vanliga merge-misstag och lösningar

### Misstag 1: Merge utan pull först

⚠️ **Problem:** Du mergear utan att ha hämtat senaste ändringar.

**Lösning:**
```bash
# Alltid pull före merge
git checkout main
git pull origin main
git merge feature-branch
```

### Misstag 2: Panikera vid konflikter

⚠️ **Problem:** Rädda för att förstöra något vid konflikter.

**Lösning:**
```bash
# Du kan alltid avbryta merge
git merge --abort

# Återgå till läget före merge
git reset --hard HEAD~1
```

### Misstag 3: Dålig konfliktlösning

❌ **Dåligt:** Alltid välja "din" version utan att förstå.

✅ **Bra:** Förstå varför konflikten uppstod och skapa optimal lösning.

### Misstag 4: Glömma att testa efter merge

**Problem:** Merge kan skapa nya bugs även om inga konflikter fanns.

**Lösning:** Alltid testa applikationen efter merge.

## Merge commit meddelanden

### Automatiska meddelanden

Git skapar automatiskt meddelanden som:
```
Merge branch 'feature-user-auth' into main
```

### Förbättra merge-meddelanden

```bash
# Egen merge-commit meddelande
git merge feature-branch -m "Integrerat användarautentisering med OAuth2 stöd

- Lagt till Google OAuth integration
- Implementerat session management  
- Lagt till användar-roller och behörigheter
- Löst konflikter i config.py för databas-inställningar"
```

## Merge best practices

### 1. Små, frekventa merges

✅ **Bra:** Merge små features ofta
```bash
# Dagliga feature branches
git merge feature-button-styling
git merge feature-form-validation  
git merge bugfix-login-redirect
```

❌ **Dåligt:** En stor merge efter veckor
```bash
# Månader av arbete i en merge
git merge massive-refactor-everything
```

### 2. Testa före merge

```bash
# Alltid testa feature branch innan merge
git checkout feature-branch
# Kör tester, manuell verifiering
git checkout main
git merge feature-branch
```

### 3. Dokumentera komplexa merges

```bash
git merge feature-complex -m "Integrerat nytt betalningssystem

BREAKING CHANGES:
- API endpoints för betalningar har ändrats
- Database schema uppdaterat (kör migrations)
- Konfiguration för Stripe behövs i .env

Lösta konflikter:
- payment.py: Kombinerat gamla och nya validering
- config.py: Lagt till nya miljövariabler"
```

## Sammanfattning

📚 **Viktiga takeaways för Git merge:**

### Grundläggande workflow
1. **Alltid pull först** - hämta senaste ändringar
2. **Merge systematiskt** - inte i panik
3. **Testa efter merge** - säkerställ att allt fungerar
4. **Pusha resultatet** - dela med teamet

### Hantera konflikter
1. **Förstå konflikten** - varför uppstod den?
2. **Välj rätt lösning** - inte bara första bästa
3. **Testa lösningen** - fungerar koden efter fix?
4. **Dokumentera komplexa fall** - hjälp framtida dig

### Teamwork-tips
- Använd **Pull Requests** för team-projekt
- **Kommunicera** komplexa merges med teamet  
- **Merge ofta** för att undvika stora konflikter
- **Backup viktiga branches** innan komplexa merges

## Nästa steg

🎯 **För att behärska Git merge:**

1. **Öva lokalt** - skapa test-branches och merge dem
2. **Simulera konflikter** - ändra samma filer i olika branches
3. **Använd visuella verktyg** - lär dig merge-verktyg
4. **Jobba i team** - praktisera Pull Request workflow
5. **Läs om rebase** - alternativ till merge för clean history

Kom ihåg: **Merge är en färdighet som förbättras med övning**. Börja med enkla merges och jobba dig upp till komplexa team-scenarios. Git är förlåtande - du kan nästan alltid ångra och försöka igen!
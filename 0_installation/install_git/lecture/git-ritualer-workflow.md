# Git-ritualer: Add, Commit, Push - Dina dagliga rutiner

## Vad är Git-ritualer?

📘 Git-ritualer är de kommandon du kör om och om igen när du utvecklar. Precis som du borstar tänderna varje morgon, kommer du köra `git add`, `git commit`, och `git push` flera gånger om dagen.

Dessa ritualer skiljer sig beroende på om du jobbar **ensam** eller i **team**. Vi ska lära oss båda!

## Solo-utveckling: Den grundläggande rytmen

### Grundläggande solo-ritual

När du jobbar ensam på ditt projekt är rytmen enkel och förutsägbar:

```plaintext
JOBBA → ADD → COMMIT → (upprepa)
```

### Stegvis genomgång - Solo

#### Steg 1: Jobba med din kod

```bash
# Du kodar, ändrar filer, skapar ny funktionalitet
# Kanske jobbar i 30-60 minuter på en specifik feature
```

#### Steg 2: Kontrollera dina ändringar

```bash
# Kolla vad som hänt
git status

# Se exakta ändringar
git diff
```

#### Steg 3: Lägg till filer för commit

```bash
# Lägg till specifika filer
git add filnamn.js

# Eller lägg till alla ändrade filer
git add .

# Eller lägg till alla filer av viss typ
git add *.py
```

#### Steg 4: Commit dina ändringar

```bash
git commit -m "Implementerat användarinloggning med validering"
```

#### Steg 5: Upprepa cykeln

```bash
# Fortsätt jobba → add → commit → jobba → add → commit...
```

### Solo-ritual med remote backup

Om du vill backa upp till GitHub/GitLab regelbundet:

```bash
# Din vanliga ritual PLUS:
git push origin main

# Eller om du vill pusha flera commits samtidigt:
# Jobba → commit → jobba → commit → jobba → commit → PUSH
```

### Konkret exempel - Solo-utveckling

```bash
# Morgon: Börja jobba
git status                              # Kolla läget

# Jobba 1 timme på login-funktion
# Ändrar login.js, style.css, index.html

git add login.js style.css index.html   # Lägg till ändringar
git commit -m "Lagt till login-formulär och styling"

# Jobba 1 timme på validering  
# Ändrar validation.js

git add validation.js
git commit -m "Implementerat validering för email och lösenord"

# Lunch - push till backup
git push origin main

# Eftermiddag: Jobba på felhantering
# ... fortsätt samma rytm
```

## Team-utveckling: Den synkroniserade rytmen

### Team-ritual: Pull först, Push sist

När flera utvecklare jobbar på samma projekt måste ni **synkronisera** regelbundet:

```plaintext
PULL → JOBBA → ADD → COMMIT → PULL → PUSH
```

### Varför denna ordning?

- **PULL först**: Hämta andras ändringar innan du börjar
- **PULL innan PUSH**: Säkerställ att du har senaste versionen innan du skickar upp dina ändringar

### Stegvis genomgång - Team

#### Steg 1: Starta dagen med att synka

```bash
# Första på morgonen - hämta vad teamet gjort
git pull origin main
```

#### Steg 2: Jobba lokalt (samma som solo)

```bash
# Jobba med din kod som vanligt
# Kolla status, add, commit som tidigare
git add .
git commit -m "Fixade bug i användarprofil"
```

#### Steg 3: Synka innan du pushar

```bash
# VIKTIGT: Pull innan push!
git pull origin main

# Om inga konflikter:
git push origin main

# Om konflikter - vi tar detta i merge-artikeln
```

### Konkret exempel - Team-utveckling

```bash
# Måndag morgon 08:00
git pull origin main                    # Hämta veckoslutets ändringar

# Jobba på ny feature till 10:00
git add src/components/UserProfile.js
git commit -m "Lagt till profilbild-funktionalitet"

# Innan lunch - synka med team
git pull origin main                    # Hämta kollegerors ändringar
git push origin main                    # Skicka upp mina ändringar

# Efter lunch 13:00 - synka igen
git pull origin main                    # Teamet kanske jobbat under lunch

# Jobba till 15:00
git add src/api/userApi.js
git commit -m "Uppdaterat API-anrop för profildata"

# Slutet av dagen
git pull origin main                    # Hämta senaste
git push origin main                    # Pusha dagens arbete
```

## Frekvens - Hur ofta?

### Commits: Ofta och små

✅ **Bra rytm:**
```bash
# Var 30-60:e minut, efter varje liten färdig del
git commit -m "Lagt till validering för email-fält"
# 30 min senare...
git commit -m "Fixade CSS för validerings-meddelanden" 
# 45 min senare...
git commit -m "Lagt till enhetstester för email-validering"
```

❌ **Dålig rytm:**
```bash
# En commit per dag med allt
git commit -m "Fixat massa grejer"
```

### Push (team): Flera gånger om dagen

**Rekommenderad push-frekvens i team:**
- Morgon (efter pull)
- Före lunch
- Slutet av dagen
- Innan du går hem för helger

### Pull (team): Innan varje push + vid behov

**När du ska pull:a:**
- Första på morgonen
- Innan varje push
- När du vet att någon pushat något viktigt
- Innan du börjar på ny feature

## Ritualer för olika situationer

### Ritual 1: Snabb bugfix

```bash
# Upptäckt bug
git pull origin main           # Säkra att du har senaste
# Fix buggen
git add filenSomFixades.js
git commit -m "Fixade div-by-zero i kalkylatorn"
git pull origin main           # Dubbel-kolla innan push
git push origin main           # Skicka upp direkt
```

### Ritual 2: Stor feature (flera dagar)

```bash
# Dag 1
git pull origin main
# Jobba på feature
git add .
git commit -m "Påbörjat implementering av betalningssystem"
# INTE push än - feature inte klar

# Dag 2
git pull origin main           # Hämta andras ändringar
# Fortsätt jobba
git add .
git commit -m "Lagt till Stripe-integration"
# Fortfarande inte push

# Dag 3 - feature klar
git pull origin main
# Slutför feature
git add .
git commit -m "Slutfört betalningssystem med tester"
git pull origin main           # Säkra inför push
git push origin main           # Nu kan teamet använda featuren
```

### Ritual 3: Experimentell kod

```bash
# Skapa experimental branch
git checkout -b experiment-new-ui

# Experimentera fritt
git add .
git commit -m "Testar ny UI-approach"
git commit -m "Justerat färger"
git commit -m "Lagt till animationer"

# Om experiment lyckas:
git checkout main
git merge experiment-new-ui
git push origin main

# Om experiment misslyckas:
git checkout main
git branch -d experiment-new-ui    # Kasta hela experimentet
```

## Vanliga misstag och lösningar

### Misstag 1: Glömde att pull före push

⚠️ **Felmeddelande:**
```
! [rejected] main -> main (fetch first)
error: failed to push some refs
```

**Lösning:**
```bash
git pull origin main
git push origin main
```

### Misstag 2: Push för sällan (team)

**Problem:** Andra utvecklare får inte dina ändringar, konflikter bygger upp.

**Lösning:** Push minst 2-3 gånger per dag när du jobbar i team.

### Misstag 3: Commit för sällan

**Problem:** Förlorar översikt, svårt att ångra specifika ändringar.

**Lösning:** Commit varje gång du "slutfört en liten bit".

### Misstag 4: Dåliga commit-meddelanden

❌ **Dåligt:**
```bash
git commit -m "update"
git commit -m "more changes"
git commit -m "fix"
```

✅ **Bra:**
```bash
git commit -m "Uppdaterat användarvalidering för specialtecken"
git commit -m "Lagt till felhantering för nätverksfel"
git commit -m "Fixade memory leak i bilduppladdning"
```

## Advanced ritualer

### Ritual för code review (team)

```bash
# Skapa feature branch
git checkout -b feature-user-notifications

# Jobba på feature
git add .
git commit -m "Lagt till grundläggande notifikationssystem"
git commit -m "Implementerat email-notifikationer"

# Push feature branch
git push origin feature-user-notifications

# Skapa pull request på GitHub/GitLab
# Vänta på godkännande
# Merge via webb-interface

# Rensa upp lokalt
git checkout main
git pull origin main
git branch -d feature-user-notifications
```

### Ritual för hotfixes

```bash
# Akut bug i produktion!
git checkout main
git pull origin main

# Skapa hotfix branch
git checkout -b hotfix-payment-error

# Fixa buggen snabbt
git add .
git commit -m "HOTFIX: Löst kritiskt fel i betalningsprocessen"

# Merge direkt till main
git checkout main
git merge hotfix-payment-error
git push origin main

# Rensa upp
git branch -d hotfix-payment-error
```

## Sammanfattning av ritualer

### Solo-utvecklare
```bash
# Grundläggande daglig rytm
git add .
git commit -m "Beskrivande meddelande"
# (upprepa flera gånger per dag)

# Backup till remote
git push origin main
# (1-2 gånger per dag)
```

### Team-utvecklare
```bash
# Morgonritual
git pull origin main

# Daglig rytm
git add .
git commit -m "Beskrivande meddelande"

# Synk-ritual (flera gånger per dag)
git pull origin main
git push origin main
```

## Nästa nivå

📚 Nu när du behärskar de grundläggande ritualerna:

1. **Öva regelbundet** - gör det till vana
2. **Lär dig branches** för att isolera features
3. **Förstå merge conflicts** för teamwork
4. **Utforska Git hooks** för automatisering
5. **Lär dig rebase** för renare historik

Kom ihåg: **Konsistenta ritualer** gör att Git känns naturligt och säkert. Efter några veckor kommer du köra dessa kommandon utan att tänka - precis som att borsta tänderna!
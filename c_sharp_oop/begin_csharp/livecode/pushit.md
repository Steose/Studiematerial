# Övning 2: Pusha till GitHub från Visual Studio och Rider

Nu tar vi nästa naturliga steg: **lägga upp din C#-kod på GitHub**.
Varför? För att spara historik, samarbeta smart och kunna jobba vidare från vilken dator som helst. Kort sagt: _versioner utan drama_.

Vi gör detta **utan terminal** (Visual Studio och Rider har fina GUI-flöden), men du får även en **minimal CLI-snabbis** mot slutet för den nyfikne.

## Förutsättningar (checklista)

- Du har ett GitHub-konto och är inloggad i:
  - **Visual Studio**: `GitHub Extension for Visual Studio` (ingår numera i VS – logga in via _View → Git Changes → GitHub_).
  - **JetBrains Rider**: logga in via _File → Settings → Version Control → GitHub → +_.
- Ditt C#-projekt bygger lokalt (Ctrl+Shift+B eller `Build → Build Solution`).
- `.gitignore` för C#/.NET finns (Visual Studio/Rider kan skapa den; annars lägg till via GitHub-mall).

> Tanke: “Behöver jag verkligen Git just nu?”
> Ja. Att committa tidigt och ofta räddar dig när _något_ går fel. För det gör det ibland. Och det är okej.

## Snabb begreppsorientering (3 minuter)

- **Repository (repo)** – projektets “hem” i Git/GitHub.
- **Commit** – en sparad punkt i historiken med en kort loggtext.
- **Remote** – en adress (t.ex. GitHub) där repo:t ligger online.
- **Push** – skicka dina commits till remote.
- **Branch** – en linje av arbete (t.ex. `main`, `feature/color-prompt`).

> Analogin: Tänk dig att koden är en bok under arbete. _Commit_ = spara ett kapitelutkast.
> _Push_ = lägga upp utkastet i molnet så andra (och du själv) kan hitta det igen.

## Del A – Visual Studio (2022+)

### A1. Initiera Git (om projektet inte redan är ett Git-repo)

1. Öppna din lösning i Visual Studio.
2. Gå till **View → Git Changes** (eller _Git_ i menyraden).
3. Klicka **Create Git Repository** om du blir ombedd.
4. Välj projektmapp (roten) och bocka i **Add .gitignore**.

> Tips: `.vs/`, `bin/`, `obj/` ska ignoreras. Välj C#/.NET-mall så sköts det.

### A2. Första commit

1. Öppna **Git Changes**.
2. Skriv en tydlig **Commit Message**, t.ex.:
   `chore: init basic_demo console app`
3. Klicka **Commit All** (eller **Commit All and Push** om remote redan finns).

### A3. Publicera till GitHub (skapa remote automatiskt)

1. I **Git Changes**, klicka **Publish to GitHub**.
2. Välj **Repository Name**, lägg ev. till **Description**, och (om du vill) gör repo:t _private_.
3. Klicka **Publish**.
   Visual Studio skapar GitHub-repo och ställer in `origin` åt dig.

### A4. Push efter nya ändringar

- Efter att du kodat vidare: **Commit All** → **Push**.
- Status syns i **Git Changes** och via lilla Git-indikatorn i statusfältet.

### A5. Om du redan har ett GitHub-repo (koppla existerande remote)

1. Kopiera **repo-URL** från GitHub (HTTPS rekommenderas).
2. I VS: _Git → Manage Remotes → Add_
   - Name: `origin`
   - Fetch: **GitHub-URL**
3. **Push**. Klart.

## Del B – JetBrains Rider (2024+)

### B1. Aktivera VCS (om inte aktivt)

1. Öppna projektet i Rider.
2. **VCS → Enable Version Control Integration…** → välj **Git**.

### B2. Dela till GitHub (“Share Project on GitHub”)

1. **Git** (tool window) eller menyn: **VCS → Import into Version Control → Share Project on GitHub**.
2. Logga in vid behov.
3. Ange **Repository name/description** och klicka **Share**.
   Rider gör första commit och sätter upp remote.

### B3. Vanligt arbetsflöde i Rider

1. Koda.
2. **Commit** (Ctrl+K):
   - Välj filer, skriv tydlig committext.
   - Kör gärna **Analyze code** och **Run tests** innan commit.
3. **Push** (Ctrl+Shift+K): skicka upp till GitHub.

### B4. Koppla till befintligt GitHub-repo

1. **VCS → Git → Remotes… → +**
2. Name: `origin`, URL: GitHub-URL (HTTPS).
3. **Push**.

## Rekommenderad branch-strategi (litet team/solo)

- `main` – stabil, körbar när som helst.
- Skapa feature-brancher:
  - `feature/input-validation`
  - `chore/rename-namespace`
- Slå ihop via Pull Request (även solo – du får diff och historik _gratis_).
- Radera feature-branch efter merge (håll det städat).

> “Först tänker man: ‘Jag behöver inte brancher när jag är ensam.’
> Men sedan inser man: ‘Jag vill kunna jämföra, backa och isolera risk.’”

## Vanliga fallgropar & snabba lösningar

- **Autentisering krånglar (403/401)**

  - Logga ut/in i VS/Rider.
  - GitHub kräver **Personal Access Token** för HTTPS-push: skapa ett nytt (scope: `repo`).
  - Spara token i Credential Manager (Windows).

- **`main` vs `master` mismatch**

  - Byt default-branch på GitHub eller lokalt:
    _Git → Branches → Rename_ (VS/Rider) och push.

- **Glömda `.gitignore` → Gigantiska commits**

  - Lägg till `.gitignore`.
  - Ta bort redan spårade mappar: `bin/`, `obj/`, `.idea/`, `.vs/`.
  - Commit igen (VS/Rider visar vad som ändrats).

- **Stora filer (100MB+)**

  - Använd **Git LFS** om du verkligen måste checka in stora artefakter.
  - Men helst: checka inte in byggresultat alls.

- **“Detached HEAD”/märklig historik**
  - Skapa en branch från nuvarande läge:
    _Git → New Branch from selected commit_ → checka ut → pusha.

## Minimal CLI (frivilligt – för den nyfikne)

```bash
# Initiera repo (om inte redan)
git init

# Lägg till allt (första gången)
git add .

# Första commit
git commit -m "chore: init basic_demo console app"

# Koppla remote (ersätt med din URL från GitHub)
git remote add origin https://github.com/<user>/<repo>.git

# Byt (vid behov) huvudgren till 'main'
git branch -M main

# Skicka upp
git push -u origin main
```

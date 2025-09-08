# Arrays - Lectures

Teoretisk grund för arrays, minneshantering och effektiv datalagring.

## Innehåll

- **[arrays.md](arrays.md)** - Komplett guide till arrays i C#

## Viktiga teorikoncept

### Minneshantering
- Arrays lagras i sammanhängande minnesblock
- Index-beräkning: `startadress + (index × elementstorlek)`
- Därför är åtkomst O(1) - konstant tid oavsett array-storlek

### Array vs List
**Arrays:**
- Fast storlek
- Snabb åtkomst
- Mindre memory overhead
- Perfekt när storleken är känd

**Lists:**
- Dynamisk storlek  
- Kan växa/krympa
- Mer funktionalitet
- Bättre för varierande data

### Best Practices
- Validera index innan åtkomst
- Använd `Length`-property för loopar  
- Förstå referens vs värde-typer
- Korrekt initialisering av arrays

### Performance
- Arrays är extremt snabba för element-åtkomst
- Cache-friendly minnesLayout
- Optimal för stora datamängder med känd storlek

Förstå teorin bakom arrays för att använda dem optimalt! 🧠
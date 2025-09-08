using System;

namespace LupinHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            // Gentleman-tjuvens namn (text)
            // Vi lagrar namn för att skapa personlig upplevelse genom koden
            // Detta gör programmet mer läsbart och maintainerbart
            string thiefName = "Arsène Lupin";

            // Tiden kvar (minuter)
            // Resource management: vi spårar tid som en begränsad resurs
            // I verkliga system: session timeout, cache expiry, deadline tracking
            int timeRemaining = 15;

            Console.WriteLine("🎩 " + thiefName + " står inför bankvalvets gåta...");
            Console.WriteLine("⏰ Tid kvar: " + timeRemaining + " minuter");
            Console.WriteLine();

            // FÖRSTA GÅTAN: Grundtalet
            // Bankvalvets första siffra baseras på årtalet banken grundades
            // Fundamentala värden: ofta kommer business logic från historiska data
            int bankFoundedYear = 1887;

            Console.WriteLine("🏛️  Första ledtråden: Banken grundades år " + bankFoundedYear);

            // Beräkna summan av siffrorna i årtalet (1+8+8+7)
            // Digital root calculation: ett vanligt mönster för att "komprimera" stora tal
            // Vi delar upp problemet i mindre delar för att undvika mänskliga fel
            int digitSum = 1 + 8 + 8 + 7;

            Console.WriteLine("🔢 Summa av siffror: " + digitSum);

            // ANDRA GÅTAN: Mystiska faktorn
            // Lupins lyckonum multiplicerat med första resultatet
            // Magic numbers undviks genom att ge dem meningsfulla namn
            int lupinLuckyNumber = 13;

            // Första kombinationssiffran
            // Composed calculations: bygger komplexa beräkningar från enkla delar
            // Detta gör koden testbar och felsökningsvänlig
            int firstDigit = digitSum * lupinLuckyNumber;

            Console.WriteLine("🎯 Lupins lyckotal: " + lupinLuckyNumber);
            Console.WriteLine("🔐 Första kombinationssiffran: " + firstDigit);
            Console.WriteLine();

            // TREDJE GÅTAN: Valvets vikt
            // Valvdörren väger exakt detta antal ton
            // Domain-specific constants: vissa värden kommer från fysiska begränsningar
            double vaultWeightTons = 12.5;

            // Konvertera till kilogram för beräkningar
            // Unit conversion: ofta behöver vi standardisera enheter för beräkningar
            // 1 ton = 1000 kg - vi hårdkodar denna konstant eftersom den aldrig ändras
            double vaultWeightKg = vaultWeightTons * 1000;

            Console.WriteLine("⚖️  Valvets vikt: " + vaultWeightTons + " ton (" + vaultWeightKg + " kg)");

            // FJÄRDE GÅTAN: Säkerhetsfaktorn
            // Ta resten när första siffran delas med valvets vikt i kg
            // Modulo operations: används för cykliska beräkningar, hash functions, checksums
            double securityFactor = firstDigit % vaultWeightKg;

            Console.WriteLine("🔒 Säkerhetsfaktor (modulo): " + securityFactor);

            // FEMTE GÅTAN: Slutlig kombination
            // Dela säkerhetsfaktorn med Lupins ålder och avrunda nedåt
            // Age-based calculations: vanligt i försäkring, pension, access control
            int lupinAge = 35;

            // Beräkna den slutgiltiga koden
            // Floor division: vi vill ha heltalsdelen för kombinationslås
            // Cast operations: konverterar mellan datatyper när nödvändigt
            int finalCode = (int)(securityFactor / lupinAge);

            Console.WriteLine("👤 Lupins ålder: " + lupinAge + " år");
            Console.WriteLine("🎯 SLUTLIG KOD: " + finalCode);
            Console.WriteLine();

            // Spåra tidsförbrukning
            // Performance monitoring: håll koll på resursanvändning
            int timeUsed = 8;

            // Beräkna återstående tid
            // Resource depletion tracking: kritiskt i resurshanteringssystem
            int timeLeft = timeRemaining - timeUsed;

            Console.WriteLine("⏱️  Tid använd för gåtan: " + timeUsed + " minuter");
            Console.WriteLine("⏰ Tid kvar: " + timeLeft + " minuter");
            Console.WriteLine();
            Console.WriteLine("🎩✨ " + thiefName + " har knäckt koden!");

            // VALVINBROTTET PÅBÖRJAS
            Console.WriteLine("🚪 Första låset öppnat! Lupin går in i valvet...");
            
            // Diamanter i valvet
            int diamondCount = 247;
            double diamondValue = 50000.0; // Per diamant i kronor
            double totalDiamondValue = diamondCount * diamondValue;
            
            Console.WriteLine("💎 Diamanter funna: " + diamondCount + " stycken");
            Console.WriteLine("💰 Total värde diamanter: " + totalDiamondValue + " kr");

            // Sekundärt lås - baserat på diamantantal
            int secondaryCode = diamondCount % 100; // Tar de två sista siffrorna
            timeLeft -= 3; // Ytterligare 3 minuter förbrukas
            
            Console.WriteLine("🔐 Sekundärt lås kod: " + secondaryCode);
            Console.WriteLine("⏰ Tid kvar: " + timeLeft + " minuter");

            // Guldsaldon från tre stora konton
            double account1 = 1500000.75;
            double account2 = 2300000.25; 
            double account3 = 980000.50;
            double totalGold = account1 + account2 + account3;
            
            // Tertärt lås - baserat på genomsnittligt saldo
            double averageAccount = totalGold / 3;
            int tertiaryCode = (int)(averageAccount / 100000); // Dividerat med 100k, avrundat nedåt
            
            Console.WriteLine("🏅 Totalt guld i valv: " + totalGold + " kr");
            Console.WriteLine("📊 Genomsnittligt konto: " + averageAccount + " kr");
            Console.WriteLine("🔐 Tertärt lås kod: " + tertiaryCode);

            // FLYKTEN
            timeLeft -= 2; // Sista låset tar 2 minuter
            int escapeTime = 2; // Tid för flykt
            int finalTimeLeft = timeLeft - escapeTime;
            
            Console.WriteLine();
            Console.WriteLine("🏃‍♂️ " + thiefName + " flyr från valvet!");
            Console.WriteLine("⏱️  Total tid använd: " + (timeRemaining - finalTimeLeft) + " minuter");
            Console.WriteLine("⏰ Tid kvar vid flykt: " + finalTimeLeft + " minuter");
            
            // Slutlig sammanfattning
            double totalHeistValue = totalDiamondValue + totalGold;
            Console.WriteLine();
            Console.WriteLine("🎩✨ KUPP GENOMFÖRT!");
            Console.WriteLine("💎 Diamanter: " + totalDiamondValue + " kr");
            Console.WriteLine("🏅 Guld: " + totalGold + " kr"); 
            Console.WriteLine("💰 Total byte: " + totalHeistValue + " kr");
            Console.WriteLine("👑 " + thiefName + " försvinner in i natten...");
        }
    }
}
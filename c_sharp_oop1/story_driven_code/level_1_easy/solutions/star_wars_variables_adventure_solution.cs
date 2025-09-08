using System;

namespace JediCrystalTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vi behöver lagra ljussabelkristallens färg
            // Variabeln "saberColor" förenklar användningen av kristallens färg
            string saberColor = "Blå";

            // Styrkan på ljussabelkristallen
            // Att lagra ett värde gör det enkelt att referera till det senare
            int saberStrength = 100;

            // Skriv ut en statusrapport om ljussabeln
            // Nu kan vi använda variablerna för att visa information
            Console.WriteLine($"Ljussabelns färg är {saberColor} och styrkan är {saberStrength}.");
        }
    }
}
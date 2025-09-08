using System;

namespace MiddleEarth
{
    class FestMaltid
    {
        // Huvudmetoden som körs
        static void Main(string[] args)
        {
            // Ingredienser för varje person
            int antalPersoner = 5;

            // Räkna ut mängden potatisar som behövs
            // Vi kommer att anropa vår metod här
            CalculatePotatoes(antalPersoner);
        }

        // Denna metod tar in antal personer som parameter
        static void CalculatePotatoes(int numberOfPeople)
        {
            int potatoesPerPerson = 3; // Fast mängd för potatisar
            int totalPotatoes = numberOfPeople * potatoesPerPerson;

            Console.WriteLine($"För {numberOfPeople} personer behövs {totalPotatoes} potatisar.");
        }
    }
}

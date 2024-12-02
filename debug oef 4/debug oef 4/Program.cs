using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Probeer iets dat een uitzondering kan veroorzaken
            int getal = int.Parse("1,7"); // Dit zal een uitzondering veroorzaken
            Console.WriteLine($"Getal: {getal}");
        }
        catch (FormatException ex)
        {
            // Handelt een FormatException af
            Console.WriteLine("Er is een formatfout opgetreden: " + ex.Message);
        }
        catch (Exception ex)
        {
            // Handelt andere uitzonderingen af
            Console.WriteLine("Er is een fout opgetreden: " + ex.Message);
        }
        finally
        {
            // Dit wordt altijd uitgevoerd, ongeacht of er een fout optreedt
            Console.WriteLine("De try-catch is voltooid.");
        }
    }
}

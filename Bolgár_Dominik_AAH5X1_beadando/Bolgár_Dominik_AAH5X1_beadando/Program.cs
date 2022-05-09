using System;
using System.Collections.Generic;
namespace Bolgár_Dominik_AAH5X1_beadando
{
    class Program
    {
        static void Main(string[] args)
        {

            SortedDictionary<string, string> felhasznalok = new SortedDictionary<string, string>();

            for (int i = 0; i < 20; i++)
            {
                if (i<10)
                {
                    felhasznalok.Add($"AHX{i}Z4", "Bolgár Dominik");
                }
                else
                {
                    felhasznalok.Add($"BHX{i}Z", "Bolgár Dominika");
                }
            }

            sorbarendezett<string> sortedlista = new sorbarendezett<string>(felhasznalok);

            foreach (var felhasznalo in sortedlista.Neptunfelhasznalok)
            {
                Console.WriteLine($"A felhasználók: {felhasznalo.Key}, {felhasznalo.Value}");

            }

            

            if (sortedlista.Neptunfelhasznalok.ContainsKey("AHX5Z4"))
            {
                Console.WriteLine("Az AHX5Z4 neptunkód benne van a sorted dictionarybe.");
            }
            else
            {
                Console.WriteLine("Nincs benne az AHX5Z4 neptunkód a sorted dictionarybe.");
            }

            sortedlista.Neptunfelhasznalok.Remove("AHX5Z4");
            Console.WriteLine("Az AH5XZ4 neptunkód ki lett törölve a sorted dictionaryból.");

            sortedlista.Neptunfelhasznalok.Clear();
            Console.WriteLine("Ki lett ürítve a dictionary!");
       

            Console.ReadKey();

        }
    }
}

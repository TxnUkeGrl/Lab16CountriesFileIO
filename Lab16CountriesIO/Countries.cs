using System;
using System.Collections.Generic;
using System.Text;

namespace Lab16CountriesIO
{
    public class Countries
    {
        public string Hemisphere { get; set; }
        public string MythicalCreature { get; set; }
        public bool Magick { get; set; }
        public bool Peaceful { get; set; }

        public Countries(string hemisphere, string mythicalCreature, bool magick, bool peaceful)
        {
            Hemisphere = hemisphere;
            MythicalCreature = mythicalCreature;
            Magick = magick;
            Peaceful = peaceful;
        }

        public static List<Countries> GetCountriesList()
        {
            List<Countries> countries = new List<Countries>
            {
                new Countries("North", "Pegasus", true, false),
                new Countries("East", "Phoenix", true, true),
                new Countries("South", "Chimera", false, true),
                new Countries("West", "Dragon", false, false)
            };

            return countries;
        }

        public static Countries MakeNewCountry()
        {
            Console.WriteLine("Hemisphere?");
            string hemisphere = Console.ReadLine();
            Console.WriteLine("\nMythical Creature?");
            string mythicalCreature = Console.ReadLine();
            Console.WriteLine("\nMagick?");
            bool magick = true;
            switch (Console.ReadLine().ToUpper())
            {
                case "Y":
                case "YES":
                case "T":
                case "TRUE":
                    magick = true;
                    break;
                case "N":
                case "NO":
                case "F":
                case "FALSE":
                    magick = false;
                    break;
            }
            //bool magick = bool.Parse(Console.ReadLine());
            //use T & F, Y or N?
            Console.WriteLine("\nPeaceful?");
            bool peaceful = true;
            switch (Console.ReadLine().ToUpper())
            {
                case "Y":
                case "YES":
                case "T":
                case "TRUE":
                    peaceful = true;
                    break;
                case "N":
                case "NO":
                case "F":
                case "FALSE":
                    peaceful = false;
                    break;
            }
            
            Countries newCountry = new Countries(hemisphere, mythicalCreature, magick, peaceful);
            return newCountry;
        }

        public override string ToString()
        {
            return Hemisphere + " " + MythicalCreature + " " + Magick + " " + Peaceful;
        }
    }
}

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
            Console.WriteLine("Mythical Creature?");
            string mythicalCreature = Console.ReadLine();
            Console.WriteLine("Magick?");
            bool magick = bool.Parse(Console.ReadLine());
            //use T & F, Y or N?
            Console.WriteLine("Peaceful?");
            bool peaceful = bool.Parse(Console.ReadLine());
            //use T & F, Y or N?
            Countries newCountry = new Countries(hemisphere, mythicalCreature, magick, peaceful);
            return newCountry;
            //add to txt file?
        }

        public override string ToString()
        {
            return Hemisphere + MythicalCreature + Magick + Peaceful;
        }
    }
}

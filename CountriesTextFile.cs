using System;
using System.Collections.Generic;
using System.IO;

namespace Lab16CountriesIO
{
    public class CountriesTextFile
    {
        //METHOD - write a list of countries to a file
        public List<Countries> ReadCountryList()
        {
            List<Countries> countries = new List<Countries>();
            StreamReader reader = new StreamReader("../../../countries.txt");
            string line = reader.ReadLine();

            while (line != null)
            {
                string[] country = line.Split('|');
                countries.Add(new Countries(country[0], country[1], bool.Parse(country[2]), bool.Parse(country[3])));
                line = reader.ReadLine();
            }

            reader.Close();
            return countries;
        }

        //METHOD - read a list of countries from a file
        public void WriteCountryList() //returns to default list
        {
            StreamWriter writer = new StreamWriter("../../../countries.txt");
            foreach (Countries country in Countries.GetCountriesList())
            {
                writer.WriteLine($"{country.Hemisphere}|{country.MythicalCreature}|{country.Magick}|{country.Peaceful}");
            }
            writer.Close();
        }

        public void AddToCountryList(Countries country)
        {
            StreamWriter addWriter = new StreamWriter("../../../countries.txt", true);

            addWriter.WriteLine($"{country.Hemisphere}|{country.MythicalCreature}|{country.Magick}|{country.Peaceful}");

            addWriter.Close();
        }
    }
}

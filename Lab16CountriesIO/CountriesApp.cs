using System;
using System.Collections.Generic;
using System.Text;

namespace Lab16CountriesIO
{
    public class CountriesApp
    {
        public void OptionSelection()
        {            
            CountriesTextFile countriesTextFile = new CountriesTextFile();
            countriesTextFile.WriteCountryList();
            bool loop = true;
            
            while (loop)
            {
                Console.WriteLine("Make a selection\n");
                Console.WriteLine(" 1. Display List \n 2. Create New Country \n 3. Exit App\n");

                switch (Console.ReadLine().ToLower())
                {                    
                    case "1": //display list
                    //case "display list":
                        Console.WriteLine();
                        foreach (var country in countriesTextFile.ReadCountryList())
                        {
                            Console.WriteLine(country); //taking in a string, implementing ToString from object
                        }
                        loop = true;
                        Console.WriteLine();
                        break;

                    case "2": //enter & write country
                    //case "create new country":
                        Console.WriteLine();
                        countriesTextFile.AddToCountryList(Countries.MakeNewCountry());
                        loop = true;
                        break;

                    case "3": //bye message & exit
                    //case "exit":
                        Console.WriteLine("\nToodles!");
                        //how to end program?
                        loop = false;
                        break;
                }
            }
        }

    }
}

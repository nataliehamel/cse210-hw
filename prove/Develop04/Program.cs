using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        while(true)
        {
            int menuUserInput = 0;
            List<string> menu = new List<string>
            {
                "Menu Options:",
                "1. Start breathing activity",
                "2. Start reflecting activity",
                "3. Start listing activity",
                "4. Quit",
                "Select a choice from the menu: "
            };

            while (menuUserInput != 4)
            {
                foreach(string menuItem in menu)
                {
                    Console.WriteLine(menuItem);
                }
                menuUserInput = int.Parse(Console.ReadLine());

                if (menuUserInput == 1)
                {
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.StartBreathingActivity();
                }

                else if (menuUserInput == 2)
                {
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.StartReflectionActivity();
                }

                else if (menuUserInput == 3)
                {
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.StartListingActivity();
                }

                else
                {
                    Console.WriteLine("Invalid response. Please try again. ");
                    continue;
                }
            };
        }
    }
}
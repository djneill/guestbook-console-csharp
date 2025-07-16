using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace guestBook
{
    public class Messages
    {
        public static string AskPartyName()
        {
            Console.Write("Welcome, what is the name for your party? ");
            return Console.ReadLine();
        }

        public static int AskPartyNumber()
        {
            bool validNumber = false;
            do
            {
                Console.Write("How many are in your party? ");
                string result = Console.ReadLine();
                validNumber = int.TryParse(result, out int guestNumber);

                if (validNumber == false)
                {
                    Console.WriteLine("Sorry that was an invalid number format. Please try again.");
                }
                else
                {
                    return guestNumber;
                }
            } while (validNumber == false);

            // This line should never be reached, but is required to satisfy the compiler
            return 0;
        }

        public static bool NoMoreEntries()
        {
            Console.Write("Are there any more parties to enter? y/n: ");
            string result = Console.ReadLine();

            if (result.ToLower() == "y" || result.ToLower() == "yes")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static void GuestList(List<string> partyNames, int totalGuest)
        {
            Console.Clear();
            Console.WriteLine($"The parties for today are,");
            foreach (string name in partyNames)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine($"We have a total of {totalGuest} guest.");
        }
    }
}
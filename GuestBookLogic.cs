using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace guestBook
{
    public class GuestBookLogic
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the Guest Book App");
            Console.WriteLine("----------------------------");
            Console.WriteLine();
        }
        public static string AskPartyName()
        {
            Console.Write("What is the name for your party? ");
            string output = Console.ReadLine();
            return output;
        }

        public static int AskPartyNumber()
        {
            bool validNumber = false;
            int guestNumber;
            do
            {
                Console.Write("How many are in your party? ");
                string result = Console.ReadLine();
                validNumber = int.TryParse(result, out guestNumber);

                if (validNumber == false)
                {
                    Console.WriteLine("Sorry that was an invalid number format. Please try again.");
                }
                else
                {
                    Console.WriteLine();
                    return guestNumber;
                }
            } while (validNumber == false);

            // This line should never be reached, but is required to satisfy the compiler
            return 0;
        }

        public static bool AskToContinue()
        {
            Console.Write("Are there any more parties to enter? y/n: ");
            string result = Console.ReadLine();

            bool addMoreGuest = (result.ToLower() == "y" || result.ToLower() == "yes");
            return addMoreGuest;
        }

        public static (List<string> partyNames, int totalGuest) GetGuestList()
        {
            List<string> partyNames = new List<string>();
            int totalGuest = 0;

            do
            {
                partyNames.Add(AskPartyName());
                totalGuest += AskPartyNumber();
            } while (AskToContinue());

            return (partyNames, totalGuest);
        }

        public static void DisplayGuest(List<string> partyNames, int totalGuest)
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
using System.Reflection.Metadata.Ecma335;

namespace guestBook;

public class GuestBookLogic
{
    public static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to the guest book app");
        Console.WriteLine("-----------------------------");
        Console.WriteLine();
    }

    public static string AskPartyName()
    {
        Console.Write("What is the name of your party?: ");
        string result = Console.ReadLine();
        return result;
    }

    public static int AskHowManyInParty()
    {
        int partySize;
        bool validEntry = false;
        do
        {
            Console.Write("How many people are in your party?: ");
            string result = Console.ReadLine();
            validEntry = int.TryParse(result, out partySize);

            if (!validEntry)
            {
                Console.WriteLine("Sorry that was an invalid number format, please enter 1 - 9.");
            }
        } while (!validEntry);
        return partySize;
    }

    public static bool AskToContinue()
    {
        Console.Write("Are there any more parties to enter? (y/n): ");
        string result = Console.ReadLine();

        bool addMoreGuest = (result.ToLower() == "y" || result.ToLower() == "yes");
        return addMoreGuest;
    }

    public static Dictionary<string, int> GetAllGuest()
    {
        Dictionary<string, int> guestList = new Dictionary<string, int>();
        do
        {
            string partyName = AskPartyName();
            int partySize = AskHowManyInParty();
            guestList[partyName] = partySize;
        } while (AskToContinue());
        Console.WriteLine();
        return guestList;
    }

    public static void DisplayGuestList(Dictionary<string, int> guestList)
    {
        Console.WriteLine("Tonights parties include:");
        foreach ((string party, int size) in guestList)
        {
            Console.WriteLine($"{party}:\t{size}");
        }
        Console.WriteLine($"The total number of guest for tonight is {guestList.Values.Sum()}");
    }
}

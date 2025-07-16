using guestBook;
bool entriesComplete = false;
List<string> party = new List<string>();
int totalGuest = 0;

do
{
    string partyName = Messages.AskPartyName();
    party.Add(partyName);
    int numberOfGuest = Messages.AskPartyNumber();
    totalGuest += numberOfGuest;
    entriesComplete = Messages.NoMoreEntries();
} while (entriesComplete == false);

Messages.GuestList(party, totalGuest);
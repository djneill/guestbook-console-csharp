using guestBook;

GuestBookLogic.WelcomeMessage();

(List<string> partyNames, int totalGuest) = GuestBookLogic.GetGuestList();

GuestBookLogic.DisplayGuest(partyNames, totalGuest);
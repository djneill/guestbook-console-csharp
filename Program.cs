
using guestBook;

GuestBookLogic.WelcomeMessage();

Dictionary<string, int> guestList = GuestBookLogic.GetAllGuest();

GuestBookLogic.DisplayGuestList(guestList);

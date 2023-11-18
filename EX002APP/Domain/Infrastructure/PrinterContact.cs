using Model;

namespace Infrastructure;

public class PrinterContact
{
    public string Print (Contact contact)
    {
        string output = string.Empty;

        output += $"FirstName: {contact.FirstName}\n";
        output += $"LastName: {contact.LastName}\n";
        output += $"TelefonNumber: {contact.TelefonNumber}\n";
        output += $"DayOfBirth: {contact.DayOfBirth}\n";   
        output += $"Email: {contact.Email}\n";   

        return output;
    }

}

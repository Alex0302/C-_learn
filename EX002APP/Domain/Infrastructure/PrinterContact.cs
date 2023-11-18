using Model;

namespace Infrastructure;

class PrinterContact
{
    public string ContactToString (PrinterContact contact)
    {
        string output = string.Empty;

        output += $"FirstName: {contact.FirstName}\n";
        output += $"LastName: {contact.LastName}\n";
        output += $"DayOfBirth: {contact.DayOfBirth}\n";   

        return output;
    }

}

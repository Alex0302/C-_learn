using Model;

namespace Infrastructure;
public class UserContactCreator : IContactCreator
{
    private static int globalId;

    static UserContactCreator()
    {
        globalId = 1;
    }

    private string[] firstNames;
    private string[] lastNames;
    public UserContactCreator(
        string pathToFirstNamesFile = "first_Names.txt",
        string pathToLastNamesFile = "last_Names.txt")
        {
            this.firstNames = File.ReadAllLines(pathToFirstNamesFile);
            this.lastNames = File.ReadAllLines(pathToLastNamesFile);
        }
    public Contact GetContact()
    {
        int lengthFn = firstNames.Length;
        int lengthLn = lastNames.Length;
        string firstName = this.firstNames[Random.Shared.Next(lengthFn)];
        string lastName = this.lastNames[Random.Shared.Next(lengthLn)];

        UserContact contact = new UserContact();
        contact.FirstName = firstName;
        contact.LastName = lastName;

        string pattern = "+7 ({0}) {1}-{2}-{3}";
        contact.TelefonNumber = string.Format(
            pattern,
            Random.Shared.Next(100,1000),
            Random.Shared.Next(100,1000),
            Random.Shared.Next(10,100),
            Random.Shared.Next(10,100)
        );

        contact.Id = globalId ++;

        return contact;
    }
}
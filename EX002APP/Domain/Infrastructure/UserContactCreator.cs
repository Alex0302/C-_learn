using Model;

namespace Infrastructure;
public class UserContactCreator : ContactCreator
{
    private string[] firstNames;
    private string[] lastNames;
    public UserContactCreator(
        string pathToFirstNamesFile = "firstNames.txt",
        string pathToLastNamesFile = "lastNames.txt")
        {
            this.firstNames = File.ReadAllLines(pathToFirstNamesFile);
            this.lastNames = File.ReadAllLines(pathToLastNamesFile);
        }
    public override UserContact GetContact()
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
        return contact;
    }
}
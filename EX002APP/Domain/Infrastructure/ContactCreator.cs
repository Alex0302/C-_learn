using Model;

namespace Infrastructure;
public class ContactCreator
{
    private string[] firstNames;
    private string[] lastNames;
    public ContactCreator(
        string pathToFirstNamesFile = "firstNames.txt",
        string pathToLastNamesFile = "lastNames.txt")
        {
            this.firstNames = File.ReadAllLines(pathToFirstNamesFile);
            this.lastNames = File.ReadAllLines(pathToLastNamesFile);
        }
    public Contact GetContact()
    {
        int lengthFn = firstNames.Length;
        int lengthLn = lastNames.Length;
    }
}
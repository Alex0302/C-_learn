using Model;

namespace Infrastructure;
public class CompanyContactCreator : ContactCreator
{
    private string[] companyNames;
    // private string[] lastNames;
    public CompanyContactCreator()
        {
            this.companyNames = new string[]
            {
                "Компания1",
                "Компания2",
                "Компания3",
                "Компания4"
            };
        }
    public override CompanyContact GetContact()
    {
        int length = this.companyNames.Length;
        string name = this.companyNames[Random.Shared.Next(length)];
       

        CompanyContact contact = new CompanyContact();
        contact.Name = name;
        // contact.LastName = lastName;

        string pattern = "+7 ({0}) {1}-{2}-{3}";
        contact.TelefonNumber = string.Format(
            pattern,
            Random.Shared.Next(100,1000),
            Random.Shared.Next(100,1000),
            Random.Shared.Next(10,100),
            Random.Shared.Next(10,100)
        
        );
        
      
        contact.Fax = string.Format(
            "+7 (911) {0}-{1}-{2}-{3}",
            Random.Shared.Next(10,100),
            Random.Shared.Next(10,100),
            Random.Shared.Next(10,100),
            Random.Shared.Next(10,100)
        
        );
        contact.OGRN = $"{Random.Shared.Next(1000000,9999999)}";
        return contact;
    }
}
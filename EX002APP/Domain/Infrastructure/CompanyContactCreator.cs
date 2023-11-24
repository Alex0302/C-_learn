using Model;
using Persistance;

namespace Infrastructure;
public class CompanyContactCreator : IContactCreator
{
    private readonly Repository<UserContact> userRepo;
    private string[] companyNames;
    // private string[] lastNames;
    public CompanyContactCreator(Repository<UserContact> userRepo)
        {
            this.companyNames = new string[100];
            
            for (int i = 1; i < this.companyNames.Length; i++)
            {
                this.companyNames[i] = $"Компания {Guid.NewGuid().ToString().Substring(0, 5)}";
            }

            this.userRepo = userRepo;
        }
    public Contact GetContact()
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
        
        UserContact[] userContacts = userRepo.GetAll();
        
        contact.ManagerId = userContacts[Random.Shared.Next(userContacts.Length)].Id;
        
        return contact;
    }
}
using Model;
using Infrastructure;
using Persistance;
using Extensions;
using Cache;
using Logger;

namespace ContactApplication;

public class App
{
   public static void Run()
   {
        int contactCount = 200;
        contactCount.Create("first_Names.txt", "Имя");
        contactCount.Create("last_Names.txt", "Фамилия");

        Ilogger logger = new FileLogger();
        
        // PrinterRepository printerRepository = new();
        UserContactCreator contactCreator = new UserContactCreator();
        Repository<UserContact> userRepository = new(logger);
        CompanyContactCreator companyContactCreator = new CompanyContactCreator(userRepository);
        Repository<CompanyContact> companyRepository = new(logger);
        
        for (int i = 0; i < 5; i++)
        {
                userRepository.Append((UserContact)contactCreator.GetContact()); 
                companyRepository.Append((CompanyContact)companyContactCreator.GetContact());  
        }

        #region CompanyRepo
        // UserContact contact1 = new UserContact("Алексей","Пупкин","+7 (221) 222-47-77",DateOnly.Parse("01.01.2023"),"эх@мыло.рф");
        
        // repo.Append(contact1);
        // string res = printerRepository.Print(repo);
        // Console.WriteLine(res);
        // Console.WriteLine(repo.ToString());

        
        // UserExtensions.IncValue();
        // UserExtensions.PrintValue();

        // Contact[] resarr =  repo.GetAll();

        // Console.WriteLine(resarr);
        // CompanyContact cc = new CompanyContact();

        // cc.Fax="sdasds";

        // UserContact uc = new UserContact();
        // System.Console.WriteLine(uc.ToString());
        

        // foreach (UserContact item in userRepository.GetAll())
        // {
        //     Console.WriteLine(item.NickName);
        // }

        // foreach (CompanyContact item in companyRepository.GetAll())
        // {
        //     Console.WriteLine(item.NickName + " " +item.ManagerId);
        // }

        // foreach (CompanyContact item in companyRepository.GetAll())
        // {
        //     Console.WriteLine($"{item.NickName}: рук.: {userRepository.Get(item.ManagerId).FirstName}");
        // }
        #endregion
   
        CacheService<UserContact> cacheUserContact = new(userRepository);
        CacheService<CompanyContact> cacheCompanyContact = new(companyRepository);

        // cache.Get(1);

        int count = Random.Shared.Next(10_000,20_000);
        Console.WriteLine($"count = {count}");
        while (count-- > 0)
        {
           cacheUserContact.Get(Random.Shared.Next(contactCount)); 
           cacheCompanyContact.Get(Random.Shared.Next(contactCount)); 
        }
   } 
}
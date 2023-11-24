using Model;
using Infrastructure;
using Persistance;
using Extensions;

namespace ContactApplication;

public class App
{
   public static void Run()
   {
        200.Create("first_Names.txt", "Имя");
        200.Create("last_Names.txt", "Фамилия");
        
        // PrinterRepository printerRepository = new();
        UserContactCreator contactCreator = new UserContactCreator();
        Repository<UserContact> userRepository = new();
        CompanyContactCreator companyContactCreator = new CompanyContactCreator(userRepository);
        Repository<CompanyContact> companyRepository = new();
        
        for (int i = 0; i < 5; i++)
        {

                userRepository.Append((UserContact)contactCreator.GetContact());
      
                companyRepository.Append((CompanyContact)companyContactCreator.GetContact());
            
        }

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
        foreach (UserContact item in userRepository.GetAll())
        {
            Console.WriteLine(item.NickName);
        }

        foreach (CompanyContact item in companyRepository.GetAll())
        {
            Console.WriteLine(item.NickName + " " +item.ManagerId);
        }

        foreach (CompanyContact item in companyRepository.GetAll())
        {
            Console.WriteLine($"{item.NickName}: рук.: {userRepository.Get(item.ManagerId).FirstName}");
        }
   } 
}
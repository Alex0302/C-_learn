using Model;
using Infrastructure;
using Persistance;
using Extensions;

namespace ContactApplication;

public class App
{
   public static void Run()
   {
        // PrinterRepository printerRepository = new();
        ContactCreator ContactCreator = new UserContactCreator();
        ContactCreator companyContactCreator = new CompanyContactCreator();
        ContactRepository repo = new();
        
        for (int i = 0; i < 10; i++)
        {
            if (Random.Shared.Next(2)==0)
            {
                repo.Append(ContactCreator.GetContact());
            }
            else
            {
                repo.Append(companyContactCreator.GetContact());
            }
            
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
        foreach (Contact item in repo.GetAll())
        {
            Console.WriteLine(item.NickName);
        }
   } 
}
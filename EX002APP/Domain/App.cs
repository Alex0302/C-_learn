using Model;
using Infrastructure;
using Persistance;

namespace ContactApplication;

public class App
{
   public static void Run()
   {
        PrinterRepository printerRepository = new();
        ContactCreator contactCreator = new();
        ContactRepository repo = new();
        
        for (int i = 0; i < 10; i++)
        {
            repo.Append(contactCreator.GetContact());
        }

        Contact contact1 = new Contact("Алексей","Пупкин","+7 (221) 222-47-77",DateOnly.Parse("01.01.2023"),"эх@мыло.рф");

        repo.Append(contact1);
        string res = printerRepository.Print(repo);
        Console.WriteLine(res);

        // Contact[] resarr =  repo.GetAll();

        // Console.WriteLine(resarr);
   } 
}
using Model;
using Infrastructure;

namespace ContactApplication;

public class App
{
   public static void Run()
   {
        Contact contact1 = new Contact();
        contact1.Firstname = "Aleksey";
        contact1.LastName = "Maltsev";
        contact1.DayOfBirth = new DateOnly (1990,8,28);
        contact1.Mail = "1@ya.ru";

        Contact contact2 = new Contact(
            "Aleksey",
            "Maltsev",
            new DateOnly (1990,8,28),"m@ya.ru");

        ContactPrint printer = new ContactPrint();
        string out = printer.ContactToString(contact1);
        Console.WriteLine(out);
   } 
}
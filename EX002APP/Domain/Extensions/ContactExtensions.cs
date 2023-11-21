using Model;

namespace Extensions;
public static class ContactExtensions
{

    public static void Print(this Contact user)
    {
        Console.WriteLine("+++++++");
        Console.WriteLine(user.NickName);
        Console.WriteLine(user.TelefonNumber);
        Console.WriteLine("=======");
    }

}
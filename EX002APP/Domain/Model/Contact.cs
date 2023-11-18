namespace Model
{
    public class Contact
    {
       public Contact()
       {
            Firstname = string.Empty;
            LastName = string.Empty;
            TelefonNumber = string.Empty;
            DayOfBirth = DateOnly.MinValue;
            Mail = string.Empty;
       }
       
        public Contact(string firstname,string lastName,
        string telefonNumber,DateOnly dayOfBirth,string mail)
        {
            Firstname = firstname;
            LastName = lastName;
            TelefonNumber = telefonNumber;
            DayOfBirth = dayOfBirth;
            Mail = mail;
        }
       public string Firstname;
       public string LastName;
       public  string TelefonNumber;
       public DateOnly DayOfBirth;
       public string Mail;
          
    }

}
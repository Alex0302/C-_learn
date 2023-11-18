namespace Model;

    public class Contact
    {
       public Contact()
       {
            this.FirstName = string.Empty;
            this.LastName = string.Empty;
            this.TelefonNumber = string.Empty;
            this.DayOfBirth = DateOnly.MinValue;
            this.Email = "nil";
       }
       
        public Contact(
            string firstName,
            string lastName,
            string telefonNumber,
            DateOnly dayOfBirth,
            string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.TelefonNumber = telefonNumber;
            this.DayOfBirth = dayOfBirth;
            this.Email = email;
        }
       public string FirstName {get; set;}
       public string LastName {get; set;}
       public  string TelefonNumber {get; set;}
       public DateOnly DayOfBirth {get; set;}
       public string Email {get; set;}
          
    }


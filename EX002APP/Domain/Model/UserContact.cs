namespace Model;

    public class UserContact : Contact
    {
       public UserContact() : 
       this(string.Empty,
            string.Empty,
            string.Empty,
            DateOnly.MinValue,
            "nil" )
       {
       }
       
        public UserContact(
            string firstName,
            string lastName,
            string telefonNumber,
            DateOnly dayOfBirth,
            string email) : base(telefonNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            base.TelefonNumber = telefonNumber;
            this.DayOfBirth = dayOfBirth;
            this.Email = email;
        }
       public string FirstName {get; set;}
       public string LastName {get; set;}
    //    public  string TelefonNumber {get; set;}
       public DateOnly DayOfBirth {get; set;}
       public string Email {get; set;}

    public override string NickName
    {
        get
        {
            return $"[{this.FirstName} {this.LastName}]";
        }
    }

    public override string ToString()
    {
        string output = string.Empty;

        output += $"FirstName: {this.FirstName}\n";
        output += $"LastName: {this.LastName}\n";
        output += base.ToString();
        output += $"DayOfBirth: {this.DayOfBirth}\n";   
        output += $"Email: {this.Email}\n";   

        return output;
    }

}


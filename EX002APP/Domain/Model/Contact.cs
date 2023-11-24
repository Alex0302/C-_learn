namespace Model;

public class Contact
{
           public Contact()
       {
            // this.NickName = string.Empty;
            this.TelefonNumber = string.Empty;

       }
       
        public Contact(
            // string nickName,
            string telefonNumber
            )
        {
            // this.NickName = nickName;

            this.TelefonNumber = telefonNumber;

        }
        public int Id {get; set;}
       public virtual string NickName {get;}
       public  string TelefonNumber {get; set;}

    public override string ToString()
    {
        string output = string.Empty;

        output += $"Id: {this.Id}\n";
        output += $"TelefonNumber: {this.TelefonNumber}\n";
        
        return output;
    }

}
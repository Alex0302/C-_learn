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
       public virtual string NickName {get;}
       public  string TelefonNumber {get; set;}

}